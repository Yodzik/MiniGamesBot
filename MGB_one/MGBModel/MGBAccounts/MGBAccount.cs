using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MGB_one.Model;

namespace MGB_one.Model.MGBAccounts
{
    public class MGBAccount 
    {
        private MGBAccountBase _accountBase;
        protected MGBGameParam[] _gamesLeft;

        public MGBAccountBase AccountBase { get { return this._accountBase; } }
        public MGBGameParam[] GamesLeft
        {
            get
            {
                return _gamesLeft;
            }
        }
        //nie jestem pewien czy potrzebne - mozna skorzystac z gamesleft i pointsleft
        /*
        public bool Ended
        {
            get
            {
                return (this._pointsLeft == 0 || this.GamesSum() == 0);
            }
        }
        */

        public MGBAccount()
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
            //this._gamesLeft = new MGBGameParam[Settings.MGB_MAX_GAME_LVL];
            //for (int i = 0; i < Settings.MGB_MAX_GAME_LVL; i++)
            //{
            //    this._gamesLeft[i] = new MGBGameParam();
            //}
        }        

        //nie wiem czy potrzebne
        public bool ValidateGames() 
        {
            if (this.GamesSum() <= Settings.MGB_MAX_GAME_POINTS)
                return true;
            else
                return false;
        }

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

        public bool SetGame(int gameLvl, MiniGameType gameType, byte gamePoints)
        {
            if ( gameLvl > 0 && gameLvl <= Settings.MGB_MAX_GAME_LVL && 
                gamePoints >= 0 && gamePoints <= Settings.MGB_MAX_GAME_POINTS)
            {
                this._gamesLeft[gameLvl].GameType = gameType;
                if (gameType != MiniGameType.None)
                {
                    if (gamePoints > Settings.MGB_MAX_GAME_POINTS - this.GamesSum())
                        gamePoints = (byte)(Settings.MGB_MAX_GAME_POINTS - this.GamesSum());
                    this._gamesLeft[gameLvl].LvlPointsLeft = gamePoints;
                }
                else
                    this._gamesLeft[gameLvl].LvlPointsLeft = 0;                
                return true;
            }
            else
                return false;
        }

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
