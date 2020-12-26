using Presenter.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IMainMenu : IView
    {
        void UpdatePatientList(IEnumerable patients);

        event Action<int> ShowPatientInfo;
        event Action AddPatientShow;
    }
}
