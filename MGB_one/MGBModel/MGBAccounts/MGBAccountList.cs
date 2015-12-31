using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace MGB_one.Model.MGBAccounts
{
    public class MGBAccountListsContainer
    {
        /*
        protected List<MGBAccountBase> _accountsBaseList;

        public List<MGBAccountBase> AccountsList { get { return new List<MGBAccountBase>(this._accountsBaseList); } }

        public event EventHandler AccountBaseListChanged;

        public MGBAccountListsContainer()
        {
            this._accountsBaseList = new List<MGBAccountBase>();
            this.OnAccountBaseListChanged();
        }
        
        public bool AddAccount(MGBAccountBase account)
        {
            if (account.Validate())
            {
                if (!this._accountsBaseList.Contains(account))
                {
                    this._accountsBaseList.Add(account);
                    this.OnAccountBaseListChanged();
                }
                return true;
            }
                else
                return false;
        }

        public bool RemoveAccount(MGBAccountBase account)
        {
            if (account.Validate())
            {
                while (this._accountsBaseList.Remove(account))
                { }
                this.OnAccountBaseListChanged();
                return true;
            }
            else
                return false;                
        }

        public int Count()
        {
            return this._accountsBaseList.Count;
        }

        public bool LoadFromFile(string filePath)
        {
            MGBAccountListSerializable tempList = new MGBAccountListSerializable();
            XmlSerializer serializer = new XmlSerializer(typeof(MGBAccountListSerializable));
            using (StreamReader reader = new StreamReader(filePath))
            {
                tempList = (MGBAccountListSerializable)serializer.Deserialize(reader);
            }
            this._accountsBaseList.Clear();
            MGBAccountBase tempBaseAccount;
            foreach (MGBAccountBaseSerializable tempItem in tempList.AccountList)
            {
                tempBaseAccount = new MGBAccountBase(tempItem);
                if (tempBaseAccount.ID != 0)
                    this._accountsBaseList.Add(tempBaseAccount);
            }
            this.OnAccountBaseListChanged();
            return true;
        }
        

        // nie wiem czy dobrze zwraca true
        public bool SaveToFile(string filePath)
        {
            MGBAccountListSerializable tempList = new MGBAccountListSerializable();
            foreach (MGBAccountBase account in this._accountsBaseList)
            {
                tempList.AccountList.Add(new MGBAccountBaseSerializable(account));               
            }
            XmlSerializer serializer = new XmlSerializer(typeof(MGBAccountListSerializable));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, tempList);
            }
            return true;
        }
        
        protected virtual void OnAccountBaseListChanged()
        {
            if (AccountBaseListChanged!=null)
            {
                AccountBaseListChanged(this, EventArgs.Empty);
            }
        }
        */
    }
}
