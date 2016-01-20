using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using MGB_one.Model.MGBAccounts;
using System.Windows.Forms;

namespace MGB_one.View
{
    public interface IMGBMainView
    {
        // Main window 
        string ProgramStatus { get; set; }
        string SelectedProcess { get; set; }
        int SelectedPage { get; }

        //Tab Main

        //Tab Accounts
        event EventHandler ShowAccountEditor;
        //event EventHandler InputValidationMGBPoints;

        int BaseAccountSelectedIndex { get; set; }
        int ChosenAccountSelectedIndex { get; set; }
        int ChosenAccountsCount { set; }
        MiniGameType SelectedGameType { get; set; }
        byte PointsLeft { get; set; }
        //getter doesn't work - dont know why - compiling error - possible infinite loop in property: byte[] LvlPoints { get; set; }
        //instead of byte table due to compiling error 
        byte RewardsLvl1 { get; set; }
        byte RewardsLvl2 { get; set; }
        byte RewardsLvl3 { get; set; }
        byte RewardsLvl4 { get; set; }
        byte RewardsLvl5 { get; set; }
        //Main window location on screen
        Point Location { get; set; }

        void ShowAccountEditorView(IMGBAccountEditorView view);
        void SetBaseAccountList(List<string> source);

        //string InputValidationMGBPoints(object sender, KeyEventArgs e);

        //Tab Settings


    }
}
