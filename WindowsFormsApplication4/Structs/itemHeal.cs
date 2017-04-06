using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsInput.Native;

namespace WindowsFormsApplication4.Structs
{
    [Serializable]
    public class itemHeal
    {
        public string name;
        public string hpPercent;
        public string mpPercent;
        public int hpPixel;
        public int mpPixel;
        public VirtualKeyCode hotkey;
        public string operatorHp;
        public string operatorMp;
        public int hpShow;
        public int mpShow;
        public int maxHp;
        public int maxMp;

        public itemHeal() { }

        public itemHeal(string NAME, string HP, string MP, VirtualKeyCode HTK, string OPERATORHP, string OPERATORMP, string MAXHP, string MAXMP)
        {
            name = NAME;
            hpPercent = HP;
            mpPercent = MP;
            hotkey = HTK;
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
            hpPixel = 210 + ((auxHP * 74) / 10);
            mpPixel = 1710 - ((auxMP * 74) / 10);
            operatorHp = OPERATORHP;
            operatorMp = OPERATORMP;
            maxHp = int.Parse(MAXHP);
            maxMp = int.Parse(MAXMP);
        }

        public override String ToString()
        {
            string aux1, aux2;
            if (operatorHp == "BELOW")
            {
                aux1 = "<";
            }
            else aux1 = ">";
            if (operatorMp == "BELOW")
            {
                aux2 = "<";
            }
            else aux2 = ">";

            return "N: " + name + "  HP: " + aux1 + " " + hpPercent + " (" + hpShow.ToString() 
                + "%)  MP: " + aux2 + " " + mpPercent + " (" + mpShow.ToString() + "%)  HK: " + ((Keys)hotkey).ToString().Replace("D", "");
        }

    }
}
