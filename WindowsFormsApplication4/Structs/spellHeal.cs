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

            public spellHeal (string NAME, string HP, VirtualKeyCode HTK)
            {
                name = NAME;
                hpPercent = HP;
                hotkey = HTK;
                hpPixel = 950 - ((int.Parse(HP) * 74) / 10);
        }
            public override String ToString()
            {
            return this.name + "       " + this.hpPercent + "       " + this.hotkey;
        }

    }
}
