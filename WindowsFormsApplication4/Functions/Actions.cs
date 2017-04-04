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
        public static void eat()
        {
            s.Keyboard.KeyPress(VirtualKeyCode.F8);
        }
        public static void haste()
        {
            s.Keyboard.KeyPress(VirtualKeyCode.NUMPAD2);
        }
        public static void empower()
        {
            s.Keyboard.KeyPress(VirtualKeyCode.VK_9);
        }
        public static void mount()
        {
            s.Keyboard.KeyPress(VirtualKeyCode.VK_T);
        }
    }
}
