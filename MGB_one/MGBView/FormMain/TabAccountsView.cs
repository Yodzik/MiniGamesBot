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
        #region Events
        public event EventHandler ShowAccountEditor;
        public event EventHandler ChosenAccountListIndexChanged;
        public event EventHandler ChosenAccountAddToList;
        public event EventHandler ChosenAccountSetSelected;
        public event EventHandler ChosenAccountRemoveFromList;
        public event EventHandler ChosenAccountMoveUp;
        public event EventHandler ChosenAccountMoveDown;
        #endregion //Events

        #region Fields
        private BindingSource _baseAccountBindingList; 
        private List<string> _baseAccountList;
        private BindingSource _chosenAccountBindingList;
        private List<string> _chosenAccountList;
        #endregion //Fields

        #region Properties
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
            get
            {
                byte temp = 0;
                byte.TryParse(this.txtPointsLeft.Text, out temp);
                return temp;
            }
            set { this.txtPointsLeft.Text = value.ToString(); }
        }
        public MGBRewardArray RewardArray
        {
            get
            {
                MGBRewardArray tempRewardArray =new MGBRewardArray();
                byte[] tempArray =new byte[Settings.MGB_MAX_GAME_LVL] { 0,0,0,0,0};             
                byte.TryParse(this.txtQuantityLvl1.Text, out tempArray[0]);
                byte.TryParse(this.txtQuantityLvl2.Text, out tempArray[1]);
                byte.TryParse(this.txtQuantityLvl3.Text, out tempArray[2]);
                byte.TryParse(this.txtQuantityLvl4.Text, out tempArray[3]);
                byte.TryParse(this.txtQuantityLvl5.Text, out tempArray[4]);
                tempRewardArray.Rewards = tempArray;
                return tempRewardArray;
            }
            set
            {

                this.txtQuantityLvl1.Text = value.Rewards[0].ToString();
                this.txtQuantityLvl2.Text = value.Rewards[1].ToString();
                this.txtQuantityLvl3.Text = value.Rewards[2].ToString();
                this.txtQuantityLvl4.Text = value.Rewards[3].ToString();
                this.txtQuantityLvl5.Text = value.Rewards[4].ToString();
            }
        }
        #endregion //Properties

        #region Methods

        //Used as a part of constructor for this partial class
        private void InitializeTabAccount()
        {
            this.RewardArray = new MGBRewardArray();

            this._baseAccountList = new List<string>();
            this._baseAccountBindingList = new BindingSource();
            this._baseAccountBindingList.DataSource = this._baseAccountList;
            this.lstAvailableAccounts.DataSource = this._baseAccountBindingList;
            this._baseAccountBindingList.RaiseListChangedEvents = true;
            //this.RefreshBaseAccountView();

            this._chosenAccountList = new List<string>();
            this._chosenAccountBindingList = new BindingSource();
            this._chosenAccountBindingList.DataSource = this._chosenAccountList;
            this.lstChosenAccounts.DataSource = this._chosenAccountBindingList;
            this._chosenAccountBindingList.RaiseListChangedEvents = true;
            //this.RefreshChosenAccountView();

            ButtonAddEnableManagement();
            ButtonRemoveEnableManagement();
            ButtonSetEnableManagement();
            
        }        

        private void FormLoad_TabAccount()
        {
            //if (this.lstAvailableAccounts.SelectedIndex >= 0)
                //this.btnAccountAdd.Enabled = true;
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

        public void SetChosenAccountList(List<string> source)
        {
            this._chosenAccountList = source;
            this.RefreshChosenAccountView();
        }

        private void RefreshBaseAccountView()
        {
            //this._baseAccountBindingList.DataSource = null;
            this._baseAccountBindingList.DataSource = this._baseAccountList;
            this._baseAccountBindingList.ResetBindings(false);
        }

        private void RefreshChosenAccountView()
        {
            this._chosenAccountBindingList.DataSource = this._chosenAccountList;
            this._chosenAccountBindingList.ResetBindings(false);
        }

        private void ButtonAddEnableManagement()
        {
            if (this.lstAvailableAccounts.SelectedIndex >= 0)
                this.btnAccountAdd.Enabled = true;
            else
                this.btnAccountAdd.Enabled = false;
        }

        private void ButtonRemoveEnableManagement()
        {
            if (this.lstChosenAccounts.SelectedIndex >= 0)
                this.btnAccountRemove.Enabled = true;
            else
                this.btnAccountRemove.Enabled = false;
        }

        private void ButtonSetEnableManagement()
        {
            if (this.lstChosenAccounts.SelectedIndex >= 0)
                this.btnAccountSet.Enabled = true;
            else
                this.btnAccountSet.Enabled = false;
        }
        /* unused in this version of code - early version of ShowAccountEditorView
        public void Show(object owner)
        {
            if (owner.GetType() == typeof(Form))
                (this as Form).Show(owner as Form);
            else                
                MessageBox.Show("Error: view types don't match");
        }*/
        #endregion //Methods

        #region Controll_Events

        private void lstAvailableAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonAddEnableManagement();
        }

        private void lstChosenAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ChosenAccountListIndexChanged != null)
                this.ChosenAccountListIndexChanged(sender, e);
            ButtonRemoveEnableManagement();
            ButtonSetEnableManagement();
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            if (this.ChosenAccountAddToList != null)
                this.ChosenAccountAddToList(sender, e);
            lstChosenAccounts_SelectedIndexChanged(sender, e);
        }

        private void btnAccountRemove_Click(object sender, EventArgs e)
        {
            if (this.ChosenAccountRemoveFromList != null)
                this.ChosenAccountRemoveFromList(sender, e);
            ButtonAddEnableManagement();
        }

        private void btnAccountEditor_Click(object sender, EventArgs e)
        {
            if (this.ShowAccountEditor != null)
                this.ShowAccountEditor(sender, e);
        }

        private void btnAccountSet_Click(object sender, EventArgs e)
        {
            if (this.ChosenAccountSetSelected != null)
                this.ChosenAccountSetSelected(sender, e);
        }

        //Text boxes input validation
        private void txtQuantityLvl1_KeyUp(object sender, KeyEventArgs e)
        {
            InputValidationMGBPoints(sender);
        }
        private void txtQuantityLvl3_KeyUp(object sender, KeyEventArgs e)
        {
            InputValidationMGBPoints(sender);
        }
        private void txtQuantityLvl2_KeyUp(object sender, KeyEventArgs e)
        {
            InputValidationMGBPoints(sender);
        }
        private void txtQuantityLvl4_KeyUp(object sender, KeyEventArgs e)
        {
            InputValidationMGBPoints(sender);
        }
        private void txtQuantityLvl5_KeyUp(object sender, KeyEventArgs e)
        {
            InputValidationMGBPoints(sender);
        }
        private void txtPointsLeft_KeyUp(object sender, KeyEventArgs e)
        {
            InputValidationMGBPoints(sender);
        }

        #endregion // Controll_Events
    }
}