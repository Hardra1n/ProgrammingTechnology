using Models;
using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Interfaces
{
    public interface IAddPatientResearch : IView
    {
        event Action<Patient, DateTime, string, int, bool, bool, bool, bool, bool> AddResearch;
    }
}
