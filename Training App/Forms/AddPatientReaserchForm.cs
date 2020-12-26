using Models;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class AddPatientReaserchForm : Form
    {
        RepositoryService _service;
        Patient _patient;
        PatientInfoForm _view;
        public AddPatientReaserchForm()
        {
            InitializeComponent();
        }
        public AddPatientReaserchForm(RepositoryService service, Patient patient, PatientInfoForm view)
        {
            InitializeComponent();
            _service = service;
            _patient = patient;
            _view = view;
        }

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
            _service.AddResearch(_patient, date, type, duration, ArterialPressInd, SkinTempInd, SkinMoisureInd, ElectrCondInd, PulseInd);
            _view.UpdateResearchList(); 
            this.Close();
        }

    }
}
