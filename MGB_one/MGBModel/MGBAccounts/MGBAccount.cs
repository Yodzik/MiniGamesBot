using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MGB_one.Model;

namespace MGB_one.Model.MGBAccounts
{
    //Chosen for game account based on MGBAccountBase
    public class MGBAccount 
    {
        protected MGBAccountBase _accountBase;
        //array of parameters for each level of minigame
        protected MGBGameParam[] _gamesLeft;

        public MGBAccountBase AccountBase { get { return this._accountBase; } }
        public MGBGameParam[] GamesLeft
        {
            get
            {
                return _gamesLeft;
            }
        }
        
        //probably shouldn't exist empty object
        private MGBAccount()
        {
            this._accountBase = new MGBAccountBase();
            this._gamesLeft = new MGBGameParam[Settings.MGB_MAX_GAME_LVL];
            for (int i = 0; i<Settings.MGB_MAX_GAME_LVL; i++)
            {
                this._gamesLeft[i] = new MGBGameParam();
            }
        }

        public MGBAccount(MGBAccountBase source) : this()
        {
            this._accountBase = source;
        }        

        //probably unnecessary
        public bool ValidateGames() 
        {
            if (this.GamesSum() <= Settings.MGB_MAX_GAME_POINTS)
                return true;
            else
                return false;
        }

        //probably unnecessary
        //sum > 20 means try your best in minigame, if fail to play max -> get next available reward
        public byte GamesSum()
        {
            byte sum = 0;
            foreach (MGBGameParam gameParam in this._gamesLeft)
            {
                sum += gameParam.LvlPointsLeft;
            }
            if (sum > Settings.MGB_MAX_GAME_POINTS)
                sum = Settings.MGB_MAX_GAME_POINTS;
            return sum;
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
                    this._gamesLeft[gameLvl].GameType = gameType;
                    //unable to set more than 20 points to all games - commented code probably for disposal
                    /* 
                    if (gamePoints > Settings.MGB_MAX_GAME_POINTS - this.GamesSum())
                        gamePoints = (byte)(Settings.MGB_MAX_GAME_POINTS - this.GamesSum());
                    */
                    this._gamesLeft[gameLvl].LvlPointsLeft = gamePoints;
                }
                else
                    this._gamesLeft[gameLvl].Reset();              
                return true;
            }
            else
                return false;
        }

        //not sure if neccessary
        //copy for security purposes in view -> no reference = no problem
        public MGBGameParam[] ReturnCopyOfParam()
        {
            MGBGameParam[] gamesLeft = new MGBGameParam[Settings.MGB_MAX_GAME_LVL];
            for (int i = 0; i < Settings.MGB_MAX_GAME_LVL; i++)
            {
                gamesLeft[i].GameType = this._gamesLeft[i].GameType;
                gamesLeft[i].LvlPointsLeft = this._gamesLeft[i].LvlPointsLeft;
            }
            return gamesLeft;
        }
    }
}
