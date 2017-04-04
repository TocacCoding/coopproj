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
    class Actions
    {
        static InputSimulator s = new InputSimulator();
        public static VirtualKeyCode mountHotkey;
        public static VirtualKeyCode recoveryHotkey;
        public static VirtualKeyCode hasteHotkey;
        public static VirtualKeyCode eatHotkey;

        public static void eat()
        {
            s.Keyboard.KeyPress(eatHotkey);
        }
        public static void haste()
        {
            s.Keyboard.KeyPress(hasteHotkey);
        }
        public static void empower()
        {
            s.Keyboard.KeyPress(recoveryHotkey);
        }
        public static void mount()
        {
            s.Keyboard.KeyPress(mountHotkey);
        }
    }
}
