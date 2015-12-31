using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MGB_one
{
    public static class Settings
    {
        public const int MGB_MAX_GAME_LVL = 5;
        public const byte MGB_MAX_GAME_POINTS = 20;
        public static string BaseAccountsFilePath;

        static Settings()
        {
            //wczytywanie ustawien z xml
            Settings.BaseAccountsFilePath = Application.StartupPath + @"\BaseAccounts.xml";
        }
    }
}
