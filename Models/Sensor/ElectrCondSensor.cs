using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Models.Sensor
{
    public class ElectrCondSensor : ISensor
    {
        public int MaxValue { get; } = 35;

        public int MinValue { get; } = 20;
        Random randomValue = new Random(21);
        public GraphPane _pane { get; set; }
        public PointPairList _ppList { get; set; }
        public ZedGraphControl _graphControl { get; set; }

        public string NameOfSensor { get; } = "Проводимость кожи";
        public bool IsActive { get; set; }
        public int Value { get; set; } = 0;

        public void CalculateValue()
        {
            Value = randomValue.Next(MinValue, MaxValue);
        }

        public int SendValue()
        {
            return Value;
        }
    }
}
