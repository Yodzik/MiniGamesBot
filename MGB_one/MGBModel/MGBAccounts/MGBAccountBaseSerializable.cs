using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MGB_one.Model.MGBAccounts
{
    //doesnt't contain state related values from MGBAccountBase class ("Used" and "PointsLeft")
    //used as copy of base part of MGBAccountBase class for serialization only
    public class MGBAccountBaseSerializable
    {
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Login { get; set; }
        [XmlAttribute]
        public string Password { get; set; }
        [XmlAttribute]
        public byte Position { get; set; }
        
        public MGBAccountBaseSerializable()
        {
            this.ID = 0;
            this.Name = string.Empty;
            this.Login = string.Empty;
            this.Password = string.Empty;
            this.Position = 0;
        }

        public MGBAccountBaseSerializable(MGBAccountBase source)
        {
            this.ID = source.ID;
            this.Name = source.Name;
            this.Login = source.Login;
            this.Password = source.Password;
            this.Position = source.Position;
        }
    }
}
