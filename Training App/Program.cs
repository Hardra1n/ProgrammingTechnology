using Ninject;
using Presenter;
using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StandardKernel kernal = new StandardKernel();
            kernal.Bind<IAddPatient>().To<AddPatientForm>();
            kernal.Bind<IMainMenu>().To<MainMenu>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
