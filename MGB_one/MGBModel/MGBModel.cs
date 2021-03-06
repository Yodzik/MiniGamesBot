﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MGB_one.Model.MGBAccounts;


namespace MGB_one.Model
{
    //
    public class MGBModel : IMGBModel
    {
        private MGBAccountBaseList _baseAccountList;
        private List<MGBAccount> _chosenAccountList;

        public int BaseAccountListCount
        {
            get { return this._baseAccountList.Count(); }
        }

        public int ChosenAccountListCount
        {
            get { return this._chosenAccountList.Count(); }
        }

        public event EventHandler BaseAccountListChanged;
        public event EventHandler ChosenAccountListChanged;
        public event EventHandler<ErrorEventArgs> ErrorOcured;

        public MGBModel()
        {
            this._baseAccountList = new MGBAccountBaseList();
            this._chosenAccountList = new List<MGBAccount>();
            //tu eventy chyba bez sensu - subskrybcja po wywołaniu konstruktora
            if (!this._baseAccountList.LoadFromXmlFile(Settings.BaseAccountsFilePath))
            {
                this._baseAccountList.Clear();
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.FileLoadBA, ErrorSources.ModelBaseAccountList));
            }
            OnBaseAccountListChanged();            
        }

        public List<string> BaseAccountsToStringListState()
        {
            return this._baseAccountList.ToStringListState();
        }

        public List<string> ChosenAccountsToStringListState()
        {
            List<string> tempList = new List<string>();
            foreach (MGBAccount account in this._chosenAccountList)
            {
                tempList.Add(account.AccountString());
            }
            return tempList;
        }

        public List<string> BaseAccountsToStringListBase()
        {
            return this._baseAccountList.ToStringListBase();
        }

        public void BaseAccountListSaveToFile(string filePath)
        {
            if (!this._baseAccountList.SaveToXmlFile(filePath))
            {
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.FileSaveBA, ErrorSources.ModelBaseAccountList));
            }
        }

        public void BaseAccountListLoadFromFile(string filePath)
        {
            if (!this._baseAccountList.LoadFromXmlFile(filePath))
            {
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.FileLoadBA, ErrorSources.ModelBaseAccountList));
            }
            OnBaseAccountListChanged();
        }

        public MGBAccountBase GetBaseAccountAt(int index)
        {
            if (this._baseAccountList.Count > index && index >= 0)
            {
                return this._baseAccountList[index].ReturnCopy();
            }
            else
            {
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.IndexOutOfBounds, ErrorSources.ModelBaseAccountList));
                return new MGBAccountBase();
            }
        }

        public bool SetBaseAccountAt(string name, string login, string password, byte position, int index)
        {
            if (this._baseAccountList.Count > index && index >= 0)
            {
                MGBAccountBase tempAccount = new MGBAccountBase(this._baseAccountList[index].ID, name, login, password, position, false, Settings.MGB_MAX_GAME_POINTS);
                if (tempAccount.Validate())
                {
                    this._baseAccountList[index] = tempAccount;
                    return true;
                }
                else
                    OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.InvalidAccount, ErrorSources.ModelBaseAccountList));
                    return false;
            }
            else
            {
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.IndexOutOfBounds, ErrorSources.ModelBaseAccountList));
                return false;
            }
        }

        public bool RemoveBaseAccountAt(int index)
        {
            if (index >= 0 && index < this._baseAccountList.Count)
            {
                this._baseAccountList.RemoveAt(index);
                OnBaseAccountListChanged();
                return true;
            }
            else
            {
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.IndexOutOfBounds, ErrorSources.ModelBaseAccountList));
                return false;
            }
        }

        public bool AddBaseAccount(string name, string login, string password, byte position)
        {
            if (this._baseAccountList.AddValidated(name, login, password, position))
            {
                OnBaseAccountListChanged();
                return true;
            }
            else
            {
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.InvalidAccount, ErrorSources.ModelBaseAccountList));
                return false;
            }
        }

        public void AddChosenAccount(int index)
        {
            if (index >= 0 && index < this._baseAccountList.Count)
            {
                bool exists = false;
                foreach (MGBAccount account in this._chosenAccountList)
                {
                    if (account.AccountBase.Equals(this._baseAccountList[index]))
                        exists = true;
                }
                if (!exists)
                    this._chosenAccountList.Add(new MGBAccount(this._baseAccountList[index]));
            }
            else
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.IndexOutOfBounds, ErrorSources.ModelAccountLists));
        }

        public void RemoveChosenAccount(int index)
        {
            if (index >= 0 && index < this._chosenAccountList.Count)
                this._chosenAccountList.RemoveAt(index);
            else
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.IndexOutOfBounds, ErrorSources.ModelChosenAccountList));
        }

        public MGBAccount GetChosenAccountAt(int index)
        {
            if (index >= 0 && index < this._chosenAccountList.Count)
                return this._chosenAccountList[index];
            else
            {
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.IndexOutOfBounds, ErrorSources.ModelChosenAccountList));
                return null;
            }
        }

        public bool SetChosenAccountAt(int index, byte pointsLeft, MiniGameType gameType, MGBRewardArray gameLvlPoints)
        {
            if (index >= 0 && index < this._chosenAccountList.Count)
            {
                this._chosenAccountList[index].SetAllGames(gameType, gameLvlPoints);
                this._chosenAccountList[index].AccountBase.SetPointsLeft(pointsLeft);
                return true;
            }
            else
            {
                OnErrorOcured(this, new ErrorEventArgs(ErrorMessages.IndexOutOfBounds, ErrorSources.ModelChosenAccountList));
                return false;
            }
        }

        protected virtual void OnBaseAccountListChanged()
        {
            if (this.BaseAccountListChanged != null)
            {
                BaseAccountListChanged(this, EventArgs.Empty);
            }
        }

        protected virtual void OnChosenAccountListChanged()
        {
            if (this.ChosenAccountListChanged != null)
            {
                ChosenAccountListChanged(this, EventArgs.Empty);
            }
        }

        protected virtual void OnErrorOcured(object sender, ErrorEventArgs e)
        {
            if (this.ErrorOcured != null)
            {
                ErrorOcured(this, e);
            }
        }
    }
}
