using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using MGB_one.Model;

namespace MGB_one.Model.MGBAccounts
{
    //Chosen for game account based on MGBAccountBase
    public class MGBAccount 
    {
        protected MGBAccountBase _accountBase;
        //array of parameters for each level of minigame
        protected MGBRewardArray _gamesLeft;
        protected MiniGameType _gameType;

        public MGBAccountBase AccountBase { get { return this._accountBase; } }
        public MGBRewardArray GamesLeft
        {
            get { return _gamesLeft; }
            set { _gamesLeft = value; }
        }
        public MiniGameType GameType { get { return this._gameType; } }
        
        //probably shouldn't exist empty object
        private MGBAccount()
        {
            this._accountBase = new MGBAccountBase();
            this._gamesLeft = new MGBRewardArray();
            this._gameType = MiniGameType.None;
        }

        public MGBAccount(MGBAccountBase source) : this()
        {
            this._accountBase = source;
        }        

        //false if values out of range
        //if gametype = None -> values set to default
        public bool SetGame(int gameLvl, MiniGameType gameType, byte gamePoints)
        {
            if ( gameLvl > 0 && gameLvl <= Settings.MGB_MAX_GAME_LVL && 
                gamePoints >= 0 && gamePoints <= Settings.MGB_MAX_GAME_POINTS)
            {
                if (gameType != MiniGameType.None)
                {
                    this._gameType = gameType;
                    this._gamesLeft.SetValueAt(gameLvl - 1, gamePoints);
                }
                else
                {
                    this._gamesLeft.ResetAt(gameLvl - 1);
                    this._gameType = MiniGameType.None;
                }            
                return true;
            }
            else
                return false;
        }

       
        public string AccountString()
        {
            return this._accountBase.Name + " P:" + this._accountBase.PointsLeft.ToString() +
                " " + this._gameType.ToString() + 
                " [" + this._gamesLeft.Rewards[4].ToString() + 
                "," + this._gamesLeft.Rewards[3].ToString() +
                "," + this._gamesLeft.Rewards[2].ToString() +
                "," + this._gamesLeft.Rewards[1].ToString() +
                "," + this._gamesLeft.Rewards[0].ToString() + "]";
        }
    }
}
