using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGB_one
{
    public static class ErrorSources
    {
        public const string ModelBaseAccountList = "Model - BaseAccount List";
        //public const string ViewTabAccounts = "Tab Accounts";
    }

        public static class ErrorMessages
    {
        public const string FileLoadBA = "Error: Unable to load BaseAccount file";
        public const string FileSaveBA = "Error: Unable to save BaseAccount file";
        public const string IndexOutOfBounds = "Error: Index out of bounds";
        public const string InvalidAccount = "This is not valid Account - check all values";
        public const string InvalidLvlPointsValue = "Should be numeric value 0 - 20";
    }

    public class ErrorEventArgs : EventArgs
    {
        public string ErrorMessage { get; set; }
        public string ErrorSource { get; set; }

        public ErrorEventArgs(string message, string source)
        {
            this.ErrorMessage = message;
            this.ErrorSource = source;
        }
    }
}
