using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Patient
    {
        public decimal id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string fathername { get; set; }
        public byte age { get; set; }
        public string sex { get; set; }

        public List<Research> researches = new List<Research>();

        public Patient(string name, string surname, string fathername, byte age, string sex, decimal id)
        {
            this.name = name;
            this.surname = surname;
            this.fathername = fathername;
            this.age = age;
            this.sex = sex;
            this.id = id;
        }

    }
}
