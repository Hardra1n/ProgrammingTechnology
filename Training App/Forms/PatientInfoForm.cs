using Models;
using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using View.Interfaces;
using View.Presenters;

namespace View
{
    public partial class PatientInfoForm : Form, IPatientInfo
    {
        IRepositoryService _service;
        Patient _patient;

        public event Action ShowAddResearch;
        public event Action ShowResearch;

        public PatientInfoForm()
        {
            InitializeComponent();
        }

        public PatientInfoForm(IRepositoryService service, Patient patient)
        {
            InitializeComponent();
            _service = service;
            _patient = patient;
            patientNameLabel.Text = patient.name;
            patientSurNameLabel.Text = patient.surname;
            patientFatherNameLabel.Text = patient.fathername;
            patientAgeLabel.Text = patient.age.ToString();
            patientSexLabel.Text = patient.sex;
            PatientInfoPresenter presenter = new PatientInfoPresenter(this, service, patient);

        }

        private void PatientInfoForm_Load(object sender, EventArgs e)
        {
            UpdateResearchList(_patient.researches);
        }

        private void AddResearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddResearch?.Invoke();
        }

        public void StartPatientResearchButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != null) {
                StartPatientResearchForm startPatientResearchForm = new StartPatientResearchForm((RepositoryService)_service, _service.GetResearch(int.Parse(button.Tag.ToString()), _patient));
                startPatientResearchForm.Show();
            }
        }

        public void UpdateResearchList(IEnumerable researches)
        {
            int y = 7;
            foreach (Research research in researches)
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
