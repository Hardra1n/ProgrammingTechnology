using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Models.Sensor
{
    public interface ISensor
    {
        int MaxValue { get; }
        int MinValue { get; }

        int Value { get; set; }

        GraphPane _pane { get; set; }
        PointPairList _ppList { get; set; }
        ZedGraphControl _graphControl { get; set; }
        string NameOfSensor { get; }
        bool IsActive { get; set; }
        int SendValue();
        void CalculateValue();
    }
}
