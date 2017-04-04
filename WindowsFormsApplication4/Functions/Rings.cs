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
        public void equipLifeRing()
        {
            s.Keyboard.KeyPress(VirtualKeyCode.VK_6);
        }
        public void unequipLifeRing()
        {
            s.Keyboard.KeyPress(VirtualKeyCode.VK_4);
        }
        public void equipEnergyRing()
        {
            s.Keyboard.KeyPress(VirtualKeyCode.VK_2);
        }
        public void unequipEnergyRing()
        {
            s.Keyboard.KeyPress(VirtualKeyCode.VK_5);
        }
    }
}
