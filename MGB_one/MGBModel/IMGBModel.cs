﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MGB_one.Model.MGBAccounts;

namespace MGB_one.Model
{
    public interface IMGBModel
    {
        event EventHandler BaseAccountListChanged;
        event EventHandler<ErrorEventArgs> ErrorOcured;

        int BaseAccountListCount { get; }

        //Contains state information vor view about AccountBase objects:
        List<string> BaseAccountsToStringListState();
        //Contains base information for view about AccountBase objects:
        List<string> BaseAccountsToStringListBase(); 
        void BaseAccountListSaveToFile(string filePath);
        void BaseAccountListLoadFromFile(string filePath);
        MGBAccountBase GetBaseAccountAt(int index);
        bool SetBaseAccountAt(string name, string login, string password, byte position, int index);
        bool RemoveBaseAccountAt(int index);
        bool AddBaseAccount(string name, string login, string password, byte position);        
    }
}
