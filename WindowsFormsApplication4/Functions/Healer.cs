﻿using System;
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
        public static void spellHeal(VirtualKeyCode hotkey)
        {
            s.Keyboard.KeyPress(hotkey);
        }
    }
}