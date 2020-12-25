
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Models.Sensor
{
    public class ArterialPressSensor : ISensor
    {
        public int MaxValue { get; } = 300;

        public int MinValue { get; } = 0;
        Random randomValue = new Random(139);
        public GraphPane _pane { get; set; }
        public PointPairList _ppList { get; set; }
        public ZedGraphControl _graphControl { get; set; }

        public string NameOfSensor { get; } = "Артериальное давление";

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
