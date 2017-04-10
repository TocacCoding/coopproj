using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(7000);
            //MessageBox.Show("error msg", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //MessageBox.Show("warning msg", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //MessageBox.Show("information msg", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- VARS ---
        // Bar pixel color
        int emptyBarAux = -13816270;
        // Coords
        int healthY = 32;
        int manaY = 32;
        int maxManaX = 971;
        // Lists
        public List<Structs.Spell> spellHealingList = new List<Structs.Spell>();
        public List<Structs.Item> itemHealingList = new List<Structs.Item>();
        // Healer HTK
        VirtualKeyCode newSpellHtk;
        VirtualKeyCode newItemHtk;
        // Status
        bool autoEat = false;
        bool autoMount = false;
        bool autoUtana = false;
        bool autoUtamo = false;
        bool autoLifeRing = false;
        bool autoEnergyRing = false;
        bool autoTimeRing = false;
        bool autoMightRing = false;
        bool autoHealingRing = false;
        bool autoParalyze = false;
        bool autoPox = false;
        bool autoHaste = false;
        bool autoUtura = false;
        bool autoManaWaster = false;
        // --- /VARS ---

        // --- TIMERS ---
        private void spellHeal_Tick(object sender, EventArgs e)
        {
            Functions.Healer.spellHeal(spellHealingList, healthY, emptyBarAux);
        }
        private void itemHeal_Tick(object sender, EventArgs e)
        {
            Functions.Healer.itemHeal(itemHealingList, healthY, emptyBarAux, manaY);
        }
        private void statusChecker_Tick(object sender, EventArgs e)
        {
            Functions.Status.statusHeal(autoEat, autoMount, autoUtana, autoUtamo, autoLifeRing, autoEnergyRing, autoTimeRing, 
                autoMightRing, autoHealingRing, autoParalyze, autoPox, autoHaste, autoUtura, autoManaWaster, maxManaX, manaY, emptyBarAux);
        }
        // --- /TIMERS ---

        // --- ACCOUNT TAB ---
        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_input.Text.ToString() == "admin@mail.com" && password_input.Text.ToString() == "pass")
            {
                this.tabControl1.TabPages.Insert(1, this.tab_main);
                this.tabControl1.TabPages.Insert(2, this.tab_heal);
                this.tabControl1.TabPages.Insert(3, this.tab_actions);
                this.tabControl1.TabPages.Insert(4, this.tab_support);
                this.groupBoxAccountStatus.Visible = true;
                this.groupBoxLogin.Visible = false;
                MessageBox.Show("Welcome " + username_input.Text.ToString() + ".","Log In Success!");
            }
            else
            {
                MessageBox.Show("Invalid USER/PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o $$$$$ button!");
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o register button!");
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Remove(this.tab_main);
            this.tabControl1.TabPages.Remove(this.tab_heal);
            this.tabControl1.TabPages.Remove(this.tab_actions);
            this.tabControl1.TabPages.Remove(this.tab_support);
            this.groupBoxAccountStatus.Visible = false;
            this.groupBoxLogin.Visible = true;
            MessageBox.Show("See you soon " + username_input.Text.ToString() + ".", "Log Out Sucess!");
        }
        // --- /ACCOUNT ---

        // --- MAIN TAB ---
        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o save cfg!");
        }
        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o load cfg!");
        }
        // --- /MAIN ---                

        // --- SPELL HEAL TAB ---
        private void updateSpellList()
        {
            listBoxSpellHealingActive.DataSource = null;
            listBoxSpellHealingActive.DataSource = spellHealingList;
            listBoxSpellHealingActive.DisplayMember = "Name";
        }
        private void spellHealingHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") newSpellHealingHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else newSpellHealingHotkey.Text = e.KeyCode.ToString();
            newSpellHtk = (VirtualKeyCode)e.KeyCode;
        }
        private void buttonAddNewSpellHealing_Click(object sender, EventArgs e)
        {
            // check hp name mp htk
            if (comboBoxSpellName.Text.ToString() == "" || newSpellHealingHotkey.Text.ToString() == "HTK"
                || spellHealingHpValue.Text.ToString() == "HP" || spellHealingMpValue.Text.ToString() == "MP")
            {
                if (comboBoxSpellName.Text.ToString() == "") MessageBox.Show("Select NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (newSpellHealingHotkey.Text.ToString() == "HTK") MessageBox.Show("Select HOTKEY.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (spellHealingHpValue.Text.ToString() == "HP") MessageBox.Show("Select HP.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (spellHealingMpValue.Text.ToString() == "MP") MessageBox.Show("Select MP.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // check numeric input
            else
            {
                    int inputHpValid;
                    int inputMpValid;
                    int.TryParse(spellHealingHpValue.Text, out inputHpValid);
                    int.TryParse(spellHealingMpValue.Text, out inputMpValid);

                    // create if valid
                    if (inputMpValid != 0 && inputHpValid != 0
                        && int.Parse(spellHealingHpValue.Text.ToString()) < int.Parse(maxHpInput.Text.ToString()) && int.Parse(spellHealingHpValue.Text.ToString()) > 0
                        && int.Parse(spellHealingMpValue.Text.ToString()) < int.Parse(maxMpInput.Text.ToString()) && int.Parse(spellHealingMpValue.Text.ToString()) > 0)
                    {
                        int auxHotkeyValid = Functions.Window.HotkeyValidation(newSpellHtk, comboBoxSpellName.Text);
                        if (auxHotkeyValid == 1)
                    {
                        Structs.Spell newSpell = new Structs.Spell(comboBoxSpellName.Text, spellHealingHpValue.Text,
                            newSpellHtk, maxHpInput.Text, spellHealingMpValue.Text, maxMpInput.Text);
                        spellHealingList.Add(newSpell);
                        updateSpellList();

                    }
                        else 
                        {
                        MessageBox.Show("Invalid HOTKEY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                {
                    if (inputMpValid == 0 || int.Parse(spellHealingMpValue.Text.ToString()) > int.Parse(maxMpInput.Text.ToString()) || int.Parse(spellHealingMpValue.Text.ToString()) < 0)
                    {
                        MessageBox.Show("Invalid MP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (inputHpValid == 0 || int.Parse(spellHealingHpValue.Text.ToString()) > int.Parse(maxHpInput.Text.ToString()) || int.Parse(spellHealingHpValue.Text.ToString()) < 0)
                    {
                        MessageBox.Show("Invalid HP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonClearNewSpell_Click(object sender, EventArgs e)
        {
            newSpellHealingHotkey.Text = "HTK";
            comboBoxSpellName.Text = "SPELL";
            spellHealingHpValue.Text = "HP";
            spellHealingMpValue.Text = "MP";
        }
        private void buttonRemoveSelectedSpellHealing_Click(object sender, EventArgs e)
        {
            if (spellHealingList.Count > 0)
            {
                spellHealingList.Remove((Structs.Spell)listBoxSpellHealingActive.SelectedItem);
                updateSpellList();
            }
        }
        private void buttonUpSpellHealing_Click(object sender, EventArgs e)
        {
            if (listBoxSpellHealingActive.SelectedItem == null || listBoxSpellHealingActive.SelectedIndex < 0)
                return;
            int newIndex = listBoxSpellHealingActive.SelectedIndex - 1;
            if (newIndex < 0 || newIndex >= listBoxSpellHealingActive.Items.Count)
                return;
            spellHealingList.Remove((Structs.Spell)listBoxSpellHealingActive.SelectedItem);
            spellHealingList.Insert(newIndex, (Structs.Spell)listBoxSpellHealingActive.SelectedItem);
            listBoxSpellHealingActive.SetSelected(newIndex, true);
            updateSpellList();
        }
        private void buttonDownSpellHealing_Click(object sender, EventArgs e)
        {
            if (listBoxSpellHealingActive.SelectedItem == null || listBoxSpellHealingActive.SelectedIndex < 0)
                return;
            int newIndex = listBoxSpellHealingActive.SelectedIndex + 1;
            if (newIndex < 0 || newIndex >= listBoxSpellHealingActive.Items.Count)
                return;
            spellHealingList.Remove((Structs.Spell)listBoxSpellHealingActive.SelectedItem);
            spellHealingList.Insert(newIndex, (Structs.Spell)listBoxSpellHealingActive.SelectedItem);
            listBoxSpellHealingActive.SetSelected(newIndex, true);
            updateSpellList();
        }
        // --- /SPELL HEAL ---

        // --- ITEM HEAL TAB ---
        private void updateItemList()
        {
            listBoxItemHealingActive.DataSource = null;
            listBoxItemHealingActive.DataSource = itemHealingList;
            listBoxItemHealingActive.DisplayMember = "Name";
        }
        private void itemHealingHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") newItemHealingHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else newItemHealingHotkey.Text = e.KeyCode.ToString();
            newItemHtk = (VirtualKeyCode)e.KeyCode;
        }
        private void buttonAddNewItemHealing_Click(object sender, EventArgs e)
        {
            if (comboBoxItemName.Text.ToString() == "" || itemHealingHpValue.Text == "HP" || newItemHealingHotkey.Text.ToString() == "HTK" 
                || itemHealingMpValue.Text.ToString() == "MP" || comboBoxHpBelowOver.Text.ToString() == "" || comboBoxMpBelowOver.Text.ToString() == "" )
            {
                if (comboBoxItemName.Text.ToString() == "") MessageBox.Show("Select NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (itemHealingHpValue.Text.ToString() == "HP") MessageBox.Show("Select HP.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (newItemHealingHotkey.Text.ToString() == "HTK") MessageBox.Show("Select HOTKEY.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (itemHealingMpValue.Text.ToString() == "MP") MessageBox.Show("Select MP.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (comboBoxHpBelowOver.Text.ToString() == "") MessageBox.Show("Select HP BELOW/OVER.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (comboBoxMpBelowOver.Text.ToString() == "") MessageBox.Show("Select MP BELOW/OVER.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int inputHpValid;
                int inputMpValid;
                int.TryParse(itemHealingHpValue.Text, out inputHpValid);
                int.TryParse(itemHealingMpValue.Text, out inputMpValid);

                if (inputMpValid != 0 && inputHpValid != 0 
                    && int.Parse(itemHealingHpValue.Text.ToString()) < int.Parse(maxHpInput.Text.ToString()) && int.Parse(itemHealingHpValue.Text.ToString()) > 0 
                    && int.Parse(itemHealingMpValue.Text.ToString()) < int.Parse(maxMpInput.Text.ToString()) && int.Parse(itemHealingMpValue.Text.ToString()) > 0)
                {
                    int auxHotkeyValid = Functions.Window.HotkeyValidation(newItemHtk, comboBoxItemName.Text);
                    if (auxHotkeyValid == 1)
                    {
                        Structs.Item newItem = new Structs.Item(comboBoxItemName.Text, itemHealingHpValue.Text, itemHealingMpValue.Text
                            , newItemHtk, comboBoxHpBelowOver.Text, comboBoxMpBelowOver.Text, maxHpInput.Text, maxMpInput.Text);
                        itemHealingList.Add(newItem);
                        updateItemList();
                    }
                    else
                    {
                        MessageBox.Show("Invalid HOTKEY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (inputMpValid == 0 || int.Parse(itemHealingMpValue.Text.ToString()) > int.Parse(maxMpInput.Text.ToString()) || int.Parse(itemHealingMpValue.Text.ToString()) < 0)
                    {
                        MessageBox.Show("Invalid MP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (inputHpValid == 0 || int.Parse(itemHealingHpValue.Text.ToString()) > int.Parse(maxHpInput.Text.ToString()) || int.Parse(itemHealingHpValue.Text.ToString()) < 0)
                    {
                        MessageBox.Show("Invalid HP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonClearNewItem_Click(object sender, EventArgs e)
        {
            newItemHealingHotkey.Text = "HTK";
            comboBoxItemName.Text = "ITEM";
            itemHealingMpValue.Text = "MP";
            comboBoxHpBelowOver.Text = "BELOW";
            comboBoxMpBelowOver.Text = "BELOW";
            itemHealingHpValue.Text = "HP";
        }
        private void buttonRemoveSelectedItemHealing_Click(object sender, EventArgs e)
        {
            if (itemHealingList.Count > 0)
            {
                itemHealingList.Remove((Structs.Item)listBoxItemHealingActive.SelectedItem);
                updateItemList();
            }

        }
        private void buttonUpItemHealing_Click(object sender, EventArgs e)
        {
            if (listBoxItemHealingActive.SelectedItem == null || listBoxItemHealingActive.SelectedIndex < 0)
                return;
            int newIndex = listBoxItemHealingActive.SelectedIndex - 1;
            if (newIndex < 0 || newIndex >= listBoxItemHealingActive.Items.Count)
                return;
            itemHealingList.Remove((Structs.Item)listBoxItemHealingActive.SelectedItem);
            itemHealingList.Insert(newIndex, (Structs.Item)listBoxItemHealingActive.SelectedItem);
            listBoxItemHealingActive.SetSelected(newIndex, true);
            updateItemList();
        }
        private void buttonDownItemHealing_Click(object sender, EventArgs e)
        {
            if (listBoxItemHealingActive.SelectedItem == null || listBoxItemHealingActive.SelectedIndex < 0)
                return;
            int newIndex = listBoxItemHealingActive.SelectedIndex + 1;
            if (newIndex < 0 || newIndex >= listBoxItemHealingActive.Items.Count)
                return;
            itemHealingList.Remove((Structs.Item)listBoxItemHealingActive.SelectedItem);
            itemHealingList.Insert(newIndex, (Structs.Item)listBoxItemHealingActive.SelectedItem);
            listBoxItemHealingActive.SetSelected(newIndex, true);
            updateItemList();
        }
        // --- /ITEM HEAL ---

        // --- STATUS/SUPPORT CHECKBOX EVENT ---
        private void checkBoxHaste_CheckedChanged(object sender, EventArgs e)
        {
            if (hasteHotkey.Text != "HTK")
            {
                autoHaste = !autoHaste;
            }
            else if (checkBoxHaste.CheckState == 0)
            {
                MessageBox.Show("Select hotkey first!");
            }
            else checkBoxHaste.CheckState = 0;
        }
        private void checkBoxUtura_CheckedChanged(object sender, EventArgs e)
        {
            if (uturaHotkey.Text != "HTK")
            {
                autoUtura = !autoUtura;
            }
            else if (checkBoxUtura.CheckState == 0)
            {
                MessageBox.Show("Select hotkey first!");
            }
            else checkBoxUtura.CheckState = 0;
        }
        private void checkBoxParalyze_CheckedChanged(object sender, EventArgs e)
        {
            if (paralyzeHotkey.Text != "HTK")
            {
                autoParalyze = !autoParalyze;
            }
            else if (checkBoxParalyze.CheckState == 0)
            {
                MessageBox.Show("Select hotkey first!");
            }
            else checkBoxParalyze.CheckState = 0;
        }
        private void checkBoxPoison_CheckedChanged(object sender, EventArgs e)
        {
            if (poisonHotkey.Text != "HTK")
            {
                autoPox = !autoPox;
            }
            else if (checkBoxPoison.CheckState == 0)
            {
                MessageBox.Show("Select hotkey first!");
            }
            else checkBoxPoison.CheckState = 0;
        }
        private void checkBoxEater_CheckedChanged(object sender, EventArgs e)
        {
            if (eaterHotkey.Text != "HTK")
            {
                autoEat = !autoEat;
            }
            else if (checkBoxEater.CheckState == 0)
            {
                MessageBox.Show("Select hotkey first!");
            }
            else checkBoxEater.CheckState = 0;
        }
        private void checkBoxMount_CheckedChanged(object sender, EventArgs e)
        {
            if (eaterHotkey.Text != "HTK")
            {
                autoMount = !autoMount;
            }
            else if (checkBoxMount.CheckState == 0)
            {
                MessageBox.Show("Select hotkey first!");
            }
            else checkBoxMount.CheckState = 0;
        }
        private void checkBoxLifeRing_CheckedChanged(object sender, EventArgs e)
        {
            if (lifeRingHotkey.Text != "HTK")
            {
                autoLifeRing = !autoLifeRing;
            }
            else if (checkBoxLifeRing.CheckState == 0)
            {
                MessageBox.Show("Select hotkey first!");
            }
            else checkBoxLifeRing.CheckState = 0;
        }
        private void checkBoxEnergyRing_CheckedChanged(object sender, EventArgs e)
        {
            if (energyRingHotkey.Text != "HTK")
            {
                autoEnergyRing = !autoEnergyRing;
            }
            else if (checkBoxEnergyRing.CheckState == 0)
            {
                MessageBox.Show("Select hotkey first!");
            }
            else checkBoxEnergyRing.CheckState = 0;
        }
        private void checkBoxManaWaster_CheckedChanged(object sender, EventArgs e)
        {
            if (manaWasterHotkey.Text != "HTK")
            {
                autoManaWaster = !autoManaWaster;
            }
            else if (checkBoxManaWaster.CheckState == 0)
            {
                MessageBox.Show("Select hotkey first!");
            }
            else checkBoxManaWaster.CheckState = 0;
        }
        // --- /STATUS/SUPPORT CHECKBOX EVENT---

        // --- MAX HP MP TAB ---
        private void buttonApplyMaxValues_Click(object sender, EventArgs e)
        {
            if (maxHpInput != null && maxMpInput !=null)
            {
                int hpValid;
                int mpValid;
                int.TryParse(maxHpInput.Text, out hpValid);
                int.TryParse(maxMpInput.Text, out mpValid);

                if (hpValid > 0 && mpValid > 0)
                {
                    groupBoxItemHealing.Visible = true;
                    groupBoxSpellHealing.Visible = true;
                    maxHpInput.ReadOnly = true;
                    maxMpInput.ReadOnly = true;
                    buttonResetHealing.Visible = true;
                    buttonApplyMaxValues.Visible = false;
                    buttonLoadCfgHealer.Visible = false;
                    buttonSaveCfgHealer.Visible = true;
                }
                else
                {
                    if (hpValid == 0) MessageBox.Show("Invalid HP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (mpValid == 0) MessageBox.Show("Invalid MP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    groupBoxItemHealing.Visible = false;
                    groupBoxSpellHealing.Visible = false;
                }
            }
        }
        private void buttonResetHealing_Click(object sender, EventArgs e)
        {
            spellHealingList.Clear();
            itemHealingList.Clear();
            updateItemList();
            updateSpellList();
            maxHpInput.ReadOnly = false;
            maxMpInput.ReadOnly = false;
            maxHpInput.Text = "";
            maxMpInput.Text = "";
            groupBoxItemHealing.Visible = false;
            groupBoxSpellHealing.Visible = false;
            buttonApplyMaxValues.Visible = true;
            buttonResetHealing.Visible = false;
            buttonLoadCfgHealer.Visible = true;
            buttonSaveCfgHealer.Visible = false;
        }
        // --- /MAX HP MP ---

        // --- SAVE CFG TAB ---
        private void buttonSaveCfgHealer_Click(object sender, EventArgs e)
        {
            Functions.FileManager.saveHealerCfg(spellHealingList, itemHealingList);
        }
        // --- /SAVE CFG ---

        // --- LOAD CFG TAB ---
        private void buttonLoadCfgHealer_Click(object sender, EventArgs e)
        {
            List<Structs.Item> loadedItemList = null;
            List<Structs.Spell> loadedSpellList = null;

            Functions.FileManager.loadHealerCfg(out loadedItemList, out loadedSpellList);

            if (loadedItemList != null && loadedSpellList != null)
            {
                // spell aux to real
                spellHealingList.Clear();
                spellHealingList = loadedSpellList;
                updateSpellList();
                // item aux to real
                itemHealingList.Clear();
                itemHealingList = loadedItemList;
                updateItemList();
                // window manipulation hiding/showing stuff on menus
                groupBoxSpellHealing.Visible = true;
                groupBoxItemHealing.Visible = true;
                buttonLoadCfgHealer.Visible = false;
                buttonSaveCfgHealer.Visible = true;
                buttonApplyMaxValues.Visible = false;
                buttonResetHealing.Visible = true;
                maxHpInput.Text = itemHealingList[0].maxHp.ToString();
                maxMpInput.Text = itemHealingList[0].maxMp.ToString();
                maxMpInput.ReadOnly = true;
                maxHpInput.ReadOnly = true;
            }
        }
        // --- /LOAD CFG ---

        // -- NEW HOTKEYS --
        private void eaterHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") eaterHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else eaterHotkey.Text = e.KeyCode.ToString();
            Functions.Actions.eatHotkey = (VirtualKeyCode)e.KeyCode;
        }
        private void mountHtk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") mountHtk.Text = e.KeyCode.ToString().Replace("D", "");
            else mountHtk.Text = e.KeyCode.ToString();
            Functions.Actions.mountHotkey = (VirtualKeyCode)e.KeyCode;
        }
        private void manaWasterHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") manaWasterHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else manaWasterHotkey.Text = e.KeyCode.ToString();
            Functions.Mana.manaWasterHotkey = (VirtualKeyCode)e.KeyCode;
        }
        private void utamoVitaHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") utamoVitaHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else utamoVitaHotkey.Text = e.KeyCode.ToString();
            MessageBox.Show("opps not implemented: Form1 -> private void utamoVitaHotkey_KeyDown(object sender, KeyEventArgs e)");
            //Functions.blablabla = (VirtualKeyCode)e.KeyCode;
        }
        private void utanaVidHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") utanaVidHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else utanaVidHotkey.Text = e.KeyCode.ToString();
            MessageBox.Show("opps not implemented: Form1 -> private void utanaVidHotkey_KeyDown(object sender, KeyEventArgs e)");
            //Functions.blablabla = (VirtualKeyCode)e.KeyCode;
        }
        private void lifeRingHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") lifeRingHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else lifeRingHotkey.Text = e.KeyCode.ToString();
            Functions.Rings.Elifering = (VirtualKeyCode)e.KeyCode;
        }
        private void energyRingHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") energyRingHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else energyRingHotkey.Text = e.KeyCode.ToString();
            Functions.Rings.Eenergyring = (VirtualKeyCode)e.KeyCode;
        }
        private void timeRingHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") timeRingHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else timeRingHotkey.Text = e.KeyCode.ToString();
            MessageBox.Show("opps not implemented: Form1 -> private void timeRingHotkey_KeyDown(object sender, KeyEventArgs e)");
            //Functions.blablabla = (VirtualKeyCode)e.KeyCode;
        }
        private void mightRingHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") mightRingHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else mightRingHotkey.Text = e.KeyCode.ToString();
            MessageBox.Show("opps not implemented: Form1 -> private void mightRingHotkey_KeyDown(object sender, KeyEventArgs e)");
            //Functions.blablabla = (VirtualKeyCode)e.KeyCode;
        }
        private void healingRingHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") healingRingHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else healingRingHotkey.Text = e.KeyCode.ToString();
            Functions.Rings.Ehealingring = (VirtualKeyCode)e.KeyCode;
            MessageBox.Show("opps not implemented: já tenho tudo mas nao há o HealRingPixelColor para compare");
        }
        private void paralyzeHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") paralyzeHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else paralyzeHotkey.Text = e.KeyCode.ToString();
            Functions.Support.paralyzeHotkey = (VirtualKeyCode)e.KeyCode;
        }
        private void poisonHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") poisonHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else poisonHotkey.Text = e.KeyCode.ToString();
            Functions.Support.poisonHotkey = (VirtualKeyCode)e.KeyCode;
        }
        private void hasteHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") hasteHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else hasteHotkey.Text = e.KeyCode.ToString();
            Functions.Actions.hasteHotkey = (VirtualKeyCode)e.KeyCode;
        }
        private void uturaHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") uturaHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else uturaHotkey.Text = e.KeyCode.ToString();
            Functions.Actions.recoveryHotkey = (VirtualKeyCode)e.KeyCode;
        }
        // --- /NEW HOTKEYS ---

        private void SEPARADOR()
        {
            // eu nao faço nada é só para a lixarada que crio nos graphs aparecer under me e nao foder o resto do codigo
        }
    } // no del
}
