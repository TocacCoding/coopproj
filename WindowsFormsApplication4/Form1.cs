﻿using System;
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
            //MessageBox.Show(GetPixel(943, 76).ToString());
            //eaterHtk.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
        }

        //Init Vars
        //Bar pixel color
        int emptyBarAux = -13816270;
        int healthY = 32;
        int manaY = 32;
        int maxManaX = 971;
        //private bool smartMana = false;

        // spell heal timer
        private void spellHeal_Tick(object sender, EventArgs e)
        {
            if (Functions.Window.isMaximized() && spellHealingList.Count > 0)
            {
                foreach (Structs.spellHeal spell in spellHealingList)
                {
                    if (Functions.Window.GetPixel(spell.hpPixel, healthY) == emptyBarAux && Functions.Window.GetPixel(spell.mpPixel, healthY) != emptyBarAux)
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
                        if (item.operatorHp == "BELOW" && item.operatorMp == "BELOW")
                        {
                            // below below
                            if (Functions.Window.GetPixel(item.hpPixel, healthY) == emptyBarAux && Functions.Window.GetPixel(item.mpPixel, manaY) == emptyBarAux)
                            {
                                Functions.Heal.spellHeal(item.hotkey);
                                return; // usou pot its over
                            }
                        }
                        else if (item.operatorHp == "BELOW" && item.operatorMp == "OVER")
                        {
                            // below over
                            if (Functions.Window.GetPixel(item.hpPixel, healthY) == emptyBarAux && Functions.Window.GetPixel(item.mpPixel, manaY) != emptyBarAux)
                            {
                                Functions.Heal.spellHeal(item.hotkey);
                                return; // usou pot its over
                            }
                        }
                        else if (item.operatorHp == "OVER" && item.operatorMp == "BELOW")
                        {
                            // over below
                            if (Functions.Window.GetPixel(item.hpPixel, healthY) != emptyBarAux && Functions.Window.GetPixel(item.mpPixel, manaY) == emptyBarAux)
                            {
                                Functions.Heal.spellHeal(item.hotkey);
                                return; // usou pot its over
                            }
                        }
                        else if (item.operatorHp == "OVER" && item.operatorMp == "OVER")
                        {
                            // over over
                            if (Functions.Window.GetPixel(item.hpPixel, healthY) != emptyBarAux && Functions.Window.GetPixel(item.mpPixel, manaY) != emptyBarAux)
                            {
                                Functions.Heal.spellHeal(item.hotkey);
                                return; // usou pot its over
                            }
                        }
                    }
                }
            }
        }

        // status checker timer
        // init vars status
        // routine
        bool autoEat = false;
        bool autoMount = false;
        // spells
        bool autoUtana = false;
        bool autoUtamo = false;
        // rings
        bool autoLifeRing = false;
        bool autoEnergyRing = false;
        bool autoTimering = false;
        bool autoMightRing = false;
        bool autoHealingRing = false;
        // condition
        bool autoParalyze = false;
        bool autoPox = false;
        // holder
        bool autoHaste = false;
        bool autoUtura = false;
        // mana waste
        bool autoManaWaste = false;

        private void statusChecker_Tick(object sender, EventArgs e)
        {
            if (Functions.Window.isMaximized() && !Functions.Status.isPZ() && Functions.Window.isClear())
            {
                // routine
                if (autoEat || autoMount)
                {
                    if (autoEat && Functions.Status.isHungry()) Functions.Actions.eat();
                    else if (autoMount && !Functions.Status.isMounted()) Functions.Actions.mount();
                }
                // spells
                if (autoUtana || autoUtamo)
                {
                    // falta implementar!
                }
                // rings
                if (autoLifeRing || autoEnergyRing || autoTimering || autoMightRing || autoHealingRing)
                {
                    if (autoEnergyRing && !Functions.Status.isEnergyRing()) Functions.Rings.equipEnergyRing();
                    else if (autoLifeRing && !Functions.Status.isLifeRing()) Functions.Rings.equipLifeRing();

                }
                // condition
                if (autoParalyze || autoPox)
                {
                    if (autoParalyze && Functions.Status.isParalyzed()) Functions.Support.RemoveParalyze();
                    else if (autoPox) Functions.Support.RemovePoison();
                }
                // holder
                if (autoHaste || autoUtura)
                {
                    if (autoHaste && !Functions.Status.isHasted()) Functions.Actions.haste();
                    else if (autoUtura && !Functions.Status.isEmpowered()) Functions.Actions.empower();
                }
                // mana waste
                if (autoManaWaste)
                {
                    if(Functions.Window.GetPixel(maxManaX, manaY) != emptyBarAux) Functions.Mana.manaWaster((VirtualKeyCode)smartManaWasterHotkey.SelectedItem);
                }
            }
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
        // hotkey geter
        VirtualKeyCode newSpellHtk;
        private void spellHealingHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") newSpellHealingHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else newSpellHealingHotkey.Text = e.KeyCode.ToString();
            newSpellHtk = (VirtualKeyCode)e.KeyCode;
        }

        private void buttonAddNewSpellHealing_Click(object sender, EventArgs e)
        {
            // check hp name mp htk
            if (textBoxSpellName.Text == "SPELL" || newSpellHealingHotkey.Text.ToString() == "HTK"
                || spellHealingHpValue.Text.ToString() == "HP" || spellHealingMpValue.Text.ToString() == "MP")
            {
                if (textBoxSpellName.Text == "SPELL") MessageBox.Show("Error! Select NAME.");
                else if (newSpellHealingHotkey.Text.ToString() == "HTK") MessageBox.Show("Error! Select HOTKEY.");
                else if (spellHealingHpValue.Text.ToString() == "HP") MessageBox.Show("Error! Select HP.");
                else if (spellHealingMpValue.Text.ToString() == "MP") MessageBox.Show("Error! Select MP.");
            }
            // check numeric input
            else
            {
                //codigo beta de validaçao de hotkeys
                var checkforhotkey1 = Structs.Hotkeys.AllInstances.FirstOrDefault(md => md.hotkey == newItemHtk);
                if (checkforhotkey1 != null && checkforhotkey1.identifier != textBoxSpellName.Text)
                {
                    MessageBox.Show("This hotkey is already asigned to a spell named: " + checkforhotkey1.identifier);
                }
                else if (checkforhotkey1 != null && checkforhotkey1.identifier == textBoxSpellName.Text)
                {
                    checkforhotkey1.hotkey = newItemHtk;
                }
                else
                {
                    var createHotkey = Structs.Hotkeys.Create();
                    createHotkey.hotkey = newItemHtk;
                    createHotkey.identifier = textBoxSpellName.Text;
                    Functions.Actions.mountHotkey = newItemHtk;
                }

                int inputHpValid;
                int inputMpValid;
                int.TryParse(spellHealingHpValue.Text, out inputHpValid);
                int.TryParse(spellHealingMpValue.Text, out inputMpValid);

                // create if valid
                if (inputMpValid != 0 && inputHpValid != 0 
                    && int.Parse(spellHealingHpValue.Text.ToString()) < int.Parse(maxHpInput.Text.ToString()) && int.Parse(spellHealingHpValue.Text.ToString()) > 0
                    && int.Parse(spellHealingMpValue.Text.ToString()) < int.Parse(maxMpInput.Text.ToString()) && int.Parse(spellHealingMpValue.Text.ToString()) > 0)
                {
                    Structs.spellHeal newSpell = new Structs.spellHeal(textBoxSpellName.Text, spellHealingHpValue.Text,
                        newSpellHtk, maxHpInput.Text, spellHealingMpValue.Text, maxMpInput.Text);
                    spellHealingList.Add(newSpell);
                    updateSpellList();
                }
                else
                {
                    MessageBox.Show("Error! Invalid values.");
                }
            }
        }

        private void buttonClearNewSpell_Click(object sender, EventArgs e)
        {
            newSpellHealingHotkey.Text = "HTK";
            textBoxSpellName.Text = "SPELL";
            spellHealingHpValue.Text = "HP";
            spellHealingMpValue.Text = "MP";
        }

        private void buttonRemoveSelectedSpellHealing_Click(object sender, EventArgs e)
        {
            if (spellHealingList.Count > 0)
            {
                spellHealingList.Remove((Structs.spellHeal)listBoxSpellHealingActive.SelectedItem);
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

        private void paralyzeHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.Support.paralyzeHotkey = (VirtualKeyCode)paralyzeHotkey.SelectedItem;
        }

        // HEALER ITEM LOGICS E CONTROLS
        // init list item heal
        public List<Structs.itemHeal> itemHealingList = new List<Structs.itemHeal>();

        private void updateItemList()
        {
            listBoxItemHealingActive.DataSource = null;
            listBoxItemHealingActive.DataSource = itemHealingList;
            listBoxItemHealingActive.DisplayMember = "Name";
        }

        // hotkeys
        VirtualKeyCode newItemHtk;
        private void itemHealingHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "D") newItemHealingHotkey.Text = e.KeyCode.ToString().Replace("D", "");
            else newItemHealingHotkey.Text = e.KeyCode.ToString();
            newItemHtk = (VirtualKeyCode)e.KeyCode;
        }

        private void buttonAddNewItemHealing_Click(object sender, EventArgs e)
        {
            if (textBoxItemName.Text == "ITEM" || itemHealingHpValue.Text == "HP" || newItemHealingHotkey.Text.ToString() == "HTK" || itemHealingMpValue.Text == "MP")
            {
                if (textBoxItemName.Text == "ITEM") MessageBox.Show("Error! Select NAME.");
                else if (itemHealingHpValue.Text == "HP") MessageBox.Show("Error! Select HP.");
                else if (newItemHealingHotkey.Text.ToString() == "HTK") MessageBox.Show("Error! Select HOTKEY.");
                else if (itemHealingMpValue.Text == "MP") MessageBox.Show("Error! Select MP.");
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
                    Structs.itemHeal newItem = new Structs.itemHeal(textBoxItemName.Text, itemHealingHpValue.Text, itemHealingMpValue.Text,
                        newItemHtk, comboBoxHpBelowOver.Text, comboBoxMpBelowOver.Text, maxHpInput.Text, maxMpInput.Text);
                    itemHealingList.Add(newItem);
                    updateItemList();
                }
                else
                {
                    MessageBox.Show("Error! Invalid HP.");
                }
            }
        }

        private void buttonClearNewItem_Click(object sender, EventArgs e)
        {
            newItemHealingHotkey.Text = "HTK";
            textBoxItemName.Text = "ITEM";
            itemHealingMpValue.Text = "MP";
            comboBoxHpBelowOver.Text = "BELOW";
            comboBoxMpBelowOver.Text = "BELOW";
            itemHealingHpValue.Text = "HP";
        }

        private void buttonRemoveSelectedItemHealing_Click(object sender, EventArgs e)
        {
            if (itemHealingList.Count > 0)
            {
                itemHealingList.Remove((Structs.itemHeal)listBoxItemHealingActive.SelectedItem);
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
        // end of item healing

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
            if (eaterHtk.Text != "HTK")
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
            if (mountHtk.Text != "HTK")
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
                    MessageBox.Show("Error! Invalid values.");
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

        private void buttonSaveCfgHealer_Click(object sender, EventArgs e)
        {
            // check if spell+item exists
            if (spellHealingList.Count > 0 && itemHealingList.Count >0)
            {
                // init spell
                bool spellValidLocation = false;
                SaveFileDialog sfdSpell = new SaveFileDialog();
                sfdSpell.Title = "SAVE SPELL IN..";
                sfdSpell.InitialDirectory = Directory.GetCurrentDirectory() + "\\Configs";
                sfdSpell.DefaultExt = "txt";
                sfdSpell.AddExtension = true;
                sfdSpell.FileName = "SPELL";
                // init item 
                bool itemValidLocation = false;
                SaveFileDialog sfdItem = new SaveFileDialog();
                sfdItem.Title = "SAVE ITEM IN..";
                sfdItem.InitialDirectory = Directory.GetCurrentDirectory() + "\\Configs";
                sfdItem.DefaultExt = "txt";
                sfdItem.AddExtension = true;
                sfdItem.FileName = "ITEM";
                // check spell folder + name
                if (sfdSpell.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    spellValidLocation = true;
                }
                else
                {
                    MessageBox.Show("Error! No SPELL location.");
                    return;
                }
                // check item folder+name
                if (sfdItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    itemValidLocation = true;
                }
                else
                {
                    MessageBox.Show("Error! No ITEM location.");
                    return;
                }
                // all ok
                if (itemValidLocation && spellValidLocation)
                {
                    // save item
                    string pathItem = sfdItem.FileName;
                    Stream streamItem = File.Create(pathItem);
                    XmlSerializer xmlSerItem = new XmlSerializer(typeof(List<Structs.itemHeal>));
                    xmlSerItem.Serialize(streamItem, itemHealingList);
                    streamItem.Close();
                    // save spell
                    string pathSpell = sfdSpell.FileName;
                    Stream streamSpell = File.Create(pathSpell);
                    XmlSerializer xmlSerSpell = new XmlSerializer(typeof(List<Structs.spellHeal>));
                    xmlSerSpell.Serialize(streamSpell, spellHealingList);
                    streamSpell.Close();
                }
            }
            // error messages first if fails
            else
            {
                if (spellHealingList.Count == 0 && itemHealingList.Count == 0) MessageBox.Show("Error! Nothing to save.");
                else if (spellHealingList.Count == 0) MessageBox.Show("Error! No SPELLS to save.");
                else if (itemHealingList.Count == 0) MessageBox.Show("Error! No ITEMS to save.");
            }
        }

        private void buttonLoadCfgHealer_Click(object sender, EventArgs e)
        {
            // init 
            bool itemLoadOk = false;
            bool spellLoadOk = false;
            List<Structs.itemHeal> auxItemList;
            List<Structs.spellHeal> auxSpellList;
            try
            {
                // init item
                OpenFileDialog ofdItem = new OpenFileDialog();
                ofdItem.Title = "LOAD ITEM FROM..";
                ofdItem.InitialDirectory = Directory.GetCurrentDirectory() + "\\Configs";
                ofdItem.DefaultExt = "txt";
                ofdItem.AddExtension = true;
                // init spell
                OpenFileDialog ofdSpell = new OpenFileDialog();
                ofdSpell.Title = "LOAD SPELL FROM..";
                ofdSpell.InitialDirectory = Directory.GetCurrentDirectory() + "\\Configs";
                ofdSpell.DefaultExt = "txt";
                ofdSpell.AddExtension = true;
                // popup dialogs
                if (ofdItem.ShowDialog() == System.Windows.Forms.DialogResult.OK && ofdSpell.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // item load
                    string pathItem = ofdItem.FileName;
                    Stream streamItem = File.OpenRead(pathItem);
                    XmlSerializer xmlSerItem = new XmlSerializer(typeof(List<Structs.itemHeal>));
                    // load to aux list
                    auxItemList = (List<Structs.itemHeal>)xmlSerItem.Deserialize(streamItem);
                    streamItem.Close();
                    // spell load
                    string pathSpell = ofdSpell.FileName;
                    Stream streamSpell = File.OpenRead(pathSpell);
                    XmlSerializer xmlSerSpell = new XmlSerializer(typeof(List<Structs.spellHeal>));
                    // load to aux list
                    auxSpellList = (List<Structs.spellHeal>)xmlSerSpell.Deserialize(streamSpell);
                    streamSpell.Close();
                    // success item+spell
                    spellLoadOk = true;
                    itemLoadOk = true;
                }
                else
                {
                    MessageBox.Show("Error! Select BOTH locations.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Corrupt/Invalid FILE.");
                return;
            }
            // all ok
            if (itemLoadOk && spellLoadOk)
            {
                // spell aux to real
                spellHealingList.Clear();
                spellHealingList = auxSpellList;
                updateSpellList();
                // item aux to real
                itemHealingList.Clear();
                itemHealingList = auxItemList;
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
        //
    }
}
