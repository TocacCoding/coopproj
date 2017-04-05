using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsInput.Native;

namespace WindowsFormsApplication4.Structs
{
    public struct itemHeal
    {
        public string name;
        public string hpPercent;
        public string mpPercent;
        public int hpPixel;
        public int mpPixel;
        public VirtualKeyCode hotkey;

        public itemHeal(string NAME, string HP, string MP, VirtualKeyCode HTK)
        {
            name = NAME;
            hpPercent = HP;
            mpPercent = MP;
            hotkey = HTK;
            hpPixel = 210 + ((int.Parse(HP) * 74) / 10);
            mpPixel = 1710 - ((int.Parse(MP) * 74) / 10);
        }
        public override String ToString()
        {
            return this.name + "       " + this.hpPercent + " " + this.mpPercent + "       " + this.hotkey;
        }

    }
}
