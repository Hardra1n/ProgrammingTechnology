using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Models.Sensor
{
    public class SkinTempSensor : ISensor
    {
        public int MaxValue { get; } = 45;

        public int MinValue { get; } = 32;

        Random randomValue = new Random(36);
        public GraphPane _pane { get; set; }
        public PointPairList _ppList { get; set; }
        public ZedGraphControl _graphControl { get; set; }

        public string NameOfSensor { get; } = "Температура кожи";
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
