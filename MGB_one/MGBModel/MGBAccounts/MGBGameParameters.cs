using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGB_one
{
    public enum MiniGameType { None = 0, Lumbermill = 1, Quarry = 2, ShootingRange = 3, Pond = 4 }
}

namespace MGB_one.Model.MGBAccounts
{    

    public class MGBGameParam
    {
        protected MiniGameType _gameType;
        protected byte _lvlPointsLeft;

        public MiniGameType GameType
        {
            get { return this._gameType; }
            set { this._gameType = value; }
        }
        public byte LvlPointsLeft
        {
            get { return this._lvlPointsLeft; }
            set { this._lvlPointsLeft = value; }
        }
        public MGBGameParam()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._gameType = MiniGameType.None;
            this._lvlPointsLeft = 0;
        }        
    }
}
