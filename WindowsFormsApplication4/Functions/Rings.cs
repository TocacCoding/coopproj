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
    class Rings
    {
        static InputSimulator s = new InputSimulator();
        /// ring funcs
        public static VirtualKeyCode Elifering;
        public static VirtualKeyCode Ulifering;
        public static VirtualKeyCode Eenergyring;
        public static VirtualKeyCode Uenergyring;
        public static VirtualKeyCode Ehealingring;

        public static void equipLifeRing()
        {
            s.Keyboard.KeyPress(Elifering);
        }

        public static void unequipLifeRing()
        {
            s.Keyboard.KeyPress(Ulifering);
        }

        public static void equipEnergyRing()
        {
            s.Keyboard.KeyPress(Eenergyring);
        }

        public static void unequipEnergyRing()
        {
            s.Keyboard.KeyPress(Uenergyring);
        }

        public static void equipHealingRing()
        {
            s.Keyboard.KeyPress(Ehealingring);
        }
    }
}
