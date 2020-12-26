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
            _view.ShowPatientInfo += ShowPatientInfo;
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

        private void ShowPatientInfo(int id)
        {
            PatientInfoForm form = new PatientInfoForm(_service, _service.GetPatient(id));
            form.Show();
        }
    }
}
