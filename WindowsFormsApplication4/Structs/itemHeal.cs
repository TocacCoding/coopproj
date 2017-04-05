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
        public string operatorHp;
        public string operatorMp;

        public itemHeal(string NAME, string HP, string MP, VirtualKeyCode HTK, string OPERATORHP, string OPERATORMP)
        {
            name = NAME;
            hpPercent = HP;
            mpPercent = MP;
            hotkey = HTK;
            hpPixel = 210 + ((int.Parse(HP) * 74) / 10);
            mpPixel = 1710 - ((int.Parse(MP) * 74) / 10);
            operatorHp = OPERATORHP;
            operatorMp = OPERATORMP;
        }

        public override String ToString()
        {
            string aux1, aux2;
            if (this.operatorHp == "BELOW")
            {
                aux1 = "<";
            }
            else aux1 = ">";
            if (this.operatorMp == "BELOW")
            {
                aux2 = "<";
            }
            else aux2 = ">";

            return "N: " + this.name + "     HP: " + aux1 + " " + this.hpPercent + "%     MP: " + aux2 + " " + this.mpPercent + "%     HT: " + this.hotkey;
        }

    }
}
