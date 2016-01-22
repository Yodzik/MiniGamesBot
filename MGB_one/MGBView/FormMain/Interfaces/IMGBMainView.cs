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
        event EventHandler ChosenAccountListIndexChanged;
        event EventHandler ChosenAccountAddToList;
        event EventHandler ChosenAccountSetSelected;
        event EventHandler ChosenAccountRemoveFromList;
        event EventHandler ChosenAccountMoveUp;
        event EventHandler ChosenAccountMoveDown;

        int BaseAccountSelectedIndex { get; set; }
        int ChosenAccountSelectedIndex { get; set; }
        int ChosenAccountsCount { set; }
        MiniGameType SelectedGameType { get; set; }
        byte PointsLeft { get; set; }
        MGBRewardArray RewardArray { get; set; }
        //Main window location on screen
        Point Location { get; set; }

        void ShowAccountEditorView(IMGBAccountEditorView view);
        void SetBaseAccountList(List<string> source);
        void SetChosenAccountList(List<string> source);


        //Tab Settings


    }
}
