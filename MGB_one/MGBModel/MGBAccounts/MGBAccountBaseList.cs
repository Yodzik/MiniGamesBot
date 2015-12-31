using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace MGB_one.Model.MGBAccounts
{
    public class MGBAccountBaseList : List<MGBAccountBase>
    {
        public bool AddValidated(MGBAccountBase element)
        {
            if (element.Validate())
            {
                foreach (MGBAccountBase current in this)
                {
                    if (current.ValuesEquals(element))
                        return true;
                }
                this.Add(element);
                return true;
            }
            else
                return false;
        }

        public bool AddValidated(string name, string login, string password, byte position)
        {
            int tempID = 0;
            List<int> idList = new List<int>();
            for (int i=1; i <= this.Count+1; i++)
            {
                idList.Add(i);
            }
            foreach (MGBAccountBase account in this)
            {
                idList.Remove(account.ID);
            }
            if (idList.Count > 0)
                tempID = idList[0];
            MGBAccountBase tempAccount = new MGBAccountBase(tempID, name, login, password, position, false, Settings.MGB_MAX_GAME_POINTS);
            return this.AddValidated(tempAccount);
        }

        public bool LoadFromXmlFile(string filePath)
        {
            bool result = false;
            MGBAccountBaseListSerializable deserializedList = new MGBAccountBaseListSerializable();
            XmlSerializer serializer = new XmlSerializer(typeof(MGBAccountBaseListSerializable));
            using (StreamReader reader = new StreamReader(filePath))
            {
                deserializedList = (MGBAccountBaseListSerializable)serializer.Deserialize(reader);
                result = true;
            }
            this.Clear();
            foreach (MGBAccountBaseSerializable tempItem in deserializedList.AccountList)
            {
                MGBAccountBase tempBaseAccount = new MGBAccountBase(tempItem);
                this.AddValidated(tempBaseAccount);
            }
            return result; 
        }

        public bool SaveToXmlFile(string filePath)
        {
            bool result = false;
            MGBAccountBaseListSerializable serializedList = new MGBAccountBaseListSerializable();
            foreach (MGBAccountBase account in this)
            {
                serializedList.AccountList.Add(new MGBAccountBaseSerializable(account));
            }
            XmlSerializer serializer = new XmlSerializer(typeof(MGBAccountBaseListSerializable));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, serializedList);
                result = true;
            }
            return result;
        }

        public List<string> ToStringListState()
        {
            List<string> result = new List<string>();
            foreach (MGBAccountBase account in this)
            {
                string line = account.Name;
                if (account.Used == false)
                    line += " <unused>, pts: ";
                else
                    line += " <used>, pts: ";
                line += (account.PointsLeft);
                result.Add(line);
            }
            return result;
        }

        public List<string> ToStringListBase()
        {
            List<string> result = new List<string>();
            foreach (MGBAccountBase account in this)
            {
                result.Add(account.ID.ToString() + ". " + account.Name + ", Pos= [" + account.Position.ToString() +
                    "], L= " + account.Login + ", P= " + account.Password);
            }
            return result;
        }
    }
}
