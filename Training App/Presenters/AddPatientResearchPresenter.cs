using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Interfaces;

namespace View.Presenters
{
    public class AddPatientResearchPresenter
    {
        IAddPatientResearch _view;

        IRepositoryService _service;
       public AddPatientResearchPresenter(IAddPatientResearch view, IRepositoryService service)
        {
            _view = view;
            _service = service;
            _view.AddResearch += AddResearch;
            _service.ResearchAdded += ResearchAddedHandler;
        }

        private void AddResearch(Patient patient, DateTime date, string type, int duration, bool ArterialPressInd, bool SkinTempInd, bool SkinMoisureInd, bool ElectrCondInd, bool PulseInd)
        {
            _service.AddResearch(patient, date, type, duration, ArterialPressInd, SkinTempInd, SkinMoisureInd, ElectrCondInd, PulseInd);
        }
        private void ResearchAddedHandler()
        {
            _view.Close();
        }

    }
}
