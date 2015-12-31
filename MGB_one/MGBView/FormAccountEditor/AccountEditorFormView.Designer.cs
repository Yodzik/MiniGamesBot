namespace MGB_one.View
{
    partial class AccountEditorFormView
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
            this.grpEditorAccountDetails = new System.Windows.Forms.GroupBox();
            this.BtnEditorAccountRemove = new System.Windows.Forms.Button();
            this.btnEditorAccountChange = new System.Windows.Forms.Button();
            this.btnEditorAccountAdd = new System.Windows.Forms.Button();
            this.grpEditorLoginPosition = new System.Windows.Forms.GroupBox();
            this.rbtnLoginPos3 = new System.Windows.Forms.RadioButton();
            this.rbtnLoginPos2 = new System.Windows.Forms.RadioButton();
            this.rbtnLoginPos1 = new System.Windows.Forms.RadioButton();
            this.txtEditorAccountPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtEditorAccountLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.txtEditorAccountName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.lstEditorAvailableAccounts = new System.Windows.Forms.ListBox();
            this.labelAvailableAccountsList = new System.Windows.Forms.Label();
            this.lblEditorHint = new System.Windows.Forms.Label();
            this.grpEditorAccountDetails.SuspendLayout();
            this.grpEditorLoginPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEditorAccountDetails
            // 
            this.grpEditorAccountDetails.Controls.Add(this.BtnEditorAccountRemove);
            this.grpEditorAccountDetails.Controls.Add(this.btnEditorAccountChange);
            this.grpEditorAccountDetails.Controls.Add(this.btnEditorAccountAdd);
            this.grpEditorAccountDetails.Controls.Add(this.grpEditorLoginPosition);
            this.grpEditorAccountDetails.Controls.Add(this.txtEditorAccountPassword);
            this.grpEditorAccountDetails.Controls.Add(this.labelPassword);
            this.grpEditorAccountDetails.Controls.Add(this.txtEditorAccountLogin);
            this.grpEditorAccountDetails.Controls.Add(this.labelLogin);
            this.grpEditorAccountDetails.Controls.Add(this.txtEditorAccountName);
            this.grpEditorAccountDetails.Controls.Add(this.labelName);
            this.grpEditorAccountDetails.Location = new System.Drawing.Point(0, 10);
            this.grpEditorAccountDetails.Name = "grpEditorAccountDetails";
            this.grpEditorAccountDetails.Size = new System.Drawing.Size(230, 123);
            this.grpEditorAccountDetails.TabIndex = 2;
            this.grpEditorAccountDetails.TabStop = false;
            this.grpEditorAccountDetails.Text = "Account details:";
            // 
            // BtnEditorAccountRemove
            // 
            this.BtnEditorAccountRemove.Location = new System.Drawing.Point(166, 93);
            this.BtnEditorAccountRemove.Name = "BtnEditorAccountRemove";
            this.BtnEditorAccountRemove.Size = new System.Drawing.Size(60, 23);
            this.BtnEditorAccountRemove.TabIndex = 11;
            this.BtnEditorAccountRemove.Text = "Remove";
            this.BtnEditorAccountRemove.UseVisualStyleBackColor = true;
            this.BtnEditorAccountRemove.Click += new System.EventHandler(this.BtnEditorAccountRemove_Click);
            // 
            // btnEditorAccountChange
            // 
            this.btnEditorAccountChange.Location = new System.Drawing.Point(166, 52);
            this.btnEditorAccountChange.Name = "btnEditorAccountChange";
            this.btnEditorAccountChange.Size = new System.Drawing.Size(60, 23);
            this.btnEditorAccountChange.TabIndex = 10;
            this.btnEditorAccountChange.Text = "Change";
            this.btnEditorAccountChange.UseVisualStyleBackColor = true;
            this.btnEditorAccountChange.Click += new System.EventHandler(this.btnEditorAccountChange_Click);
            // 
            // btnEditorAccountAdd
            // 
            this.btnEditorAccountAdd.Location = new System.Drawing.Point(166, 13);
            this.btnEditorAccountAdd.Name = "btnEditorAccountAdd";
            this.btnEditorAccountAdd.Size = new System.Drawing.Size(60, 23);
            this.btnEditorAccountAdd.TabIndex = 9;
            this.btnEditorAccountAdd.Text = "Add";
            this.btnEditorAccountAdd.UseVisualStyleBackColor = true;
            this.btnEditorAccountAdd.Click += new System.EventHandler(this.btnEditorAccountAdd_Click);
            // 
            // grpEditorLoginPosition
            // 
            this.grpEditorLoginPosition.Controls.Add(this.rbtnLoginPos3);
            this.grpEditorLoginPosition.Controls.Add(this.rbtnLoginPos2);
            this.grpEditorLoginPosition.Controls.Add(this.rbtnLoginPos1);
            this.grpEditorLoginPosition.Location = new System.Drawing.Point(8, 81);
            this.grpEditorLoginPosition.Name = "grpEditorLoginPosition";
            this.grpEditorLoginPosition.Size = new System.Drawing.Size(152, 36);
            this.grpEditorLoginPosition.TabIndex = 7;
            this.grpEditorLoginPosition.TabStop = false;
            this.grpEditorLoginPosition.Text = "Character login position";
            // 
            // rbtnLoginPos3
            // 
            this.rbtnLoginPos3.AutoSize = true;
            this.rbtnLoginPos3.Location = new System.Drawing.Point(85, 15);
            this.rbtnLoginPos3.Name = "rbtnLoginPos3";
            this.rbtnLoginPos3.Size = new System.Drawing.Size(30, 17);
            this.rbtnLoginPos3.TabIndex = 2;
            this.rbtnLoginPos3.TabStop = true;
            this.rbtnLoginPos3.Text = "3";
            this.rbtnLoginPos3.UseVisualStyleBackColor = true;
            // 
            // rbtnLoginPos2
            // 
            this.rbtnLoginPos2.AutoSize = true;
            this.rbtnLoginPos2.Location = new System.Drawing.Point(45, 15);
            this.rbtnLoginPos2.Name = "rbtnLoginPos2";
            this.rbtnLoginPos2.Size = new System.Drawing.Size(30, 17);
            this.rbtnLoginPos2.TabIndex = 1;
            this.rbtnLoginPos2.TabStop = true;
            this.rbtnLoginPos2.Text = "2";
            this.rbtnLoginPos2.UseVisualStyleBackColor = true;
            // 
            // rbtnLoginPos1
            // 
            this.rbtnLoginPos1.AutoSize = true;
            this.rbtnLoginPos1.Location = new System.Drawing.Point(5, 15);
            this.rbtnLoginPos1.Name = "rbtnLoginPos1";
            this.rbtnLoginPos1.Size = new System.Drawing.Size(30, 17);
            this.rbtnLoginPos1.TabIndex = 0;
            this.rbtnLoginPos1.TabStop = true;
            this.rbtnLoginPos1.Text = "1";
            this.rbtnLoginPos1.UseVisualStyleBackColor = true;
            // 
            // txtEditorAccountPassword
            // 
            this.txtEditorAccountPassword.Location = new System.Drawing.Point(60, 55);
            this.txtEditorAccountPassword.Name = "txtEditorAccountPassword";
            this.txtEditorAccountPassword.Size = new System.Drawing.Size(100, 20);
            this.txtEditorAccountPassword.TabIndex = 6;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(5, 58);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            // 
            // txtEditorAccountLogin
            // 
            this.txtEditorAccountLogin.Location = new System.Drawing.Point(60, 35);
            this.txtEditorAccountLogin.Name = "txtEditorAccountLogin";
            this.txtEditorAccountLogin.Size = new System.Drawing.Size(100, 20);
            this.txtEditorAccountLogin.TabIndex = 4;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(5, 38);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login:";
            // 
            // txtEditorAccountName
            // 
            this.txtEditorAccountName.Location = new System.Drawing.Point(60, 15);
            this.txtEditorAccountName.Name = "txtEditorAccountName";
            this.txtEditorAccountName.Size = new System.Drawing.Size(100, 20);
            this.txtEditorAccountName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // lstEditorAvailableAccounts
            // 
            this.lstEditorAvailableAccounts.FormattingEnabled = true;
            this.lstEditorAvailableAccounts.Location = new System.Drawing.Point(0, 155);
            this.lstEditorAvailableAccounts.Name = "lstEditorAvailableAccounts";
            this.lstEditorAvailableAccounts.Size = new System.Drawing.Size(230, 186);
            this.lstEditorAvailableAccounts.TabIndex = 3;
            this.lstEditorAvailableAccounts.SelectedIndexChanged += new System.EventHandler(this.lstEditorAvailableAccounts_SelectedIndexChanged);
            // 
            // labelAvailableAccountsList
            // 
            this.labelAvailableAccountsList.AutoSize = true;
            this.labelAvailableAccountsList.Location = new System.Drawing.Point(-3, 136);
            this.labelAvailableAccountsList.Name = "labelAvailableAccountsList";
            this.labelAvailableAccountsList.Size = new System.Drawing.Size(115, 13);
            this.labelAvailableAccountsList.TabIndex = 4;
            this.labelAvailableAccountsList.Text = "Available accounts list:";
            // 
            // lblEditorHint
            // 
            this.lblEditorHint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEditorHint.AutoSize = true;
            this.lblEditorHint.ForeColor = System.Drawing.Color.Orange;
            this.lblEditorHint.Location = new System.Drawing.Point(28, 344);
            this.lblEditorHint.Name = "lblEditorHint";
            this.lblEditorHint.Size = new System.Drawing.Size(169, 13);
            this.lblEditorHint.TabIndex = 5;
            this.lblEditorHint.Text = "<Fill all fields to add new account>";
            // 
            // AccountEditorFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 363);
            this.Controls.Add(this.lblEditorHint);
            this.Controls.Add(this.labelAvailableAccountsList);
            this.Controls.Add(this.lstEditorAvailableAccounts);
            this.Controls.Add(this.grpEditorAccountDetails);
            this.Name = "AccountEditorFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AccountEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountEditorFormView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountEditorFormView_FormClosed);
            this.Load += new System.EventHandler(this.AccountEditorFormView_Load);
            this.grpEditorAccountDetails.ResumeLayout(false);
            this.grpEditorAccountDetails.PerformLayout();
            this.grpEditorLoginPosition.ResumeLayout(false);
            this.grpEditorLoginPosition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditorAccountDetails;
        private System.Windows.Forms.Button BtnEditorAccountRemove;
        private System.Windows.Forms.Button btnEditorAccountChange;
        private System.Windows.Forms.Button btnEditorAccountAdd;
        private System.Windows.Forms.GroupBox grpEditorLoginPosition;
        private System.Windows.Forms.RadioButton rbtnLoginPos3;
        private System.Windows.Forms.RadioButton rbtnLoginPos2;
        private System.Windows.Forms.RadioButton rbtnLoginPos1;
        private System.Windows.Forms.TextBox txtEditorAccountPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtEditorAccountLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox txtEditorAccountName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox lstEditorAvailableAccounts;
        private System.Windows.Forms.Label labelAvailableAccountsList;
        private System.Windows.Forms.Label lblEditorHint;
    }
}