using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsInput;
using WindowsInput.Native;

namespace WindowsFormsApplication4.Structs
{
        public struct spellHeal
        {
            public string name;
            public string hpPercent;
            public int hpPixel;
            public VirtualKeyCode hotkey;

            public spellHeal (string NAME, string HP, VirtualKeyCode HTK, string MAXHP)
            {
                name = NAME;
                hotkey = HTK;
                hpPercent = HP;
                int aux = (int.Parse(HP) * 100) / int.Parse(MAXHP);
                if (aux == 0 || aux == 100)
                {
                    if (aux == 0) aux = 1;
                 else if (aux == 100) aux = 99;
                }
                hpPixel = 210 + ((int.Parse(aux.ToString()) * 74) / 10);
            }

            public override String ToString()
            {
            return "N: " + this.name + "     HP: < " + this.hpPercent + "     HT: " + this.hotkey;
            }

    }
}
