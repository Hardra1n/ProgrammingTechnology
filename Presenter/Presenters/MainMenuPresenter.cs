using Models;
using Presenter.Interfaces;
using System.Reflection;

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


        }

        private void AddPatientShow()
        {
            IAddPatient form = new AddPatientForm();
        }
    }
}
