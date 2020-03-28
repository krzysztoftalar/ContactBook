using CBDesktopUI.Library.DataAccess;
using CBDesktopUI.Library.Internal.DataAccess;
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

            ISqlDataAccess sql = new SqlDataAccess();
            IMainView mainView = new MainForm();
            IPersonData personData = new PersonData(sql);
            IComboBoxData boxData = new ComboBoxData(sql);

            ApplicationSeed.Seed(boxData, sql);

            var mainPresenter = new MainPresenter(mainView, personData, boxData);
            mainPresenter.ShowView();
        }
    }
}
