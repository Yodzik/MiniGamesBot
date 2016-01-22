using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MGB_one.Model.MGBAccounts;
using MGB_one.View;
using MGB_one.Model;
using System.Windows.Forms;

namespace MGB_one.Presenter
{
    public class MainViewPresenter
    {
        private IMGBModel _model;
        private IMGBMainView _mainFormView;
        

        public MainViewPresenter(IMGBMainView mainFormView, IMGBModel model)
        {
            this._mainFormView = mainFormView;
            this._model = model;
            this.ConectModelWithView();
            this.Initialize();
        }

        private void ConectModelWithView()
        {
            //model event subscryption
            this._model.BaseAccountListChanged += this.OnBaseAccountListChanged;
            this._model.ChosenAccountListChanged += this.OnChosenAccountListChanged;
            //view event subscription
            this._mainFormView.ShowAccountEditor += this.OnShowAccountEditor;
            this._mainFormView.ChosenAccountAddToList += this.OnChosenAccountAddToList;
            this._mainFormView.ChosenAccountRemoveFromList += this.OnChosenAccountRemoveFromList;
            this._mainFormView.ChosenAccountListIndexChanged += this.OnChosenAccountListIndexChanged;
            this._mainFormView.ChosenAccountSetSelected += this.OnChosenAccountSetSelected;
        }
        private void Initialize()
        {
            this._mainFormView.ProgramStatus = "<uninitialized>";
            this._mainFormView.SelectedProcess = "<no process selected>";
            this.OnBaseAccountListChanged(this, EventArgs.Empty);
            this.OnChosenAccountListChanged(this, EventArgs.Empty);
        }

        private void OnBaseAccountListChanged(object sender, EventArgs e)
        {
            this._mainFormView.SetBaseAccountList(this._model.BaseAccountsToStringListState());
        }

        private void OnChosenAccountListChanged(object sender, EventArgs e)
        {
            this._mainFormView.SetChosenAccountList(this._model.ChosenAccountsToStringListState());
        }

        private void OnShowAccountEditor(object sender, EventArgs e)
        {
            var formAccountEditorView = new AccountEditorFormView();
            var formAccountEditorPresenter = new AccountEditorPresenter(formAccountEditorView, this._model);
            this._mainFormView.ShowAccountEditorView(formAccountEditorView);
        }

        private void OnChosenAccountAddToList(object sender, EventArgs e)
        {
            this._model.AddChosenAccount(this._mainFormView.BaseAccountSelectedIndex);
            this._mainFormView.SetChosenAccountList(this._model.ChosenAccountsToStringListState());
        }

        private void OnChosenAccountRemoveFromList(object sender, EventArgs e)
        {
            this._model.RemoveChosenAccount(this._mainFormView.ChosenAccountSelectedIndex);
            this._mainFormView.SetChosenAccountList(this._model.ChosenAccountsToStringListState());
        }

        private void OnChosenAccountListIndexChanged(object sender, EventArgs e)
        {
            if (this._mainFormView.ChosenAccountSelectedIndex >= 0)
            {
                MGBAccount account = this._model.GetChosenAccountAt(this._mainFormView.ChosenAccountSelectedIndex);
                this._mainFormView.SelectedGameType = account.GameType;
                this._mainFormView.RewardArray = account.GamesLeft;
                this._mainFormView.PointsLeft = account.AccountBase.PointsLeft;
            }
        }

        private void OnChosenAccountSetSelected(object sender, EventArgs e)
        {
            //dodac message boz z zapytaniem czy na pewno?
            if (this._mainFormView.ChosenAccountSelectedIndex >= 0)
            {
                this._model.SetChosenAccountAt(this._mainFormView.ChosenAccountSelectedIndex, this._mainFormView.PointsLeft, this._mainFormView.SelectedGameType, this._mainFormView.RewardArray);
                OnChosenAccountListChanged(sender, e);
                OnBaseAccountListChanged(sender, e);
            }
        }
    }
}
