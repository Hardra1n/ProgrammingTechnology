using Models;
using Presenter.Interfaces;
using System.Reflection;
using View;

namespace Presenter.Presenters
{
    public class MainMenuPresenter
    {
        IMainMenu _view;
        IRepositoryService _service;


        public MainMenuPresenter(IMainMenu view, IRepositoryService service)
        {
            _view = view;
            _service = service;
            _view.AddPatientShow += AddPatientShow;
            _service.PatientAdded += PatientAdddedHandler;

        }

        private void AddPatientShow()
        {
            IAddPatient form = new AddPatientForm(_service, _view);
            form.Show();
        }

        private void PatientAdddedHandler()
        {
            _view.UpdatePatientList(_service.SendAllPatients());
        }
    }
}
