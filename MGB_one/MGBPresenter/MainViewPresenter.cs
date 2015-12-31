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
            //view event subscription
            this._mainFormView.ShowAccountEditor += this.OnShowAccountEditor;
        }
        public void Initialize()
        {
            this._mainFormView.ProgramStatus = "<uninitialized>";
            this._mainFormView.SelectedProcess = "<no process selected>";
            this.OnBaseAccountListChanged(this, EventArgs.Empty);
        }

        public void OnBaseAccountListChanged(object sender, EventArgs e)
        {
            this._mainFormView.SetBaseAccountList(this._model.BaseAccountsToStringListState());
        }

        public void OnShowAccountEditor(object sender, EventArgs e)
        {
            var formAccountEditorView = new AccountEditorFormView();
            var formAccountEditorPresenter = new AccountEditorPresenter(formAccountEditorView, this._model);
            this._mainFormView.ShowAccountEditorView(formAccountEditorView);
        }
    }
}
