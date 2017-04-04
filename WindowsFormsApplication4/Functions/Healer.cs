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
    class Heal
    {
        static InputSimulator s = new InputSimulator();

        public static void redHeal()
        {s.Keyboard.KeyPress(VirtualKeyCode.VK_0);}
        public static void yellowHeal()
        {s.Keyboard.KeyPress(VirtualKeyCode.VK_9);}
        public static void greenHeal()
        {s.Keyboard.KeyPress(VirtualKeyCode.VK_8);}
    }
}
