using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGB_one
{
    //Used by MGBGameParam class
    //Type must be accesible in MainView - used for selection
    public enum MiniGameType { None = 0, Lumbermill = 1, Quarry = 2, ShootingRange = 3, Pond = 4 }
}

namespace MGB_one.Model.MGBAccounts
{
    //Contains minigame type and points left for level of minigame
    //Used by MGBAccount class for each minigame level in an array
    public class MGBGameParam
    {
        //Selected type of mini game - default "None"
        protected MiniGameType _gameType;
        //Points left for this level of minigame - value range 0 - const Settings.MGB_MAX_GAME_POINTS
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
