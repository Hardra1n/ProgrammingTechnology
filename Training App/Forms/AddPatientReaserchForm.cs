using Models;
using System;
using System.Windows.Forms;
using View.Interfaces;
using View.Presenters;

namespace View
{
    public partial class AddPatientReaserchForm : Form, IAddPatientResearch
    {
        public Patient _patient;
        public AddPatientReaserchForm()
        {
            InitializeComponent();
        }
        public AddPatientReaserchForm(IRepositoryService service, Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            AddPatientResearchPresenter presenter = new AddPatientResearchPresenter(this, service);
        }

        public event Action<Patient, DateTime, string, int, bool, bool, bool, bool, bool> AddResearch;

        private void AddResearchClick(object sender, EventArgs e)
        {
            string type = null;
            if (runRadioButton.Checked)
                type = runRadioButton.Text;
            if (walkRadioButton.Checked)
                type = walkRadioButton.Text;
            if (bycicleRadioButton.Checked)
                type = bycicleRadioButton.Text;
            if (powerRadioButton.Checked)
                type = powerRadioButton.Text;
            DateTime date = dateTimePicker.Value;
            int duration = (int)durationNumericUpDown.Value;
            bool ArterialPressInd = researchTypeCheckedListBox.GetItemChecked(0);
            bool SkinTempInd = researchTypeCheckedListBox.GetItemChecked(1);
            bool SkinMoisureInd = researchTypeCheckedListBox.GetItemChecked(2);
            bool ElectrCondInd = researchTypeCheckedListBox.GetItemChecked(3);
            bool PulseInd = researchTypeCheckedListBox.GetItemChecked(4);
            AddResearch?.Invoke(_patient, date, type, duration, ArterialPressInd, SkinTempInd, SkinMoisureInd, ElectrCondInd, PulseInd);
        }

    }
}
