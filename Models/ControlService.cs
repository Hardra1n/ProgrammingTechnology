using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ControlService
    {
        List<Patient> patients;
        private decimal end_of_patient_index = 0;

        public ControlService () {
            patients = new List<Patient>();
        }
        
        public void AddPatient (string name, string surname, string fathername, byte age, string sex)
        {
            patients.Add(new Patient(name, surname, fathername, age, sex, end_of_patient_index++));
        }

        public List<Patient> SendAllPatients()
        {
            return patients;
        }

        public Patient GetPatient(int id)
        {
            foreach (Patient patient in patients)
            {
                if (patient.id == id)
                    return patient;
            }
            return null; 
        }
        public void AddResearch(Patient patient, DateTime date, string type, int duration, bool ArterialPressInd, bool SkinTempInd, bool SkinMoisureInd, bool ElectrCondInd, bool PulseInd)
        {
            patient.researches.Add(new Research(patient.researches.Count, date, type, duration, ArterialPressInd, SkinTempInd, SkinMoisureInd, ElectrCondInd, PulseInd));
        }

        public Research GetResearch(int id, Patient patient)
        {
            return patient.researches[id];
        }

        public string GetResearchInfo(Research research)
        {
            StringBuilder str = new StringBuilder();
            return str.Append(research.date.ToString())
                                        .Append(" ")
                                        .Append(research.type.ToString())
                                        .Append(" ")
                                        .Append(research.duration.ToString())
                                        .Append(" min")
                                        .ToString();
        }
    
    }
}
