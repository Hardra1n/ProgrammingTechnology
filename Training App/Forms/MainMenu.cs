using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MainMenu : Form
    {
        ControlService _service;
        public MainMenu()
        {
            InitializeComponent();
            _service = new ControlService();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm(_service, this);
            addPatientForm.Show();
        }

        public void UpdatePatientList()
        {
            int y = 7;
            foreach (Patient patient in _service.SendAllPatients())
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
                button.Click += ButtonOnClick;
                button.Font = new Font("Segoe UI", 9f);
                button.TextAlign = ContentAlignment.MiddleLeft;
                patientPanel.Controls.Add(button);
            }
        }

        private void ButtonOnClick (object sender, EventArgs e)
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
