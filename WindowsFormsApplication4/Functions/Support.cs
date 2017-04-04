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
    class Support
    {
        static InputSimulator s = new InputSimulator();
        public static VirtualKeyCode paralyzeHotkey;
        public static VirtualKeyCode poisonHotkey;
        public static void RemovePoison()
        {
            s.Keyboard.KeyPress(poisonHotkey);
        }
        public static void RemoveParalyze()
        {
            s.Keyboard.KeyPress(paralyzeHotkey);
        }
    }
}
