namespace MGB_one.View
{
    partial class MainFormView
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.pageMain = new System.Windows.Forms.TabPage();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.labelChosenAccountsList = new System.Windows.Forms.Label();
            this.lstChosenAccountsMain = new System.Windows.Forms.ListBox();
            this.labelProcess = new System.Windows.Forms.Label();
            this.cboProcesses = new System.Windows.Forms.ComboBox();
            this.pageAccounts = new System.Windows.Forms.TabPage();
            this.grpGameParameters = new System.Windows.Forms.GroupBox();
            this.labelPointsLeft = new System.Windows.Forms.Label();
            this.btnAccountSet = new System.Windows.Forms.Button();
            this.labelLvl5 = new System.Windows.Forms.Label();
            this.labelLvl4 = new System.Windows.Forms.Label();
            this.labelLvl2 = new System.Windows.Forms.Label();
            this.labelLvl3 = new System.Windows.Forms.Label();
            this.labelLvl1 = new System.Windows.Forms.Label();
            this.txtQuantityLvl5 = new System.Windows.Forms.TextBox();
            this.txtQuantityLvl4 = new System.Windows.Forms.TextBox();
            this.txtQuantityLvl3 = new System.Windows.Forms.TextBox();
            this.txtQuantityLvl2 = new System.Windows.Forms.TextBox();
            this.txtQuantityLvl1 = new System.Windows.Forms.TextBox();
            this.rbtnShootingRange = new System.Windows.Forms.RadioButton();
            this.rbtnLumberMill = new System.Windows.Forms.RadioButton();
            this.rbtnQuarry = new System.Windows.Forms.RadioButton();
            this.rbtnPond = new System.Windows.Forms.RadioButton();
            this.btnAccountEditor = new System.Windows.Forms.Button();
            this.btnAccountMoveDown = new System.Windows.Forms.Button();
            this.btnAccountMoveUp = new System.Windows.Forms.Button();
            this.btnAccountRemove = new System.Windows.Forms.Button();
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.lblAccountsQuantity = new System.Windows.Forms.Label();
            this.lstChosenAccounts = new System.Windows.Forms.ListBox();
            this.labelChosenForGAmeAccounts = new System.Windows.Forms.Label();
            this.labelAvailableAccounts = new System.Windows.Forms.Label();
            this.lstAvailableAccounts = new System.Windows.Forms.ListBox();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.cboShortcutKey = new System.Windows.Forms.ComboBox();
            this.labelShortcutKey = new System.Windows.Forms.Label();
            this.lblSelectedProcessInfo = new System.Windows.Forms.Label();
            this.lblProgramStatusInfo = new System.Windows.Forms.Label();
            this.labelProgramStatus = new System.Windows.Forms.Label();
            this.labelSelectedProcess = new System.Windows.Forms.Label();
            this.txtPointsLeft = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.pageAccounts.SuspendLayout();
            this.grpGameParameters.SuspendLayout();
            this.pageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.pageMain);
            this.tabControlMain.Controls.Add(this.pageAccounts);
            this.tabControlMain.Controls.Add(this.pageSettings);
            this.tabControlMain.Location = new System.Drawing.Point(0, 35);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(243, 423);
            this.tabControlMain.TabIndex = 0;
            // 
            // pageMain
            // 
            this.pageMain.Controls.Add(this.btnStartStop);
            this.pageMain.Controls.Add(this.labelChosenAccountsList);
            this.pageMain.Controls.Add(this.lstChosenAccountsMain);
            this.pageMain.Controls.Add(this.labelProcess);
            this.pageMain.Controls.Add(this.cboProcesses);
            this.pageMain.Location = new System.Drawing.Point(4, 22);
            this.pageMain.Name = "pageMain";
            this.pageMain.Padding = new System.Windows.Forms.Padding(3);
            this.pageMain.Size = new System.Drawing.Size(235, 397);
            this.pageMain.TabIndex = 0;
            this.pageMain.Text = "Main";
            this.pageMain.UseVisualStyleBackColor = true;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(6, 341);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(223, 50);
            this.btnStartStop.TabIndex = 8;
            this.btnStartStop.Text = "START";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // labelChosenAccountsList
            // 
            this.labelChosenAccountsList.AutoSize = true;
            this.labelChosenAccountsList.Location = new System.Drawing.Point(3, 30);
            this.labelChosenAccountsList.Name = "labelChosenAccountsList";
            this.labelChosenAccountsList.Size = new System.Drawing.Size(113, 13);
            this.labelChosenAccountsList.TabIndex = 7;
            this.labelChosenAccountsList.Text = "Chosen Accounts List:";
            // 
            // lstChosenAccountsMain
            // 
            this.lstChosenAccountsMain.FormattingEnabled = true;
            this.lstChosenAccountsMain.Location = new System.Drawing.Point(3, 45);
            this.lstChosenAccountsMain.Name = "lstChosenAccountsMain";
            this.lstChosenAccountsMain.Size = new System.Drawing.Size(230, 95);
            this.lstChosenAccountsMain.TabIndex = 6;
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(3, 10);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(48, 13);
            this.labelProcess.TabIndex = 5;
            this.labelProcess.Text = "Process:";
            // 
            // cboProcesses
            // 
            this.cboProcesses.FormattingEnabled = true;
            this.cboProcesses.Location = new System.Drawing.Point(50, 7);
            this.cboProcesses.Name = "cboProcesses";
            this.cboProcesses.Size = new System.Drawing.Size(175, 21);
            this.cboProcesses.TabIndex = 0;
            // 
            // pageAccounts
            // 
            this.pageAccounts.Controls.Add(this.grpGameParameters);
            this.pageAccounts.Controls.Add(this.btnAccountEditor);
            this.pageAccounts.Controls.Add(this.btnAccountMoveDown);
            this.pageAccounts.Controls.Add(this.btnAccountMoveUp);
            this.pageAccounts.Controls.Add(this.btnAccountRemove);
            this.pageAccounts.Controls.Add(this.btnAccountAdd);
            this.pageAccounts.Controls.Add(this.lblAccountsQuantity);
            this.pageAccounts.Controls.Add(this.lstChosenAccounts);
            this.pageAccounts.Controls.Add(this.labelChosenForGAmeAccounts);
            this.pageAccounts.Controls.Add(this.labelAvailableAccounts);
            this.pageAccounts.Controls.Add(this.lstAvailableAccounts);
            this.pageAccounts.Location = new System.Drawing.Point(4, 22);
            this.pageAccounts.Name = "pageAccounts";
            this.pageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.pageAccounts.Size = new System.Drawing.Size(235, 397);
            this.pageAccounts.TabIndex = 2;
            this.pageAccounts.Text = "Accounts";
            this.pageAccounts.UseVisualStyleBackColor = true;
            // 
            // grpGameParameters
            // 
            this.grpGameParameters.Controls.Add(this.txtPointsLeft);
            this.grpGameParameters.Controls.Add(this.labelPointsLeft);
            this.grpGameParameters.Controls.Add(this.btnAccountSet);
            this.grpGameParameters.Controls.Add(this.labelLvl5);
            this.grpGameParameters.Controls.Add(this.labelLvl4);
            this.grpGameParameters.Controls.Add(this.labelLvl2);
            this.grpGameParameters.Controls.Add(this.labelLvl3);
            this.grpGameParameters.Controls.Add(this.labelLvl1);
            this.grpGameParameters.Controls.Add(this.txtQuantityLvl5);
            this.grpGameParameters.Controls.Add(this.txtQuantityLvl4);
            this.grpGameParameters.Controls.Add(this.txtQuantityLvl3);
            this.grpGameParameters.Controls.Add(this.txtQuantityLvl2);
            this.grpGameParameters.Controls.Add(this.txtQuantityLvl1);
            this.grpGameParameters.Controls.Add(this.rbtnShootingRange);
            this.grpGameParameters.Controls.Add(this.rbtnLumberMill);
            this.grpGameParameters.Controls.Add(this.rbtnQuarry);
            this.grpGameParameters.Controls.Add(this.rbtnPond);
            this.grpGameParameters.Location = new System.Drawing.Point(3, 291);
            this.grpGameParameters.Name = "grpGameParameters";
            this.grpGameParameters.Size = new System.Drawing.Size(229, 100);
            this.grpGameParameters.TabIndex = 13;
            this.grpGameParameters.TabStop = false;
            this.grpGameParameters.Text = "Game parameters";
            // 
            // labelPointsLeft
            // 
            this.labelPointsLeft.Location = new System.Drawing.Point(156, 58);
            this.labelPointsLeft.Name = "labelPointsLeft";
            this.labelPointsLeft.Size = new System.Drawing.Size(56, 13);
            this.labelPointsLeft.TabIndex = 14;
            this.labelPointsLeft.Text = "Pts left:";
            // 
            // btnAccountSet
            // 
            this.btnAccountSet.Location = new System.Drawing.Point(159, 77);
            this.btnAccountSet.Name = "btnAccountSet";
            this.btnAccountSet.Size = new System.Drawing.Size(70, 23);
            this.btnAccountSet.TabIndex = 16;
            this.btnAccountSet.Text = "Set";
            this.btnAccountSet.UseVisualStyleBackColor = true;
            // 
            // labelLvl5
            // 
            this.labelLvl5.AutoSize = true;
            this.labelLvl5.Location = new System.Drawing.Point(91, 58);
            this.labelLvl5.Name = "labelLvl5";
            this.labelLvl5.Size = new System.Drawing.Size(29, 13);
            this.labelLvl5.TabIndex = 13;
            this.labelLvl5.Text = "lvl 5:";
            // 
            // labelLvl4
            // 
            this.labelLvl4.AutoSize = true;
            this.labelLvl4.Location = new System.Drawing.Point(158, 38);
            this.labelLvl4.Name = "labelLvl4";
            this.labelLvl4.Size = new System.Drawing.Size(29, 13);
            this.labelLvl4.TabIndex = 12;
            this.labelLvl4.Text = "lvl 4:";
            // 
            // labelLvl2
            // 
            this.labelLvl2.AutoSize = true;
            this.labelLvl2.Location = new System.Drawing.Point(158, 17);
            this.labelLvl2.Name = "labelLvl2";
            this.labelLvl2.Size = new System.Drawing.Size(29, 13);
            this.labelLvl2.TabIndex = 11;
            this.labelLvl2.Text = "lvl 2:";
            // 
            // labelLvl3
            // 
            this.labelLvl3.AutoSize = true;
            this.labelLvl3.Location = new System.Drawing.Point(91, 38);
            this.labelLvl3.Name = "labelLvl3";
            this.labelLvl3.Size = new System.Drawing.Size(29, 13);
            this.labelLvl3.TabIndex = 10;
            this.labelLvl3.Text = "lvl 3:";
            // 
            // labelLvl1
            // 
            this.labelLvl1.AutoSize = true;
            this.labelLvl1.Location = new System.Drawing.Point(91, 17);
            this.labelLvl1.Name = "labelLvl1";
            this.labelLvl1.Size = new System.Drawing.Size(29, 13);
            this.labelLvl1.TabIndex = 9;
            this.labelLvl1.Text = "lvl 1:";
            // 
            // txtQuantityLvl5
            // 
            this.txtQuantityLvl5.Location = new System.Drawing.Point(120, 55);
            this.txtQuantityLvl5.Name = "txtQuantityLvl5";
            this.txtQuantityLvl5.Size = new System.Drawing.Size(36, 20);
            this.txtQuantityLvl5.TabIndex = 8;
            this.txtQuantityLvl5.Text = "20";
            this.txtQuantityLvl5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantityLvl5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantityLvl5_KeyUp);
            // 
            // txtQuantityLvl4
            // 
            this.txtQuantityLvl4.Location = new System.Drawing.Point(187, 35);
            this.txtQuantityLvl4.Name = "txtQuantityLvl4";
            this.txtQuantityLvl4.Size = new System.Drawing.Size(36, 20);
            this.txtQuantityLvl4.TabIndex = 7;
            this.txtQuantityLvl4.Text = "0";
            this.txtQuantityLvl4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantityLvl4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantityLvl4_KeyUp);
            // 
            // txtQuantityLvl3
            // 
            this.txtQuantityLvl3.Location = new System.Drawing.Point(120, 35);
            this.txtQuantityLvl3.Name = "txtQuantityLvl3";
            this.txtQuantityLvl3.Size = new System.Drawing.Size(36, 20);
            this.txtQuantityLvl3.TabIndex = 6;
            this.txtQuantityLvl3.Text = "0";
            this.txtQuantityLvl3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantityLvl3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantityLvl3_KeyUp);
            // 
            // txtQuantityLvl2
            // 
            this.txtQuantityLvl2.Location = new System.Drawing.Point(187, 15);
            this.txtQuantityLvl2.Name = "txtQuantityLvl2";
            this.txtQuantityLvl2.Size = new System.Drawing.Size(36, 20);
            this.txtQuantityLvl2.TabIndex = 5;
            this.txtQuantityLvl2.Text = "0";
            this.txtQuantityLvl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantityLvl2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantityLvl2_KeyUp);
            // 
            // txtQuantityLvl1
            // 
            this.txtQuantityLvl1.Location = new System.Drawing.Point(120, 15);
            this.txtQuantityLvl1.Name = "txtQuantityLvl1";
            this.txtQuantityLvl1.Size = new System.Drawing.Size(36, 20);
            this.txtQuantityLvl1.TabIndex = 4;
            this.txtQuantityLvl1.Text = "0";
            this.txtQuantityLvl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantityLvl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantityLvl1_KeyUp);
            // 
            // rbtnShootingRange
            // 
            this.rbtnShootingRange.AutoSize = true;
            this.rbtnShootingRange.Checked = true;
            this.rbtnShootingRange.Location = new System.Drawing.Point(5, 75);
            this.rbtnShootingRange.Name = "rbtnShootingRange";
            this.rbtnShootingRange.Size = new System.Drawing.Size(96, 17);
            this.rbtnShootingRange.TabIndex = 3;
            this.rbtnShootingRange.TabStop = true;
            this.rbtnShootingRange.Text = "Shooting range";
            this.rbtnShootingRange.UseVisualStyleBackColor = true;
            // 
            // rbtnLumberMill
            // 
            this.rbtnLumberMill.AutoSize = true;
            this.rbtnLumberMill.Location = new System.Drawing.Point(5, 55);
            this.rbtnLumberMill.Name = "rbtnLumberMill";
            this.rbtnLumberMill.Size = new System.Drawing.Size(76, 17);
            this.rbtnLumberMill.TabIndex = 2;
            this.rbtnLumberMill.Text = "Lumber mill";
            this.rbtnLumberMill.UseVisualStyleBackColor = true;
            // 
            // rbtnQuarry
            // 
            this.rbtnQuarry.AutoSize = true;
            this.rbtnQuarry.Location = new System.Drawing.Point(5, 35);
            this.rbtnQuarry.Name = "rbtnQuarry";
            this.rbtnQuarry.Size = new System.Drawing.Size(55, 17);
            this.rbtnQuarry.TabIndex = 1;
            this.rbtnQuarry.Text = "Quarry";
            this.rbtnQuarry.UseVisualStyleBackColor = true;
            // 
            // rbtnPond
            // 
            this.rbtnPond.AutoSize = true;
            this.rbtnPond.Location = new System.Drawing.Point(5, 15);
            this.rbtnPond.Name = "rbtnPond";
            this.rbtnPond.Size = new System.Drawing.Size(49, 17);
            this.rbtnPond.TabIndex = 0;
            this.rbtnPond.Text = "Pond";
            this.rbtnPond.UseVisualStyleBackColor = true;
            // 
            // btnAccountEditor
            // 
            this.btnAccountEditor.Location = new System.Drawing.Point(162, 120);
            this.btnAccountEditor.Name = "btnAccountEditor";
            this.btnAccountEditor.Size = new System.Drawing.Size(70, 23);
            this.btnAccountEditor.TabIndex = 12;
            this.btnAccountEditor.Text = "Editor";
            this.btnAccountEditor.UseVisualStyleBackColor = true;
            this.btnAccountEditor.Click += new System.EventHandler(this.btnAccountEditor_Click);
            // 
            // btnAccountMoveDown
            // 
            this.btnAccountMoveDown.Enabled = false;
            this.btnAccountMoveDown.Location = new System.Drawing.Point(79, 265);
            this.btnAccountMoveDown.Name = "btnAccountMoveDown";
            this.btnAccountMoveDown.Size = new System.Drawing.Size(72, 23);
            this.btnAccountMoveDown.TabIndex = 11;
            this.btnAccountMoveDown.Text = "Move down";
            this.btnAccountMoveDown.UseVisualStyleBackColor = true;
            // 
            // btnAccountMoveUp
            // 
            this.btnAccountMoveUp.Enabled = false;
            this.btnAccountMoveUp.Location = new System.Drawing.Point(3, 265);
            this.btnAccountMoveUp.Name = "btnAccountMoveUp";
            this.btnAccountMoveUp.Size = new System.Drawing.Size(70, 23);
            this.btnAccountMoveUp.TabIndex = 10;
            this.btnAccountMoveUp.Text = "Move up";
            this.btnAccountMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnAccountRemove
            // 
            this.btnAccountRemove.Enabled = false;
            this.btnAccountRemove.Location = new System.Drawing.Point(79, 120);
            this.btnAccountRemove.Name = "btnAccountRemove";
            this.btnAccountRemove.Size = new System.Drawing.Size(70, 23);
            this.btnAccountRemove.TabIndex = 9;
            this.btnAccountRemove.Text = "Remove";
            this.btnAccountRemove.UseVisualStyleBackColor = true;
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.Enabled = false;
            this.btnAccountAdd.Location = new System.Drawing.Point(3, 120);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(70, 23);
            this.btnAccountAdd.TabIndex = 8;
            this.btnAccountAdd.Text = "Add ";
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // lblAccountsQuantity
            // 
            this.lblAccountsQuantity.AutoSize = true;
            this.lblAccountsQuantity.Location = new System.Drawing.Point(204, 148);
            this.lblAccountsQuantity.Name = "lblAccountsQuantity";
            this.lblAccountsQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccountsQuantity.Size = new System.Drawing.Size(25, 13);
            this.lblAccountsQuantity.TabIndex = 6;
            this.lblAccountsQuantity.Text = "[ 0 ]";
            // 
            // lstChosenAccounts
            // 
            this.lstChosenAccounts.FormattingEnabled = true;
            this.lstChosenAccounts.Location = new System.Drawing.Point(3, 164);
            this.lstChosenAccounts.Name = "lstChosenAccounts";
            this.lstChosenAccounts.Size = new System.Drawing.Size(229, 95);
            this.lstChosenAccounts.TabIndex = 5;
            // 
            // labelChosenForGAmeAccounts
            // 
            this.labelChosenForGAmeAccounts.AutoSize = true;
            this.labelChosenForGAmeAccounts.Location = new System.Drawing.Point(3, 148);
            this.labelChosenForGAmeAccounts.Name = "labelChosenForGAmeAccounts";
            this.labelChosenForGAmeAccounts.Size = new System.Drawing.Size(137, 13);
            this.labelChosenForGAmeAccounts.TabIndex = 4;
            this.labelChosenForGAmeAccounts.Text = "Chosen for game accounts:";
            // 
            // labelAvailableAccounts
            // 
            this.labelAvailableAccounts.AutoSize = true;
            this.labelAvailableAccounts.Location = new System.Drawing.Point(3, 3);
            this.labelAvailableAccounts.Name = "labelAvailableAccounts";
            this.labelAvailableAccounts.Size = new System.Drawing.Size(100, 13);
            this.labelAvailableAccounts.TabIndex = 3;
            this.labelAvailableAccounts.Text = "Available accounts:";
            // 
            // lstAvailableAccounts
            // 
            this.lstAvailableAccounts.FormattingEnabled = true;
            this.lstAvailableAccounts.Location = new System.Drawing.Point(3, 19);
            this.lstAvailableAccounts.Name = "lstAvailableAccounts";
            this.lstAvailableAccounts.Size = new System.Drawing.Size(229, 95);
            this.lstAvailableAccounts.TabIndex = 2;
            // 
            // pageSettings
            // 
            this.pageSettings.Controls.Add(this.cboShortcutKey);
            this.pageSettings.Controls.Add(this.labelShortcutKey);
            this.pageSettings.Location = new System.Drawing.Point(4, 22);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pageSettings.Size = new System.Drawing.Size(235, 397);
            this.pageSettings.TabIndex = 1;
            this.pageSettings.Text = "Settings";
            this.pageSettings.UseVisualStyleBackColor = true;
            // 
            // cboShortcutKey
            // 
            this.cboShortcutKey.FormattingEnabled = true;
            this.cboShortcutKey.Location = new System.Drawing.Point(105, 9);
            this.cboShortcutKey.Name = "cboShortcutKey";
            this.cboShortcutKey.Size = new System.Drawing.Size(121, 21);
            this.cboShortcutKey.TabIndex = 1;
            // 
            // labelShortcutKey
            // 
            this.labelShortcutKey.AutoSize = true;
            this.labelShortcutKey.Location = new System.Drawing.Point(7, 12);
            this.labelShortcutKey.Name = "labelShortcutKey";
            this.labelShortcutKey.Size = new System.Drawing.Size(70, 13);
            this.labelShortcutKey.TabIndex = 0;
            this.labelShortcutKey.Text = "Shortcut key:";
            // 
            // lblSelectedProcessInfo
            // 
            this.lblSelectedProcessInfo.AutoSize = true;
            this.lblSelectedProcessInfo.ForeColor = System.Drawing.Color.Brown;
            this.lblSelectedProcessInfo.Location = new System.Drawing.Point(90, 20);
            this.lblSelectedProcessInfo.Name = "lblSelectedProcessInfo";
            this.lblSelectedProcessInfo.Size = new System.Drawing.Size(114, 13);
            this.lblSelectedProcessInfo.TabIndex = 1;
            this.lblSelectedProcessInfo.Text = "<no process selected>";
            // 
            // lblProgramStatusInfo
            // 
            this.lblProgramStatusInfo.AutoSize = true;
            this.lblProgramStatusInfo.ForeColor = System.Drawing.Color.Brown;
            this.lblProgramStatusInfo.Location = new System.Drawing.Point(90, 5);
            this.lblProgramStatusInfo.Name = "lblProgramStatusInfo";
            this.lblProgramStatusInfo.Size = new System.Drawing.Size(73, 13);
            this.lblProgramStatusInfo.TabIndex = 2;
            this.lblProgramStatusInfo.Text = "<uninitialized>";
            // 
            // labelProgramStatus
            // 
            this.labelProgramStatus.AutoSize = true;
            this.labelProgramStatus.Location = new System.Drawing.Point(1, 5);
            this.labelProgramStatus.Name = "labelProgramStatus";
            this.labelProgramStatus.Size = new System.Drawing.Size(80, 13);
            this.labelProgramStatus.TabIndex = 3;
            this.labelProgramStatus.Text = "Program status:";
            // 
            // labelSelectedProcess
            // 
            this.labelSelectedProcess.AutoSize = true;
            this.labelSelectedProcess.Location = new System.Drawing.Point(1, 20);
            this.labelSelectedProcess.Name = "labelSelectedProcess";
            this.labelSelectedProcess.Size = new System.Drawing.Size(92, 13);
            this.labelSelectedProcess.TabIndex = 4;
            this.labelSelectedProcess.Text = "Selected process:";
            // 
            // txtPointsLeft
            // 
            this.txtPointsLeft.Location = new System.Drawing.Point(198, 55);
            this.txtPointsLeft.Name = "txtPointsLeft";
            this.txtPointsLeft.Size = new System.Drawing.Size(25, 20);
            this.txtPointsLeft.TabIndex = 17;
            this.txtPointsLeft.Text = "0";
            this.txtPointsLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 470);
            this.Controls.Add(this.labelSelectedProcess);
            this.Controls.Add(this.labelProgramStatus);
            this.Controls.Add(this.lblProgramStatusInfo);
            this.Controls.Add(this.lblSelectedProcessInfo);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainFormView";
            this.Text = "MGB v1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageMain.PerformLayout();
            this.pageAccounts.ResumeLayout(false);
            this.pageAccounts.PerformLayout();
            this.grpGameParameters.ResumeLayout(false);
            this.grpGameParameters.PerformLayout();
            this.pageSettings.ResumeLayout(false);
            this.pageSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage pageMain;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.Label lblSelectedProcessInfo;
        private System.Windows.Forms.Label lblProgramStatusInfo;
        private System.Windows.Forms.Label labelProgramStatus;
        private System.Windows.Forms.Label labelSelectedProcess;
        private System.Windows.Forms.ListBox lstChosenAccountsMain;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.ComboBox cboProcesses;
        private System.Windows.Forms.TabPage pageAccounts;
        private System.Windows.Forms.Label labelChosenAccountsList;
        private System.Windows.Forms.Label lblAccountsQuantity;
        private System.Windows.Forms.ListBox lstChosenAccounts;
        private System.Windows.Forms.Label labelChosenForGAmeAccounts;
        private System.Windows.Forms.Label labelAvailableAccounts;
        private System.Windows.Forms.ListBox lstAvailableAccounts;
        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.ComboBox cboShortcutKey;
        private System.Windows.Forms.Label labelShortcutKey;
        private System.Windows.Forms.GroupBox grpGameParameters;
        private System.Windows.Forms.Label labelPointsLeft;
        private System.Windows.Forms.Label labelLvl5;
        private System.Windows.Forms.Label labelLvl4;
        private System.Windows.Forms.Label labelLvl2;
        private System.Windows.Forms.Label labelLvl3;
        private System.Windows.Forms.Label labelLvl1;
        private System.Windows.Forms.TextBox txtQuantityLvl5;
        private System.Windows.Forms.TextBox txtQuantityLvl4;
        private System.Windows.Forms.TextBox txtQuantityLvl3;
        private System.Windows.Forms.TextBox txtQuantityLvl2;
        private System.Windows.Forms.TextBox txtQuantityLvl1;
        private System.Windows.Forms.RadioButton rbtnShootingRange;
        private System.Windows.Forms.RadioButton rbtnLumberMill;
        private System.Windows.Forms.RadioButton rbtnQuarry;
        private System.Windows.Forms.RadioButton rbtnPond;
        private System.Windows.Forms.Button btnAccountEditor;
        private System.Windows.Forms.Button btnAccountMoveDown;
        private System.Windows.Forms.Button btnAccountMoveUp;
        private System.Windows.Forms.Button btnAccountRemove;
        private System.Windows.Forms.Button btnAccountSet;
        private System.Windows.Forms.TextBox txtPointsLeft;
    }
}

