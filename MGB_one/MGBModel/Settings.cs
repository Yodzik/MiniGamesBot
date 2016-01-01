using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MGB_one
{
    //Settings for entire program
    public static class Settings
    {
        //number of levels in minigames
        public const int MGB_MAX_GAME_LVL = 5;
        //number of max points for minigames in one sesion per account
        public const byte MGB_MAX_GAME_POINTS = 20;
        //file path for list of BaseAccounts
        public static string BaseAccountsFilePath;

        static Settings()
        {
            //default BaseAccounts file path
            Settings.BaseAccountsFilePath = Application.StartupPath + @"\BaseAccounts.xml";
            //todo - loading settings from xml file
        }
    }
}
