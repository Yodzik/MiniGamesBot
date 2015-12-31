using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MGB_one.Model;
using MGB_one.View;
using System.Windows.Forms;

namespace MGB_one.Presenter
{
    public class AccountEditorPresenter
    {
        IMGBAccountEditorView _accountEditorFormView;
        IMGBModel _model;

        public  AccountEditorPresenter(IMGBAccountEditorView view, IMGBModel model)
        {
            this._accountEditorFormView = view;
            this._model = model;
            this.ConnectModelWithView();
            this.Initialize();
        }

        private void ConnectModelWithView()
        {
            //event subscription for model
            this._model.BaseAccountListChanged += this.OnBaseAccountListChanged;
            this._model.ErrorOcured += this.OnErrorOcured;
            //event subscription for view
            this._accountEditorFormView.BaseAccountListIndexChanged += this.OnBaseAccountListIndexChanged;
            this._accountEditorFormView.BaseAccountChangeSelected += this.OnChangeAccount;
            this._accountEditorFormView.BaseAccountRemoveFromList += this.OnRemoveAccount;
            this._accountEditorFormView.BaseAccountAddToList += this.OnAddAccount;
            this._accountEditorFormView.BaseAccountSaveToFile += this.OnAccountEditorViewClosing;
        }
        public void Initialize()
        {
            this.OnBaseAccountListChanged(this, EventArgs.Empty);
            this.OnBaseAccountListIndexChanged(this, EventArgs.Empty);
        }

        public void OnChangeAccount(object sender, EventArgs e)
        {
            if (this._accountEditorFormView.SelectedIndex >= 0 &&
                this._accountEditorFormView.DisplayYesNoQuestion("Are you sure you want to change selected account?","Changing Account"))
            {
                this._model.SetBaseAccountAt(this._accountEditorFormView.AccountName, this._accountEditorFormView.AccountLogin,
                    this._accountEditorFormView.AccountPassword, this._accountEditorFormView.AccountPosition, 
                    this._accountEditorFormView.SelectedIndex);
                OnBaseAccountListChanged(this,EventArgs.Empty);
            }
        }

        public void OnRemoveAccount(object sender, EventArgs e)
        {
            if (this._model.BaseAccountListCount > 0)
            {
                if (this._accountEditorFormView.DisplayYesNoQuestion("Are you sure you want to delete this account?", "Removing Account"))
                {
                    this._model.RemoveBaseAccountAt(this._accountEditorFormView.SelectedIndex);
                    this.OnBaseAccountListIndexChanged(this, EventArgs.Empty);
                }
            }
        }

        public void OnAddAccount(object sender, EventArgs e)
        {
            if (this._accountEditorFormView.DisplayYesNoQuestion("Are you sure you want to add this account?", "Adding Account"))
            {
                this._model.AddBaseAccount(this._accountEditorFormView.AccountName, this._accountEditorFormView.AccountLogin,
                    this._accountEditorFormView.AccountPassword, this._accountEditorFormView.AccountPosition);
                this.OnBaseAccountListChanged(this, EventArgs.Empty);
                this.OnBaseAccountListIndexChanged(this, EventArgs.Empty);
            }
        }

        public void OnBaseAccountListChanged(object sender, EventArgs e)
        {
            this._accountEditorFormView.SetBaseAccountList(this._model.BaseAccountsToStringListBase());
        }

        public void OnBaseAccountListIndexChanged(object sender, EventArgs e)
        {
            int index = this._accountEditorFormView.SelectedIndex;
            if (index >= 0 && index < this._model.BaseAccountListCount)
            {
                this._accountEditorFormView.AccountName = this._model.GetBaseAccountAt(index).Name;
                this._accountEditorFormView.AccountLogin = this._model.GetBaseAccountAt(index).Login;
                this._accountEditorFormView.AccountPassword = this._model.GetBaseAccountAt(index).Password;
                this._accountEditorFormView.AccountPosition = this._model.GetBaseAccountAt(index).Position;
            }
            else
            {
                this._accountEditorFormView.AccountName = string.Empty;
                this._accountEditorFormView.AccountLogin = string.Empty;
                this._accountEditorFormView.AccountPassword = string.Empty;
                this._accountEditorFormView.AccountPosition = 0;
            }
        }

        public void OnErrorOcured(object sender, ErrorEventArgs e)
        {
            this._accountEditorFormView.DisplayMessage(e.ErrorMessage, e.ErrorSource);
        }

        public void OnAccountEditorViewClosing(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(FormClosingEventArgs))
            {
                MyDialogResult dialogResult = this._accountEditorFormView.DisplayYesNoCancelQuestion("Do you want save changes?", "Editing Results");
                if (dialogResult == MyDialogResult.Cancel)
                    (e as FormClosingEventArgs).Cancel = true;
                else if (dialogResult == MyDialogResult.No)
                {
                    this._model.BaseAccountListLoadFromFile(Settings.BaseAccountsFilePath);
                }
                else if (dialogResult == MyDialogResult.Yes)
                {
                    this._model.BaseAccountListSaveToFile(Settings.BaseAccountsFilePath);
                }
            }
        }
    }
}
