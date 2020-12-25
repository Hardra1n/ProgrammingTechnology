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
            textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
        }

        private void AddPatientButton(object sender, EventArgs e)
        {
            if( textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty) {


                _service.AddPatient(textBox1.Text, textBox2.Text, textBox3.Text, (byte)numericUpDown1.Value, radioButton1.Checked? "Женский" : "Мужской");
                _form.UpdatePatientList();
                this.Close(); 
            }
        }
    }
}
