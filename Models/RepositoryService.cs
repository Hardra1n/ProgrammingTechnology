﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RepositoryService : IRepositoryService
    {
        List<Patient> patients;
        private decimal end_of_patient_index = 0;

        public event Action PatientAdded;
        public event Action ResearchAdded;

        public RepositoryService () {
            patients = new List<Patient>();
        }
        
        public void AddPatient (string name, string surname, string fathername, byte age, string sex)
        {
            if (IsAlreadyHere(name, surname, fathername))
                return;
            patients.Add(new Patient(name, surname, fathername, age, sex, end_of_patient_index++));
            PatientAdded?.Invoke();
        }

        public List<Patient> SendAllPatients()
        {
            return patients;
        }

        public IEnumerable<Research> SendAllResearches(Patient patient)
        {
            return patient.researches;
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
            patient.researches.Add(new Research((int)patient.researches.Count, date, type, duration, ArterialPressInd, SkinTempInd, SkinMoisureInd, ElectrCondInd, PulseInd));
            ResearchAdded?.Invoke();
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

        public bool IsAlreadyHere(string name, string surname, string fathername)
        {
            foreach (Patient patient in patients)
            {
                if (name == patient.name && surname == patient.surname && fathername == patient.fathername)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
