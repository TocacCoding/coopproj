using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication4.Functions
{
    class FileManager
    {
        // SAVE
        public static void saveHealerCfg(List<Structs.Spell> spellHealingList, List<Structs.Item> itemHealingList)
        {
            // check if spell+item exists
            if (spellHealingList.Count > 0 && itemHealingList.Count > 0)
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
                // check spell folder+name
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
                    XmlSerializer xmlSerItem = new XmlSerializer(typeof(List<Structs.Item>));
                    xmlSerItem.Serialize(streamItem, itemHealingList);
                    streamItem.Close();
                    // save spell
                    string pathSpell = sfdSpell.FileName;
                    Stream streamSpell = File.Create(pathSpell);
                    XmlSerializer xmlSerSpell = new XmlSerializer(typeof(List<Structs.Spell>));
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

        public static void saveHotkeyCfg(List<Structs.Hotkeys> hotkeyList)
        {
            if (hotkeyList.Count > 0)
            {
                SaveFileDialog sfdHotkey = new SaveFileDialog();
                sfdHotkey.Title = "SAVE HOTKEY IN..";
                sfdHotkey.InitialDirectory = Directory.GetCurrentDirectory() + "\\Configs";
                sfdHotkey.DefaultExt = "txt";
                sfdHotkey.AddExtension = true;
                sfdHotkey.FileName = "HOTKEY";
                // check item folder+name
                if (sfdHotkey.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // save item
                    string pathHotkey = sfdHotkey.FileName;
                    Stream streamHotkey = File.Create(pathHotkey);
                    XmlSerializer xmlSerItem = new XmlSerializer(typeof(List<Structs.Hotkeys>));
                    xmlSerItem.Serialize(streamHotkey, hotkeyList);
                    streamHotkey.Close();
                }
                else
                {
                    MessageBox.Show("Error! No location.");
                    return;
                }
            }
            // error messages first if fails
            else
            {
                MessageBox.Show("Error! Nothing to save.");
            }
        }

        // LOAD
        public static void loadHealerCfg(out List<Structs.Item> loadedItemList, out List<Structs.Spell> loadedSpellList)
        {
            // init 
            List<Structs.Item> auxItemList = null;
            List<Structs.Spell> auxSpellList = null;
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
                    XmlSerializer xmlSerItem = new XmlSerializer(typeof(List<Structs.Item>));
                    // load to aux list
                    auxItemList = (List<Structs.Item>)xmlSerItem.Deserialize(streamItem);
                    streamItem.Close();
                    // spell load
                    string pathSpell = ofdSpell.FileName;
                    Stream streamSpell = File.OpenRead(pathSpell);
                    XmlSerializer xmlSerSpell = new XmlSerializer(typeof(List<Structs.Spell>));
                    // load to aux list
                    auxSpellList = (List<Structs.Spell>)xmlSerSpell.Deserialize(streamSpell);
                    streamSpell.Close();
                    // success item+spell
                    loadedItemList = auxItemList;
                    loadedSpellList = auxSpellList;
                }
                else
                {
                    MessageBox.Show("Error! Select BOTH locations.");
                    loadedItemList = null;
                    loadedSpellList = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Corrupt/Invalid FILE.");
                loadedItemList = null;
                loadedSpellList = null;
                return;
            }
        }

        public static void loadHotkeyCfg(out List<Structs.Hotkeys> loadedHotkeyList)
        {
            // init 
            List<Structs.Hotkeys> auxHotkeyList = null;
            try
            {
                // init item
                OpenFileDialog ofdItem = new OpenFileDialog();
                ofdItem.Title = "LOAD HOTKEYS FROM..";
                ofdItem.InitialDirectory = Directory.GetCurrentDirectory() + "\\Configs";
                ofdItem.DefaultExt = "txt";
                ofdItem.AddExtension = true;
                // popup dialogs
                if (ofdItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // item load
                    string pathHotkey = ofdItem.FileName;
                    Stream streamHotkey = File.OpenRead(pathHotkey);
                    XmlSerializer xmlSerHotkey = new XmlSerializer(typeof(List<Structs.Hotkeys>));
                    // load to aux list
                    auxHotkeyList = (List<Structs.Hotkeys>)xmlSerHotkey.Deserialize(streamHotkey);
                    streamHotkey.Close();
                    // success item+spell
                    loadedHotkeyList = auxHotkeyList;
                }
                else
                {
                    MessageBox.Show("Error! Select location.");
                    loadedHotkeyList = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Corrupt/Invalid FILE.");
                loadedHotkeyList = null;
                return;
            }
        }

    } // no del
}
