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

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(7000);
            //MessageBox.Show(GetPixel(943, 76).ToString());
            //eaterHtk.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
        }

        //Init Vars
        //Bar pixel color
        int emptyBarAux = -13816270;

        // size hp=745px (10% == 74px)
        // hp start:950px
        int redHealthX = 950 - 74 - 74 - 74 - 74 - 74; // 50%
        int yellowHealthX = 950 - 74 - 74 - 74;    // 30%
        int greenHealthX = 950 - 74;           // 10%
        int healthY = 32;

        // size mana=745px (10% == 74px)
        // mp start:970px
        int manaStartDrinkX = 970 + 74 + 74 + 74 + 74 + 74; // 50%
        int manaStopDrinkX = 970 + 74 + 74 + 37; // 25%
        int maxManaX = 971;
        int manaY = 32;
        private bool smartMana = false;

        // spell heal timer
        private void spellHeal_Tick(object sender, EventArgs e)
        {

        }

        // item heal timer
        private void itemHeal_Tick(object sender, EventArgs e)
        {

        }

        // status checker timer
        private void statusChecker_Tick(object sender, EventArgs e)
        {

        }

        // garbage collection timer
        private void gc_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }
        // Graphical shit - cuidado aqui a cena fica negra se apagas fodes tudo - beware
        private void login_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o login button!");
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o $$$$$ button!");
        }

        private void buttonAddNewSpellHealing_Click(object sender, EventArgs e)
        {
            listBoxSpellHealingActive.Items.Add(this.textBoxSpellName.Text + "  " + this.comboBoxNewSpellHealingHotkey.Text 
                + "  " + this.newSpellHealingHpBelow.Text);
        }

        private void buttonClearNewSpell_Click(object sender, EventArgs e)
        {
            this.newSpellHealingHpBelow.ResetText();
            this.comboBoxNewSpellHealingHotkey.ResetText();
            this.textBoxSpellName.ResetText();
        }

        private void buttonRemoveSelectedSpellHealing_Click(object sender, EventArgs e)
        {
            this.listBoxSpellHealingActive.Items.Remove(listBoxSpellHealingActive.SelectedItem);
        }

        private void buttonUpSpellHealing_Click(object sender, EventArgs e)
        {
            if (listBoxSpellHealingActive.SelectedItem == null || listBoxSpellHealingActive.SelectedIndex < 0)
                return;
            int newIndex = listBoxSpellHealingActive.SelectedIndex - 1;
            if (newIndex < 0 || newIndex >= listBoxSpellHealingActive.Items.Count)
                return;
            object selected = listBoxSpellHealingActive.SelectedItem;
            listBoxSpellHealingActive.Items.Remove(selected);
            listBoxSpellHealingActive.Items.Insert(newIndex, selected);
            listBoxSpellHealingActive.SetSelected(newIndex, true);
        }

        private void buttonDownSpellHealing_Click(object sender, EventArgs e)
        {
            if (listBoxSpellHealingActive.SelectedItem == null || listBoxSpellHealingActive.SelectedIndex < 0)
                return;
            int newIndex = listBoxSpellHealingActive.SelectedIndex + 1;
            if (newIndex < 0 || newIndex >= listBoxSpellHealingActive.Items.Count)
                return;
            object selected = listBoxSpellHealingActive.SelectedItem;
            listBoxSpellHealingActive.Items.Remove(selected);
            listBoxSpellHealingActive.Items.Insert(newIndex, selected);
            listBoxSpellHealingActive.SetSelected(newIndex, true);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o register button!");
        }

        private void buttonUpdateSmartManaDrinker_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o update mana drinker!");
        }

        private void buttonUpdateManaWaster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o update mana waster!");
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o save cfg!");
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sou o load cfg!");
        }
    }
}
