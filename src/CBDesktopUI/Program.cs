using CBDesktopUI.Library.DataAccess;
using CBDesktopUI.Presenter;
using CBDesktopUI.ViewAbstraction;
using System;
using System.Windows.Forms;

namespace CBDesktopUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainView mainView = new MainForm();
            IPersonData personData = new PersonData();
            IComboBoxData boxData = new ComboBoxData();

            var mainPresenter = new MainPresenter(mainView, personData, boxData);
            mainPresenter.ShowView();
        }
    }
}
