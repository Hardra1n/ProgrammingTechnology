using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter.Interfaces
{
    public interface IAddPatient : IView
    {
        event Action<string, string, string, byte, string> PatientAdd;
    }
}
