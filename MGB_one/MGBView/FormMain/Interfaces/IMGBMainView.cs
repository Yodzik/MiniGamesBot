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

        //Tab Main

        //Tab Accounts
        event EventHandler ShowAccountEditor;
        //event EventHandler InputValidationMGBPoints;

        int BaseAccountSelectedIndex { get; set; }
        int ChosenAccountSelectedIndex { get; set; }
        int ChosenAccountsCount { set; }
        MiniGameType SelectedGameType { get; set; }
        byte PointsLeft { set; }
        string[] LvlPoints { get;  set; } 
        Point Location { get; set; }

        void ShowAccountEditorView(IMGBAccountEditorView view);
        void SetBaseAccountList(List<string> source);

        //string InputValidationMGBPoints(object sender, KeyEventArgs e);

        //Tab Settings


    }
}
