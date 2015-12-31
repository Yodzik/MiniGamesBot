using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;


namespace MGB_one.View
{
    public partial class MainFormView
    {
        public event EventHandler ShowAccountEditor;

        private BindingSource _baseAccountBindingList = new BindingSource();
        private List<string> _baseAccountList;

        public int BaseAccountSelectedIndex
        {
            get { return this.lstAvailableAccounts.SelectedIndex; }
            set { this.lstAvailableAccounts.SelectedIndex = value; }
        }
        public int ChosenAccountSelectedIndex
        {
            get { return this.lstChosenAccounts.SelectedIndex; }
            set { this.lstChosenAccounts.SelectedIndex = value; }
        }
        public int ChosenAccountsCount
        {
            set { this.lblAccountsQuantity.Text = value.ToString(); }
        }
        public MiniGameType SelectedGameType
        {
            get
            {
                MiniGameType result = MiniGameType.None;
                if (this.rbtnLumberMill.Checked) result = MiniGameType.Lumbermill;
                if (this.rbtnPond.Checked) result = MiniGameType.Pond;
                if (this.rbtnQuarry.Checked) result = MiniGameType.Quarry;
                if (this.rbtnShootingRange.Checked) result = MiniGameType.ShootingRange;
                return result;
            }
            set
            {
                switch (value)
                {
                    case MiniGameType.None:
                        this.rbtnLumberMill.Checked = false;
                        this.rbtnPond.Checked = false;
                        this.rbtnQuarry.Checked = false;
                        this.rbtnShootingRange.Checked = false;
                        break;
                    case MiniGameType.Lumbermill:
                        this.rbtnLumberMill.Checked = true;
                        this.rbtnPond.Checked = false;
                        this.rbtnQuarry.Checked = false;
                        this.rbtnShootingRange.Checked = false;
                        break;
                    case MiniGameType.Quarry:
                        this.rbtnLumberMill.Checked = false;
                        this.rbtnPond.Checked = false;
                        this.rbtnQuarry.Checked = true;
                        this.rbtnShootingRange.Checked = false;
                        break;
                    case MiniGameType.ShootingRange:
                        this.rbtnLumberMill.Checked = false;
                        this.rbtnPond.Checked = false;
                        this.rbtnQuarry.Checked = false;
                        this.rbtnShootingRange.Checked = true;
                        break;
                    case MiniGameType.Pond:
                        this.rbtnLumberMill.Checked = false;
                        this.rbtnPond.Checked = true;
                        this.rbtnQuarry.Checked = false;
                        this.rbtnShootingRange.Checked = false;
                        break;
                    default:
                        this.rbtnLumberMill.Checked = false;
                        this.rbtnPond.Checked = false;
                        this.rbtnQuarry.Checked = false;
                        this.rbtnShootingRange.Checked = false;
                        break;
                }
            }
        }
        public byte PointsLeft
        {
            set { this.lblPointsLeft.Text = value.ToString(); }
        }
        public string[] LvlPoints { get; set; }

        public void Show(object owner)
        {
            if (owner.GetType() == typeof(Form))
                (this as Form).Show(owner as Form);
            else                
                MessageBox.Show("Error: view types don't match");
        }

        public void ShowAccountEditorView(IMGBAccountEditorView view)
        {
            view.Location = this.Location;
            view.ShowView(this);
            this.Hide();
        }

        public void SetBaseAccountList(List<string> source)
        {
            this._baseAccountList = source;
            this.RefreshBaseAccountView();
        }

        private void RefreshBaseAccountView()
        {
            //this._baseAccountBindingList.DataSource = null;
            this._baseAccountBindingList.DataSource = this._baseAccountList;
            this._baseAccountBindingList.ResetBindings(false);
        }

        private void InitializeTabAccount()
        {            
            this._baseAccountBindingList.DataSource = this._baseAccountList;
            this.lstAvailableAccounts.DataSource = this._baseAccountBindingList;
            this._baseAccountBindingList.RaiseListChangedEvents = true;
            this.RefreshBaseAccountView();
        }


    }
}