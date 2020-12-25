using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Research
    {
        public decimal id;
        public DateTime date { get; set; }
        public string type { get; set; }
        public int duration { get; set; }

        public bool ArterialPressInd { get; set; }
        public bool SkinTempInd { get; set; }
        public bool SkinMoisureInd { get; set; }
        public bool ElectrCondInd { get; set; }
        public bool PulseInd { get; set; }

        public Research(decimal id,DateTime date, string type, int duration, bool ArterialPressInd,bool SkinTempInd, bool SkinMoisureInd, bool ElectrCondInd, bool PulseInd)
        {
            this.id = id;
            this.date = date;
            this.type = type;
            this.duration = duration;
            this.ArterialPressInd = ArterialPressInd;
            this.SkinTempInd = SkinTempInd;
            this.ElectrCondInd = ElectrCondInd;
            this.PulseInd = PulseInd;
            this.SkinMoisureInd = SkinMoisureInd; 
        }
    }
}
