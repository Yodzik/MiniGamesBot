using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MGB_one.View
{
    public enum MyDialogResult { Cancel = 0, No = 1, Yes = 2}

    public interface IMGBAccountEditorView
    {
        event EventHandler BaseAccountListIndexChanged;
        event EventHandler BaseAccountAddToList;
        event EventHandler BaseAccountChangeSelected;
        event EventHandler BaseAccountRemoveFromList;
        event EventHandler BaseAccountSaveToFile;

        string AccountName { get; set; }
        string AccountLogin { get; set; }
        string AccountPassword { get; set; }
        byte AccountPosition { get; set; }
        string HintText { set; }
        int SelectedIndex { get; set; }
        Point Location { get; set; }

        void DisplayMessage(string message, string title);
        bool DisplayYesNoQuestion(string message, string title);
        MyDialogResult DisplayYesNoCancelQuestion(string message, string title);
        void SetBaseAccountList(List<string> source);
        void ShowView(IMGBMainView owner);
        void ShowOwnerView();
    }
}
