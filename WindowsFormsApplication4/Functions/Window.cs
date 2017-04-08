<<<<<<< HEAD
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
using System.Diagnostics;


namespace WindowsFormsApplication4.Functions
{
    class Window
    {
        static Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        static Point location = new Point();
        public static int GetPixel(int x, int y)
        {
             location.X = x;
             location.Y = y;
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = NativeMethods.BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }
            return screenPixel.GetPixel(0, 0).ToArgb();
        }
        public static bool isMaximized()
        {
            int controlAux = -15327199;
            int controlX = 1882;
            int controlY = 107;
            if (GetPixel(controlX, controlY) == controlAux) return true;
            return false;
        }
        public static bool isClear()
        {
            int control2Aux = -13220541;
            int control2X = 960;
            int control2Y = 53;
            if (GetPixel(control2X, control2Y) == control2Aux) return true;
            return false;
        }
        public static int HotkeyValidation(VirtualKeyCode hotkey, string identification)
        {
            var checkforhotkey = Structs.Hotkeys.AllInstances.FirstOrDefault(md => md.hotkey == hotkey);
            var checkforid = Structs.Hotkeys.AllInstances.FirstOrDefault(md => md.identifier == identification);
            if(checkforhotkey == null && checkforid == null)
            {
                var createHotkey = Structs.Hotkeys.Create();
                createHotkey.hotkey = hotkey;
                createHotkey.identifier = identification;
                return 1;
                //new hotkey/action combo created
            }
            else if(checkforhotkey == null && checkforid != null)
            {
                
                DialogResult dr = MessageBox.Show("Replace Hotkey " + checkforid.identifier,"Cancel", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    checkforid.hotkey = hotkey;
                    return 1;
                    //Hotkey for the action was replaced with a new hotkey
                }
                else if (dr == DialogResult.No)
                {
                    return 0;
                    //everything is the same validation passed
                }
            }
            else if (checkforhotkey != null && checkforhotkey.identifier != identification)
            {
                DialogResult dr = MessageBox.Show("Replace " + checkforhotkey.identifier + " hotkey", "Cancel", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (checkforid!=null)
                    {
                        Structs.Hotkeys.Delete(checkforid);
                        checkforhotkey.identifier = identification;
                        return 1;
                        //the hotkey has been replaced with a new action

                    }
                    else
                    {
                        checkforhotkey.identifier = identification;
                        return 1;
                        //the hotkey has been replaced with a new action
                    }
                }
                else if (dr == DialogResult.No)
                {
                    return 2;
                    //the hotkey has not been replaced, thus validation did not pass
                }
            }
            else if (checkforhotkey != null && checkforhotkey.identifier == identification)
            {
                return 0;
                //user is trying to repeat an hotkey-action combo, everything is the same, validation passed
            }
            return 3;
            //Messagebox.Show("This return is impossible, something is wrong!")
        }
    }
}
=======
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
using System.Diagnostics;


namespace WindowsFormsApplication4.Functions
{
    class Window
    {
        static Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        static Point location = new Point();
        public static int GetPixel(int x, int y)
        {
             location.X = x;
             location.Y = y;
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = NativeMethods.BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }
            return screenPixel.GetPixel(0, 0).ToArgb();
        }
        public static bool isMaximized()
        {
            int controlAux = -15327199;
            int controlX = 1882;
            int controlY = 107;
            if (GetPixel(controlX, controlY) == controlAux) return true;
            return false;
        }
        public static bool isClear()
        {
            int control2Aux = -13220541;
            int control2X = 960;
            int control2Y = 53;
            if (GetPixel(control2X, control2Y) == control2Aux) return true;
            return false;
        }
        public static int HotkeyValidation(VirtualKeyCode hotkey, string identification)
        {
            var checkforhotkey = Structs.Hotkeys.AllInstances.FirstOrDefault(md => md.hotkey == hotkey);
            var checkforid = Structs.Hotkeys.AllInstances.FirstOrDefault(md => md.identifier == identification);
            if(checkforhotkey == null && checkforid == null)
            {
                var createHotkey = Structs.Hotkeys.Create();
                createHotkey.hotkey = hotkey;
                createHotkey.identifier = identification;
                return 1;
                //new hotkey/action combo created
            }
            else if(checkforhotkey == null && checkforid != null)
            {
                
                DialogResult dr = MessageBox.Show("Replace Hotkey " + checkforid.identifier,"Cancel", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    checkforid.hotkey = hotkey;
                    return 1;
                    //Hotkey for the action was replaced with a new hotkey
                }
                else if (dr == DialogResult.No)
                {
                    return 0;
                    //everything is the same validation passed
                }
            }
            else if (checkforhotkey != null && checkforhotkey.identifier != identification)
            {
                DialogResult dr = MessageBox.Show("Replace " + checkforhotkey.identifier + " hotkey", "Cancel", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (checkforid!=null)
                    {
                        Structs.Hotkeys.Delete(checkforid);
                        checkforhotkey.identifier = identification;
                        return 1;
                        //the hotkey has been replaced with a new action

                    }
                    else
                    {
                        checkforhotkey.identifier = identification;
                        return 1;
                        //the hotkey has been replaced with a new action
                    }
                }
                else if (dr == DialogResult.No)
                {
                    return 2;
                    //the hotkey has not been replaced, thus validation did not pass
                }
            }
            else if (checkforhotkey != null && checkforhotkey.identifier == identification)
            {
                return 0;
                //user is trying to repeat an hotkey-action combo, everything is the same, validation passed
            }
            return 3;
            //Messagebox.Show("This return is impossible, something is wrong!")
        }
    }
}
>>>>>>> origin/master
