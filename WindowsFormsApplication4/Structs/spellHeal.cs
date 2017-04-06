using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace WindowsFormsApplication4.Structs
{
    [Serializable]
        public class spellHeal
        {
            public string name;
            public string hpPercent;
            public string mpPercent;
            public int hpPixel;
            public int mpPixel;
            public int hpShow;
            public int mpShow;
            public VirtualKeyCode hotkey;
            public string maxHp;
            public string maxMp;

        public spellHeal() { }

        public spellHeal (string NAME, string HP, VirtualKeyCode HTK, string MAXHP, string MP, string MAXMP)
            {
                name = NAME;
                hotkey = HTK;
                hpPercent = HP;
                mpPercent = MP;
                int auxHP = (int.Parse(HP) * 100) / int.Parse(MAXHP);
                if (auxHP == 0 || auxHP == 100)
                {
                    if (auxHP == 0) auxHP = 1;
                 else if (auxHP == 100) auxHP = 99;
                }
                    int auxMP = (int.Parse(MP) * 100) / int.Parse(MAXHP);
                    if (auxMP == 0 || auxMP == 100)
                  {
                if (auxMP == 0) auxMP = 1;
                else if (auxMP == 100) auxMP = 99;
                 }
                mpShow = auxMP;
                hpShow = auxHP;
                mpPixel = 1710 - ((auxMP * 74) / 10);
                hpPixel = 210 + ((auxHP * 74) / 10);
                maxHp = MAXHP;
                maxMp = MAXMP;
            }

            public override String ToString()
            {
            return "N: " + name + "  HP: < " + hpPercent + " (" + hpShow.ToString() + "%)  MP: > " 
                + mpPercent + " (" + mpShow.ToString() + "%)  HK: " + (Keys)hotkey;
            }

    }
}
