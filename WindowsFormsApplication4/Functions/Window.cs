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
    class Window
    {
        public static int GetPixel(int X, int Y)
        {
            Bitmap bmp = new Bitmap(1, 1, PixelFormat.Format32bppPArgb);
            Graphics grp = Graphics.FromImage(bmp);
            grp.CopyFromScreen(new Point(X, Y), Point.Empty, new Size(1, 1));
            grp.Save();
            grp.Dispose();
            return bmp.GetPixel(0, 0).ToArgb();
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
