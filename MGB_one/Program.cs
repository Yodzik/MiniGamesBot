using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MGB_one.View;
using MGB_one.Presenter;
using MGB_one.Model;

namespace MGB_one
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            var model = new MGBModel();
            var mainFormView = new MainFormView();
            var mainFormPresenter = new MainViewPresenter(mainFormView, model);
            Application.Run(mainFormView);
        }
    }
}
