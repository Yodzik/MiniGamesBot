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
            get
            {
                byte temp = 0;
                byte.TryParse(this.txtPointsLeft.Text, out temp);
                return temp;
            }
            set { this.txtPointsLeft.Text = value.ToString(); }
        }
        public byte RewardsLvl1
        {
            get
            {
                byte temp = 0;
                byte.TryParse(this.txtQuantityLvl1.Text, out temp);
                return temp;
            }
            set { this.txtQuantityLvl1.Text = value.ToString(); }
        }
        public byte RewardsLvl2
        {
            get
            {
                byte temp = 0;
                byte.TryParse(this.txtQuantityLvl2.Text, out temp);
                return temp;
            }
            set { this.txtQuantityLvl2.Text = value.ToString(); }
        }
        public byte RewardsLvl3
        {
            get
            {
                byte temp = 0;
                byte.TryParse(this.txtQuantityLvl3.Text, out temp);
                return temp;
            }
            set { this.txtQuantityLvl3.Text = value.ToString(); }
        }
        public byte RewardsLvl4
        {
            get
            {
                byte temp = 0;
                byte.TryParse(this.txtQuantityLvl4.Text, out temp);
                return temp;
            }
            set { this.txtQuantityLvl4.Text = value.ToString(); }
        }
        public byte RewardsLvl5
        {
            get
            {
                byte temp = 0;
                byte.TryParse(this.txtQuantityLvl5.Text, out temp);
                return temp;
            }
            set { this.txtQuantityLvl5.Text = value.ToString(); }
        }

        /* getter doesn't work - dont know why - compiling error possible infinite loop
        public byte[] LvlPoints
        {
            get
            {
                byte[] tempArray =new byte[Settings.MGB_MAX_GAME_LVL];
                //Not sure if have to make every element of array = 0
                for (int i = 0; i<LvlPoints.Length; i++)
                {
                    tempArray[i] = 0;                    
                }
                byte.TryParse(this.txtQuantityLvl1.Text, out tempArray[0]);
                byte.TryParse(this.txtQuantityLvl2.Text, out tempArray[1]);
                byte.TryParse(this.txtQuantityLvl3.Text, out tempArray[2]);
                byte.TryParse(this.txtQuantityLvl4.Text, out tempArray[3]);
                byte.TryParse(this.txtQuantityLvl5.Text, out tempArray[4]);
                return tempArray;
            }
            set
            {
                if (value.Length == Settings.MGB_MAX_GAME_LVL)
                {
                    this.txtQuantityLvl1.Text = value[0].ToString();
                    this.txtQuantityLvl2.Text = value[1].ToString();
                    this.txtQuantityLvl3.Text = value[2].ToString();
                    this.txtQuantityLvl4.Text = value[3].ToString();
                    this.txtQuantityLvl5.Text = value[4].ToString();
                }
                else
                    MessageBox.Show("Error: Game maximum reward lvl is different than 5");
            }
        }*/

        /* unused in this version of code - early version of ShowAccountEditorView
        public void Show(object owner)
        {
            if (owner.GetType() == typeof(Form))
                (this as Form).Show(owner as Form);
            else                
                MessageBox.Show("Error: view types don't match");
        }*/

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