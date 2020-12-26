using Models;
using Presenter;
using Presenter.Presenters;
using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class MainMenu : Form, IMainMenu
    {
        RepositoryService _service;

        public event Action AddPatientShow;

        public MainMenu()
        {
            InitializeComponent();
            _service = new RepositoryService();
            MainMenuPresenter presenter = new MainMenuPresenter(this, _service);
        }

        private void AddPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientShow?.Invoke();              
                                                    
        }

        public void UpdatePatientList(IEnumerable patients)
        {
            int y = 7;
            foreach (Patient patient in patients)
            {
                Button button = new Button();
                button.Tag = patient.id.ToString();
                StringBuilder buttonName = new StringBuilder();
                button.Text = buttonName.Append(patient.surname)
                                        .Append(" ")
                                        .Append(patient.name)
                                        .Append(" ")
                                        .Append(patient.fathername)
                                        .ToString();

                button.Location = new Point(10, y);
                y += 30;
                button.Width = Width - 40;
                button.BackColor = SystemColors.ScrollBar;
                button.Click += ShowPatientInfoForm;
                button.Font = new Font("Segoe UI", 9f);
                button.TextAlign = ContentAlignment.MiddleLeft;
                patientPanel.Controls.Add(button);
            }
        }

        private void ShowPatientInfoForm (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button!=null)
            {
                PatientInfoForm patientInfoForm = new PatientInfoForm(_service,_service.GetPatient(int.Parse(button.Tag.ToString())));
                patientInfoForm.Show();
            }

        }

    }
}
