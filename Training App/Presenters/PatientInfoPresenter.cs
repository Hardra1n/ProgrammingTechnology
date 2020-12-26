using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Interfaces;

namespace View.Presenters
{
    public class PatientInfoPresenter
    {
        IPatientInfo _view;
        IRepositoryService _service;
        Patient _patient;
        public PatientInfoPresenter(IPatientInfo view, IRepositoryService service, Patient patient)
        {
            _view = view;
            _service = service;
            _patient = patient;
            _view.ShowAddResearch += ShowAddPatientResearch;
            _service.ResearchAdded += UpdateResearchList;

        }

        private void ShowAddPatientResearch()
        {
            IAddPatientResearch form = new AddPatientReaserchForm(_service,_patient);
            form.Show();
        }
        private void UpdateResearchList()
        {
            _view.UpdateResearchList(_service.SendAllResearches(_patient));
        }

    }
}

