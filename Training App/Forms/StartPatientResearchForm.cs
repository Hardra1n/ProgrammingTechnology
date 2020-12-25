using Models;
using Models.Sensor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace View
{
    public partial class StartPatientResearchForm : Form
    {

        private ControlService _service;
        private Research _research;
        private List<ISensor> sensors = new List<ISensor>();
        private bool isSensorsActive = false;
        Timer _timer;
        private int n = 0;

        public StartPatientResearchForm()
        {
            InitializeComponent();
        }

        public StartPatientResearchForm(ControlService service, Research research)
        {
            InitializeComponent();
            _service = service;
            _research = research;
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += TimerTicked;
            label6.Text = _service.GetResearchInfo(research);
        }

        private void StartPatientResearchForm_Load(object sender, System.EventArgs e)
        {
            InitializeSensors();
            DrawingGraphs();
        }

        private void InitializeSensors()
        {
            if (_research.ElectrCondInd)
                sensors.Add(new ElectrCondSensor());
            if (_research.ArterialPressInd)
                sensors.Add(new ArterialPressSensor());
            if (_research.PulseInd)
                sensors.Add(new PulseSensor());
            if (_research.SkinMoisureInd)
                sensors.Add(new SkinMoisureSensor());
            if (_research.SkinTempInd)
                sensors.Add(new SkinTempSensor());
        }

        private void DrawingGraphs()
        {
            int y = 7;
            int x = 10;
            int i = 0;
            foreach (ISensor sensor in sensors)
            {
                PointPairList ppList = new PointPairList();
                ZedGraphControl graphControl = new ZedGraphControl();
                GraphPane pane = graphControl.GraphPane;

                sensor._pane = pane;     
                sensor._ppList = ppList;       
                sensor._graphControl = graphControl;
                graphControl.Location = new System.Drawing.Point(x, y);
                graphControl.Name = sensor.NameOfSensor;
                graphControl.Size = new System.Drawing.Size(350, 200);
                panel1.Controls.Add(graphControl);

                pane.Title.Text = sensor.NameOfSensor;
                pane.XAxis.Scale.Min = 0;
                pane.XAxis.Scale.Max = _research.duration + 1;
                pane.XAxis.Scale.MajorStep = 1;
                pane.YAxis.Scale.Max = sensor.MaxValue;
                pane.YAxis.Scale.MajorStep = 5;
                graphControl.AxisChange();
                graphControl.Invalidate();
              
                if (i%2 == 0)
                {
                    x += 355;
                } else
                {
                    y += 205;
                    x -= 355;
                }
                i++;
            }
        }

        private void StartResearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (n < _research.duration)
                _timer.Start();
        }

        private void TimerTicked(object sender, EventArgs e)
        {
            if (n == _research.duration)
            {
                _timer.Stop();
                ShowEndMessage();
            } 
            StringBuilder str = new StringBuilder();
            if (isSensorsActive)
            {
                UpdateGraphInfo();
            }
            label9.Text = str.Append(n++).Append(" min").ToString();

        }
        public void ShowEndMessage()
        {
            label10.Text = "Обследование закончено!";
        }
        private void UpdateGraphInfo ()
        {
            foreach (ISensor sensor in sensors)
            {
                sensor.CalculateValue(); 
                sensor._ppList.Add((double)n, (double)sensor.Value);
                sensor._pane.CurveList.Clear();
                sensor._pane.AddCurve(string.Empty, sensor._ppList, Color.Red);
                sensor._graphControl.Invalidate();
                IndicatorChange(sensor);
            }
        }

        private void IndicatorChange(ISensor sensor)
        {
            switch (sensor.NameOfSensor)
            {
                case "Артериальное давление":
                    label2.Text = sensor.Value.ToString();
                    break;
                case "Проводимость кожи":
                    label4.Text = sensor.Value.ToString();
                    break;
                case "Пульс":
                    label3.Text = sensor.Value.ToString();
                    break;
                case "Влажность кожи":
                    label5.Text = sensor.Value.ToString();
                    break;
                case "Температура кожи":
                    label1.Text = sensor.Value.ToString();
                    break;
            }
        }

        private void ActivateSensorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSensorsActive = true;
        }
    }
}
