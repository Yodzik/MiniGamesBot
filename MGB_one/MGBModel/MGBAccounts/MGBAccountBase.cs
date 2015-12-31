using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGB_one.Model.MGBAccounts
{
    public class MGBAccountBase
    {
        //base information:
        protected int _id;
        protected string _name;
        protected string _login;
        protected string _password;
        protected byte _position;
        //state information:
        protected bool _used;
        protected byte _pointsLeft;

        public int ID { get { return this._id; } }
        public string Name { get { return this._name; } }
        public string Login { get { return this._login; } }
        public string Password { get { return this._password; } }
        public byte Position { get { return this._position; } }
        public bool Used { get { return this._used; } }
        public byte PointsLeft { get { return this._pointsLeft; } }

        public MGBAccountBase()
        {
            this.Reset();
        }

        public MGBAccountBase(int id, string name, string login, string password, byte position, bool used, byte pointsLeft)
        {
            this.ValidatedCopy(id, name, login, password, position, used, pointsLeft);
        }

        public MGBAccountBase(MGBAccountBase source)
        {
            this.ValidatedCopy(source);
        }

        //MGBAccountBaseSerializable doesn't have "used" and "pointsLeft" fields
        public MGBAccountBase(MGBAccountBaseSerializable source)
        {
            this.ValidatedCopy(source.ID, source.Name, source.Login, source.Password, source.Position, false, Settings.MGB_MAX_GAME_POINTS);
        }

        public void Reset()
        {
            this._id = 0;
            this._name = string.Empty;
            this._login = string.Empty;
            this._password = string.Empty;
            this._position = 0;
            this._used = false;
            this._pointsLeft = 20;
        }

        //checks if object contains allowed data values
        public bool Validate()
        {
            if (this._id > 0 && this._name != string.Empty && this._login != string.Empty &&
                this._password != string.Empty && this._position > 0 && this._position <= 3 && 
                this._pointsLeft <= Settings.MGB_MAX_GAME_POINTS)
                return true;
            else
                return false;
        }

        //if wrong values returns default
        public bool ValidatedCopy(MGBAccountBase source)
        {
            this._id = source.ID;
            this._name = source.Name;
            this._login = source.Login;
            this._password = source.Password;
            this._position = source.Position;
            this._used = source.Used;
            this._pointsLeft = source.PointsLeft;
            if (this.Validate())
                return true;
            else
            {
                this.Reset();
                return false;
            }
        }

        public bool ValidatedCopy(int id, string name, string login, string password, byte position, bool used, byte pointsLeft)
        {
            this._id = id;
            this._name = name;
            this._login = login;
            this._password = password;
            this._position = position;
            this._used = used;
            this._pointsLeft = pointsLeft;
            if (this.Validate())
                return true;
            else
            {
                this.Reset();
                return false;
            }
        }

        public MGBAccountBase ReturnCopy()
        {
            return new MGBAccountBase(this);
        }

        public void SetPointsLeft(byte pointsLeft)
        {
            if (pointsLeft > Settings.MGB_MAX_GAME_POINTS)
                this._pointsLeft = Settings.MGB_MAX_GAME_POINTS;
            else
                this._pointsLeft = pointsLeft;
        }

        public void SetUsed(bool value)
        {
            this._used = value;
        }

        public bool ValuesEquals(MGBAccountBase baseAccount)
        {
            if (baseAccount.ID == this._id || baseAccount.Name == this._name)
                return true;
            else if (baseAccount.Login == this._login && baseAccount.Position == this._position)
                return true;
            else
                return false;
        }
    }
}
