using View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.Interfaces;
using System.Collections;

namespace View.Interfaces
{
    public interface IPatientInfo : IView
    {
        event Action ShowAddResearch;
        event Action ShowResearch;
        void UpdateResearchList(IEnumerable researches);

    }
}
