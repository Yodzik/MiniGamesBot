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

        public int SelectedPage
        {
            get { return this.tabControlMain.SelectedIndex; }
        }

        public MainFormView()
        {
            InitializeComponent();
            InitializeTabAccount();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            

        }

           



        private void btnStartStop_Click(object sender, EventArgs e)
        {
            
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

        
    }
}
