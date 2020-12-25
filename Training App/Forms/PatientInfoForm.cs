using Models;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class PatientInfoForm : Form
    {
        ControlService _service;
        Patient _patient;

        public PatientInfoForm()
        {
            InitializeComponent();
        }

        public PatientInfoForm(ControlService service, Patient patient)
        {
            InitializeComponent();
            _service = service;
            _patient = patient;
            label6.Text = patient.name;
            label7.Text = patient.surname;
            label8.Text = patient.fathername;
            label9.Text = patient.age.ToString();
            label10.Text = patient.sex;

        }

        private void PatientInfoForm_Load(object sender, EventArgs e)
        {
            UpdateResearchList();
        }

        private void AddResearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientReaserchForm addPatientReaserchForm = new AddPatientReaserchForm(_service, _patient, this);
            addPatientReaserchForm.Show();
        }

        public void StartPatientResearchButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != null) {
                StartPatientResearchForm startPatientResearchForm = new StartPatientResearchForm(_service, _service.GetResearch(int.Parse(button.Tag.ToString()), _patient));
                startPatientResearchForm.Show();
            }
        }

        public void UpdateResearchList()
        {
            int y = 7;
            foreach (Research research in _patient.researches)
            {
                Button button = new Button();
                button.Tag = research.id.ToString();
                StringBuilder buttonName = new StringBuilder();
                button.Text = buttonName.Append(research.date.ToString())
                                        .Append(" ")
                                        .Append(research.type.ToString())
                                        .Append(" ")
                                        .Append(research.duration.ToString())
                                        .Append(" min")
                                        .ToString();
                button.Location = new Point(10, y);
                y += 30;
                button.Width = Width - 40;
                button.BackColor = SystemColors.ScrollBar;
                button.Click += StartPatientResearchButton;
                button.Font = new Font("Segoe UI", 9f);
                button.TextAlign = ContentAlignment.MiddleLeft;
                panel1.Controls.Add(button);
            }
        }
    }
}
