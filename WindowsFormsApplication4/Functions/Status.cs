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
    class Status
    {
        public static bool isPZ()
        {
            int pzAux = -15718862;
            int y = 76;
            int[] coords = { 952, 933, 971, 943, 962, 924, 981, 905, 1000 };
            foreach (int x in coords)
            {
                if (Window.GetPixel(x, y) == pzAux) return true;
            }
            return false;
        }

        public static bool isHasted()
        {
            int hastedAux = -6385037;
            int y = 76;
            int[] coords = { 952, 933, 971, 943, 962, 924, 981, 905, 1000 };
            foreach (int x in coords)
            {
                if (Window.GetPixel(x, y) == hastedAux) return true;
            }
            return false;
        }

        public static bool isHungry()
        {
            int hungryAux = -9550811;
            int y = 76;
            int[] coords = { 952, 933, 971, 943, 962, 924, 981, 905, 1000 };
            foreach (int x in coords)
            {
                if (Window.GetPixel(x, y) == hungryAux) return true;
            }
            return false;
        }

        public static bool isParalyzed()
        {
            int paralizeAux = -14545657;
            int y = 76;
            int[] coords = { 952, 933, 971, 943, 962, 924, 981, 905, 1000 };
            foreach (int x in coords)
            {
                if (Window.GetPixel(x, y) == paralizeAux) return true;
            }
            return false;
        }

        public static bool isEmpowered()
        {
            int empoweredAux = -14743548;
            int y = 76;
            int[] coords = { 952, 933, 971, 943, 962, 924, 981, 905, 1000 };
            foreach (int x in coords)
            {
                if (Window.GetPixel(x, y) == empoweredAux) return true;
            }
            return false;
        }

        public static bool isMounted()
        {
            int x = 1775;
            int y = 230;
            int mountedAux = -13718993;
            if (Window.GetPixel(x, y) == mountedAux) return true;
            return false;
        }

        public static bool isLifeRing()
        {
            int x = 1780;
            int y = 419;
            int lifeRingAux = -9046944;
            if (Window.GetPixel(x, y) == lifeRingAux) return true;
            return false;
        }

        public static bool isEnergyRing()
        {
            int x = 1780;
            int y = 419;
            int energyRingAux = -8847393;
            if (Window.GetPixel(x, y) == energyRingAux) return true;
            return false;
        }
    }

}
