using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGB_one
{
    //part of program causing problem
    //static string values for displaying messages
    //probably other languages will be added
    public static class ErrorSources
    {
        public static string ModelBaseAccountList = "Model - BaseAccount List";
        public static string ViewTabAccounts = "Tab Accounts";
    }

    //desription of caused problem
    //static string values for displaying messages
    //probably other languages will be added
    public static class ErrorMessages
    {
        public static string FileLoadBA = "Error: Unable to load BaseAccount file";
        public static string FileSaveBA = "Error: Unable to save BaseAccount file";
        public static string IndexOutOfBounds = "Error: Index out of bounds";
        public static string InvalidAccount = "This is not valid Account - check all values";
        public static string InvalidLvlPointsValue = "Should be numeric value 0 - 20";
    }

    //Custom EventArgs class for Error event
    public class ErrorEventArgs : EventArgs
    {
        //content of displayed message
        public string ErrorMessage { get; set; }
        //part of program causing problem displayed in title
        public string ErrorSource { get; set; }

        public ErrorEventArgs(string message, string source)
        {
            this.ErrorMessage = message;
            this.ErrorSource = source;
        }
    }
}
