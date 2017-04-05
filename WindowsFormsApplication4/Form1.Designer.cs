using System;
using WindowsInput.Native;

namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spellHealTimer = new System.Windows.Forms.Timer(this.components);
            this.itemHealTimer = new System.Windows.Forms.Timer(this.components);
            this.statusCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_account = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_daysLeftShow = new System.Windows.Forms.Label();
            this.label_accountStatusShow = new System.Windows.Forms.Label();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.label_daysLeft = new System.Windows.Forms.Label();
            this.label_accountStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.password_input = new System.Windows.Forms.TextBox();
            this.username_input = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.tab_main = new System.Windows.Forms.TabPage();
            this.groupBoxConfigManager = new System.Windows.Forms.GroupBox();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.tab_heal = new System.Windows.Forms.TabPage();
            this.groupBoxGeneralInfo = new System.Windows.Forms.GroupBox();
            this.buttonResetHealing = new System.Windows.Forms.Button();
            this.maxMpInput = new System.Windows.Forms.TextBox();
            this.maxHpInput = new System.Windows.Forms.TextBox();
            this.buttonApplyMaxValues = new System.Windows.Forms.Button();
            this.labelMaxMp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxItemHealing = new System.Windows.Forms.GroupBox();
            this.groupBoxNewItemHealing = new System.Windows.Forms.GroupBox();
            this.newItemHealingMpBelow = new System.Windows.Forms.DomainUpDown();
            this.labelNewItemMp = new System.Windows.Forms.Label();
            this.buttonClearNewItem = new System.Windows.Forms.Button();
            this.newItemHealingHpBelow = new System.Windows.Forms.DomainUpDown();
            this.comboBoxNewItemHealingHotkey = new System.Windows.Forms.ComboBox();
            this.buttonAddNewItemHealing = new System.Windows.Forms.Button();
            this.labelNewItemHp = new System.Windows.Forms.Label();
            this.labelNewHotkeyItem = new System.Windows.Forms.Label();
            this.labelNewItemName = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.groupBoxActiveItems = new System.Windows.Forms.GroupBox();
            this.listBoxItemHealingActive = new System.Windows.Forms.ListBox();
            this.labelTopActiveItems = new System.Windows.Forms.Label();
            this.buttonDownItemHealing = new System.Windows.Forms.Button();
            this.buttonUpItemHealing = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedItemHealing = new System.Windows.Forms.Button();
            this.groupBoxSpellHealing = new System.Windows.Forms.GroupBox();
            this.groupBoxNewSpellHealing = new System.Windows.Forms.GroupBox();
            this.spellHealingHpValue = new System.Windows.Forms.TextBox();
            this.buttonClearNewSpell = new System.Windows.Forms.Button();
            this.newSpellHealingHpBelow = new System.Windows.Forms.DomainUpDown();
            this.comboBoxNewSpellHealingHotkey = new System.Windows.Forms.ComboBox();
            this.buttonAddNewSpellHealing = new System.Windows.Forms.Button();
            this.labelNewSpellHp = new System.Windows.Forms.Label();
            this.labelNewSpellHotkey = new System.Windows.Forms.Label();
            this.labelNewSpellName = new System.Windows.Forms.Label();
            this.textBoxSpellName = new System.Windows.Forms.TextBox();
            this.groupBoxActiveSpellsHealing = new System.Windows.Forms.GroupBox();
            this.listBoxSpellHealingActive = new System.Windows.Forms.ListBox();
            this.labelTopActiveSpells = new System.Windows.Forms.Label();
            this.buttonDownSpellHealing = new System.Windows.Forms.Button();
            this.buttonUpSpellHealing = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedSpellHealing = new System.Windows.Forms.Button();
            this.tab_mana = new System.Windows.Forms.TabPage();
            this.groupBoxSmartManaDrinker = new System.Windows.Forms.GroupBox();
            this.smartManaDrinkerStopManaPercent = new System.Windows.Forms.DomainUpDown();
            this.smartManaDrinkerStartManaPercent = new System.Windows.Forms.DomainUpDown();
            this.smartManaDrinkerHotkey = new System.Windows.Forms.ComboBox();
            this.labelSmartManaDrinkerHotkey = new System.Windows.Forms.Label();
            this.labelSmartManaDrinkerStopMana = new System.Windows.Forms.Label();
            this.labelSmartManaDrinkerStartMana = new System.Windows.Forms.Label();
            this.tab_actions = new System.Windows.Forms.TabPage();
            this.groupBoxManaWaster = new System.Windows.Forms.GroupBox();
            this.smartManaWasterHotkey = new System.Windows.Forms.ComboBox();
            this.labelManaWasterHotkey = new System.Windows.Forms.Label();
            this.groupBoxSpells = new System.Windows.Forms.GroupBox();
            this.utamoVitaHotkey = new System.Windows.Forms.ComboBox();
            this.utanaVidHotkey = new System.Windows.Forms.ComboBox();
            this.checkBoxUtana = new System.Windows.Forms.CheckBox();
            this.checkBoxUtamo = new System.Windows.Forms.CheckBox();
            this.groupBoxRoutine = new System.Windows.Forms.GroupBox();
            this.mountHtk = new System.Windows.Forms.ComboBox();
            this.eaterHtk = new System.Windows.Forms.ComboBox();
            this.checkBoxMount = new System.Windows.Forms.CheckBox();
            this.checkBoxEater = new System.Windows.Forms.CheckBox();
            this.groupboxRings = new System.Windows.Forms.GroupBox();
            this.healingRingHotkey = new System.Windows.Forms.ComboBox();
            this.mightRingHotkey = new System.Windows.Forms.ComboBox();
            this.timeRingHotkey = new System.Windows.Forms.ComboBox();
            this.energyRingHotkey = new System.Windows.Forms.ComboBox();
            this.lifeRingHotkey = new System.Windows.Forms.ComboBox();
            this.checkBoxMightRing = new System.Windows.Forms.CheckBox();
            this.checkBoxHealingRing = new System.Windows.Forms.CheckBox();
            this.checkBoxTimeRing = new System.Windows.Forms.CheckBox();
            this.checkBoxEnergyRing = new System.Windows.Forms.CheckBox();
            this.checkBoxLifeRing = new System.Windows.Forms.CheckBox();
            this.tab_support = new System.Windows.Forms.TabPage();
            this.groupBoxStatusHolder = new System.Windows.Forms.GroupBox();
            this.uturaHotkey = new System.Windows.Forms.ComboBox();
            this.hasteHotkey = new System.Windows.Forms.ComboBox();
            this.checkBoxUtura = new System.Windows.Forms.CheckBox();
            this.checkBoxHaste = new System.Windows.Forms.CheckBox();
            this.groupBoxConditionHealer = new System.Windows.Forms.GroupBox();
            this.poisonHotkey = new System.Windows.Forms.ComboBox();
            this.paralyzeHotkey = new System.Windows.Forms.ComboBox();
            this.checkBoxPoison = new System.Windows.Forms.CheckBox();
            this.checkBoxParalyze = new System.Windows.Forms.CheckBox();
            this.itemHealingHpValue = new System.Windows.Forms.TextBox();
            this.itemHealingMpValue = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_account.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.groupBoxConfigManager.SuspendLayout();
            this.tab_heal.SuspendLayout();
            this.groupBoxGeneralInfo.SuspendLayout();
            this.groupBoxItemHealing.SuspendLayout();
            this.groupBoxNewItemHealing.SuspendLayout();
            this.groupBoxActiveItems.SuspendLayout();
            this.groupBoxSpellHealing.SuspendLayout();
            this.groupBoxNewSpellHealing.SuspendLayout();
            this.groupBoxActiveSpellsHealing.SuspendLayout();
            this.tab_mana.SuspendLayout();
            this.groupBoxSmartManaDrinker.SuspendLayout();
            this.tab_actions.SuspendLayout();
            this.groupBoxManaWaster.SuspendLayout();
            this.groupBoxSpells.SuspendLayout();
            this.groupBoxRoutine.SuspendLayout();
            this.groupboxRings.SuspendLayout();
            this.tab_support.SuspendLayout();
            this.groupBoxStatusHolder.SuspendLayout();
            this.groupBoxConditionHealer.SuspendLayout();
            this.SuspendLayout();
            // 
            // spellHealTimer
            // 
            this.spellHealTimer.Enabled = true;
            this.spellHealTimer.Interval = 1050;
            this.spellHealTimer.Tick += new System.EventHandler(this.spellHeal_Tick);
            // 
            // itemHealTimer
            // 
            this.itemHealTimer.Enabled = true;
            this.itemHealTimer.Interval = 1060;
            this.itemHealTimer.Tick += new System.EventHandler(this.itemHeal_Tick);
            // 
            // statusCheckTimer
            // 
            this.statusCheckTimer.Enabled = true;
            this.statusCheckTimer.Interval = 3000;
            this.statusCheckTimer.Tick += new System.EventHandler(this.statusChecker_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_account);
            this.tabControl1.Controls.Add(this.tab_main);
            this.tabControl1.Controls.Add(this.tab_heal);
            this.tabControl1.Controls.Add(this.tab_mana);
            this.tabControl1.Controls.Add(this.tab_actions);
            this.tabControl1.Controls.Add(this.tab_support);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_account
            // 
            this.tab_account.Controls.Add(this.groupBox3);
            this.tab_account.Controls.Add(this.groupBox2);
            this.tab_account.Location = new System.Drawing.Point(4, 22);
            this.tab_account.Name = "tab_account";
            this.tab_account.Padding = new System.Windows.Forms.Padding(3);
            this.tab_account.Size = new System.Drawing.Size(475, 455);
            this.tab_account.TabIndex = 0;
            this.tab_account.Text = "Account";
            this.tab_account.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_daysLeftShow);
            this.groupBox3.Controls.Add(this.label_accountStatusShow);
            this.groupBox3.Controls.Add(this.buttonPurchase);
            this.groupBox3.Controls.Add(this.label_daysLeft);
            this.groupBox3.Controls.Add(this.label_accountStatus);
            this.groupBox3.Location = new System.Drawing.Point(44, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 135);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Status";
            // 
            // label_daysLeftShow
            // 
            this.label_daysLeftShow.AutoSize = true;
            this.label_daysLeftShow.ForeColor = System.Drawing.Color.Red;
            this.label_daysLeftShow.Location = new System.Drawing.Point(123, 49);
            this.label_daysLeftShow.Name = "label_daysLeftShow";
            this.label_daysLeftShow.Size = new System.Drawing.Size(13, 13);
            this.label_daysLeftShow.TabIndex = 9;
            this.label_daysLeftShow.Text = "0";
            // 
            // label_accountStatusShow
            // 
            this.label_accountStatusShow.AutoSize = true;
            this.label_accountStatusShow.ForeColor = System.Drawing.Color.Red;
            this.label_accountStatusShow.Location = new System.Drawing.Point(123, 22);
            this.label_accountStatusShow.Name = "label_accountStatusShow";
            this.label_accountStatusShow.Size = new System.Drawing.Size(71, 13);
            this.label_accountStatusShow.TabIndex = 8;
            this.label_accountStatusShow.Text = "Free Account";
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(49, 76);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(126, 24);
            this.buttonPurchase.TabIndex = 7;
            this.buttonPurchase.Text = "Get more days!";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // label_daysLeft
            // 
            this.label_daysLeft.AutoSize = true;
            this.label_daysLeft.Location = new System.Drawing.Point(61, 49);
            this.label_daysLeft.Name = "label_daysLeft";
            this.label_daysLeft.Size = new System.Drawing.Size(51, 13);
            this.label_daysLeft.TabIndex = 6;
            this.label_daysLeft.Text = "Days left:";
            // 
            // label_accountStatus
            // 
            this.label_accountStatus.AutoSize = true;
            this.label_accountStatus.Location = new System.Drawing.Point(29, 22);
            this.label_accountStatus.Name = "label_accountStatus";
            this.label_accountStatus.Size = new System.Drawing.Size(83, 13);
            this.label_accountStatus.TabIndex = 5;
            this.label_accountStatus.Text = "Account Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRegister);
            this.groupBox2.Controls.Add(this.login_button);
            this.groupBox2.Controls.Add(this.password_input);
            this.groupBox2.Controls.Add(this.username_input);
            this.groupBox2.Controls.Add(this.label_password);
            this.groupBox2.Controls.Add(this.label_username);
            this.groupBox2.Location = new System.Drawing.Point(44, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 140);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log In";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(56, 90);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(101, 23);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "Create Account";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(163, 90);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(79, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(85, 53);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(156, 20);
            this.password_input.TabIndex = 3;
            this.password_input.Text = "*************";
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(85, 23);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(156, 20);
            this.username_input.TabIndex = 2;
            this.username_input.Text = "user@mail.com";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(12, 52);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(12, 26);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(58, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username:";
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.groupBoxConfigManager);
            this.tab_main.Location = new System.Drawing.Point(4, 22);
            this.tab_main.Name = "tab_main";
            this.tab_main.Padding = new System.Windows.Forms.Padding(3);
            this.tab_main.Size = new System.Drawing.Size(475, 455);
            this.tab_main.TabIndex = 1;
            this.tab_main.Text = "Main";
            this.tab_main.UseVisualStyleBackColor = true;
            // 
            // groupBoxConfigManager
            // 
            this.groupBoxConfigManager.Controls.Add(this.buttonSaveConfig);
            this.groupBoxConfigManager.Controls.Add(this.buttonLoadConfig);
            this.groupBoxConfigManager.Location = new System.Drawing.Point(6, 6);
            this.groupBoxConfigManager.Name = "groupBoxConfigManager";
            this.groupBoxConfigManager.Size = new System.Drawing.Size(109, 94);
            this.groupBoxConfigManager.TabIndex = 0;
            this.groupBoxConfigManager.TabStop = false;
            this.groupBoxConfigManager.Text = "Config Manager";
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Location = new System.Drawing.Point(17, 19);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveConfig.TabIndex = 1;
            this.buttonSaveConfig.Text = "Save Config";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // buttonLoadConfig
            // 
            this.buttonLoadConfig.Location = new System.Drawing.Point(17, 48);
            this.buttonLoadConfig.Name = "buttonLoadConfig";
            this.buttonLoadConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadConfig.TabIndex = 0;
            this.buttonLoadConfig.Text = "Load Config";
            this.buttonLoadConfig.UseVisualStyleBackColor = true;
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);
            // 
            // tab_heal
            // 
            this.tab_heal.Controls.Add(this.groupBoxGeneralInfo);
            this.tab_heal.Controls.Add(this.groupBoxItemHealing);
            this.tab_heal.Controls.Add(this.groupBoxSpellHealing);
            this.tab_heal.Location = new System.Drawing.Point(4, 22);
            this.tab_heal.Name = "tab_heal";
            this.tab_heal.Size = new System.Drawing.Size(475, 444);
            this.tab_heal.TabIndex = 2;
            this.tab_heal.Text = "Heal";
            this.tab_heal.UseVisualStyleBackColor = true;
            // 
            // groupBoxGeneralInfo
            // 
            this.groupBoxGeneralInfo.Controls.Add(this.buttonResetHealing);
            this.groupBoxGeneralInfo.Controls.Add(this.maxMpInput);
            this.groupBoxGeneralInfo.Controls.Add(this.maxHpInput);
            this.groupBoxGeneralInfo.Controls.Add(this.buttonApplyMaxValues);
            this.groupBoxGeneralInfo.Controls.Add(this.labelMaxMp);
            this.groupBoxGeneralInfo.Controls.Add(this.label1);
            this.groupBoxGeneralInfo.Location = new System.Drawing.Point(3, 4);
            this.groupBoxGeneralInfo.Name = "groupBoxGeneralInfo";
            this.groupBoxGeneralInfo.Size = new System.Drawing.Size(466, 88);
            this.groupBoxGeneralInfo.TabIndex = 2;
            this.groupBoxGeneralInfo.TabStop = false;
            this.groupBoxGeneralInfo.Text = "General Info";
            // 
            // buttonResetHealing
            // 
            this.buttonResetHealing.ForeColor = System.Drawing.Color.Red;
            this.buttonResetHealing.Location = new System.Drawing.Point(185, 52);
            this.buttonResetHealing.Name = "buttonResetHealing";
            this.buttonResetHealing.Size = new System.Drawing.Size(87, 30);
            this.buttonResetHealing.TabIndex = 7;
            this.buttonResetHealing.Text = "Reset";
            this.buttonResetHealing.UseVisualStyleBackColor = true;
            this.buttonResetHealing.Visible = false;
            this.buttonResetHealing.Click += new System.EventHandler(this.buttonResetHealing_Click);
            // 
            // maxMpInput
            // 
            this.maxMpInput.Location = new System.Drawing.Point(335, 19);
            this.maxMpInput.Name = "maxMpInput";
            this.maxMpInput.Size = new System.Drawing.Size(70, 20);
            this.maxMpInput.TabIndex = 6;
            // 
            // maxHpInput
            // 
            this.maxHpInput.Location = new System.Drawing.Point(102, 20);
            this.maxHpInput.Name = "maxHpInput";
            this.maxHpInput.Size = new System.Drawing.Size(69, 20);
            this.maxHpInput.TabIndex = 5;
            // 
            // buttonApplyMaxValues
            // 
            this.buttonApplyMaxValues.ForeColor = System.Drawing.Color.Green;
            this.buttonApplyMaxValues.Location = new System.Drawing.Point(185, 52);
            this.buttonApplyMaxValues.Name = "buttonApplyMaxValues";
            this.buttonApplyMaxValues.Size = new System.Drawing.Size(87, 30);
            this.buttonApplyMaxValues.TabIndex = 4;
            this.buttonApplyMaxValues.Text = "Apply";
            this.buttonApplyMaxValues.UseVisualStyleBackColor = true;
            this.buttonApplyMaxValues.Click += new System.EventHandler(this.buttonApplyMaxValues_Click);
            // 
            // labelMaxMp
            // 
            this.labelMaxMp.AutoSize = true;
            this.labelMaxMp.ForeColor = System.Drawing.Color.Blue;
            this.labelMaxMp.Location = new System.Drawing.Point(275, 22);
            this.labelMaxMp.Name = "labelMaxMp";
            this.labelMaxMp.Size = new System.Drawing.Size(49, 13);
            this.labelMaxMp.TabIndex = 1;
            this.labelMaxMp.Text = "Max MP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max HP:";
            // 
            // groupBoxItemHealing
            // 
            this.groupBoxItemHealing.Controls.Add(this.groupBoxNewItemHealing);
            this.groupBoxItemHealing.Controls.Add(this.groupBoxActiveItems);
            this.groupBoxItemHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxItemHealing.Location = new System.Drawing.Point(3, 262);
            this.groupBoxItemHealing.Name = "groupBoxItemHealing";
            this.groupBoxItemHealing.Size = new System.Drawing.Size(466, 178);
            this.groupBoxItemHealing.TabIndex = 1;
            this.groupBoxItemHealing.TabStop = false;
            this.groupBoxItemHealing.Text = "Item Healing";
            this.groupBoxItemHealing.Visible = false;
            // 
            // groupBoxNewItemHealing
            // 
            this.groupBoxNewItemHealing.Controls.Add(this.itemHealingMpValue);
            this.groupBoxNewItemHealing.Controls.Add(this.itemHealingHpValue);
            this.groupBoxNewItemHealing.Controls.Add(this.newItemHealingMpBelow);
            this.groupBoxNewItemHealing.Controls.Add(this.labelNewItemMp);
            this.groupBoxNewItemHealing.Controls.Add(this.buttonClearNewItem);
            this.groupBoxNewItemHealing.Controls.Add(this.newItemHealingHpBelow);
            this.groupBoxNewItemHealing.Controls.Add(this.comboBoxNewItemHealingHotkey);
            this.groupBoxNewItemHealing.Controls.Add(this.buttonAddNewItemHealing);
            this.groupBoxNewItemHealing.Controls.Add(this.labelNewItemHp);
            this.groupBoxNewItemHealing.Controls.Add(this.labelNewHotkeyItem);
            this.groupBoxNewItemHealing.Controls.Add(this.labelNewItemName);
            this.groupBoxNewItemHealing.Controls.Add(this.textBoxItemName);
            this.groupBoxNewItemHealing.Location = new System.Drawing.Point(269, 19);
            this.groupBoxNewItemHealing.Name = "groupBoxNewItemHealing";
            this.groupBoxNewItemHealing.Size = new System.Drawing.Size(191, 146);
            this.groupBoxNewItemHealing.TabIndex = 2;
            this.groupBoxNewItemHealing.TabStop = false;
            this.groupBoxNewItemHealing.Text = "New Item";
            // 
            // newItemHealingMpBelow
            // 
            this.newItemHealingMpBelow.Items.Add("100");
            this.newItemHealingMpBelow.Items.Add("95");
            this.newItemHealingMpBelow.Items.Add("90");
            this.newItemHealingMpBelow.Items.Add("85");
            this.newItemHealingMpBelow.Items.Add("80");
            this.newItemHealingMpBelow.Items.Add("75");
            this.newItemHealingMpBelow.Items.Add("70");
            this.newItemHealingMpBelow.Items.Add("65");
            this.newItemHealingMpBelow.Items.Add("60");
            this.newItemHealingMpBelow.Items.Add("55");
            this.newItemHealingMpBelow.Items.Add("50");
            this.newItemHealingMpBelow.Items.Add("45");
            this.newItemHealingMpBelow.Items.Add("40");
            this.newItemHealingMpBelow.Items.Add("35");
            this.newItemHealingMpBelow.Items.Add("30");
            this.newItemHealingMpBelow.Items.Add("25");
            this.newItemHealingMpBelow.Items.Add("20");
            this.newItemHealingMpBelow.Items.Add("15");
            this.newItemHealingMpBelow.Items.Add("10");
            this.newItemHealingMpBelow.Items.Add("5");
            this.newItemHealingMpBelow.Location = new System.Drawing.Point(98, 94);
            this.newItemHealingMpBelow.Name = "newItemHealingMpBelow";
            this.newItemHealingMpBelow.Size = new System.Drawing.Size(38, 20);
            this.newItemHealingMpBelow.TabIndex = 9;
            this.newItemHealingMpBelow.Text = "MP";
            // 
            // labelNewItemMp
            // 
            this.labelNewItemMp.AutoSize = true;
            this.labelNewItemMp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewItemMp.Location = new System.Drawing.Point(6, 96);
            this.labelNewItemMp.Name = "labelNewItemMp";
            this.labelNewItemMp.Size = new System.Drawing.Size(65, 13);
            this.labelNewItemMp.TabIndex = 8;
            this.labelNewItemMp.Text = "MP BELOW";
            // 
            // buttonClearNewItem
            // 
            this.buttonClearNewItem.ForeColor = System.Drawing.Color.Red;
            this.buttonClearNewItem.Location = new System.Drawing.Point(98, 118);
            this.buttonClearNewItem.Name = "buttonClearNewItem";
            this.buttonClearNewItem.Size = new System.Drawing.Size(76, 21);
            this.buttonClearNewItem.TabIndex = 7;
            this.buttonClearNewItem.Text = "Clear Fields";
            this.buttonClearNewItem.UseVisualStyleBackColor = true;
            this.buttonClearNewItem.Click += new System.EventHandler(this.buttonClearNewItem_Click);
            // 
            // newItemHealingHpBelow
            // 
            this.newItemHealingHpBelow.Items.Add("100");
            this.newItemHealingHpBelow.Items.Add("95");
            this.newItemHealingHpBelow.Items.Add("90");
            this.newItemHealingHpBelow.Items.Add("85");
            this.newItemHealingHpBelow.Items.Add("80");
            this.newItemHealingHpBelow.Items.Add("75");
            this.newItemHealingHpBelow.Items.Add("70");
            this.newItemHealingHpBelow.Items.Add("65");
            this.newItemHealingHpBelow.Items.Add("60");
            this.newItemHealingHpBelow.Items.Add("55");
            this.newItemHealingHpBelow.Items.Add("50");
            this.newItemHealingHpBelow.Items.Add("45");
            this.newItemHealingHpBelow.Items.Add("40");
            this.newItemHealingHpBelow.Items.Add("35");
            this.newItemHealingHpBelow.Items.Add("30");
            this.newItemHealingHpBelow.Items.Add("25");
            this.newItemHealingHpBelow.Items.Add("20");
            this.newItemHealingHpBelow.Items.Add("15");
            this.newItemHealingHpBelow.Items.Add("10");
            this.newItemHealingHpBelow.Items.Add("5");
            this.newItemHealingHpBelow.Location = new System.Drawing.Point(98, 73);
            this.newItemHealingHpBelow.Name = "newItemHealingHpBelow";
            this.newItemHealingHpBelow.Size = new System.Drawing.Size(38, 20);
            this.newItemHealingHpBelow.TabIndex = 6;
            this.newItemHealingHpBelow.Text = "HP";
            // 
            // comboBoxNewItemHealingHotkey
            // 
            this.comboBoxNewItemHealingHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.comboBoxNewItemHealingHotkey.Location = new System.Drawing.Point(98, 43);
            this.comboBoxNewItemHealingHotkey.Name = "comboBoxNewItemHealingHotkey";
            this.comboBoxNewItemHealingHotkey.Size = new System.Drawing.Size(86, 21);
            this.comboBoxNewItemHealingHotkey.TabIndex = 5;
            this.comboBoxNewItemHealingHotkey.Text = "HTK";
            // 
            // buttonAddNewItemHealing
            // 
            this.buttonAddNewItemHealing.ForeColor = System.Drawing.Color.Green;
            this.buttonAddNewItemHealing.Location = new System.Drawing.Point(31, 118);
            this.buttonAddNewItemHealing.Name = "buttonAddNewItemHealing";
            this.buttonAddNewItemHealing.Size = new System.Drawing.Size(61, 21);
            this.buttonAddNewItemHealing.TabIndex = 4;
            this.buttonAddNewItemHealing.Text = "Add Item";
            this.buttonAddNewItemHealing.UseVisualStyleBackColor = true;
            this.buttonAddNewItemHealing.Click += new System.EventHandler(this.buttonAddNewItemHealing_Click);
            // 
            // labelNewItemHp
            // 
            this.labelNewItemHp.AutoSize = true;
            this.labelNewItemHp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewItemHp.Location = new System.Drawing.Point(6, 76);
            this.labelNewItemHp.Name = "labelNewItemHp";
            this.labelNewItemHp.Size = new System.Drawing.Size(64, 13);
            this.labelNewItemHp.TabIndex = 3;
            this.labelNewItemHp.Text = "HP BELOW";
            // 
            // labelNewHotkeyItem
            // 
            this.labelNewHotkeyItem.AutoSize = true;
            this.labelNewHotkeyItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewHotkeyItem.Location = new System.Drawing.Point(6, 46);
            this.labelNewHotkeyItem.Name = "labelNewHotkeyItem";
            this.labelNewHotkeyItem.Size = new System.Drawing.Size(41, 13);
            this.labelNewHotkeyItem.TabIndex = 2;
            this.labelNewHotkeyItem.Text = "Hotkey";
            // 
            // labelNewItemName
            // 
            this.labelNewItemName.AutoSize = true;
            this.labelNewItemName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewItemName.Location = new System.Drawing.Point(6, 19);
            this.labelNewItemName.Name = "labelNewItemName";
            this.labelNewItemName.Size = new System.Drawing.Size(35, 13);
            this.labelNewItemName.TabIndex = 1;
            this.labelNewItemName.Text = "Name";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(98, 16);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(86, 20);
            this.textBoxItemName.TabIndex = 0;
            this.textBoxItemName.Text = "ITEM";
            // 
            // groupBoxActiveItems
            // 
            this.groupBoxActiveItems.Controls.Add(this.listBoxItemHealingActive);
            this.groupBoxActiveItems.Controls.Add(this.labelTopActiveItems);
            this.groupBoxActiveItems.Controls.Add(this.buttonDownItemHealing);
            this.groupBoxActiveItems.Controls.Add(this.buttonUpItemHealing);
            this.groupBoxActiveItems.Controls.Add(this.buttonRemoveSelectedItemHealing);
            this.groupBoxActiveItems.Location = new System.Drawing.Point(6, 19);
            this.groupBoxActiveItems.Name = "groupBoxActiveItems";
            this.groupBoxActiveItems.Size = new System.Drawing.Size(257, 146);
            this.groupBoxActiveItems.TabIndex = 1;
            this.groupBoxActiveItems.TabStop = false;
            this.groupBoxActiveItems.Text = "Active Items";
            // 
            // listBoxItemHealingActive
            // 
            this.listBoxItemHealingActive.FormattingEnabled = true;
            this.listBoxItemHealingActive.HorizontalScrollbar = true;
            this.listBoxItemHealingActive.Location = new System.Drawing.Point(6, 29);
            this.listBoxItemHealingActive.Name = "listBoxItemHealingActive";
            this.listBoxItemHealingActive.Size = new System.Drawing.Size(209, 82);
            this.listBoxItemHealingActive.TabIndex = 4;
            // 
            // labelTopActiveItems
            // 
            this.labelTopActiveItems.AutoSize = true;
            this.labelTopActiveItems.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTopActiveItems.Location = new System.Drawing.Point(16, 13);
            this.labelTopActiveItems.Name = "labelTopActiveItems";
            this.labelTopActiveItems.Size = new System.Drawing.Size(160, 13);
            this.labelTopActiveItems.TabIndex = 7;
            this.labelTopActiveItems.Text = "Name        HP    MP        Hotkey";
            // 
            // buttonDownItemHealing
            // 
            this.buttonDownItemHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDownItemHealing.Location = new System.Drawing.Point(221, 66);
            this.buttonDownItemHealing.Name = "buttonDownItemHealing";
            this.buttonDownItemHealing.Size = new System.Drawing.Size(30, 23);
            this.buttonDownItemHealing.TabIndex = 6;
            this.buttonDownItemHealing.Text = "\\/";
            this.buttonDownItemHealing.UseVisualStyleBackColor = true;
            this.buttonDownItemHealing.Click += new System.EventHandler(this.buttonDownItemHealing_Click);
            // 
            // buttonUpItemHealing
            // 
            this.buttonUpItemHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpItemHealing.Location = new System.Drawing.Point(221, 46);
            this.buttonUpItemHealing.Name = "buttonUpItemHealing";
            this.buttonUpItemHealing.Size = new System.Drawing.Size(30, 23);
            this.buttonUpItemHealing.TabIndex = 5;
            this.buttonUpItemHealing.Text = "/\\";
            this.buttonUpItemHealing.UseVisualStyleBackColor = true;
            this.buttonUpItemHealing.Click += new System.EventHandler(this.buttonUpItemHealing_Click);
            // 
            // buttonRemoveSelectedItemHealing
            // 
            this.buttonRemoveSelectedItemHealing.ForeColor = System.Drawing.Color.Red;
            this.buttonRemoveSelectedItemHealing.Location = new System.Drawing.Point(47, 118);
            this.buttonRemoveSelectedItemHealing.Name = "buttonRemoveSelectedItemHealing";
            this.buttonRemoveSelectedItemHealing.Size = new System.Drawing.Size(118, 23);
            this.buttonRemoveSelectedItemHealing.TabIndex = 3;
            this.buttonRemoveSelectedItemHealing.Text = "Remove selected";
            this.buttonRemoveSelectedItemHealing.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedItemHealing.Click += new System.EventHandler(this.buttonRemoveSelectedItemHealing_Click);
            // 
            // groupBoxSpellHealing
            // 
            this.groupBoxSpellHealing.Controls.Add(this.groupBoxNewSpellHealing);
            this.groupBoxSpellHealing.Controls.Add(this.groupBoxActiveSpellsHealing);
            this.groupBoxSpellHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxSpellHealing.Location = new System.Drawing.Point(3, 98);
            this.groupBoxSpellHealing.Name = "groupBoxSpellHealing";
            this.groupBoxSpellHealing.Size = new System.Drawing.Size(466, 158);
            this.groupBoxSpellHealing.TabIndex = 0;
            this.groupBoxSpellHealing.TabStop = false;
            this.groupBoxSpellHealing.Text = "Spell Healing";
            this.groupBoxSpellHealing.Visible = false;
            // 
            // groupBoxNewSpellHealing
            // 
            this.groupBoxNewSpellHealing.Controls.Add(this.spellHealingHpValue);
            this.groupBoxNewSpellHealing.Controls.Add(this.buttonClearNewSpell);
            this.groupBoxNewSpellHealing.Controls.Add(this.newSpellHealingHpBelow);
            this.groupBoxNewSpellHealing.Controls.Add(this.comboBoxNewSpellHealingHotkey);
            this.groupBoxNewSpellHealing.Controls.Add(this.buttonAddNewSpellHealing);
            this.groupBoxNewSpellHealing.Controls.Add(this.labelNewSpellHp);
            this.groupBoxNewSpellHealing.Controls.Add(this.labelNewSpellHotkey);
            this.groupBoxNewSpellHealing.Controls.Add(this.labelNewSpellName);
            this.groupBoxNewSpellHealing.Controls.Add(this.textBoxSpellName);
            this.groupBoxNewSpellHealing.Location = new System.Drawing.Point(269, 19);
            this.groupBoxNewSpellHealing.Name = "groupBoxNewSpellHealing";
            this.groupBoxNewSpellHealing.Size = new System.Drawing.Size(191, 133);
            this.groupBoxNewSpellHealing.TabIndex = 2;
            this.groupBoxNewSpellHealing.TabStop = false;
            this.groupBoxNewSpellHealing.Text = "New Spell";
            // 
            // spellHealingHpValue
            // 
            this.spellHealingHpValue.Location = new System.Drawing.Point(141, 73);
            this.spellHealingHpValue.Name = "spellHealingHpValue";
            this.spellHealingHpValue.Size = new System.Drawing.Size(43, 20);
            this.spellHealingHpValue.TabIndex = 8;
            this.spellHealingHpValue.Text = "HP";
            // 
            // buttonClearNewSpell
            // 
            this.buttonClearNewSpell.ForeColor = System.Drawing.Color.Red;
            this.buttonClearNewSpell.Location = new System.Drawing.Point(98, 104);
            this.buttonClearNewSpell.Name = "buttonClearNewSpell";
            this.buttonClearNewSpell.Size = new System.Drawing.Size(76, 21);
            this.buttonClearNewSpell.TabIndex = 7;
            this.buttonClearNewSpell.Text = "Clear Fields";
            this.buttonClearNewSpell.UseVisualStyleBackColor = true;
            this.buttonClearNewSpell.Click += new System.EventHandler(this.buttonClearNewSpell_Click);
            // 
            // newSpellHealingHpBelow
            // 
            this.newSpellHealingHpBelow.Items.Add("95");
            this.newSpellHealingHpBelow.Items.Add("90");
            this.newSpellHealingHpBelow.Items.Add("85");
            this.newSpellHealingHpBelow.Items.Add("80");
            this.newSpellHealingHpBelow.Items.Add("75");
            this.newSpellHealingHpBelow.Items.Add("70");
            this.newSpellHealingHpBelow.Items.Add("65");
            this.newSpellHealingHpBelow.Items.Add("60");
            this.newSpellHealingHpBelow.Items.Add("55");
            this.newSpellHealingHpBelow.Items.Add("50");
            this.newSpellHealingHpBelow.Items.Add("45");
            this.newSpellHealingHpBelow.Items.Add("40");
            this.newSpellHealingHpBelow.Items.Add("35");
            this.newSpellHealingHpBelow.Items.Add("30");
            this.newSpellHealingHpBelow.Items.Add("25");
            this.newSpellHealingHpBelow.Items.Add("20");
            this.newSpellHealingHpBelow.Items.Add("15");
            this.newSpellHealingHpBelow.Items.Add("10");
            this.newSpellHealingHpBelow.Items.Add("5");
            this.newSpellHealingHpBelow.Location = new System.Drawing.Point(98, 73);
            this.newSpellHealingHpBelow.Name = "newSpellHealingHpBelow";
            this.newSpellHealingHpBelow.Size = new System.Drawing.Size(38, 20);
            this.newSpellHealingHpBelow.TabIndex = 6;
            this.newSpellHealingHpBelow.Text = "HP";
            // 
            // comboBoxNewSpellHealingHotkey
            // 
            this.comboBoxNewSpellHealingHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.comboBoxNewSpellHealingHotkey.Location = new System.Drawing.Point(98, 44);
            this.comboBoxNewSpellHealingHotkey.Name = "comboBoxNewSpellHealingHotkey";
            this.comboBoxNewSpellHealingHotkey.Size = new System.Drawing.Size(86, 21);
            this.comboBoxNewSpellHealingHotkey.TabIndex = 5;
            this.comboBoxNewSpellHealingHotkey.Text = "HTK";
            // 
            // buttonAddNewSpellHealing
            // 
            this.buttonAddNewSpellHealing.ForeColor = System.Drawing.Color.Green;
            this.buttonAddNewSpellHealing.Location = new System.Drawing.Point(31, 104);
            this.buttonAddNewSpellHealing.Name = "buttonAddNewSpellHealing";
            this.buttonAddNewSpellHealing.Size = new System.Drawing.Size(61, 21);
            this.buttonAddNewSpellHealing.TabIndex = 4;
            this.buttonAddNewSpellHealing.Text = "Add Spell";
            this.buttonAddNewSpellHealing.UseVisualStyleBackColor = true;
            this.buttonAddNewSpellHealing.Click += new System.EventHandler(this.buttonAddNewSpellHealing_Click);
            // 
            // labelNewSpellHp
            // 
            this.labelNewSpellHp.AutoSize = true;
            this.labelNewSpellHp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewSpellHp.Location = new System.Drawing.Point(18, 75);
            this.labelNewSpellHp.Name = "labelNewSpellHp";
            this.labelNewSpellHp.Size = new System.Drawing.Size(64, 13);
            this.labelNewSpellHp.TabIndex = 3;
            this.labelNewSpellHp.Text = "HP BELOW";
            // 
            // labelNewSpellHotkey
            // 
            this.labelNewSpellHotkey.AutoSize = true;
            this.labelNewSpellHotkey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewSpellHotkey.Location = new System.Drawing.Point(18, 47);
            this.labelNewSpellHotkey.Name = "labelNewSpellHotkey";
            this.labelNewSpellHotkey.Size = new System.Drawing.Size(41, 13);
            this.labelNewSpellHotkey.TabIndex = 2;
            this.labelNewSpellHotkey.Text = "Hotkey";
            // 
            // labelNewSpellName
            // 
            this.labelNewSpellName.AutoSize = true;
            this.labelNewSpellName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewSpellName.Location = new System.Drawing.Point(18, 21);
            this.labelNewSpellName.Name = "labelNewSpellName";
            this.labelNewSpellName.Size = new System.Drawing.Size(35, 13);
            this.labelNewSpellName.TabIndex = 1;
            this.labelNewSpellName.Text = "Name";
            // 
            // textBoxSpellName
            // 
            this.textBoxSpellName.Location = new System.Drawing.Point(98, 18);
            this.textBoxSpellName.Name = "textBoxSpellName";
            this.textBoxSpellName.Size = new System.Drawing.Size(86, 20);
            this.textBoxSpellName.TabIndex = 0;
            this.textBoxSpellName.Text = "SPELL";
            // 
            // groupBoxActiveSpellsHealing
            // 
            this.groupBoxActiveSpellsHealing.Controls.Add(this.listBoxSpellHealingActive);
            this.groupBoxActiveSpellsHealing.Controls.Add(this.labelTopActiveSpells);
            this.groupBoxActiveSpellsHealing.Controls.Add(this.buttonDownSpellHealing);
            this.groupBoxActiveSpellsHealing.Controls.Add(this.buttonUpSpellHealing);
            this.groupBoxActiveSpellsHealing.Controls.Add(this.buttonRemoveSelectedSpellHealing);
            this.groupBoxActiveSpellsHealing.Location = new System.Drawing.Point(6, 19);
            this.groupBoxActiveSpellsHealing.Name = "groupBoxActiveSpellsHealing";
            this.groupBoxActiveSpellsHealing.Size = new System.Drawing.Size(257, 133);
            this.groupBoxActiveSpellsHealing.TabIndex = 1;
            this.groupBoxActiveSpellsHealing.TabStop = false;
            this.groupBoxActiveSpellsHealing.Text = "Active Spells";
            // 
            // listBoxSpellHealingActive
            // 
            this.listBoxSpellHealingActive.FormattingEnabled = true;
            this.listBoxSpellHealingActive.HorizontalScrollbar = true;
            this.listBoxSpellHealingActive.Location = new System.Drawing.Point(6, 29);
            this.listBoxSpellHealingActive.Name = "listBoxSpellHealingActive";
            this.listBoxSpellHealingActive.Size = new System.Drawing.Size(209, 69);
            this.listBoxSpellHealingActive.TabIndex = 4;
            // 
            // labelTopActiveSpells
            // 
            this.labelTopActiveSpells.AutoSize = true;
            this.labelTopActiveSpells.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTopActiveSpells.Location = new System.Drawing.Point(39, 13);
            this.labelTopActiveSpells.Name = "labelTopActiveSpells";
            this.labelTopActiveSpells.Size = new System.Drawing.Size(147, 13);
            this.labelTopActiveSpells.TabIndex = 7;
            this.labelTopActiveSpells.Text = "Name          HP           Hotkey";
            // 
            // buttonDownSpellHealing
            // 
            this.buttonDownSpellHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDownSpellHealing.Location = new System.Drawing.Point(221, 66);
            this.buttonDownSpellHealing.Name = "buttonDownSpellHealing";
            this.buttonDownSpellHealing.Size = new System.Drawing.Size(30, 23);
            this.buttonDownSpellHealing.TabIndex = 6;
            this.buttonDownSpellHealing.Text = "\\/";
            this.buttonDownSpellHealing.UseVisualStyleBackColor = true;
            this.buttonDownSpellHealing.Click += new System.EventHandler(this.buttonDownSpellHealing_Click);
            // 
            // buttonUpSpellHealing
            // 
            this.buttonUpSpellHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpSpellHealing.Location = new System.Drawing.Point(221, 44);
            this.buttonUpSpellHealing.Name = "buttonUpSpellHealing";
            this.buttonUpSpellHealing.Size = new System.Drawing.Size(30, 23);
            this.buttonUpSpellHealing.TabIndex = 5;
            this.buttonUpSpellHealing.Text = "/\\";
            this.buttonUpSpellHealing.UseVisualStyleBackColor = true;
            this.buttonUpSpellHealing.Click += new System.EventHandler(this.buttonUpSpellHealing_Click);
            // 
            // buttonRemoveSelectedSpellHealing
            // 
            this.buttonRemoveSelectedSpellHealing.ForeColor = System.Drawing.Color.Red;
            this.buttonRemoveSelectedSpellHealing.Location = new System.Drawing.Point(47, 104);
            this.buttonRemoveSelectedSpellHealing.Name = "buttonRemoveSelectedSpellHealing";
            this.buttonRemoveSelectedSpellHealing.Size = new System.Drawing.Size(118, 23);
            this.buttonRemoveSelectedSpellHealing.TabIndex = 3;
            this.buttonRemoveSelectedSpellHealing.Text = "Remove selected";
            this.buttonRemoveSelectedSpellHealing.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedSpellHealing.Click += new System.EventHandler(this.buttonRemoveSelectedSpellHealing_Click);
            // 
            // tab_mana
            // 
            this.tab_mana.Controls.Add(this.groupBoxSmartManaDrinker);
            this.tab_mana.Location = new System.Drawing.Point(4, 22);
            this.tab_mana.Name = "tab_mana";
            this.tab_mana.Size = new System.Drawing.Size(475, 444);
            this.tab_mana.TabIndex = 3;
            this.tab_mana.Text = "Mana";
            this.tab_mana.UseVisualStyleBackColor = true;
            // 
            // groupBoxSmartManaDrinker
            // 
            this.groupBoxSmartManaDrinker.Controls.Add(this.smartManaDrinkerStopManaPercent);
            this.groupBoxSmartManaDrinker.Controls.Add(this.smartManaDrinkerStartManaPercent);
            this.groupBoxSmartManaDrinker.Controls.Add(this.smartManaDrinkerHotkey);
            this.groupBoxSmartManaDrinker.Controls.Add(this.labelSmartManaDrinkerHotkey);
            this.groupBoxSmartManaDrinker.Controls.Add(this.labelSmartManaDrinkerStopMana);
            this.groupBoxSmartManaDrinker.Controls.Add(this.labelSmartManaDrinkerStartMana);
            this.groupBoxSmartManaDrinker.Location = new System.Drawing.Point(88, 32);
            this.groupBoxSmartManaDrinker.Name = "groupBoxSmartManaDrinker";
            this.groupBoxSmartManaDrinker.Size = new System.Drawing.Size(253, 139);
            this.groupBoxSmartManaDrinker.TabIndex = 0;
            this.groupBoxSmartManaDrinker.TabStop = false;
            this.groupBoxSmartManaDrinker.Text = "Smart Mana Drinker !!DISABLED!!";
            // 
            // smartManaDrinkerStopManaPercent
            // 
            this.smartManaDrinkerStopManaPercent.Items.Add("5");
            this.smartManaDrinkerStopManaPercent.Items.Add("10");
            this.smartManaDrinkerStopManaPercent.Items.Add("15");
            this.smartManaDrinkerStopManaPercent.Items.Add("20");
            this.smartManaDrinkerStopManaPercent.Items.Add("25");
            this.smartManaDrinkerStopManaPercent.Items.Add("30");
            this.smartManaDrinkerStopManaPercent.Items.Add("35");
            this.smartManaDrinkerStopManaPercent.Items.Add("40");
            this.smartManaDrinkerStopManaPercent.Items.Add("45");
            this.smartManaDrinkerStopManaPercent.Location = new System.Drawing.Point(153, 58);
            this.smartManaDrinkerStopManaPercent.Name = "smartManaDrinkerStopManaPercent";
            this.smartManaDrinkerStopManaPercent.Size = new System.Drawing.Size(38, 20);
            this.smartManaDrinkerStopManaPercent.TabIndex = 8;
            this.smartManaDrinkerStopManaPercent.Text = "%";
            // 
            // smartManaDrinkerStartManaPercent
            // 
            this.smartManaDrinkerStartManaPercent.Items.Add("95");
            this.smartManaDrinkerStartManaPercent.Items.Add("90");
            this.smartManaDrinkerStartManaPercent.Items.Add("85");
            this.smartManaDrinkerStartManaPercent.Items.Add("80");
            this.smartManaDrinkerStartManaPercent.Items.Add("75");
            this.smartManaDrinkerStartManaPercent.Items.Add("70");
            this.smartManaDrinkerStartManaPercent.Items.Add("65");
            this.smartManaDrinkerStartManaPercent.Items.Add("60");
            this.smartManaDrinkerStartManaPercent.Items.Add("55");
            this.smartManaDrinkerStartManaPercent.Items.Add("50");
            this.smartManaDrinkerStartManaPercent.Location = new System.Drawing.Point(153, 33);
            this.smartManaDrinkerStartManaPercent.Name = "smartManaDrinkerStartManaPercent";
            this.smartManaDrinkerStartManaPercent.Size = new System.Drawing.Size(38, 20);
            this.smartManaDrinkerStartManaPercent.TabIndex = 7;
            this.smartManaDrinkerStartManaPercent.Text = "%";
            // 
            // smartManaDrinkerHotkey
            // 
            this.smartManaDrinkerHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.smartManaDrinkerHotkey.Location = new System.Drawing.Point(82, 82);
            this.smartManaDrinkerHotkey.Name = "smartManaDrinkerHotkey";
            this.smartManaDrinkerHotkey.Size = new System.Drawing.Size(77, 21);
            this.smartManaDrinkerHotkey.TabIndex = 4;
            this.smartManaDrinkerHotkey.Text = "HTK";
            // 
            // labelSmartManaDrinkerHotkey
            // 
            this.labelSmartManaDrinkerHotkey.AutoSize = true;
            this.labelSmartManaDrinkerHotkey.Location = new System.Drawing.Point(16, 85);
            this.labelSmartManaDrinkerHotkey.Name = "labelSmartManaDrinkerHotkey";
            this.labelSmartManaDrinkerHotkey.Size = new System.Drawing.Size(44, 13);
            this.labelSmartManaDrinkerHotkey.TabIndex = 2;
            this.labelSmartManaDrinkerHotkey.Text = "Hotkey:";
            // 
            // labelSmartManaDrinkerStopMana
            // 
            this.labelSmartManaDrinkerStopMana.AutoSize = true;
            this.labelSmartManaDrinkerStopMana.Location = new System.Drawing.Point(16, 60);
            this.labelSmartManaDrinkerStopMana.Name = "labelSmartManaDrinkerStopMana";
            this.labelSmartManaDrinkerStopMana.Size = new System.Drawing.Size(106, 13);
            this.labelSmartManaDrinkerStopMana.TabIndex = 1;
            this.labelSmartManaDrinkerStopMana.Text = "Stop drinking manas:";
            // 
            // labelSmartManaDrinkerStartMana
            // 
            this.labelSmartManaDrinkerStartMana.AutoSize = true;
            this.labelSmartManaDrinkerStartMana.Location = new System.Drawing.Point(16, 35);
            this.labelSmartManaDrinkerStartMana.Name = "labelSmartManaDrinkerStartMana";
            this.labelSmartManaDrinkerStartMana.Size = new System.Drawing.Size(106, 13);
            this.labelSmartManaDrinkerStartMana.TabIndex = 0;
            this.labelSmartManaDrinkerStartMana.Text = "Start drinking manas:";
            // 
            // tab_actions
            // 
            this.tab_actions.Controls.Add(this.groupBoxManaWaster);
            this.tab_actions.Controls.Add(this.groupBoxSpells);
            this.tab_actions.Controls.Add(this.groupBoxRoutine);
            this.tab_actions.Controls.Add(this.groupboxRings);
            this.tab_actions.Location = new System.Drawing.Point(4, 22);
            this.tab_actions.Name = "tab_actions";
            this.tab_actions.Size = new System.Drawing.Size(475, 455);
            this.tab_actions.TabIndex = 4;
            this.tab_actions.Text = "Actions";
            this.tab_actions.UseVisualStyleBackColor = true;
            // 
            // groupBoxManaWaster
            // 
            this.groupBoxManaWaster.Controls.Add(this.smartManaWasterHotkey);
            this.groupBoxManaWaster.Controls.Add(this.labelManaWasterHotkey);
            this.groupBoxManaWaster.Location = new System.Drawing.Point(9, 144);
            this.groupBoxManaWaster.Name = "groupBoxManaWaster";
            this.groupBoxManaWaster.Size = new System.Drawing.Size(187, 116);
            this.groupBoxManaWaster.TabIndex = 4;
            this.groupBoxManaWaster.TabStop = false;
            this.groupBoxManaWaster.Text = "Mana Waster";
            // 
            // smartManaWasterHotkey
            // 
            this.smartManaWasterHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.smartManaWasterHotkey.Location = new System.Drawing.Point(85, 48);
            this.smartManaWasterHotkey.Name = "smartManaWasterHotkey";
            this.smartManaWasterHotkey.Size = new System.Drawing.Size(77, 21);
            this.smartManaWasterHotkey.TabIndex = 5;
            this.smartManaWasterHotkey.Text = "HTK";
            // 
            // labelManaWasterHotkey
            // 
            this.labelManaWasterHotkey.AutoSize = true;
            this.labelManaWasterHotkey.Location = new System.Drawing.Point(25, 50);
            this.labelManaWasterHotkey.Name = "labelManaWasterHotkey";
            this.labelManaWasterHotkey.Size = new System.Drawing.Size(44, 13);
            this.labelManaWasterHotkey.TabIndex = 0;
            this.labelManaWasterHotkey.Text = "Hotkey:";
            // 
            // groupBoxSpells
            // 
            this.groupBoxSpells.Controls.Add(this.utamoVitaHotkey);
            this.groupBoxSpells.Controls.Add(this.utanaVidHotkey);
            this.groupBoxSpells.Controls.Add(this.checkBoxUtana);
            this.groupBoxSpells.Controls.Add(this.checkBoxUtamo);
            this.groupBoxSpells.Location = new System.Drawing.Point(209, 24);
            this.groupBoxSpells.Name = "groupBoxSpells";
            this.groupBoxSpells.Size = new System.Drawing.Size(179, 99);
            this.groupBoxSpells.TabIndex = 3;
            this.groupBoxSpells.TabStop = false;
            this.groupBoxSpells.Text = "Spells";
            // 
            // utamoVitaHotkey
            // 
            this.utamoVitaHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.utamoVitaHotkey.Location = new System.Drawing.Point(93, 25);
            this.utamoVitaHotkey.Name = "utamoVitaHotkey";
            this.utamoVitaHotkey.Size = new System.Drawing.Size(77, 21);
            this.utamoVitaHotkey.TabIndex = 10;
            // 
            // utanaVidHotkey
            // 
            this.utanaVidHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.utanaVidHotkey.Location = new System.Drawing.Point(93, 52);
            this.utanaVidHotkey.Name = "utanaVidHotkey";
            this.utanaVidHotkey.Size = new System.Drawing.Size(77, 21);
            this.utanaVidHotkey.TabIndex = 9;
            // 
            // checkBoxUtana
            // 
            this.checkBoxUtana.AutoSize = true;
            this.checkBoxUtana.Location = new System.Drawing.Point(14, 52);
            this.checkBoxUtana.Name = "checkBoxUtana";
            this.checkBoxUtana.Size = new System.Drawing.Size(73, 17);
            this.checkBoxUtana.TabIndex = 1;
            this.checkBoxUtana.Text = "Utana Vid";
            this.checkBoxUtana.UseVisualStyleBackColor = true;
            // 
            // checkBoxUtamo
            // 
            this.checkBoxUtamo.AutoSize = true;
            this.checkBoxUtamo.Location = new System.Drawing.Point(14, 25);
            this.checkBoxUtamo.Name = "checkBoxUtamo";
            this.checkBoxUtamo.Size = new System.Drawing.Size(78, 17);
            this.checkBoxUtamo.TabIndex = 0;
            this.checkBoxUtamo.Text = "Utamo Vita";
            this.checkBoxUtamo.UseVisualStyleBackColor = true;
            // 
            // groupBoxRoutine
            // 
            this.groupBoxRoutine.Controls.Add(this.mountHtk);
            this.groupBoxRoutine.Controls.Add(this.eaterHtk);
            this.groupBoxRoutine.Controls.Add(this.checkBoxMount);
            this.groupBoxRoutine.Controls.Add(this.checkBoxEater);
            this.groupBoxRoutine.Location = new System.Drawing.Point(17, 24);
            this.groupBoxRoutine.Name = "groupBoxRoutine";
            this.groupBoxRoutine.Size = new System.Drawing.Size(179, 99);
            this.groupBoxRoutine.TabIndex = 2;
            this.groupBoxRoutine.TabStop = false;
            this.groupBoxRoutine.Text = "Routine";
            // 
            // mountHtk
            // 
            this.mountHtk.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.mountHtk.Location = new System.Drawing.Point(91, 48);
            this.mountHtk.Name = "mountHtk";
            this.mountHtk.Size = new System.Drawing.Size(77, 21);
            this.mountHtk.TabIndex = 4;
            this.mountHtk.Text = "HTK";
            this.mountHtk.SelectedIndexChanged += new System.EventHandler(this.mountHtk_SelectedIndexChanged);
            // 
            // eaterHtk
            // 
            this.eaterHtk.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.eaterHtk.Location = new System.Drawing.Point(91, 23);
            this.eaterHtk.Name = "eaterHtk";
            this.eaterHtk.Size = new System.Drawing.Size(77, 21);
            this.eaterHtk.TabIndex = 3;
            this.eaterHtk.Text = "HTK";
            this.eaterHtk.SelectedIndexChanged += new System.EventHandler(this.eaterHtk_SelectedIndexChanged);
            // 
            // checkBoxMount
            // 
            this.checkBoxMount.AutoSize = true;
            this.checkBoxMount.Location = new System.Drawing.Point(19, 52);
            this.checkBoxMount.Name = "checkBoxMount";
            this.checkBoxMount.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMount.TabIndex = 1;
            this.checkBoxMount.Text = "Mount";
            this.checkBoxMount.UseVisualStyleBackColor = true;
            this.checkBoxMount.CheckedChanged += new System.EventHandler(this.checkBoxMount_CheckedChanged);
            // 
            // checkBoxEater
            // 
            this.checkBoxEater.AutoSize = true;
            this.checkBoxEater.Location = new System.Drawing.Point(19, 23);
            this.checkBoxEater.Name = "checkBoxEater";
            this.checkBoxEater.Size = new System.Drawing.Size(51, 17);
            this.checkBoxEater.TabIndex = 0;
            this.checkBoxEater.Text = "Eater";
            this.checkBoxEater.UseVisualStyleBackColor = true;
            this.checkBoxEater.CheckedChanged += new System.EventHandler(this.checkBoxEater_CheckedChanged);
            // 
            // groupboxRings
            // 
            this.groupboxRings.Controls.Add(this.healingRingHotkey);
            this.groupboxRings.Controls.Add(this.mightRingHotkey);
            this.groupboxRings.Controls.Add(this.timeRingHotkey);
            this.groupboxRings.Controls.Add(this.energyRingHotkey);
            this.groupboxRings.Controls.Add(this.lifeRingHotkey);
            this.groupboxRings.Controls.Add(this.checkBoxMightRing);
            this.groupboxRings.Controls.Add(this.checkBoxHealingRing);
            this.groupboxRings.Controls.Add(this.checkBoxTimeRing);
            this.groupboxRings.Controls.Add(this.checkBoxEnergyRing);
            this.groupboxRings.Controls.Add(this.checkBoxLifeRing);
            this.groupboxRings.Location = new System.Drawing.Point(197, 144);
            this.groupboxRings.Name = "groupboxRings";
            this.groupboxRings.Size = new System.Drawing.Size(188, 145);
            this.groupboxRings.TabIndex = 0;
            this.groupboxRings.TabStop = false;
            this.groupboxRings.Text = "Rings";
            // 
            // healingRingHotkey
            // 
            this.healingRingHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.healingRingHotkey.Location = new System.Drawing.Point(102, 113);
            this.healingRingHotkey.Name = "healingRingHotkey";
            this.healingRingHotkey.Size = new System.Drawing.Size(77, 21);
            this.healingRingHotkey.TabIndex = 9;
            this.healingRingHotkey.SelectedIndexChanged += new System.EventHandler(this.healingRingHotkey_SelectedIndexChanged);
            // 
            // mightRingHotkey
            // 
            this.mightRingHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.mightRingHotkey.Location = new System.Drawing.Point(102, 90);
            this.mightRingHotkey.Name = "mightRingHotkey";
            this.mightRingHotkey.Size = new System.Drawing.Size(77, 21);
            this.mightRingHotkey.TabIndex = 8;
            // 
            // timeRingHotkey
            // 
            this.timeRingHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.timeRingHotkey.Location = new System.Drawing.Point(102, 67);
            this.timeRingHotkey.Name = "timeRingHotkey";
            this.timeRingHotkey.Size = new System.Drawing.Size(77, 21);
            this.timeRingHotkey.TabIndex = 7;
            // 
            // energyRingHotkey
            // 
            this.energyRingHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.energyRingHotkey.Location = new System.Drawing.Point(102, 46);
            this.energyRingHotkey.Name = "energyRingHotkey";
            this.energyRingHotkey.Size = new System.Drawing.Size(77, 21);
            this.energyRingHotkey.TabIndex = 6;
            this.energyRingHotkey.Text = "HTK";
            this.energyRingHotkey.SelectedIndexChanged += new System.EventHandler(this.energyRingHotkey_SelectedIndexChanged);
            // 
            // lifeRingHotkey
            // 
            this.lifeRingHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.lifeRingHotkey.Location = new System.Drawing.Point(102, 23);
            this.lifeRingHotkey.Name = "lifeRingHotkey";
            this.lifeRingHotkey.Size = new System.Drawing.Size(77, 21);
            this.lifeRingHotkey.TabIndex = 5;
            this.lifeRingHotkey.Text = "HTK";
            this.lifeRingHotkey.SelectedIndexChanged += new System.EventHandler(this.lifeRingHotkey_SelectedIndexChanged);
            // 
            // checkBoxMightRing
            // 
            this.checkBoxMightRing.AutoSize = true;
            this.checkBoxMightRing.Location = new System.Drawing.Point(14, 94);
            this.checkBoxMightRing.Name = "checkBoxMightRing";
            this.checkBoxMightRing.Size = new System.Drawing.Size(77, 17);
            this.checkBoxMightRing.TabIndex = 4;
            this.checkBoxMightRing.Text = "Might Ring";
            this.checkBoxMightRing.UseVisualStyleBackColor = true;
            // 
            // checkBoxHealingRing
            // 
            this.checkBoxHealingRing.AutoSize = true;
            this.checkBoxHealingRing.Location = new System.Drawing.Point(14, 117);
            this.checkBoxHealingRing.Name = "checkBoxHealingRing";
            this.checkBoxHealingRing.Size = new System.Drawing.Size(87, 17);
            this.checkBoxHealingRing.TabIndex = 3;
            this.checkBoxHealingRing.Text = "Healing Ring";
            this.checkBoxHealingRing.UseVisualStyleBackColor = true;
            // 
            // checkBoxTimeRing
            // 
            this.checkBoxTimeRing.AutoSize = true;
            this.checkBoxTimeRing.Location = new System.Drawing.Point(14, 71);
            this.checkBoxTimeRing.Name = "checkBoxTimeRing";
            this.checkBoxTimeRing.Size = new System.Drawing.Size(74, 17);
            this.checkBoxTimeRing.TabIndex = 2;
            this.checkBoxTimeRing.Text = "Time Ring";
            this.checkBoxTimeRing.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnergyRing
            // 
            this.checkBoxEnergyRing.AutoSize = true;
            this.checkBoxEnergyRing.Location = new System.Drawing.Point(14, 48);
            this.checkBoxEnergyRing.Name = "checkBoxEnergyRing";
            this.checkBoxEnergyRing.Size = new System.Drawing.Size(84, 17);
            this.checkBoxEnergyRing.TabIndex = 1;
            this.checkBoxEnergyRing.Text = "Energy Ring";
            this.checkBoxEnergyRing.UseVisualStyleBackColor = true;
            this.checkBoxEnergyRing.CheckedChanged += new System.EventHandler(this.checkBoxEnergyRing_CheckedChanged);
            // 
            // checkBoxLifeRing
            // 
            this.checkBoxLifeRing.AutoSize = true;
            this.checkBoxLifeRing.Location = new System.Drawing.Point(14, 25);
            this.checkBoxLifeRing.Name = "checkBoxLifeRing";
            this.checkBoxLifeRing.Size = new System.Drawing.Size(68, 17);
            this.checkBoxLifeRing.TabIndex = 0;
            this.checkBoxLifeRing.Text = "Life Ring";
            this.checkBoxLifeRing.UseVisualStyleBackColor = true;
            this.checkBoxLifeRing.CheckedChanged += new System.EventHandler(this.checkBoxLifeRing_CheckedChanged);
            // 
            // tab_support
            // 
            this.tab_support.Controls.Add(this.groupBoxStatusHolder);
            this.tab_support.Controls.Add(this.groupBoxConditionHealer);
            this.tab_support.Location = new System.Drawing.Point(4, 22);
            this.tab_support.Name = "tab_support";
            this.tab_support.Size = new System.Drawing.Size(475, 455);
            this.tab_support.TabIndex = 5;
            this.tab_support.Text = "Support";
            this.tab_support.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatusHolder
            // 
            this.groupBoxStatusHolder.Controls.Add(this.uturaHotkey);
            this.groupBoxStatusHolder.Controls.Add(this.hasteHotkey);
            this.groupBoxStatusHolder.Controls.Add(this.checkBoxUtura);
            this.groupBoxStatusHolder.Controls.Add(this.checkBoxHaste);
            this.groupBoxStatusHolder.Location = new System.Drawing.Point(217, 13);
            this.groupBoxStatusHolder.Name = "groupBoxStatusHolder";
            this.groupBoxStatusHolder.Size = new System.Drawing.Size(167, 179);
            this.groupBoxStatusHolder.TabIndex = 1;
            this.groupBoxStatusHolder.TabStop = false;
            this.groupBoxStatusHolder.Text = "Status Holder";
            // 
            // uturaHotkey
            // 
            this.uturaHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.uturaHotkey.Location = new System.Drawing.Point(78, 47);
            this.uturaHotkey.Name = "uturaHotkey";
            this.uturaHotkey.Size = new System.Drawing.Size(77, 21);
            this.uturaHotkey.TabIndex = 8;
            this.uturaHotkey.Text = "HTK";
            this.uturaHotkey.SelectedIndexChanged += new System.EventHandler(this.uturaHotkey_SelectedIndexChanged);
            // 
            // hasteHotkey
            // 
            this.hasteHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.hasteHotkey.Location = new System.Drawing.Point(78, 24);
            this.hasteHotkey.Name = "hasteHotkey";
            this.hasteHotkey.Size = new System.Drawing.Size(77, 21);
            this.hasteHotkey.TabIndex = 7;
            this.hasteHotkey.Text = "HTK";
            this.hasteHotkey.SelectedIndexChanged += new System.EventHandler(this.hasteHotkey_SelectedIndexChanged);
            // 
            // checkBoxUtura
            // 
            this.checkBoxUtura.AutoSize = true;
            this.checkBoxUtura.Location = new System.Drawing.Point(20, 49);
            this.checkBoxUtura.Name = "checkBoxUtura";
            this.checkBoxUtura.Size = new System.Drawing.Size(52, 17);
            this.checkBoxUtura.TabIndex = 1;
            this.checkBoxUtura.Text = "Utura";
            this.checkBoxUtura.UseVisualStyleBackColor = true;
            this.checkBoxUtura.CheckedChanged += new System.EventHandler(this.checkBoxUtura_CheckedChanged);
            // 
            // checkBoxHaste
            // 
            this.checkBoxHaste.AutoSize = true;
            this.checkBoxHaste.Location = new System.Drawing.Point(20, 26);
            this.checkBoxHaste.Name = "checkBoxHaste";
            this.checkBoxHaste.Size = new System.Drawing.Size(54, 17);
            this.checkBoxHaste.TabIndex = 0;
            this.checkBoxHaste.Text = "Haste";
            this.checkBoxHaste.UseVisualStyleBackColor = true;
            this.checkBoxHaste.CheckedChanged += new System.EventHandler(this.checkBoxHaste_CheckedChanged);
            // 
            // groupBoxConditionHealer
            // 
            this.groupBoxConditionHealer.Controls.Add(this.poisonHotkey);
            this.groupBoxConditionHealer.Controls.Add(this.paralyzeHotkey);
            this.groupBoxConditionHealer.Controls.Add(this.checkBoxPoison);
            this.groupBoxConditionHealer.Controls.Add(this.checkBoxParalyze);
            this.groupBoxConditionHealer.Location = new System.Drawing.Point(21, 13);
            this.groupBoxConditionHealer.Name = "groupBoxConditionHealer";
            this.groupBoxConditionHealer.Size = new System.Drawing.Size(185, 179);
            this.groupBoxConditionHealer.TabIndex = 0;
            this.groupBoxConditionHealer.TabStop = false;
            this.groupBoxConditionHealer.Text = "Condition Healer";
            // 
            // poisonHotkey
            // 
            this.poisonHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.poisonHotkey.Location = new System.Drawing.Point(92, 47);
            this.poisonHotkey.Name = "poisonHotkey";
            this.poisonHotkey.Size = new System.Drawing.Size(77, 21);
            this.poisonHotkey.TabIndex = 7;
            this.poisonHotkey.Text = "HTK";
            this.poisonHotkey.SelectedIndexChanged += new System.EventHandler(this.poisonHotkey_SelectedIndexChanged);
            // 
            // paralyzeHotkey
            // 
            this.paralyzeHotkey.Items.AddRange(new object[] {
            WindowsInput.Native.VirtualKeyCode.LBUTTON,
            WindowsInput.Native.VirtualKeyCode.RBUTTON,
            WindowsInput.Native.VirtualKeyCode.CANCEL,
            WindowsInput.Native.VirtualKeyCode.MBUTTON,
            WindowsInput.Native.VirtualKeyCode.XBUTTON1,
            WindowsInput.Native.VirtualKeyCode.XBUTTON2,
            WindowsInput.Native.VirtualKeyCode.BACK,
            WindowsInput.Native.VirtualKeyCode.TAB,
            WindowsInput.Native.VirtualKeyCode.CLEAR,
            WindowsInput.Native.VirtualKeyCode.RETURN,
            WindowsInput.Native.VirtualKeyCode.SHIFT,
            WindowsInput.Native.VirtualKeyCode.CONTROL,
            WindowsInput.Native.VirtualKeyCode.MENU,
            WindowsInput.Native.VirtualKeyCode.PAUSE,
            WindowsInput.Native.VirtualKeyCode.CAPITAL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.HANGUL,
            WindowsInput.Native.VirtualKeyCode.JUNJA,
            WindowsInput.Native.VirtualKeyCode.FINAL,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.HANJA,
            WindowsInput.Native.VirtualKeyCode.ESCAPE,
            WindowsInput.Native.VirtualKeyCode.CONVERT,
            WindowsInput.Native.VirtualKeyCode.NONCONVERT,
            WindowsInput.Native.VirtualKeyCode.ACCEPT,
            WindowsInput.Native.VirtualKeyCode.MODECHANGE,
            WindowsInput.Native.VirtualKeyCode.SPACE,
            WindowsInput.Native.VirtualKeyCode.PRIOR,
            WindowsInput.Native.VirtualKeyCode.NEXT,
            WindowsInput.Native.VirtualKeyCode.END,
            WindowsInput.Native.VirtualKeyCode.HOME,
            WindowsInput.Native.VirtualKeyCode.LEFT,
            WindowsInput.Native.VirtualKeyCode.UP,
            WindowsInput.Native.VirtualKeyCode.RIGHT,
            WindowsInput.Native.VirtualKeyCode.DOWN,
            WindowsInput.Native.VirtualKeyCode.SELECT,
            WindowsInput.Native.VirtualKeyCode.PRINT,
            WindowsInput.Native.VirtualKeyCode.EXECUTE,
            WindowsInput.Native.VirtualKeyCode.SNAPSHOT,
            WindowsInput.Native.VirtualKeyCode.INSERT,
            WindowsInput.Native.VirtualKeyCode.DELETE,
            WindowsInput.Native.VirtualKeyCode.HELP,
            WindowsInput.Native.VirtualKeyCode.VK_0,
            WindowsInput.Native.VirtualKeyCode.VK_1,
            WindowsInput.Native.VirtualKeyCode.VK_2,
            WindowsInput.Native.VirtualKeyCode.VK_3,
            WindowsInput.Native.VirtualKeyCode.VK_4,
            WindowsInput.Native.VirtualKeyCode.VK_5,
            WindowsInput.Native.VirtualKeyCode.VK_6,
            WindowsInput.Native.VirtualKeyCode.VK_7,
            WindowsInput.Native.VirtualKeyCode.VK_8,
            WindowsInput.Native.VirtualKeyCode.VK_9,
            WindowsInput.Native.VirtualKeyCode.VK_A,
            WindowsInput.Native.VirtualKeyCode.VK_B,
            WindowsInput.Native.VirtualKeyCode.VK_C,
            WindowsInput.Native.VirtualKeyCode.VK_D,
            WindowsInput.Native.VirtualKeyCode.VK_E,
            WindowsInput.Native.VirtualKeyCode.VK_F,
            WindowsInput.Native.VirtualKeyCode.VK_G,
            WindowsInput.Native.VirtualKeyCode.VK_H,
            WindowsInput.Native.VirtualKeyCode.VK_I,
            WindowsInput.Native.VirtualKeyCode.VK_J,
            WindowsInput.Native.VirtualKeyCode.VK_K,
            WindowsInput.Native.VirtualKeyCode.VK_L,
            WindowsInput.Native.VirtualKeyCode.VK_M,
            WindowsInput.Native.VirtualKeyCode.VK_N,
            WindowsInput.Native.VirtualKeyCode.VK_O,
            WindowsInput.Native.VirtualKeyCode.VK_P,
            WindowsInput.Native.VirtualKeyCode.VK_Q,
            WindowsInput.Native.VirtualKeyCode.VK_R,
            WindowsInput.Native.VirtualKeyCode.VK_S,
            WindowsInput.Native.VirtualKeyCode.VK_T,
            WindowsInput.Native.VirtualKeyCode.VK_U,
            WindowsInput.Native.VirtualKeyCode.VK_V,
            WindowsInput.Native.VirtualKeyCode.VK_W,
            WindowsInput.Native.VirtualKeyCode.VK_X,
            WindowsInput.Native.VirtualKeyCode.VK_Y,
            WindowsInput.Native.VirtualKeyCode.VK_Z,
            WindowsInput.Native.VirtualKeyCode.LWIN,
            WindowsInput.Native.VirtualKeyCode.RWIN,
            WindowsInput.Native.VirtualKeyCode.APPS,
            WindowsInput.Native.VirtualKeyCode.SLEEP,
            WindowsInput.Native.VirtualKeyCode.NUMPAD0,
            WindowsInput.Native.VirtualKeyCode.NUMPAD1,
            WindowsInput.Native.VirtualKeyCode.NUMPAD2,
            WindowsInput.Native.VirtualKeyCode.NUMPAD3,
            WindowsInput.Native.VirtualKeyCode.NUMPAD4,
            WindowsInput.Native.VirtualKeyCode.NUMPAD5,
            WindowsInput.Native.VirtualKeyCode.NUMPAD6,
            WindowsInput.Native.VirtualKeyCode.NUMPAD7,
            WindowsInput.Native.VirtualKeyCode.NUMPAD8,
            WindowsInput.Native.VirtualKeyCode.NUMPAD9,
            WindowsInput.Native.VirtualKeyCode.MULTIPLY,
            WindowsInput.Native.VirtualKeyCode.ADD,
            WindowsInput.Native.VirtualKeyCode.SEPARATOR,
            WindowsInput.Native.VirtualKeyCode.SUBTRACT,
            WindowsInput.Native.VirtualKeyCode.DECIMAL,
            WindowsInput.Native.VirtualKeyCode.DIVIDE,
            WindowsInput.Native.VirtualKeyCode.F1,
            WindowsInput.Native.VirtualKeyCode.F2,
            WindowsInput.Native.VirtualKeyCode.F3,
            WindowsInput.Native.VirtualKeyCode.F4,
            WindowsInput.Native.VirtualKeyCode.F5,
            WindowsInput.Native.VirtualKeyCode.F6,
            WindowsInput.Native.VirtualKeyCode.F7,
            WindowsInput.Native.VirtualKeyCode.F8,
            WindowsInput.Native.VirtualKeyCode.F9,
            WindowsInput.Native.VirtualKeyCode.F10,
            WindowsInput.Native.VirtualKeyCode.F11,
            WindowsInput.Native.VirtualKeyCode.F12,
            WindowsInput.Native.VirtualKeyCode.F13,
            WindowsInput.Native.VirtualKeyCode.F14,
            WindowsInput.Native.VirtualKeyCode.F15,
            WindowsInput.Native.VirtualKeyCode.F16,
            WindowsInput.Native.VirtualKeyCode.F17,
            WindowsInput.Native.VirtualKeyCode.F18,
            WindowsInput.Native.VirtualKeyCode.F19,
            WindowsInput.Native.VirtualKeyCode.F20,
            WindowsInput.Native.VirtualKeyCode.F21,
            WindowsInput.Native.VirtualKeyCode.F22,
            WindowsInput.Native.VirtualKeyCode.F23,
            WindowsInput.Native.VirtualKeyCode.F24,
            WindowsInput.Native.VirtualKeyCode.NUMLOCK,
            WindowsInput.Native.VirtualKeyCode.SCROLL,
            WindowsInput.Native.VirtualKeyCode.LSHIFT,
            WindowsInput.Native.VirtualKeyCode.RSHIFT,
            WindowsInput.Native.VirtualKeyCode.LCONTROL,
            WindowsInput.Native.VirtualKeyCode.RCONTROL,
            WindowsInput.Native.VirtualKeyCode.LMENU,
            WindowsInput.Native.VirtualKeyCode.RMENU,
            WindowsInput.Native.VirtualKeyCode.BROWSER_BACK,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FORWARD,
            WindowsInput.Native.VirtualKeyCode.BROWSER_REFRESH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_STOP,
            WindowsInput.Native.VirtualKeyCode.BROWSER_SEARCH,
            WindowsInput.Native.VirtualKeyCode.BROWSER_FAVORITES,
            WindowsInput.Native.VirtualKeyCode.BROWSER_HOME,
            WindowsInput.Native.VirtualKeyCode.VOLUME_MUTE,
            WindowsInput.Native.VirtualKeyCode.VOLUME_DOWN,
            WindowsInput.Native.VirtualKeyCode.VOLUME_UP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK,
            WindowsInput.Native.VirtualKeyCode.MEDIA_STOP,
            WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MAIL,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_MEDIA_SELECT,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP1,
            WindowsInput.Native.VirtualKeyCode.LAUNCH_APP2,
            WindowsInput.Native.VirtualKeyCode.OEM_1,
            WindowsInput.Native.VirtualKeyCode.OEM_PLUS,
            WindowsInput.Native.VirtualKeyCode.OEM_COMMA,
            WindowsInput.Native.VirtualKeyCode.OEM_MINUS,
            WindowsInput.Native.VirtualKeyCode.OEM_PERIOD,
            WindowsInput.Native.VirtualKeyCode.OEM_2,
            WindowsInput.Native.VirtualKeyCode.OEM_3,
            WindowsInput.Native.VirtualKeyCode.OEM_4,
            WindowsInput.Native.VirtualKeyCode.OEM_5,
            WindowsInput.Native.VirtualKeyCode.OEM_6,
            WindowsInput.Native.VirtualKeyCode.OEM_7,
            WindowsInput.Native.VirtualKeyCode.OEM_8,
            WindowsInput.Native.VirtualKeyCode.OEM_102,
            WindowsInput.Native.VirtualKeyCode.PROCESSKEY,
            WindowsInput.Native.VirtualKeyCode.PACKET,
            WindowsInput.Native.VirtualKeyCode.ATTN,
            WindowsInput.Native.VirtualKeyCode.CRSEL,
            WindowsInput.Native.VirtualKeyCode.EXSEL,
            WindowsInput.Native.VirtualKeyCode.EREOF,
            WindowsInput.Native.VirtualKeyCode.PLAY,
            WindowsInput.Native.VirtualKeyCode.ZOOM,
            WindowsInput.Native.VirtualKeyCode.NONAME,
            WindowsInput.Native.VirtualKeyCode.PA1,
            WindowsInput.Native.VirtualKeyCode.OEM_CLEAR});
            this.paralyzeHotkey.Location = new System.Drawing.Point(92, 24);
            this.paralyzeHotkey.Name = "paralyzeHotkey";
            this.paralyzeHotkey.Size = new System.Drawing.Size(77, 21);
            this.paralyzeHotkey.TabIndex = 6;
            this.paralyzeHotkey.Text = "HTK";
            this.paralyzeHotkey.SelectedIndexChanged += new System.EventHandler(this.paralyzeHotkey_SelectedIndexChanged);
            // 
            // checkBoxPoison
            // 
            this.checkBoxPoison.AutoSize = true;
            this.checkBoxPoison.Location = new System.Drawing.Point(20, 49);
            this.checkBoxPoison.Name = "checkBoxPoison";
            this.checkBoxPoison.Size = new System.Drawing.Size(58, 17);
            this.checkBoxPoison.TabIndex = 1;
            this.checkBoxPoison.Text = "Poison";
            this.checkBoxPoison.UseVisualStyleBackColor = true;
            this.checkBoxPoison.CheckedChanged += new System.EventHandler(this.checkBoxPoison_CheckedChanged);
            // 
            // checkBoxParalyze
            // 
            this.checkBoxParalyze.AutoSize = true;
            this.checkBoxParalyze.Location = new System.Drawing.Point(20, 26);
            this.checkBoxParalyze.Name = "checkBoxParalyze";
            this.checkBoxParalyze.Size = new System.Drawing.Size(66, 17);
            this.checkBoxParalyze.TabIndex = 0;
            this.checkBoxParalyze.Text = "Paralyze";
            this.checkBoxParalyze.UseVisualStyleBackColor = true;
            this.checkBoxParalyze.CheckedChanged += new System.EventHandler(this.checkBoxParalyze_CheckedChanged);
            // 
            // itemHealingHpValue
            // 
            this.itemHealingHpValue.Location = new System.Drawing.Point(142, 73);
            this.itemHealingHpValue.Name = "itemHealingHpValue";
            this.itemHealingHpValue.Size = new System.Drawing.Size(43, 20);
            this.itemHealingHpValue.TabIndex = 10;
            this.itemHealingHpValue.Text = "HP";
            // 
            // itemHealingMpValue
            // 
            this.itemHealingMpValue.Location = new System.Drawing.Point(142, 94);
            this.itemHealingMpValue.Name = "itemHealingMpValue";
            this.itemHealingMpValue.Size = new System.Drawing.Size(43, 20);
            this.itemHealingMpValue.TabIndex = 11;
            this.itemHealingMpValue.Text = "MP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<name> Tool v.0.0 (first sketch)";
            this.tabControl1.ResumeLayout(false);
            this.tab_account.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_main.ResumeLayout(false);
            this.groupBoxConfigManager.ResumeLayout(false);
            this.tab_heal.ResumeLayout(false);
            this.groupBoxGeneralInfo.ResumeLayout(false);
            this.groupBoxGeneralInfo.PerformLayout();
            this.groupBoxItemHealing.ResumeLayout(false);
            this.groupBoxNewItemHealing.ResumeLayout(false);
            this.groupBoxNewItemHealing.PerformLayout();
            this.groupBoxActiveItems.ResumeLayout(false);
            this.groupBoxActiveItems.PerformLayout();
            this.groupBoxSpellHealing.ResumeLayout(false);
            this.groupBoxNewSpellHealing.ResumeLayout(false);
            this.groupBoxNewSpellHealing.PerformLayout();
            this.groupBoxActiveSpellsHealing.ResumeLayout(false);
            this.groupBoxActiveSpellsHealing.PerformLayout();
            this.tab_mana.ResumeLayout(false);
            this.groupBoxSmartManaDrinker.ResumeLayout(false);
            this.groupBoxSmartManaDrinker.PerformLayout();
            this.tab_actions.ResumeLayout(false);
            this.groupBoxManaWaster.ResumeLayout(false);
            this.groupBoxManaWaster.PerformLayout();
            this.groupBoxSpells.ResumeLayout(false);
            this.groupBoxSpells.PerformLayout();
            this.groupBoxRoutine.ResumeLayout(false);
            this.groupBoxRoutine.PerformLayout();
            this.groupboxRings.ResumeLayout(false);
            this.groupboxRings.PerformLayout();
            this.tab_support.ResumeLayout(false);
            this.groupBoxStatusHolder.ResumeLayout(false);
            this.groupBoxStatusHolder.PerformLayout();
            this.groupBoxConditionHealer.ResumeLayout(false);
            this.groupBoxConditionHealer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer spellHealTimer;
        private System.Windows.Forms.Timer itemHealTimer;
        private System.Windows.Forms.Timer statusCheckTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_account;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.TabPage tab_heal;
        private System.Windows.Forms.TabPage tab_mana;
        private System.Windows.Forms.TabPage tab_actions;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Label label_daysLeft;
        private System.Windows.Forms.Label label_accountStatus;
        private System.Windows.Forms.TabPage tab_support;
        private System.Windows.Forms.Label label_accountStatusShow;
        private System.Windows.Forms.Label label_daysLeftShow;
        private System.Windows.Forms.GroupBox groupBoxSpells;
        private System.Windows.Forms.GroupBox groupBoxRoutine;
        private System.Windows.Forms.GroupBox groupboxRings;
        private System.Windows.Forms.CheckBox checkBoxEater;
        private System.Windows.Forms.CheckBox checkBoxMightRing;
        private System.Windows.Forms.CheckBox checkBoxHealingRing;
        private System.Windows.Forms.CheckBox checkBoxTimeRing;
        private System.Windows.Forms.CheckBox checkBoxEnergyRing;
        private System.Windows.Forms.CheckBox checkBoxLifeRing;
        private System.Windows.Forms.CheckBox checkBoxUtana;
        private System.Windows.Forms.CheckBox checkBoxUtamo;
        private System.Windows.Forms.CheckBox checkBoxMount;
        private System.Windows.Forms.ComboBox eaterHtk;
        private System.Windows.Forms.ComboBox mountHtk;
        private System.Windows.Forms.GroupBox groupBoxSpellHealing;
        private System.Windows.Forms.GroupBox groupBoxNewSpellHealing;
        private System.Windows.Forms.Button buttonAddNewSpellHealing;
        private System.Windows.Forms.Label labelNewSpellHp;
        private System.Windows.Forms.Label labelNewSpellHotkey;
        private System.Windows.Forms.Label labelNewSpellName;
        private System.Windows.Forms.TextBox textBoxSpellName;
        private System.Windows.Forms.GroupBox groupBoxActiveSpellsHealing;
        private System.Windows.Forms.Button buttonRemoveSelectedSpellHealing;
        private System.Windows.Forms.ComboBox comboBoxNewSpellHealingHotkey;
        private System.Windows.Forms.DomainUpDown newSpellHealingHpBelow;
        private System.Windows.Forms.Button buttonClearNewSpell;
        private System.Windows.Forms.ListBox listBoxSpellHealingActive;
        private System.Windows.Forms.Button buttonDownSpellHealing;
        private System.Windows.Forms.Button buttonUpSpellHealing;
        private System.Windows.Forms.Label labelTopActiveSpells;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.GroupBox groupBoxSmartManaDrinker;
        private System.Windows.Forms.Label labelSmartManaDrinkerHotkey;
        private System.Windows.Forms.Label labelSmartManaDrinkerStopMana;
        private System.Windows.Forms.Label labelSmartManaDrinkerStartMana;
        private System.Windows.Forms.ComboBox smartManaDrinkerHotkey;
        private System.Windows.Forms.DomainUpDown smartManaDrinkerStopManaPercent;
        private System.Windows.Forms.DomainUpDown smartManaDrinkerStartManaPercent;
        private System.Windows.Forms.ComboBox healingRingHotkey;
        private System.Windows.Forms.ComboBox mightRingHotkey;
        private System.Windows.Forms.ComboBox timeRingHotkey;
        private System.Windows.Forms.ComboBox energyRingHotkey;
        private System.Windows.Forms.ComboBox lifeRingHotkey;
        private System.Windows.Forms.ComboBox utamoVitaHotkey;
        private System.Windows.Forms.ComboBox utanaVidHotkey;
        private System.Windows.Forms.GroupBox groupBoxConditionHealer;
        private System.Windows.Forms.CheckBox checkBoxParalyze;
        private System.Windows.Forms.CheckBox checkBoxPoison;
        private System.Windows.Forms.GroupBox groupBoxStatusHolder;
        private System.Windows.Forms.CheckBox checkBoxUtura;
        private System.Windows.Forms.CheckBox checkBoxHaste;
        private System.Windows.Forms.ComboBox uturaHotkey;
        private System.Windows.Forms.ComboBox hasteHotkey;
        private System.Windows.Forms.ComboBox poisonHotkey;
        private System.Windows.Forms.ComboBox paralyzeHotkey;
        private System.Windows.Forms.GroupBox groupBoxConfigManager;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.GroupBox groupBoxItemHealing;
        private System.Windows.Forms.GroupBox groupBoxNewItemHealing;
        private System.Windows.Forms.Button buttonClearNewItem;
        private System.Windows.Forms.DomainUpDown newItemHealingHpBelow;
        private System.Windows.Forms.ComboBox comboBoxNewItemHealingHotkey;
        private System.Windows.Forms.Button buttonAddNewItemHealing;
        private System.Windows.Forms.Label labelNewItemHp;
        private System.Windows.Forms.Label labelNewHotkeyItem;
        private System.Windows.Forms.Label labelNewItemName;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.GroupBox groupBoxActiveItems;
        private System.Windows.Forms.ListBox listBoxItemHealingActive;
        private System.Windows.Forms.Label labelTopActiveItems;
        private System.Windows.Forms.Button buttonDownItemHealing;
        private System.Windows.Forms.Button buttonUpItemHealing;
        private System.Windows.Forms.Button buttonRemoveSelectedItemHealing;
        private System.Windows.Forms.Label labelNewItemMp;
        private System.Windows.Forms.DomainUpDown newItemHealingMpBelow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxManaWaster;
        private System.Windows.Forms.ComboBox smartManaWasterHotkey;
        private System.Windows.Forms.Label labelManaWasterHotkey;
        private System.Windows.Forms.GroupBox groupBoxGeneralInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spellHealingHpValue;
        private System.Windows.Forms.Label labelMaxMp;
        private System.Windows.Forms.Button buttonApplyMaxValues;
        private System.Windows.Forms.TextBox maxMpInput;
        private System.Windows.Forms.TextBox maxHpInput;
        private System.Windows.Forms.Button buttonResetHealing;
        private System.Windows.Forms.TextBox itemHealingMpValue;
        private System.Windows.Forms.TextBox itemHealingHpValue;
    }
}

