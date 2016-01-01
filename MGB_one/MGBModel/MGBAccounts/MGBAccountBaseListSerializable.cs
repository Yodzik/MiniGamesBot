using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MGB_one.Model.MGBAccounts
{
    //List of MGBAccountBaseSerializable elements with changed Xml tags
    //used only for simple serialization of entire list in MGBAccountBaseList class

    [XmlRoot("Root")]
    public class MGBAccountBaseListSerializable
    {
        [XmlArray ("AccountList")]
        [XmlArrayItem("Account")]
        public List<MGBAccountBaseSerializable> AccountList { get; set; }

        public MGBAccountBaseListSerializable()
        {
            this.AccountList = new List<MGBAccountBaseSerializable>();
        }
    }
}
