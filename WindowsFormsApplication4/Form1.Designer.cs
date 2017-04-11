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
            this.tab_main = new System.Windows.Forms.TabPage();
            this.groupBoxAccountStatus = new System.Windows.Forms.GroupBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label_daysLeftShow = new System.Windows.Forms.Label();
            this.label_accountStatusShow = new System.Windows.Forms.Label();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.label_daysLeft = new System.Windows.Forms.Label();
            this.label_accountStatus = new System.Windows.Forms.Label();
            this.groupBoxConfigManager = new System.Windows.Forms.GroupBox();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.tab_heal = new System.Windows.Forms.TabPage();
            this.groupBoxGeneralInfo = new System.Windows.Forms.GroupBox();
            this.buttonSaveCfgHealer = new System.Windows.Forms.Button();
            this.buttonLoadCfgHealer = new System.Windows.Forms.Button();
            this.buttonResetHealing = new System.Windows.Forms.Button();
            this.maxMpInput = new System.Windows.Forms.TextBox();
            this.maxHpInput = new System.Windows.Forms.TextBox();
            this.buttonApplyMaxValues = new System.Windows.Forms.Button();
            this.labelMaxMp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxItemHealing = new System.Windows.Forms.GroupBox();
            this.groupBoxNewItemHealing = new System.Windows.Forms.GroupBox();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.newItemHealingHotkey = new System.Windows.Forms.TextBox();
            this.comboBoxMpBelowOver = new System.Windows.Forms.ComboBox();
            this.comboBoxHpBelowOver = new System.Windows.Forms.ComboBox();
            this.itemHealingMpValue = new System.Windows.Forms.TextBox();
            this.itemHealingHpValue = new System.Windows.Forms.TextBox();
            this.labelNewItemMp = new System.Windows.Forms.Label();
            this.buttonClearNewItem = new System.Windows.Forms.Button();
            this.buttonAddNewItemHealing = new System.Windows.Forms.Button();
            this.labelNewItemHp = new System.Windows.Forms.Label();
            this.labelNewHotkeyItem = new System.Windows.Forms.Label();
            this.labelNewItemName = new System.Windows.Forms.Label();
            this.groupBoxActiveItems = new System.Windows.Forms.GroupBox();
            this.listBoxItemHealingActive = new System.Windows.Forms.ListBox();
            this.buttonDownItemHealing = new System.Windows.Forms.Button();
            this.buttonUpItemHealing = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedItemHealing = new System.Windows.Forms.Button();
            this.groupBoxSpellHealing = new System.Windows.Forms.GroupBox();
            this.groupBoxNewSpellHealing = new System.Windows.Forms.GroupBox();
            this.comboBoxSpellName = new System.Windows.Forms.ComboBox();
            this.newSpellHealingHotkey = new System.Windows.Forms.TextBox();
            this.spellHealingMpValue = new System.Windows.Forms.TextBox();
            this.labelNewSpellMpOver = new System.Windows.Forms.Label();
            this.buttonClearNewSpell = new System.Windows.Forms.Button();
            this.buttonAddNewSpellHealing = new System.Windows.Forms.Button();
            this.spellHealingHpValue = new System.Windows.Forms.TextBox();
            this.labelNewSpellHp = new System.Windows.Forms.Label();
            this.labelNewSpellHotkey = new System.Windows.Forms.Label();
            this.labelNewSpellName = new System.Windows.Forms.Label();
            this.groupBoxActiveSpellsHealing = new System.Windows.Forms.GroupBox();
            this.listBoxSpellHealingActive = new System.Windows.Forms.ListBox();
            this.buttonDownSpellHealing = new System.Windows.Forms.Button();
            this.buttonUpSpellHealing = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedSpellHealing = new System.Windows.Forms.Button();
            this.tab_actions = new System.Windows.Forms.TabPage();
            this.groupBoxManaWaster = new System.Windows.Forms.GroupBox();
            this.checkBoxManaWaster = new System.Windows.Forms.CheckBox();
            this.manaWasterHotkey = new System.Windows.Forms.TextBox();
            this.groupBoxSpells = new System.Windows.Forms.GroupBox();
            this.utanaVidHotkey = new System.Windows.Forms.TextBox();
            this.utamoVitaHotkey = new System.Windows.Forms.TextBox();
            this.checkBoxUtana = new System.Windows.Forms.CheckBox();
            this.checkBoxUtamo = new System.Windows.Forms.CheckBox();
            this.groupBoxRoutine = new System.Windows.Forms.GroupBox();
            this.mountHtk = new System.Windows.Forms.TextBox();
            this.eaterHotkey = new System.Windows.Forms.TextBox();
            this.checkBoxMount = new System.Windows.Forms.CheckBox();
            this.checkBoxEater = new System.Windows.Forms.CheckBox();
            this.groupboxRings = new System.Windows.Forms.GroupBox();
            this.healingRingHotkey = new System.Windows.Forms.TextBox();
            this.mightRingHotkey = new System.Windows.Forms.TextBox();
            this.timeRingHotkey = new System.Windows.Forms.TextBox();
            this.energyRingHotkey = new System.Windows.Forms.TextBox();
            this.lifeRingHotkey = new System.Windows.Forms.TextBox();
            this.checkBoxMightRing = new System.Windows.Forms.CheckBox();
            this.checkBoxHealingRing = new System.Windows.Forms.CheckBox();
            this.checkBoxTimeRing = new System.Windows.Forms.CheckBox();
            this.checkBoxEnergyRing = new System.Windows.Forms.CheckBox();
            this.checkBoxLifeRing = new System.Windows.Forms.CheckBox();
            this.tab_support = new System.Windows.Forms.TabPage();
            this.groupBoxStatusHolder = new System.Windows.Forms.GroupBox();
            this.uturaHotkey = new System.Windows.Forms.TextBox();
            this.hasteHotkey = new System.Windows.Forms.TextBox();
            this.checkBoxUtura = new System.Windows.Forms.CheckBox();
            this.checkBoxHaste = new System.Windows.Forms.CheckBox();
            this.groupBoxConditionHealer = new System.Windows.Forms.GroupBox();
            this.poisonHotkey = new System.Windows.Forms.TextBox();
            this.paralyzeHotkey = new System.Windows.Forms.TextBox();
            this.checkBoxPoison = new System.Windows.Forms.CheckBox();
            this.checkBoxParalyze = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.groupBoxAccountStatus.SuspendLayout();
            this.groupBoxConfigManager.SuspendLayout();
            this.tab_heal.SuspendLayout();
            this.groupBoxGeneralInfo.SuspendLayout();
            this.groupBoxItemHealing.SuspendLayout();
            this.groupBoxNewItemHealing.SuspendLayout();
            this.groupBoxActiveItems.SuspendLayout();
            this.groupBoxSpellHealing.SuspendLayout();
            this.groupBoxNewSpellHealing.SuspendLayout();
            this.groupBoxActiveSpellsHealing.SuspendLayout();
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
            this.statusCheckTimer.Interval = 1500;
            this.statusCheckTimer.Tick += new System.EventHandler(this.statusChecker_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_main);
            this.tabControl1.Controls.Add(this.tab_heal);
            this.tabControl1.Controls.Add(this.tab_actions);
            this.tabControl1.Controls.Add(this.tab_support);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.groupBoxAccountStatus);
            this.tab_main.Controls.Add(this.groupBoxConfigManager);
            this.tab_main.Location = new System.Drawing.Point(4, 22);
            this.tab_main.Name = "tab_main";
            this.tab_main.Padding = new System.Windows.Forms.Padding(3);
            this.tab_main.Size = new System.Drawing.Size(534, 423);
            this.tab_main.TabIndex = 1;
            this.tab_main.Text = "Main";
            this.tab_main.UseVisualStyleBackColor = true;
            // 
            // groupBoxAccountStatus
            // 
            this.groupBoxAccountStatus.Controls.Add(this.buttonLogOut);
            this.groupBoxAccountStatus.Controls.Add(this.label_daysLeftShow);
            this.groupBoxAccountStatus.Controls.Add(this.label_accountStatusShow);
            this.groupBoxAccountStatus.Controls.Add(this.buttonPurchase);
            this.groupBoxAccountStatus.Controls.Add(this.label_daysLeft);
            this.groupBoxAccountStatus.Controls.Add(this.label_accountStatus);
            this.groupBoxAccountStatus.Location = new System.Drawing.Point(22, 29);
            this.groupBoxAccountStatus.Name = "groupBoxAccountStatus";
            this.groupBoxAccountStatus.Size = new System.Drawing.Size(270, 140);
            this.groupBoxAccountStatus.TabIndex = 13;
            this.groupBoxAccountStatus.TabStop = false;
            this.groupBoxAccountStatus.Text = "Account Status";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(181, 76);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(70, 24);
            this.buttonLogOut.TabIndex = 10;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // label_daysLeftShow
            // 
            this.label_daysLeftShow.AutoSize = true;
            this.label_daysLeftShow.ForeColor = System.Drawing.Color.Green;
            this.label_daysLeftShow.Location = new System.Drawing.Point(123, 49);
            this.label_daysLeftShow.Name = "label_daysLeftShow";
            this.label_daysLeftShow.Size = new System.Drawing.Size(37, 13);
            this.label_daysLeftShow.TabIndex = 9;
            this.label_daysLeftShow.Text = "9000+";
            // 
            // label_accountStatusShow
            // 
            this.label_accountStatusShow.AutoSize = true;
            this.label_accountStatusShow.ForeColor = System.Drawing.Color.Green;
            this.label_accountStatusShow.Location = new System.Drawing.Point(123, 22);
            this.label_accountStatusShow.Name = "label_accountStatusShow";
            this.label_accountStatusShow.Size = new System.Drawing.Size(67, 13);
            this.label_accountStatusShow.TabIndex = 8;
            this.label_accountStatusShow.Text = "VIP Account";
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
            // groupBoxConfigManager
            // 
            this.groupBoxConfigManager.Controls.Add(this.buttonSaveConfig);
            this.groupBoxConfigManager.Controls.Add(this.buttonLoadConfig);
            this.groupBoxConfigManager.Location = new System.Drawing.Point(312, 29);
            this.groupBoxConfigManager.Name = "groupBoxConfigManager";
            this.groupBoxConfigManager.Size = new System.Drawing.Size(109, 140);
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
            this.tab_heal.Size = new System.Drawing.Size(534, 423);
            this.tab_heal.TabIndex = 2;
            this.tab_heal.Text = "Heal";
            this.tab_heal.UseVisualStyleBackColor = true;
            // 
            // groupBoxGeneralInfo
            // 
            this.groupBoxGeneralInfo.Controls.Add(this.buttonSaveCfgHealer);
            this.groupBoxGeneralInfo.Controls.Add(this.buttonLoadCfgHealer);
            this.groupBoxGeneralInfo.Controls.Add(this.buttonResetHealing);
            this.groupBoxGeneralInfo.Controls.Add(this.maxMpInput);
            this.groupBoxGeneralInfo.Controls.Add(this.maxHpInput);
            this.groupBoxGeneralInfo.Controls.Add(this.buttonApplyMaxValues);
            this.groupBoxGeneralInfo.Controls.Add(this.labelMaxMp);
            this.groupBoxGeneralInfo.Controls.Add(this.label1);
            this.groupBoxGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGeneralInfo.Location = new System.Drawing.Point(3, 4);
            this.groupBoxGeneralInfo.Name = "groupBoxGeneralInfo";
            this.groupBoxGeneralInfo.Size = new System.Drawing.Size(528, 59);
            this.groupBoxGeneralInfo.TabIndex = 2;
            this.groupBoxGeneralInfo.TabStop = false;
            this.groupBoxGeneralInfo.Text = "General Info";
            // 
            // buttonSaveCfgHealer
            // 
            this.buttonSaveCfgHealer.Location = new System.Drawing.Point(432, 19);
            this.buttonSaveCfgHealer.Name = "buttonSaveCfgHealer";
            this.buttonSaveCfgHealer.Size = new System.Drawing.Size(87, 30);
            this.buttonSaveCfgHealer.TabIndex = 9;
            this.buttonSaveCfgHealer.Text = "Save CFG";
            this.buttonSaveCfgHealer.UseVisualStyleBackColor = true;
            this.buttonSaveCfgHealer.Visible = false;
            this.buttonSaveCfgHealer.Click += new System.EventHandler(this.buttonSaveCfgHealer_Click);
            // 
            // buttonLoadCfgHealer
            // 
            this.buttonLoadCfgHealer.Location = new System.Drawing.Point(432, 18);
            this.buttonLoadCfgHealer.Name = "buttonLoadCfgHealer";
            this.buttonLoadCfgHealer.Size = new System.Drawing.Size(87, 30);
            this.buttonLoadCfgHealer.TabIndex = 8;
            this.buttonLoadCfgHealer.Text = "Load CFG";
            this.buttonLoadCfgHealer.UseVisualStyleBackColor = true;
            this.buttonLoadCfgHealer.Click += new System.EventHandler(this.buttonLoadCfgHealer_Click);
            // 
            // buttonResetHealing
            // 
            this.buttonResetHealing.ForeColor = System.Drawing.Color.Red;
            this.buttonResetHealing.Location = new System.Drawing.Point(327, 19);
            this.buttonResetHealing.Name = "buttonResetHealing";
            this.buttonResetHealing.Size = new System.Drawing.Size(87, 30);
            this.buttonResetHealing.TabIndex = 7;
            this.buttonResetHealing.Text = "Reset ALL";
            this.buttonResetHealing.UseVisualStyleBackColor = true;
            this.buttonResetHealing.Visible = false;
            this.buttonResetHealing.Click += new System.EventHandler(this.buttonResetHealing_Click);
            // 
            // maxMpInput
            // 
            this.maxMpInput.Location = new System.Drawing.Point(209, 23);
            this.maxMpInput.Name = "maxMpInput";
            this.maxMpInput.Size = new System.Drawing.Size(70, 20);
            this.maxMpInput.TabIndex = 6;
            // 
            // maxHpInput
            // 
            this.maxHpInput.Location = new System.Drawing.Point(79, 23);
            this.maxHpInput.Name = "maxHpInput";
            this.maxHpInput.Size = new System.Drawing.Size(69, 20);
            this.maxHpInput.TabIndex = 5;
            // 
            // buttonApplyMaxValues
            // 
            this.buttonApplyMaxValues.ForeColor = System.Drawing.Color.Green;
            this.buttonApplyMaxValues.Location = new System.Drawing.Point(327, 18);
            this.buttonApplyMaxValues.Name = "buttonApplyMaxValues";
            this.buttonApplyMaxValues.Size = new System.Drawing.Size(87, 30);
            this.buttonApplyMaxValues.TabIndex = 4;
            this.buttonApplyMaxValues.Text = "Start Healer";
            this.buttonApplyMaxValues.UseVisualStyleBackColor = true;
            this.buttonApplyMaxValues.Click += new System.EventHandler(this.buttonApplyMaxValues_Click);
            // 
            // labelMaxMp
            // 
            this.labelMaxMp.AutoSize = true;
            this.labelMaxMp.ForeColor = System.Drawing.Color.Blue;
            this.labelMaxMp.Location = new System.Drawing.Point(154, 26);
            this.labelMaxMp.Name = "labelMaxMp";
            this.labelMaxMp.Size = new System.Drawing.Size(49, 13);
            this.labelMaxMp.TabIndex = 1;
            this.labelMaxMp.Text = "Max MP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max HP:";
            // 
            // groupBoxItemHealing
            // 
            this.groupBoxItemHealing.Controls.Add(this.groupBoxNewItemHealing);
            this.groupBoxItemHealing.Controls.Add(this.groupBoxActiveItems);
            this.groupBoxItemHealing.Enabled = false;
            this.groupBoxItemHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxItemHealing.Location = new System.Drawing.Point(3, 233);
            this.groupBoxItemHealing.Name = "groupBoxItemHealing";
            this.groupBoxItemHealing.Size = new System.Drawing.Size(528, 178);
            this.groupBoxItemHealing.TabIndex = 1;
            this.groupBoxItemHealing.TabStop = false;
            this.groupBoxItemHealing.Text = "Item Healing";
            // 
            // groupBoxNewItemHealing
            // 
            this.groupBoxNewItemHealing.Controls.Add(this.comboBoxItemName);
            this.groupBoxNewItemHealing.Controls.Add(this.newItemHealingHotkey);
            this.groupBoxNewItemHealing.Controls.Add(this.comboBoxMpBelowOver);
            this.groupBoxNewItemHealing.Controls.Add(this.comboBoxHpBelowOver);
            this.groupBoxNewItemHealing.Controls.Add(this.itemHealingMpValue);
            this.groupBoxNewItemHealing.Controls.Add(this.itemHealingHpValue);
            this.groupBoxNewItemHealing.Controls.Add(this.labelNewItemMp);
            this.groupBoxNewItemHealing.Controls.Add(this.buttonClearNewItem);
            this.groupBoxNewItemHealing.Controls.Add(this.buttonAddNewItemHealing);
            this.groupBoxNewItemHealing.Controls.Add(this.labelNewItemHp);
            this.groupBoxNewItemHealing.Controls.Add(this.labelNewHotkeyItem);
            this.groupBoxNewItemHealing.Controls.Add(this.labelNewItemName);
            this.groupBoxNewItemHealing.Location = new System.Drawing.Point(355, 19);
            this.groupBoxNewItemHealing.Name = "groupBoxNewItemHealing";
            this.groupBoxNewItemHealing.Size = new System.Drawing.Size(164, 146);
            this.groupBoxNewItemHealing.TabIndex = 2;
            this.groupBoxNewItemHealing.TabStop = false;
            this.groupBoxNewItemHealing.Text = "New Item";
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Items.AddRange(new object[] {
            "Small Mana",
            "Strong Mana",
            "Great Mana",
            "Ultimate Mana",
            "Small Life",
            "Strong Life",
            "Great Life",
            "Ultimate Life",
            "Strong Spirit",
            "Great Spirit",
            "Ultimate Spirit",
            "UH Rune",
            "IH Rune"});
            this.comboBoxItemName.Location = new System.Drawing.Point(58, 16);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(98, 21);
            this.comboBoxItemName.TabIndex = 15;
            // 
            // newItemHealingHotkey
            // 
            this.newItemHealingHotkey.Location = new System.Drawing.Point(119, 39);
            this.newItemHealingHotkey.Name = "newItemHealingHotkey";
            this.newItemHealingHotkey.ReadOnly = true;
            this.newItemHealingHotkey.Size = new System.Drawing.Size(37, 20);
            this.newItemHealingHotkey.TabIndex = 14;
            this.newItemHealingHotkey.Text = "HTK";
            this.newItemHealingHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemHealingHotkey_KeyDown);
            // 
            // comboBoxMpBelowOver
            // 
            this.comboBoxMpBelowOver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMpBelowOver.FormattingEnabled = true;
            this.comboBoxMpBelowOver.Items.AddRange(new object[] {
            "BELOW",
            "OVER"});
            this.comboBoxMpBelowOver.Location = new System.Drawing.Point(41, 89);
            this.comboBoxMpBelowOver.Name = "comboBoxMpBelowOver";
            this.comboBoxMpBelowOver.Size = new System.Drawing.Size(66, 21);
            this.comboBoxMpBelowOver.TabIndex = 13;
            // 
            // comboBoxHpBelowOver
            // 
            this.comboBoxHpBelowOver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHpBelowOver.FormattingEnabled = true;
            this.comboBoxHpBelowOver.Items.AddRange(new object[] {
            "BELOW",
            "OVER"});
            this.comboBoxHpBelowOver.Location = new System.Drawing.Point(41, 62);
            this.comboBoxHpBelowOver.Name = "comboBoxHpBelowOver";
            this.comboBoxHpBelowOver.Size = new System.Drawing.Size(66, 21);
            this.comboBoxHpBelowOver.TabIndex = 12;
            // 
            // itemHealingMpValue
            // 
            this.itemHealingMpValue.Location = new System.Drawing.Point(113, 90);
            this.itemHealingMpValue.Name = "itemHealingMpValue";
            this.itemHealingMpValue.Size = new System.Drawing.Size(43, 20);
            this.itemHealingMpValue.TabIndex = 11;
            this.itemHealingMpValue.Text = "MP";
            // 
            // itemHealingHpValue
            // 
            this.itemHealingHpValue.Location = new System.Drawing.Point(113, 63);
            this.itemHealingHpValue.Name = "itemHealingHpValue";
            this.itemHealingHpValue.Size = new System.Drawing.Size(43, 20);
            this.itemHealingHpValue.TabIndex = 10;
            this.itemHealingHpValue.Text = "HP";
            // 
            // labelNewItemMp
            // 
            this.labelNewItemMp.AutoSize = true;
            this.labelNewItemMp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewItemMp.Location = new System.Drawing.Point(6, 86);
            this.labelNewItemMp.Name = "labelNewItemMp";
            this.labelNewItemMp.Size = new System.Drawing.Size(34, 13);
            this.labelNewItemMp.TabIndex = 8;
            this.labelNewItemMp.Text = "Mana";
            // 
            // buttonClearNewItem
            // 
            this.buttonClearNewItem.ForeColor = System.Drawing.Color.Red;
            this.buttonClearNewItem.Location = new System.Drawing.Point(80, 120);
            this.buttonClearNewItem.Name = "buttonClearNewItem";
            this.buttonClearNewItem.Size = new System.Drawing.Size(76, 21);
            this.buttonClearNewItem.TabIndex = 7;
            this.buttonClearNewItem.Text = "Clear";
            this.buttonClearNewItem.UseVisualStyleBackColor = true;
            this.buttonClearNewItem.Click += new System.EventHandler(this.buttonClearNewItem_Click);
            // 
            // buttonAddNewItemHealing
            // 
            this.buttonAddNewItemHealing.ForeColor = System.Drawing.Color.Green;
            this.buttonAddNewItemHealing.Location = new System.Drawing.Point(9, 120);
            this.buttonAddNewItemHealing.Name = "buttonAddNewItemHealing";
            this.buttonAddNewItemHealing.Size = new System.Drawing.Size(61, 21);
            this.buttonAddNewItemHealing.TabIndex = 4;
            this.buttonAddNewItemHealing.Text = "Add";
            this.buttonAddNewItemHealing.UseVisualStyleBackColor = true;
            this.buttonAddNewItemHealing.Click += new System.EventHandler(this.buttonAddNewItemHealing_Click);
            // 
            // labelNewItemHp
            // 
            this.labelNewItemHp.AutoSize = true;
            this.labelNewItemHp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewItemHp.Location = new System.Drawing.Point(6, 65);
            this.labelNewItemHp.Name = "labelNewItemHp";
            this.labelNewItemHp.Size = new System.Drawing.Size(38, 13);
            this.labelNewItemHp.TabIndex = 3;
            this.labelNewItemHp.Text = "Health";
            // 
            // labelNewHotkeyItem
            // 
            this.labelNewHotkeyItem.AutoSize = true;
            this.labelNewHotkeyItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewHotkeyItem.Location = new System.Drawing.Point(6, 42);
            this.labelNewHotkeyItem.Name = "labelNewHotkeyItem";
            this.labelNewHotkeyItem.Size = new System.Drawing.Size(41, 13);
            this.labelNewHotkeyItem.TabIndex = 2;
            this.labelNewHotkeyItem.Text = "Hotkey";
            // 
            // labelNewItemName
            // 
            this.labelNewItemName.AutoSize = true;
            this.labelNewItemName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewItemName.Location = new System.Drawing.Point(5, 16);
            this.labelNewItemName.Name = "labelNewItemName";
            this.labelNewItemName.Size = new System.Drawing.Size(35, 13);
            this.labelNewItemName.TabIndex = 1;
            this.labelNewItemName.Text = "Name";
            // 
            // groupBoxActiveItems
            // 
            this.groupBoxActiveItems.Controls.Add(this.listBoxItemHealingActive);
            this.groupBoxActiveItems.Controls.Add(this.buttonDownItemHealing);
            this.groupBoxActiveItems.Controls.Add(this.buttonUpItemHealing);
            this.groupBoxActiveItems.Controls.Add(this.buttonRemoveSelectedItemHealing);
            this.groupBoxActiveItems.Location = new System.Drawing.Point(6, 19);
            this.groupBoxActiveItems.Name = "groupBoxActiveItems";
            this.groupBoxActiveItems.Size = new System.Drawing.Size(343, 146);
            this.groupBoxActiveItems.TabIndex = 1;
            this.groupBoxActiveItems.TabStop = false;
            this.groupBoxActiveItems.Text = "Active Items";
            // 
            // listBoxItemHealingActive
            // 
            this.listBoxItemHealingActive.FormattingEnabled = true;
            this.listBoxItemHealingActive.HorizontalScrollbar = true;
            this.listBoxItemHealingActive.Location = new System.Drawing.Point(6, 16);
            this.listBoxItemHealingActive.Name = "listBoxItemHealingActive";
            this.listBoxItemHealingActive.Size = new System.Drawing.Size(291, 121);
            this.listBoxItemHealingActive.TabIndex = 4;
            // 
            // buttonDownItemHealing
            // 
            this.buttonDownItemHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDownItemHealing.Location = new System.Drawing.Point(303, 65);
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
            this.buttonUpItemHealing.Location = new System.Drawing.Point(303, 41);
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
            this.buttonRemoveSelectedItemHealing.Location = new System.Drawing.Point(303, 90);
            this.buttonRemoveSelectedItemHealing.Name = "buttonRemoveSelectedItemHealing";
            this.buttonRemoveSelectedItemHealing.Size = new System.Drawing.Size(30, 23);
            this.buttonRemoveSelectedItemHealing.TabIndex = 3;
            this.buttonRemoveSelectedItemHealing.Text = "X";
            this.buttonRemoveSelectedItemHealing.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedItemHealing.Click += new System.EventHandler(this.buttonRemoveSelectedItemHealing_Click);
            // 
            // groupBoxSpellHealing
            // 
            this.groupBoxSpellHealing.Controls.Add(this.groupBoxNewSpellHealing);
            this.groupBoxSpellHealing.Controls.Add(this.groupBoxActiveSpellsHealing);
            this.groupBoxSpellHealing.Enabled = false;
            this.groupBoxSpellHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxSpellHealing.Location = new System.Drawing.Point(3, 69);
            this.groupBoxSpellHealing.Name = "groupBoxSpellHealing";
            this.groupBoxSpellHealing.Size = new System.Drawing.Size(528, 158);
            this.groupBoxSpellHealing.TabIndex = 0;
            this.groupBoxSpellHealing.TabStop = false;
            this.groupBoxSpellHealing.Text = "Spell Healing";
            // 
            // groupBoxNewSpellHealing
            // 
            this.groupBoxNewSpellHealing.Controls.Add(this.comboBoxSpellName);
            this.groupBoxNewSpellHealing.Controls.Add(this.newSpellHealingHotkey);
            this.groupBoxNewSpellHealing.Controls.Add(this.spellHealingMpValue);
            this.groupBoxNewSpellHealing.Controls.Add(this.labelNewSpellMpOver);
            this.groupBoxNewSpellHealing.Controls.Add(this.buttonClearNewSpell);
            this.groupBoxNewSpellHealing.Controls.Add(this.buttonAddNewSpellHealing);
            this.groupBoxNewSpellHealing.Controls.Add(this.spellHealingHpValue);
            this.groupBoxNewSpellHealing.Controls.Add(this.labelNewSpellHp);
            this.groupBoxNewSpellHealing.Controls.Add(this.labelNewSpellHotkey);
            this.groupBoxNewSpellHealing.Controls.Add(this.labelNewSpellName);
            this.groupBoxNewSpellHealing.Location = new System.Drawing.Point(355, 13);
            this.groupBoxNewSpellHealing.Name = "groupBoxNewSpellHealing";
            this.groupBoxNewSpellHealing.Size = new System.Drawing.Size(164, 139);
            this.groupBoxNewSpellHealing.TabIndex = 2;
            this.groupBoxNewSpellHealing.TabStop = false;
            this.groupBoxNewSpellHealing.Text = "New Spell";
            // 
            // comboBoxSpellName
            // 
            this.comboBoxSpellName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpellName.FormattingEnabled = true;
            this.comboBoxSpellName.Items.AddRange(new object[] {
            "Exura",
            "Exura Gran",
            "Exura Vita / Sio",
            "Exura Ico",
            "Exura Gran Ico",
            "Exura San",
            "Exura Gran San"});
            this.comboBoxSpellName.Location = new System.Drawing.Point(58, 16);
            this.comboBoxSpellName.Name = "comboBoxSpellName";
            this.comboBoxSpellName.Size = new System.Drawing.Size(98, 21);
            this.comboBoxSpellName.TabIndex = 11;
            // 
            // newSpellHealingHotkey
            // 
            this.newSpellHealingHotkey.Location = new System.Drawing.Point(121, 39);
            this.newSpellHealingHotkey.Name = "newSpellHealingHotkey";
            this.newSpellHealingHotkey.ReadOnly = true;
            this.newSpellHealingHotkey.Size = new System.Drawing.Size(37, 20);
            this.newSpellHealingHotkey.TabIndex = 3;
            this.newSpellHealingHotkey.Text = "HTK";
            this.newSpellHealingHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spellHealingHotkey_KeyDown);
            // 
            // spellHealingMpValue
            // 
            this.spellHealingMpValue.Location = new System.Drawing.Point(115, 85);
            this.spellHealingMpValue.Name = "spellHealingMpValue";
            this.spellHealingMpValue.Size = new System.Drawing.Size(43, 20);
            this.spellHealingMpValue.TabIndex = 10;
            this.spellHealingMpValue.Text = "MP";
            // 
            // labelNewSpellMpOver
            // 
            this.labelNewSpellMpOver.AutoSize = true;
            this.labelNewSpellMpOver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewSpellMpOver.Location = new System.Drawing.Point(1, 85);
            this.labelNewSpellMpOver.Name = "labelNewSpellMpOver";
            this.labelNewSpellMpOver.Size = new System.Drawing.Size(67, 13);
            this.labelNewSpellMpOver.TabIndex = 9;
            this.labelNewSpellMpOver.Text = "Mana OVER";
            // 
            // buttonClearNewSpell
            // 
            this.buttonClearNewSpell.ForeColor = System.Drawing.Color.Red;
            this.buttonClearNewSpell.Location = new System.Drawing.Point(63, 108);
            this.buttonClearNewSpell.Name = "buttonClearNewSpell";
            this.buttonClearNewSpell.Size = new System.Drawing.Size(40, 21);
            this.buttonClearNewSpell.TabIndex = 7;
            this.buttonClearNewSpell.Text = "Clear";
            this.buttonClearNewSpell.UseVisualStyleBackColor = true;
            this.buttonClearNewSpell.Click += new System.EventHandler(this.buttonClearNewSpell_Click);
            // 
            // buttonAddNewSpellHealing
            // 
            this.buttonAddNewSpellHealing.ForeColor = System.Drawing.Color.Green;
            this.buttonAddNewSpellHealing.Location = new System.Drawing.Point(17, 108);
            this.buttonAddNewSpellHealing.Name = "buttonAddNewSpellHealing";
            this.buttonAddNewSpellHealing.Size = new System.Drawing.Size(40, 21);
            this.buttonAddNewSpellHealing.TabIndex = 4;
            this.buttonAddNewSpellHealing.Text = "Add";
            this.buttonAddNewSpellHealing.UseVisualStyleBackColor = true;
            this.buttonAddNewSpellHealing.Click += new System.EventHandler(this.buttonAddNewSpellHealing_Click);
            // 
            // spellHealingHpValue
            // 
            this.spellHealingHpValue.Location = new System.Drawing.Point(115, 61);
            this.spellHealingHpValue.Name = "spellHealingHpValue";
            this.spellHealingHpValue.Size = new System.Drawing.Size(43, 20);
            this.spellHealingHpValue.TabIndex = 8;
            this.spellHealingHpValue.Text = "HP";
            // 
            // labelNewSpellHp
            // 
            this.labelNewSpellHp.AutoSize = true;
            this.labelNewSpellHp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewSpellHp.Location = new System.Drawing.Point(1, 64);
            this.labelNewSpellHp.Name = "labelNewSpellHp";
            this.labelNewSpellHp.Size = new System.Drawing.Size(80, 13);
            this.labelNewSpellHp.TabIndex = 3;
            this.labelNewSpellHp.Text = "Health BELOW";
            // 
            // labelNewSpellHotkey
            // 
            this.labelNewSpellHotkey.AutoSize = true;
            this.labelNewSpellHotkey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewSpellHotkey.Location = new System.Drawing.Point(1, 42);
            this.labelNewSpellHotkey.Name = "labelNewSpellHotkey";
            this.labelNewSpellHotkey.Size = new System.Drawing.Size(41, 13);
            this.labelNewSpellHotkey.TabIndex = 2;
            this.labelNewSpellHotkey.Text = "Hotkey";
            // 
            // labelNewSpellName
            // 
            this.labelNewSpellName.AutoSize = true;
            this.labelNewSpellName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNewSpellName.Location = new System.Drawing.Point(1, 20);
            this.labelNewSpellName.Name = "labelNewSpellName";
            this.labelNewSpellName.Size = new System.Drawing.Size(35, 13);
            this.labelNewSpellName.TabIndex = 1;
            this.labelNewSpellName.Text = "Name";
            // 
            // groupBoxActiveSpellsHealing
            // 
            this.groupBoxActiveSpellsHealing.Controls.Add(this.listBoxSpellHealingActive);
            this.groupBoxActiveSpellsHealing.Controls.Add(this.buttonDownSpellHealing);
            this.groupBoxActiveSpellsHealing.Controls.Add(this.buttonUpSpellHealing);
            this.groupBoxActiveSpellsHealing.Controls.Add(this.buttonRemoveSelectedSpellHealing);
            this.groupBoxActiveSpellsHealing.Location = new System.Drawing.Point(6, 13);
            this.groupBoxActiveSpellsHealing.Name = "groupBoxActiveSpellsHealing";
            this.groupBoxActiveSpellsHealing.Size = new System.Drawing.Size(343, 139);
            this.groupBoxActiveSpellsHealing.TabIndex = 1;
            this.groupBoxActiveSpellsHealing.TabStop = false;
            this.groupBoxActiveSpellsHealing.Text = "Active Spells";
            // 
            // listBoxSpellHealingActive
            // 
            this.listBoxSpellHealingActive.FormattingEnabled = true;
            this.listBoxSpellHealingActive.HorizontalScrollbar = true;
            this.listBoxSpellHealingActive.Location = new System.Drawing.Point(6, 16);
            this.listBoxSpellHealingActive.Name = "listBoxSpellHealingActive";
            this.listBoxSpellHealingActive.Size = new System.Drawing.Size(291, 121);
            this.listBoxSpellHealingActive.TabIndex = 4;
            // 
            // buttonDownSpellHealing
            // 
            this.buttonDownSpellHealing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDownSpellHealing.Location = new System.Drawing.Point(303, 51);
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
            this.buttonUpSpellHealing.Location = new System.Drawing.Point(303, 25);
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
            this.buttonRemoveSelectedSpellHealing.Location = new System.Drawing.Point(303, 80);
            this.buttonRemoveSelectedSpellHealing.Name = "buttonRemoveSelectedSpellHealing";
            this.buttonRemoveSelectedSpellHealing.Size = new System.Drawing.Size(30, 23);
            this.buttonRemoveSelectedSpellHealing.TabIndex = 3;
            this.buttonRemoveSelectedSpellHealing.Text = "X";
            this.buttonRemoveSelectedSpellHealing.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedSpellHealing.Click += new System.EventHandler(this.buttonRemoveSelectedSpellHealing_Click);
            // 
            // tab_actions
            // 
            this.tab_actions.Controls.Add(this.groupBoxManaWaster);
            this.tab_actions.Controls.Add(this.groupBoxSpells);
            this.tab_actions.Controls.Add(this.groupBoxRoutine);
            this.tab_actions.Controls.Add(this.groupboxRings);
            this.tab_actions.Location = new System.Drawing.Point(4, 22);
            this.tab_actions.Name = "tab_actions";
            this.tab_actions.Size = new System.Drawing.Size(534, 423);
            this.tab_actions.TabIndex = 4;
            this.tab_actions.Text = "Actions";
            this.tab_actions.UseVisualStyleBackColor = true;
            // 
            // groupBoxManaWaster
            // 
            this.groupBoxManaWaster.Controls.Add(this.checkBoxManaWaster);
            this.groupBoxManaWaster.Controls.Add(this.manaWasterHotkey);
            this.groupBoxManaWaster.Location = new System.Drawing.Point(17, 177);
            this.groupBoxManaWaster.Name = "groupBoxManaWaster";
            this.groupBoxManaWaster.Size = new System.Drawing.Size(179, 116);
            this.groupBoxManaWaster.TabIndex = 4;
            this.groupBoxManaWaster.TabStop = false;
            this.groupBoxManaWaster.Text = "Mana Waster";
            // 
            // checkBoxManaWaster
            // 
            this.checkBoxManaWaster.AutoSize = true;
            this.checkBoxManaWaster.Location = new System.Drawing.Point(12, 25);
            this.checkBoxManaWaster.Name = "checkBoxManaWaster";
            this.checkBoxManaWaster.Size = new System.Drawing.Size(144, 17);
            this.checkBoxManaWaster.TabIndex = 13;
            this.checkBoxManaWaster.Text = "Mana Waster (mana=full)";
            this.checkBoxManaWaster.UseVisualStyleBackColor = true;
            this.checkBoxManaWaster.CheckedChanged += new System.EventHandler(this.checkBoxManaWaster_CheckedChanged);
            // 
            // manaWasterHotkey
            // 
            this.manaWasterHotkey.Location = new System.Drawing.Point(62, 74);
            this.manaWasterHotkey.Name = "manaWasterHotkey";
            this.manaWasterHotkey.ReadOnly = true;
            this.manaWasterHotkey.Size = new System.Drawing.Size(37, 20);
            this.manaWasterHotkey.TabIndex = 12;
            this.manaWasterHotkey.Text = "HTK";
            this.manaWasterHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manaWasterHotkey_KeyDown);
            // 
            // groupBoxSpells
            // 
            this.groupBoxSpells.Controls.Add(this.utanaVidHotkey);
            this.groupBoxSpells.Controls.Add(this.utamoVitaHotkey);
            this.groupBoxSpells.Controls.Add(this.checkBoxUtana);
            this.groupBoxSpells.Controls.Add(this.checkBoxUtamo);
            this.groupBoxSpells.Location = new System.Drawing.Point(209, 24);
            this.groupBoxSpells.Name = "groupBoxSpells";
            this.groupBoxSpells.Size = new System.Drawing.Size(173, 99);
            this.groupBoxSpells.TabIndex = 3;
            this.groupBoxSpells.TabStop = false;
            this.groupBoxSpells.Text = "Spells";
            // 
            // utanaVidHotkey
            // 
            this.utanaVidHotkey.Location = new System.Drawing.Point(108, 49);
            this.utanaVidHotkey.Name = "utanaVidHotkey";
            this.utanaVidHotkey.ReadOnly = true;
            this.utanaVidHotkey.Size = new System.Drawing.Size(37, 20);
            this.utanaVidHotkey.TabIndex = 11;
            this.utanaVidHotkey.Text = "HTK";
            this.utanaVidHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.utanaVidHotkey_KeyDown);
            // 
            // utamoVitaHotkey
            // 
            this.utamoVitaHotkey.Location = new System.Drawing.Point(108, 20);
            this.utamoVitaHotkey.Name = "utamoVitaHotkey";
            this.utamoVitaHotkey.ReadOnly = true;
            this.utamoVitaHotkey.Size = new System.Drawing.Size(37, 20);
            this.utamoVitaHotkey.TabIndex = 7;
            this.utamoVitaHotkey.Text = "HTK";
            this.utamoVitaHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.utamoVitaHotkey_KeyDown);
            // 
            // checkBoxUtana
            // 
            this.checkBoxUtana.AutoSize = true;
            this.checkBoxUtana.Location = new System.Drawing.Point(14, 52);
            this.checkBoxUtana.Name = "checkBoxUtana";
            this.checkBoxUtana.Size = new System.Drawing.Size(89, 17);
            this.checkBoxUtana.TabIndex = 1;
            this.checkBoxUtana.Text = "Utana Vid (X)";
            this.checkBoxUtana.UseVisualStyleBackColor = true;
            // 
            // checkBoxUtamo
            // 
            this.checkBoxUtamo.AutoSize = true;
            this.checkBoxUtamo.Location = new System.Drawing.Point(14, 25);
            this.checkBoxUtamo.Name = "checkBoxUtamo";
            this.checkBoxUtamo.Size = new System.Drawing.Size(94, 17);
            this.checkBoxUtamo.TabIndex = 0;
            this.checkBoxUtamo.Text = "Utamo Vita (X)";
            this.checkBoxUtamo.UseVisualStyleBackColor = true;
            // 
            // groupBoxRoutine
            // 
            this.groupBoxRoutine.Controls.Add(this.mountHtk);
            this.groupBoxRoutine.Controls.Add(this.eaterHotkey);
            this.groupBoxRoutine.Controls.Add(this.checkBoxMount);
            this.groupBoxRoutine.Controls.Add(this.checkBoxEater);
            this.groupBoxRoutine.Location = new System.Drawing.Point(17, 24);
            this.groupBoxRoutine.Name = "groupBoxRoutine";
            this.groupBoxRoutine.Size = new System.Drawing.Size(179, 147);
            this.groupBoxRoutine.TabIndex = 2;
            this.groupBoxRoutine.TabStop = false;
            this.groupBoxRoutine.Text = "Routine";
            // 
            // mountHtk
            // 
            this.mountHtk.Location = new System.Drawing.Point(102, 49);
            this.mountHtk.Name = "mountHtk";
            this.mountHtk.ReadOnly = true;
            this.mountHtk.Size = new System.Drawing.Size(37, 20);
            this.mountHtk.TabIndex = 6;
            this.mountHtk.Text = "HTK";
            this.mountHtk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mountHtk_KeyDown);
            // 
            // eaterHotkey
            // 
            this.eaterHotkey.Location = new System.Drawing.Point(102, 22);
            this.eaterHotkey.Name = "eaterHotkey";
            this.eaterHotkey.ReadOnly = true;
            this.eaterHotkey.Size = new System.Drawing.Size(37, 20);
            this.eaterHotkey.TabIndex = 5;
            this.eaterHotkey.Text = "HTK";
            this.eaterHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eaterHotkey_KeyDown);
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
            this.groupboxRings.Location = new System.Drawing.Point(209, 129);
            this.groupboxRings.Name = "groupboxRings";
            this.groupboxRings.Size = new System.Drawing.Size(173, 164);
            this.groupboxRings.TabIndex = 0;
            this.groupboxRings.TabStop = false;
            this.groupboxRings.Text = "Rings";
            // 
            // healingRingHotkey
            // 
            this.healingRingHotkey.Location = new System.Drawing.Point(123, 115);
            this.healingRingHotkey.Name = "healingRingHotkey";
            this.healingRingHotkey.ReadOnly = true;
            this.healingRingHotkey.Size = new System.Drawing.Size(37, 20);
            this.healingRingHotkey.TabIndex = 14;
            this.healingRingHotkey.Text = "HTK";
            this.healingRingHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.healingRingHotkey_KeyDown);
            // 
            // mightRingHotkey
            // 
            this.mightRingHotkey.Location = new System.Drawing.Point(123, 94);
            this.mightRingHotkey.Name = "mightRingHotkey";
            this.mightRingHotkey.ReadOnly = true;
            this.mightRingHotkey.Size = new System.Drawing.Size(37, 20);
            this.mightRingHotkey.TabIndex = 13;
            this.mightRingHotkey.Text = "HTK";
            this.mightRingHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mightRingHotkey_KeyDown);
            // 
            // timeRingHotkey
            // 
            this.timeRingHotkey.Location = new System.Drawing.Point(123, 71);
            this.timeRingHotkey.Name = "timeRingHotkey";
            this.timeRingHotkey.ReadOnly = true;
            this.timeRingHotkey.Size = new System.Drawing.Size(37, 20);
            this.timeRingHotkey.TabIndex = 12;
            this.timeRingHotkey.Text = "HTK";
            this.timeRingHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeRingHotkey_KeyDown);
            // 
            // energyRingHotkey
            // 
            this.energyRingHotkey.Location = new System.Drawing.Point(123, 48);
            this.energyRingHotkey.Name = "energyRingHotkey";
            this.energyRingHotkey.ReadOnly = true;
            this.energyRingHotkey.Size = new System.Drawing.Size(37, 20);
            this.energyRingHotkey.TabIndex = 11;
            this.energyRingHotkey.Text = "HTK";
            this.energyRingHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.energyRingHotkey_KeyDown);
            // 
            // lifeRingHotkey
            // 
            this.lifeRingHotkey.Location = new System.Drawing.Point(123, 25);
            this.lifeRingHotkey.Name = "lifeRingHotkey";
            this.lifeRingHotkey.ReadOnly = true;
            this.lifeRingHotkey.Size = new System.Drawing.Size(37, 20);
            this.lifeRingHotkey.TabIndex = 10;
            this.lifeRingHotkey.Text = "HTK";
            this.lifeRingHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lifeRingHotkey_KeyDown);
            // 
            // checkBoxMightRing
            // 
            this.checkBoxMightRing.AutoSize = true;
            this.checkBoxMightRing.Location = new System.Drawing.Point(14, 94);
            this.checkBoxMightRing.Name = "checkBoxMightRing";
            this.checkBoxMightRing.Size = new System.Drawing.Size(96, 17);
            this.checkBoxMightRing.TabIndex = 4;
            this.checkBoxMightRing.Text = "Might Ring  (X)";
            this.checkBoxMightRing.UseVisualStyleBackColor = true;
            // 
            // checkBoxHealingRing
            // 
            this.checkBoxHealingRing.AutoSize = true;
            this.checkBoxHealingRing.Location = new System.Drawing.Point(14, 117);
            this.checkBoxHealingRing.Name = "checkBoxHealingRing";
            this.checkBoxHealingRing.Size = new System.Drawing.Size(103, 17);
            this.checkBoxHealingRing.TabIndex = 3;
            this.checkBoxHealingRing.Text = "Healing Ring (X)";
            this.checkBoxHealingRing.UseVisualStyleBackColor = true;
            // 
            // checkBoxTimeRing
            // 
            this.checkBoxTimeRing.AutoSize = true;
            this.checkBoxTimeRing.Location = new System.Drawing.Point(14, 71);
            this.checkBoxTimeRing.Name = "checkBoxTimeRing";
            this.checkBoxTimeRing.Size = new System.Drawing.Size(93, 17);
            this.checkBoxTimeRing.TabIndex = 2;
            this.checkBoxTimeRing.Text = "Time Ring  (X)";
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
            this.tab_support.Size = new System.Drawing.Size(534, 423);
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
            this.uturaHotkey.Location = new System.Drawing.Point(97, 52);
            this.uturaHotkey.Name = "uturaHotkey";
            this.uturaHotkey.ReadOnly = true;
            this.uturaHotkey.Size = new System.Drawing.Size(37, 20);
            this.uturaHotkey.TabIndex = 7;
            this.uturaHotkey.Text = "HTK";
            this.uturaHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uturaHotkey_KeyDown);
            // 
            // hasteHotkey
            // 
            this.hasteHotkey.Location = new System.Drawing.Point(97, 26);
            this.hasteHotkey.Name = "hasteHotkey";
            this.hasteHotkey.ReadOnly = true;
            this.hasteHotkey.Size = new System.Drawing.Size(37, 20);
            this.hasteHotkey.TabIndex = 6;
            this.hasteHotkey.Text = "HTK";
            this.hasteHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hasteHotkey_KeyDown);
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
            this.poisonHotkey.Location = new System.Drawing.Point(128, 46);
            this.poisonHotkey.Name = "poisonHotkey";
            this.poisonHotkey.ReadOnly = true;
            this.poisonHotkey.Size = new System.Drawing.Size(37, 20);
            this.poisonHotkey.TabIndex = 7;
            this.poisonHotkey.Text = "HTK";
            this.poisonHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.poisonHotkey_KeyDown);
            // 
            // paralyzeHotkey
            // 
            this.paralyzeHotkey.Location = new System.Drawing.Point(128, 24);
            this.paralyzeHotkey.Name = "paralyzeHotkey";
            this.paralyzeHotkey.ReadOnly = true;
            this.paralyzeHotkey.Size = new System.Drawing.Size(37, 20);
            this.paralyzeHotkey.TabIndex = 6;
            this.paralyzeHotkey.Text = "HTK";
            this.paralyzeHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.paralyzeHotkey_KeyDown);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 438);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<name> Tool v.0.0 (first sketch)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.groupBoxAccountStatus.ResumeLayout(false);
            this.groupBoxAccountStatus.PerformLayout();
            this.groupBoxConfigManager.ResumeLayout(false);
            this.tab_heal.ResumeLayout(false);
            this.groupBoxGeneralInfo.ResumeLayout(false);
            this.groupBoxGeneralInfo.PerformLayout();
            this.groupBoxItemHealing.ResumeLayout(false);
            this.groupBoxNewItemHealing.ResumeLayout(false);
            this.groupBoxNewItemHealing.PerformLayout();
            this.groupBoxActiveItems.ResumeLayout(false);
            this.groupBoxSpellHealing.ResumeLayout(false);
            this.groupBoxNewSpellHealing.ResumeLayout(false);
            this.groupBoxNewSpellHealing.PerformLayout();
            this.groupBoxActiveSpellsHealing.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.TabPage tab_heal;
        private System.Windows.Forms.TabPage tab_actions;
        private System.Windows.Forms.TabPage tab_support;
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
        private System.Windows.Forms.GroupBox groupBoxSpellHealing;
        private System.Windows.Forms.GroupBox groupBoxNewSpellHealing;
        private System.Windows.Forms.Button buttonAddNewSpellHealing;
        private System.Windows.Forms.Label labelNewSpellHp;
        private System.Windows.Forms.Label labelNewSpellHotkey;
        private System.Windows.Forms.Label labelNewSpellName;
        private System.Windows.Forms.GroupBox groupBoxActiveSpellsHealing;
        private System.Windows.Forms.Button buttonRemoveSelectedSpellHealing;
        private System.Windows.Forms.Button buttonClearNewSpell;
        private System.Windows.Forms.ListBox listBoxSpellHealingActive;
        private System.Windows.Forms.Button buttonDownSpellHealing;
        private System.Windows.Forms.Button buttonUpSpellHealing;
        private System.Windows.Forms.GroupBox groupBoxConditionHealer;
        private System.Windows.Forms.CheckBox checkBoxParalyze;
        private System.Windows.Forms.CheckBox checkBoxPoison;
        private System.Windows.Forms.GroupBox groupBoxStatusHolder;
        private System.Windows.Forms.CheckBox checkBoxUtura;
        private System.Windows.Forms.CheckBox checkBoxHaste;
        private System.Windows.Forms.GroupBox groupBoxConfigManager;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.GroupBox groupBoxItemHealing;
        private System.Windows.Forms.GroupBox groupBoxNewItemHealing;
        private System.Windows.Forms.Button buttonClearNewItem;
        private System.Windows.Forms.Button buttonAddNewItemHealing;
        private System.Windows.Forms.Label labelNewItemHp;
        private System.Windows.Forms.Label labelNewHotkeyItem;
        private System.Windows.Forms.Label labelNewItemName;
        private System.Windows.Forms.GroupBox groupBoxActiveItems;
        private System.Windows.Forms.ListBox listBoxItemHealingActive;
        private System.Windows.Forms.Button buttonDownItemHealing;
        private System.Windows.Forms.Button buttonUpItemHealing;
        private System.Windows.Forms.Button buttonRemoveSelectedItemHealing;
        private System.Windows.Forms.Label labelNewItemMp;
        private System.Windows.Forms.GroupBox groupBoxManaWaster;
        private System.Windows.Forms.GroupBox groupBoxGeneralInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spellHealingHpValue;
        private System.Windows.Forms.Label labelMaxMp;
        private System.Windows.Forms.Button buttonApplyMaxValues;
        private System.Windows.Forms.Button buttonResetHealing;
        private System.Windows.Forms.TextBox itemHealingMpValue;
        private System.Windows.Forms.TextBox itemHealingHpValue;
        private System.Windows.Forms.ComboBox comboBoxMpBelowOver;
        private System.Windows.Forms.ComboBox comboBoxHpBelowOver;
        public System.Windows.Forms.TextBox maxMpInput;
        public System.Windows.Forms.TextBox maxHpInput;
        private System.Windows.Forms.Label labelNewSpellMpOver;
        private System.Windows.Forms.TextBox spellHealingMpValue;
        private System.Windows.Forms.Button buttonSaveCfgHealer;
        private System.Windows.Forms.Button buttonLoadCfgHealer;
        private System.Windows.Forms.TextBox newSpellHealingHotkey;
        private System.Windows.Forms.TextBox newItemHealingHotkey;
        private System.Windows.Forms.TextBox manaWasterHotkey;
        private System.Windows.Forms.TextBox utanaVidHotkey;
        private System.Windows.Forms.TextBox utamoVitaHotkey;
        private System.Windows.Forms.TextBox eaterHotkey;
        private System.Windows.Forms.TextBox healingRingHotkey;
        private System.Windows.Forms.TextBox mightRingHotkey;
        private System.Windows.Forms.TextBox timeRingHotkey;
        private System.Windows.Forms.TextBox energyRingHotkey;
        private System.Windows.Forms.TextBox lifeRingHotkey;
        private System.Windows.Forms.TextBox mountHtk;
        private System.Windows.Forms.CheckBox checkBoxManaWaster;
        private System.Windows.Forms.TextBox uturaHotkey;
        private System.Windows.Forms.TextBox hasteHotkey;
        private System.Windows.Forms.TextBox poisonHotkey;
        private System.Windows.Forms.TextBox paralyzeHotkey;
        private System.Windows.Forms.ComboBox comboBoxItemName;
        private System.Windows.Forms.ComboBox comboBoxSpellName;
        private System.Windows.Forms.GroupBox groupBoxAccountStatus;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label_daysLeftShow;
        private System.Windows.Forms.Label label_accountStatusShow;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Label label_daysLeft;
        private System.Windows.Forms.Label label_accountStatus;
    }
}

