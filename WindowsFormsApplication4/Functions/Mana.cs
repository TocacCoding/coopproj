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
    class Mana
    {
        // init htks
        public static VirtualKeyCode manaWasterHotkey;
        static InputSimulator s = new InputSimulator();

        public static void manaDrinker(VirtualKeyCode hotkey)
        {
            s.Keyboard.KeyPress(hotkey);
        }

        public static void manaWaster()
        {
            s.Keyboard.KeyPress(manaWasterHotkey);
        }
    }
}
