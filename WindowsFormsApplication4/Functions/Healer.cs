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
namespace WindowsFormsApplication4.Functions
{
    class Healer
    {
        static InputSimulator s = new InputSimulator();
        public static void healChar(VirtualKeyCode hotkey)
        {
            s.Keyboard.KeyPress(hotkey);
        }

        // cleanse starts here
        public static void spellHeal(List<Structs.Spell> spellHealingList, int healthY, int emptyBarAux)
        {
            if (Functions.Window.isMaximized() && spellHealingList.Count > 0)
            {
                foreach (Structs.Spell spell in spellHealingList)
                {
                    if (Functions.Window.GetPixel(spell.hpPixel, healthY) == emptyBarAux && Functions.Window.GetPixel(spell.mpPixel, healthY) != emptyBarAux)
                    {
                        Functions.Healer.healChar(spell.hotkey);
                        return; // usou heal its over
                    }
                }
            }
        }

        public static void itemHeal(List<Structs.Item> itemHealingList, int healthY, int emptyBarAux, int manaY)
        {
            if (Functions.Window.isMaximized())
            {
                if (itemHealingList.Count > 0)
                {
                    foreach (Structs.Item item in itemHealingList)
                    {
                        if (item.operatorHp == "BELOW" && item.operatorMp == "BELOW")
                        {
                            // below below
                            if (Functions.Window.GetPixel(item.hpPixel, healthY) == emptyBarAux && Functions.Window.GetPixel(item.mpPixel, manaY) == emptyBarAux)
                            {
                                Functions.Healer.healChar(item.hotkey);
                                return; // usou pot its over
                            }
                        }
                        else if (item.operatorHp == "BELOW" && item.operatorMp == "OVER")
                        {
                            // below over
                            if (Functions.Window.GetPixel(item.hpPixel, healthY) == emptyBarAux && Functions.Window.GetPixel(item.mpPixel, manaY) != emptyBarAux)
                            {
                                Functions.Healer.healChar(item.hotkey);
                                return; // usou pot its over
                            }
                        }
                        else if (item.operatorHp == "OVER" && item.operatorMp == "BELOW")
                        {
                            // over below
                            if (Functions.Window.GetPixel(item.hpPixel, healthY) != emptyBarAux && Functions.Window.GetPixel(item.mpPixel, manaY) == emptyBarAux)
                            {
                                Functions.Healer.healChar(item.hotkey);
                                return; // usou pot its over
                            }
                        }
                        else if (item.operatorHp == "OVER" && item.operatorMp == "OVER")
                        {
                            // over over
                            if (Functions.Window.GetPixel(item.hpPixel, healthY) != emptyBarAux && Functions.Window.GetPixel(item.mpPixel, manaY) != emptyBarAux)
                            {
                                Functions.Healer.healChar(item.hotkey);
                                return; // usou pot its over
                            }
                        }
                    }
                }
            }
        }

        // cleanse ends here
    }
}
