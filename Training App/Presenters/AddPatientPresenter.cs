using Models;
using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter.Presenters
{
    public class AddPatientPresenter
    {
        IAddPatient _view;
        IRepositoryService _service;

        public AddPatientPresenter(IAddPatient view, IRepositoryService service)
        {
            _view = view;
            _service = service;
            _view.PatientAdd += AddPatient;
            _service.PatientAdded += PatientAddedHandler;
        }


        private void AddPatient(string name, string surname, string fathername, byte age, string sex)
        {
            _service.AddPatient(name, surname, fathername, age,  sex);
        }


        private void PatientAddedHandler()
        {
            _view.Close();
        }
    }
}
