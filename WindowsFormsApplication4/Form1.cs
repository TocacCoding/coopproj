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
            //MessageBox.Show(GetPixel(943, 76).ToString());
            //eaterHtk.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
            //int maxManaX = 971;
        }

        //Init Vars
        //Bar pixel color
        int emptyBarAux = -13816270;
        int healthY = 32;
        int manaY = 32;
        private bool smartMana = false;

        // spell heal timer
        private void spellHeal_Tick(object sender, EventArgs e)
        {
            if (Functions.Window.isMaximized() && spellHealingList.Count > 0)
            {
                foreach (Structs.spellHeal spell in spellHealingList)
                {
                    if (Functions.Window.GetPixel(spell.hpPixel, healthY) == emptyBarAux)
                    {
                        Functions.Heal.spellHeal(spell.hotkey);
                        return; // usou heal its over
                    }
                }
            }
        }

        // item heal timer
        private void itemHeal_Tick(object sender, EventArgs e)
        {
            if (Functions.Window.isMaximized())
            {
                if (itemHealingList.Count > 0)
                {
                    foreach (Structs.itemHeal item in itemHealingList)
                    {
                        if (Functions.Window.GetPixel(item.hpPixel, healthY) == emptyBarAux && Functions.Window.GetPixel(item.mpPixel, manaY) == emptyBarAux)
                        {
                            Functions.Heal.spellHeal(item.hotkey);
                            return; // usou pot its over
                        }
                    }
                }
                // nao tinha pots para usar vai iniciar a routine do smart mana
                if (smartManaDrinkerStartManaPercent.Text != "" && smartManaDrinkerStopManaPercent.Text != "" && smartManaWasterHotkey.SelectedItem.ToString() != "" 
                    && smartManaDrinkerHotkey.SelectedItem.ToString() != "")
                {
                    int pixelStart = 970 + ((int.Parse(smartManaDrinkerStartManaPercent.Text) * 74) / 10);
                    int pixelStop = 970 + ((int.Parse(smartManaDrinkerStopManaPercent.Text) * 74) / 10);
                    if (smartMana)
                    {
                        if (Functions.Window.GetPixel(pixelStop, manaY) != emptyBarAux)
                        {
                            smartMana = false;
                            return; // ja bebeu tudo vai turn off
                        }
                        else
                        {
                            Functions.Mana.manaDrinker((VirtualKeyCode)smartManaDrinkerHotkey.SelectedItem);
                            return; // usou mana
                        }
                    }
                    else if (Functions.Window.GetPixel(pixelStart, manaY) == emptyBarAux)
                    {
                        smartMana = true;
                        Functions.Mana.manaDrinker((VirtualKeyCode)smartManaWasterHotkey.SelectedItem);
                        return; // ligou a smart mana e bebeu fluid
                    }
                }
            }
        }

        // status checker timer
        private void statusChecker_Tick(object sender, EventArgs e)
        {

        }

        // garbage collection timer
        private void gc_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        // graphical shit 
        private void login_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o login button!");
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o $$$$$ button!");
        }

        // HEALER SPELL LOGICS E CONTROLS
        // init lista spells heal
        public List<Structs.spellHeal> spellHealingList = new List<Structs.spellHeal>();

        private void updateSpellList()
        {
            listBoxSpellHealingActive.DataSource = null;
            listBoxSpellHealingActive.DataSource = spellHealingList;
            listBoxSpellHealingActive.DisplayMember = "Name";
        }

        private void buttonAddNewSpellHealing_Click(object sender, EventArgs e)
        {
            if (textBoxSpellName.Text == "SPELL" || newSpellHealingHpBelow.Text == "100" || comboBoxNewSpellHealingHotkey.Text.ToString() == "HTK")
            {
                if (textBoxSpellName.Text == "SPELL") MessageBox.Show("Error! Please select a Name.");
                else if (newSpellHealingHpBelow.Text == "100") MessageBox.Show("Error! Please select a HP Below value.");
                else if (comboBoxNewSpellHealingHotkey.Text.ToString() == "HTK") MessageBox.Show("Error! Please select a Hotkey.");
            }
             else
            {
                Structs.spellHeal newSpell = new Structs.spellHeal(this.textBoxSpellName.Text, this.newSpellHealingHpBelow.Text, (VirtualKeyCode)comboBoxNewSpellHealingHotkey.SelectedItem);
                spellHealingList.Add(newSpell);
                updateSpellList();
            }
        }

        private void buttonClearNewSpell_Click(object sender, EventArgs e)
        {
            this.newSpellHealingHpBelow.Text = "100";
            this.comboBoxNewSpellHealingHotkey.Text = "HTK";
            this.textBoxSpellName.Text = "SPELL";
        }

        private void buttonRemoveSelectedSpellHealing_Click(object sender, EventArgs e)
        {
            spellHealingList.Remove((Structs.spellHeal)listBoxSpellHealingActive.SelectedItem);
            updateSpellList();
        }

        private void buttonUpSpellHealing_Click(object sender, EventArgs e)
        {
            if (listBoxSpellHealingActive.SelectedItem == null || listBoxSpellHealingActive.SelectedIndex < 0)
                return;
            int newIndex = listBoxSpellHealingActive.SelectedIndex - 1;
            if (newIndex < 0 || newIndex >= listBoxSpellHealingActive.Items.Count)
                return;
            spellHealingList.Remove((Structs.spellHeal)listBoxSpellHealingActive.SelectedItem);
            spellHealingList.Insert(newIndex, (Structs.spellHeal)listBoxSpellHealingActive.SelectedItem);
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
            spellHealingList.Remove((Structs.spellHeal)listBoxSpellHealingActive.SelectedItem);
            spellHealingList.Insert(newIndex, (Structs.spellHeal)listBoxSpellHealingActive.SelectedItem);
            listBoxSpellHealingActive.SetSelected(newIndex, true);
            updateSpellList();
        }
        // end spell heal logics

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o register button!");
        }

        private void buttonUpdateSmartManaDrinker_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o update mana drinker!");
        }

        private void buttonUpdateManaWaster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o update mana waster!");
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o save cfg!");
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o load cfg!");
        }

        private void listBoxSpellHealingActive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMount_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mountHtk_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Actions.mountHotkey = (VirtualKeyCode)mountHtk.SelectedItem;
        }

        private void eaterHtk_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Actions.eatHotkey = (VirtualKeyCode)eaterHtk.SelectedItem;
        }

        private void hasteHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Actions.hasteHotkey = (VirtualKeyCode)hasteHotkey.SelectedItem;
        }

        private void uturaHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Actions.recoveryHotkey = (VirtualKeyCode)uturaHotkey.SelectedItem;
        }

        private void poisonHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Support.poisonHotkey = (VirtualKeyCode)poisonHotkey.SelectedItem;
        }

        private void lifeRingHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Rings.Elifering = (VirtualKeyCode)lifeRingHotkey.SelectedItem;
        }

        private void energyRingHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Rings.Eenergyring = (VirtualKeyCode)energyRingHotkey.SelectedItem;
        }

        private void healingRingHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Rings.Ehealingring = (VirtualKeyCode)healingRingHotkey.SelectedItem;
        }

        private void checkBoxHealingRing_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void paralyzeHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Support.paralyzeHotkey = (VirtualKeyCode)paralyzeHotkey.SelectedItem;
        }

        // HEALER ITEM LOGICS E CONTROLS
        public List<Structs.itemHeal> itemHealingList = new List<Structs.itemHeal>();

        private void updateItemList()
        {
            listBoxItemHealingActive.DataSource = null;
            listBoxItemHealingActive.DataSource = itemHealingList;
            listBoxItemHealingActive.DisplayMember = "Name";
        }

        private void buttonAddNewItemHealing_Click(object sender, EventArgs e)
        {
            if (textBoxItemName.Text == "SPELL" || newItemHealingHpBelow.Text == "100" || comboBoxNewItemHealingHotkey.Text.ToString() == "HTK" || newItemHealingMpBelow.Text == "100")
            {
                if (textBoxItemName.Text == "SPELL") MessageBox.Show("Error! Please select a Name.");
                else if (newItemHealingHpBelow.Text == "100") MessageBox.Show("Error! Please select a HP Below value.");
                else if (comboBoxNewItemHealingHotkey.Text.ToString() == "HTK") MessageBox.Show("Error! Please select a Hotkey.");
                else if (newItemHealingMpBelow.Text == "100") MessageBox.Show("Error! Please select a MP Below value.");
            }
            else
            {
                Structs.itemHeal newSpell = new Structs.itemHeal(textBoxItemName.Text, newItemHealingHpBelow.Text, 
                    newItemHealingMpBelow.Text, (VirtualKeyCode)comboBoxNewItemHealingHotkey.SelectedItem);
                itemHealingList.Add(newSpell);
                updateItemList();
            }
        }

        private void buttonClearNewItem_Click(object sender, EventArgs e)
        {
            newItemHealingHpBelow.Text = "100";
            comboBoxNewItemHealingHotkey.Text = "HTK";
            textBoxItemName.Text = "SPELL";
            newItemHealingMpBelow.Text = "100";
        }

        private void buttonRemoveSelectedItemHealing_Click(object sender, EventArgs e)
        {
            itemHealingList.Remove((Structs.itemHeal)listBoxItemHealingActive.SelectedItem);
            updateItemList();
        }

        private void buttonUpItemHealing_Click(object sender, EventArgs e)
        {
            if (listBoxItemHealingActive.SelectedItem == null || listBoxItemHealingActive.SelectedIndex < 0)
                return;
            int newIndex = listBoxItemHealingActive.SelectedIndex - 1;
            if (newIndex < 0 || newIndex >= listBoxItemHealingActive.Items.Count)
                return;
            itemHealingList.Remove((Structs.itemHeal)listBoxItemHealingActive.SelectedItem);
            itemHealingList.Insert(newIndex, (Structs.itemHeal)listBoxItemHealingActive.SelectedItem);
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
            itemHealingList.Remove((Structs.itemHeal)listBoxItemHealingActive.SelectedItem);
            itemHealingList.Insert(newIndex, (Structs.itemHeal)listBoxItemHealingActive.SelectedItem);
            listBoxItemHealingActive.SetSelected(newIndex, true);
            updateItemList();
        }
        // end of item healer
    }
}
