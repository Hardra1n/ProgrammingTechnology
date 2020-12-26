using Models;
using Presenter;
using Presenter.Interfaces;
using Presenter.Presenters;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class AddPatientForm : Form, IAddPatient
    {
        public event Action<string, string, string, byte, string> PatientAdd;



        public AddPatientForm(IRepositoryService service, IMainMenu form)
        {
            InitializeComponent();
            AddPatientPresenter presenter = new AddPatientPresenter(this , service);
            nameTextBox.Text = surnameTextBox.Text = fatherNameTextBox.Text = string.Empty;
        }



        private void AddPatientButton(object sender, EventArgs e)
        {
            if( nameTextBox.Text != string.Empty && surnameTextBox.Text != string.Empty && fatherNameTextBox.Text != string.Empty) {

                PatientAdd?.Invoke(nameTextBox.Text, surnameTextBox.Text, fatherNameTextBox.Text, (byte)ageNumericUpDown.Value, femaleRadioButton.Checked? "Женский" : "Мужской");
            }
        }
    }
}
