using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MGB_one.View
{
    public partial class AccountEditorFormView : Form, IMGBAccountEditorView
    {
        private BindingSource _baseAccountBindingList = new BindingSource();
        private List<string> _baseAccountList;

        public event EventHandler BaseAccountListIndexChanged;
        public event EventHandler BaseAccountAddToList;
        public event EventHandler BaseAccountChangeSelected;
        public event EventHandler BaseAccountRemoveFromList;
        public event EventHandler BaseAccountSaveToFile;

        public string AccountName
        {
            get { return this.txtEditorAccountName.Text; }
            set { this.txtEditorAccountName.Text = value; }
        }
        public string AccountLogin
        {
            get { return this.txtEditorAccountLogin.Text; }
            set { this.txtEditorAccountLogin.Text = value; }
        }
        public string AccountPassword
        {
            get { return this.txtEditorAccountPassword.Text; }
            set { this.txtEditorAccountPassword.Text = value; }
        }
        public byte AccountPosition
        {
            get
            {
                if (this.rbtnLoginPos1.Checked) return 1;
                else if (this.rbtnLoginPos2.Checked) return 2;
                else if (this.rbtnLoginPos3.Checked) return 3;
                else return 0;
            }
            set
            {
                switch (value)
                {
                    case 1:
                        this.rbtnLoginPos1.Checked = true;
                        break;
                    case 2:
                        this.rbtnLoginPos2.Checked = true;
                        break;
                    case 3:
                        this.rbtnLoginPos3.Checked = true;
                        break;
                    default:
                        this.rbtnLoginPos1.Checked = false;
                        this.rbtnLoginPos2.Checked = false;
                        this.rbtnLoginPos3.Checked = false;
                        break;
                }
            }
        }
        public string HintText
        {
            //get { return this.lblEditorHint.Text; }
            set { this.lblEditorHint.Text = value; }
        }
        public int SelectedIndex
        {
            get { return this.lstEditorAvailableAccounts.SelectedIndex; }
            set { this.lstEditorAvailableAccounts.SelectedIndex = value; }
        }        
        

        public AccountEditorFormView()
        {
            this._baseAccountList = new List<string>();
            InitializeComponent();
        }        

        public void ShowView(IMGBMainView owner)
        {
            this.Show((Form)owner);
        }

        public void ShowOwnerView()
        {
            this.Owner.Show();
        }

        public void DisplayMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        public bool DisplayYesNoQuestion(string message, string title)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public MyDialogResult DisplayYesNoCancelQuestion(string message, string title)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Cancel:
                    return MyDialogResult.Cancel;
                case DialogResult.Yes:
                    return MyDialogResult.Yes;
                case DialogResult.No:
                    return MyDialogResult.No;
                default:
                    return MyDialogResult.No;
            }
        }

        public void SetBaseAccountList(List<string> source)
        {
            this._baseAccountList = source;
            this.RefreshBaseAccountView();
        }

        private void RefreshBaseAccountView()
        {
            this._baseAccountBindingList.DataSource = this._baseAccountList;
        }

        private void InitializeTabAccount()
        {
            this._baseAccountBindingList.DataSource = this._baseAccountList;
            this.lstEditorAvailableAccounts.DataSource = this._baseAccountBindingList;
            this._baseAccountBindingList.RaiseListChangedEvents = true;
            this.BaseAccountListIndexChanged(this, EventArgs.Empty);
        }

        private void AccountEditorFormView_Load(object sender, EventArgs e)
        {
            this.InitializeTabAccount();
        }

        private void lstEditorAvailableAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BaseAccountListIndexChanged != null)
            {
                BaseAccountListIndexChanged(sender, e);
            }
        }

        private void btnEditorAccountChange_Click(object sender, EventArgs e)
        {
            if (BaseAccountChangeSelected != null)
            {
                BaseAccountChangeSelected(sender, e);
            }
        }

        private void BtnEditorAccountRemove_Click(object sender, EventArgs e)
        {
            if (BaseAccountRemoveFromList != null)
            {
                BaseAccountRemoveFromList(sender, e);
            }
        }

        private void btnEditorAccountAdd_Click(object sender, EventArgs e)
        {
            if (BaseAccountAddToList != null)
            {
                BaseAccountAddToList(sender, e);
            }
        }

        private void AccountEditorFormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.FormOwnerClosing || 
                e.CloseReason == CloseReason.MdiFormClosing) && BaseAccountSaveToFile != null)
            {
                BaseAccountSaveToFile(sender, e);
            }
        }

        private void AccountEditorFormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //showing hidden main program window - mainFormView
            this.ShowOwnerView();
        }
    }
}
