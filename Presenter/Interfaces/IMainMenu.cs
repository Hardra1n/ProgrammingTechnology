using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IMainMenu : IView
    {
        void UpdatePatientList();

        event Action AddPatientShow;
    }
}
