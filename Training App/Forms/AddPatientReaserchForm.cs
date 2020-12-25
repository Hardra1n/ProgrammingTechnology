using Models;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class AddPatientReaserchForm : Form
    {
        ControlService _service;
        Patient _patient;
        PatientInfoForm _view;
        public AddPatientReaserchForm()
        {
            InitializeComponent();
        }
        public AddPatientReaserchForm(ControlService service, Patient patient, PatientInfoForm view)
        {
            InitializeComponent();
            _service = service;
            _patient = patient;
            _view = view;
        }

        private void AddResearchClick(object sender, EventArgs e)
        {
            string type = null;
            if (radioButton1.Checked)
                type = radioButton1.Text;
            if (radioButton2.Checked)
                type = radioButton2.Text;
            if (radioButton3.Checked)
                type = radioButton3.Text;
            if (radioButton4.Checked)
                type = radioButton4.Text;
            DateTime date = dateTimePicker1.Value;
            int duration = (int)numericUpDown1.Value;
            bool ArterialPressInd = checkedListBox1.GetItemChecked(0);
            bool SkinTempInd = checkedListBox1.GetItemChecked(1);
            bool SkinMoisureInd = checkedListBox1.GetItemChecked(2);
            bool ElectrCondInd = checkedListBox1.GetItemChecked(3);
            bool PulseInd = checkedListBox1.GetItemChecked(4);
            _service.AddResearch(_patient, date, type, duration, ArterialPressInd, SkinTempInd, SkinMoisureInd, ElectrCondInd, PulseInd);
            _view.UpdateResearchList(); 
            this.Close();
    }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
