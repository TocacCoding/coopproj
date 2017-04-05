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
    }
}
