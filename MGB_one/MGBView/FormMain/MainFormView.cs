using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//tymczasowy
using MGB_one.Model.MGBAccounts;


namespace MGB_one.View
{
    public partial class MainFormView : Form, IMGBMainView
    {
        public string ProgramStatus
        {
            get { return this.lblProgramStatusInfo.Text; }
            set { this.lblProgramStatusInfo.Text = value; }
        }
        public string SelectedProcess
        {
            get { return this.lblSelectedProcessInfo.Text; }
            set { this.lblSelectedProcessInfo.Text = value; }
        }

        public MainFormView()
        {
            this._baseAccountList = new List<string>();
            this.LvlPoints = new string[Settings.MGB_MAX_GAME_LVL];
            InitializeComponent();            
        }       

        public void frmMain_Load(object sender, EventArgs e)
        {
            this.InitializeTabAccount();            
            this.btnAccountAdd.Enabled = true;
            
        }

        private void btnAccountEditor_Click(object sender, EventArgs e)
        {
            if (this.ShowAccountEditor != null)
                this.ShowAccountEditor(sender, e);           
        }      



        private void btnStartStop_Click(object sender, EventArgs e)
        {
            MGBAccountBaseList temp = new MGBAccountBaseList();
            /*
            temp.Add(new MGBAccountBase(1, "name1", "login1", "password1", 1, false, 20));
            temp.Add(new MGBAccountBase(2, "name2", "login2", "password2", 2, false, 20));
            temp.Add(new MGBAccountBase(3, "name3", "login3", "password3", 3, false, 20));
            temp.Add(new MGBAccountBase(4, "name4", "login4", "password4", 1, false, 20));
            temp.SaveToXmlFile(MGBModel.Settings.BaseAccountsFilePath);
            */
            temp.LoadFromXmlFile(Settings.BaseAccountsFilePath);
            this.lblProgramStatusInfo.Text = temp[2].Name;
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            //List<string> lista = new List<string>() { "aaa", "bbb", "ccc" };
            //this.lstAvailableAccounts.DataSource = lista;
            //this.lstAvailableAccounts.Refresh();
            MessageBox.Show(this._baseAccountList.Count.ToString());
        }

        private void InputValidationMGBPoints(object sender)
        {
            string text = ((TextBox)sender).Text;
            int value = 0;
            if (int.TryParse(text, out value))
            {
                if (value < 0) value = 0;
                else if (value > Settings.MGB_MAX_GAME_POINTS) value = Settings.MGB_MAX_GAME_POINTS;
                ((TextBox)sender).Text = value.ToString();
            }
            else
            {
                MessageBox.Show(ErrorMessages.InvalidLvlPointsValue);
                ((TextBox)sender).Text = "0";
            }
        }

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
    }
}
