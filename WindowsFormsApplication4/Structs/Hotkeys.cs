using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsInput.Native;

namespace WindowsFormsApplication4.Structs
{
    class Hotkeys
    {
        private static List<Hotkeys> allMyHotkeys = new List<Hotkeys>();
        public static IEnumerable<Hotkeys> AllInstances
        {
            get { return allMyHotkeys; }
        }

        public string identifier { get; set; }
        public VirtualKeyCode hotkey { get; set; }

        private Hotkeys() // Tem de ser privado se n ha 1 list ke nunca pode ser lida 
        {                
        }
        public static Hotkeys Create()
        {
            var newHotkey = new Hotkeys();
            allMyHotkeys.Add(newHotkey);
            return newHotkey;
        }
        public static void Delete(Hotkeys itemToRemove)
        {
            allMyHotkeys.Remove(itemToRemove);
        }
    }
}