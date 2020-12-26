using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IRepositoryService
    {

        event Action PatientAdded;
        void AddPatient(string name, string surname, string fathername, byte age, string sex);
        void AddResearch(Patient patient, DateTime date, string type, int duration, bool ArterialPressInd, bool SkinTempInd, bool SkinMoisureInd, bool ElectrCondInd, bool PulseInd);

        List<Patient> SendAllPatients();
        Patient GetPatient(int id);
        Research GetResearch(int id, Patient patient);
        string GetResearchInfo(Research research);

    }
}
