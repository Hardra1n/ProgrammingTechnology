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
    public partial class AddPatientForm : Form
    {
        ControlService _service;
        MainMenu _form;
        public AddPatientForm(ControlService service, MainMenu form)
        {
            InitializeComponent();
            _service = service;
            _form = form;
            nameTextBox.Text = surnameTextBox.Text = fatherNameTextBox.Text = string.Empty;
        }

        private void AddPatientButton(object sender, EventArgs e)
        {
            if( nameTextBox.Text != string.Empty && surnameTextBox.Text != string.Empty && fatherNameTextBox.Text != string.Empty) {


                _service.AddPatient(nameTextBox.Text, surnameTextBox.Text, fatherNameTextBox.Text, (byte)ageNumericUpDown.Value, femaleRadioButton.Checked? "Женский" : "Мужской");
                _form.UpdatePatientList();
                this.Close(); 
            }
        }
    }
}
