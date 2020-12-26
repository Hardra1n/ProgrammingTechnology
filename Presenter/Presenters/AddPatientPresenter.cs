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
        }
    }
}
