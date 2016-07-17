using System;
using LibEquine;
using System.Xml;
using System.Data;
using System.Linq;
using System.Text;
using WebSocket4Net;
using System.Drawing;
using Newtonsoft.Json;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;



namespace WSClient
{
    public partial class frmMain : Form
    {
        //Variables
        int _step;
        int _numberOfSteps;
        ///Create a Horse object
        Horse _horse;
        XmlHandler _xmlHandler;
        SocketClient _socketClient;
        Analytics _horseAnalysis;
        List<Label> _labels;
        System.Windows.Forms.Timer peekTimer = new System.Windows.Forms.Timer();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _horse = new Horse();
            _labels = new List<Label>();
            _xmlHandler = new XmlHandler();
            _socketClient = new SocketClient(txtIP.Text);

            //Assign Events of the socket client
            _socketClient.WebSocketOpened += websocket_Opened;
            _socketClient.WebSocketClosed += websocket_Closed;
            _socketClient.SampleArrived += websocket_Message;
            _socketClient.PeekSampleArrived += websocket_PeekMessage;

            _step = 1;
            _numberOfSteps = 4;

            //Setup file dialogs
            sfdSaveXml.InitialDirectory = "C:\\Data\\Users\\waerenbl\\Documents\\2. Personal\\Equine\\WSClient\\DataLogs";
            ofdOpenXml.InitialDirectory = "C:\\Data\\Users\\waerenbl\\Documents\\2. Personal\\Equine\\WSClient\\DataLogs";

            lblFileName.Text = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _socketClient.Open(txtIP.Text);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _socketClient.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            stage_sampling_started();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _xmlHandler.Clear();
            stage_sampling_stopped();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            _xmlHandler.Clear();

            //Set the stage          
            stage_start_calibration();

            //Initialise timer
            peekTimer.Tick += new EventHandler(peekTimer_Tick);
            peekTimer.Interval = 500;
            peekTimer.Enabled = true;
            peekTimer.Start();

            _socketClient.NextSample();
        }

        private void pbStopCalibration_Click(object sender, EventArgs e)
        {
            //Set the stage
            stage_stop_calibration();

            //Stop sampling
            _socketClient.StopSampling();
        }

        private void pbOpen_Click(object sender, EventArgs e)
        {
            ofdOpenXml.ShowDialog();
        }

        private void ofdOpenXml_FileOk(object sender, CancelEventArgs e)
        {
            _xmlHandler.LoadFile(ofdOpenXml.FileName);

            lblFileName.Text = ofdOpenXml.SafeFileName;
            pbAnalyse.Visible = true;
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            sfdSaveXml.ShowDialog();
        }

        private void sfdSaveXml_FileOk(object sender, CancelEventArgs e)
        {
            foreach (Sample sample in _xmlHandler.SampleList)
                _xmlHandler.WriteSample(sample);

            _xmlHandler.SaveToFile(sfdSaveXml.FileName);

            _xmlHandler.Clear();
        }

        private void pbAnalyse_Click(object sender, EventArgs e)
        {
            _step = 1;
            _numberOfSteps = 4;

            foreach (Sample sample in _xmlHandler.SampleList)
                foreach (Types.SensorLocation sensorLocation in Enum.GetValues(typeof(Types.SensorLocation)))
                    _horse.addDataPoint(new ForcePoint(sample.timestamp, sample.forcevalues[(int)sensorLocation]), sample.hoof, sensorLocation);

            ///Analyse the horse 
            pnlAnalysis.Visible = true;
            _horseAnalysis = new Analytics(_horse);
            
            plotSteps(_horseAnalysis.StepSequences, _step, _numberOfSteps);

            lblStep.Text = _step.ToString();
            lblNumberOfSteps.Text = _numberOfSteps.ToString();
        }

        private void pbUp_Click(object sender, EventArgs e)
        {
            if ((_step + _numberOfSteps )< _horseAnalysis.StepSequences.Max(x => x.Steps.Count))
                _step++;

            lblStep.Text = _step.ToString();
            plotSteps(_horseAnalysis.StepSequences, _step, _numberOfSteps);
        }

        private void pbDown_Click(object sender, EventArgs e)
        {
            if(_step > 1)
                _step--;

            lblStep.Text = _step.ToString();
            plotSteps(_horseAnalysis.StepSequences, _step, _numberOfSteps);
        }

        private void pbMore_Click(object sender, EventArgs e)
        {
            if((_step + _numberOfSteps) < _horseAnalysis.StepSequences.Max(x => x.Steps.Count))
                _numberOfSteps++;

            lblNumberOfSteps.Text = _numberOfSteps.ToString();
            plotSteps(_horseAnalysis.StepSequences, _step, _numberOfSteps);
        }

        private void pbLess_Click(object sender, EventArgs e)
        {
            if(_numberOfSteps > 1)
                _numberOfSteps--;

            lblNumberOfSteps.Text = _numberOfSteps.ToString();
            plotSteps(_horseAnalysis.StepSequences, _step, _numberOfSteps);
        }

        private void cbRawData_CheckedChanged(object sender, EventArgs e)
        {
            Chart chart;

            foreach (Hoof hoof in _horse.Hoofs)
            {
                if (hoof.HoofLocation.Equals(Types.HoofLocation.FRONT_RIGHT))
                    chart = chRight;
                else
                    chart = chLeft;

                foreach (Sensor sensor in hoof.Sensors)
                {
                    if (!cbRawData.Checked)
                        this.clearChart(chart, sensor.SensorLocation.ToString());
                    else
                    {
                        chart.Series.Add(sensor.SensorLocation.ToString());
                        chart.Series[sensor.SensorLocation.ToString()].ChartType = SeriesChartType.FastLine;
                        chart.Series[sensor.SensorLocation.ToString()].BorderWidth = 3;

                        switch (sensor.SensorLocation)
                        {
                            case Types.SensorLocation.REAR_LEFT:
                                chart.Series[sensor.SensorLocation.ToString()].Color = Color.DarkRed;
                                chart.Series[sensor.SensorLocation.ToString()].BorderWidth = 6;
                                break;

                            case Types.SensorLocation.REAR_RIGHT:
                                chart.Series[sensor.SensorLocation.ToString()].Color = Color.Silver;
                                chart.Series[sensor.SensorLocation.ToString()].BorderWidth = 6;
                                break;

                            case Types.SensorLocation.TOP_LEFT:
                                chart.Series[sensor.SensorLocation.ToString()].Color = Color.MediumVioletRed;
                                break;

                            case Types.SensorLocation.TOP_RIGHT:
                                chart.Series[sensor.SensorLocation.ToString()].Color = Color.Salmon;
                                break;
                        }

                        foreach (ForcePoint forcepoint in sensor.RawStream)
                            chart.Series[sensor.SensorLocation.ToString()].Points.AddXY(forcepoint.TimeStamp, forcepoint.ForceValue);
                    }
                }
            }
        }

        private void cbSteps_CheckedChanged(object sender, EventArgs e)
        {
            plotSteps(_horseAnalysis.StepSequences, _step, _numberOfSteps);
        }

        private void cbDelta_CheckedChanged(object sender, EventArgs e)
        {
            plotSteps(_horseAnalysis.StepSequences, _step, _numberOfSteps);
        }

        private void initialiseChart(Chart chart, string seriesName, Color color)
        {
            chart.Series.Add(seriesName);
            chart.Series[seriesName].Color = color;
            chart.Series[seriesName].BorderWidth = 5;
            chart.Series[seriesName].ChartType = SeriesChartType.FastLine;
        }

        private void addStepToChart(Chart chart, string seriesName, Step step)
        {
            int height = 0;

            if (step.StepStatus.Equals(StepStatus.High))
                height = 500;

            chart.Series[seriesName].Points.AddXY(step.StartTime, height);
            chart.Series[seriesName].Points.AddXY(step.StopTime, height);
        }

        private void clearChart(Chart chart, string seriesName)
        {
            if(chart.Series.FindByName(seriesName) != null)
                chart.Series.Remove(chart.Series[seriesName]);
        }

        private void setChartXAxis(Chart chart, double minVal, double maxVal)
        {
            chart.ChartAreas["ChartArea1"].AxisX.Minimum = minVal;
            chart.ChartAreas["ChartArea1"].AxisX.Maximum = maxVal;
            chart.Update();
        }

        private Label addLabel(Chart chart, Step step, Color foreColor)
        {
            Label label = new Label();
            chart.Update();

            //Visual setup
            label.ForeColor = foreColor;
            label.Text = step.Duration.ToString() + "ms";
            label.TextAlign = ContentAlignment.MiddleCenter;

            //Location
            Axis axisX = chart.ChartAreas["ChartArea1"].AxisX;
            Size size = new System.Drawing.Size((int)(axisX.ValueToPixelPosition(step.StopTime) - axisX.ValueToPixelPosition(step.StartTime)) - 150, 20);

            int yCoord = chart.Location.Y + 150;
            if(step.StepStatus.Equals(StepStatus.Low))
                yCoord = chart.Location.Y + 300;
            
            Point location = new Point((chart.Location.X + 100) + (int)axisX.ValueToPixelPosition(step.StartTime), yCoord);
            label.Size = size;
            label.Location = location;

            //Add to stage
            this.Controls.Add(label);
            label.BringToFront();

            return label;
        }

        private void clearLabels(List<Label> labels)
        {
            foreach(Label label in labels)
                this.Controls.Remove(label);

            labels.Clear();
        }

        private void plotSteps(List<StepSequence> stepSequences, int startStep, int nrOfSteps)
        {
            List<Step> renderedSteps = new List<Step>();

            StepSequence rightSequence = stepSequences.Find(x => x.HoofLocation.Equals(Types.HoofLocation.FRONT_RIGHT));
            StepSequence leftSequence = stepSequences.Find(x => x.HoofLocation.Equals(Types.HoofLocation.FRONT_LEFT));

            clearChart(chRight, "STEP");
            clearChart(chRight, "DELTA");
            clearChart(chLeft, "STEP");
            clearChart(chLeft, "DELTA");
            clearLabels(_labels);

            if (cbSteps.Checked)
            {
                initialiseChart(chRight, "STEP", Color.White);
                initialiseChart(chLeft, "STEP", Color.White);

                double MinVal = rightSequence.Steps.GetRange(startStep, nrOfSteps).Min(x => x.StartTime);
                double MaxVal = rightSequence.Steps.GetRange(startStep, nrOfSteps).Max(x => x.StopTime);

                //align axis
                setChartXAxis(chLeft, MinVal, MaxVal);
                setChartXAxis(chRight, MinVal, MaxVal);

                for (int i = startStep; i < (startStep + nrOfSteps); i++)
                {
                    Step rStep = rightSequence.Steps[i];
                    List<Step> lSteps = leftSequence.Steps.FindAll(x => ((x.StopTime > rStep.StartTime && x.StopTime < rStep.StopTime)
                        || (x.StartTime > rStep.StartTime && x.StartTime < rStep.StopTime)) && (!renderedSteps.Exists(y => y.StepNumber.Equals(x.StepNumber))));

                    renderedSteps.AddRange(lSteps);

                    ForcePoint forcePoint = new ForcePoint(rStep.StartTime, 0);

                    addStepToChart(chRight, "STEP", rStep);
                    _labels.Add(addLabel(chRight, rStep, Color.White));

                    foreach (Step lStep in lSteps)
                    {
                        addStepToChart(chLeft, "STEP", lStep);
                        _labels.Add(addLabel(chLeft, lStep, Color.White));
                    }
                }
            }

            if (cbDelta.Checked)
            {

                //Show delta
                initialiseChart(chRight, "DELTA", Color.Orange);
                initialiseChart(chLeft, "DELTA", Color.Orange);

                foreach (Step step in _horseAnalysis.DeltaSequence.Steps)
                {
                    addStepToChart(chRight, "DELTA", step);
                    addStepToChart(chLeft, "DELTA", step);
                }
            }
        }
        
        void peekTimer_Tick(object sender, EventArgs e)
        {
            _socketClient.RetrieveSamples();
        }
        
        /// <summary>
        /// Plot sample valules onto the correct hoof drawing
        /// </summary>
        /// <param name="sample">The sample that must be plotted on the hoof drawing</param>
        private void plotOnHoof(Sample sample)
        {
            MethodInvoker hoofAction = null;

            switch (sample.hoof)
            {
                case Types.HoofLocation.FRONT_LEFT:

                    hoofAction = delegate
                    {
                        lblLeftRearLeft.Text = sample.forcevalues[(int)Types.SensorLocation.REAR_LEFT].ToString();
                        lblLeftRearRight.Text = sample.forcevalues[(int)Types.SensorLocation.REAR_RIGHT].ToString();
                        lblLeftTopLeft.Text = sample.forcevalues[(int)Types.SensorLocation.TOP_LEFT].ToString();
                        lblLeftTopRight.Text = sample.forcevalues[(int)Types.SensorLocation.TOP_RIGHT].ToString();
                    };      
              
                    break;

                case Types.HoofLocation.FRONT_RIGHT:

                    hoofAction = delegate
                    {
                        lblRightRearLeft.Text = sample.forcevalues[(int)Types.SensorLocation.REAR_LEFT].ToString();
                        lblRightRearRight.Text = sample.forcevalues[(int)Types.SensorLocation.REAR_RIGHT].ToString();
                        lblRightTopLeft.Text = sample.forcevalues[(int)Types.SensorLocation.TOP_LEFT].ToString();
                        lblRightTopRight.Text = sample.forcevalues[(int)Types.SensorLocation.TOP_RIGHT].ToString();
                    };

                    break;

                default:
                    break;
            }                        

            pnlCalibrate.BeginInvoke(hoofAction);
        }

        private void websocket_Message(object sender, MessageReceivedEventArgs e)
        {
            Sample sample = JsonConvert.DeserializeObject<Sample>(e.Message);
        }

        private void websocket_PeekMessage(object sender, MessageReceivedEventArgs e)
        {
            Sample sample = JsonConvert.DeserializeObject<Sample>(e.Message);
        }

        private void websocket_Opened(object sender, EventArgs e)
        {
            MethodInvoker openedAction = delegate
            {
                stage_connection_opened();
            };
            this.BeginInvoke(openedAction);
        }

        private void websocket_Closed(object sender, EventArgs e)
        {
            MethodInvoker closeAction = delegate
            {
                stage_connection_closed();
            };
            this.BeginInvoke(closeAction);
        }

        private void stage_connection_opened()
        {
            txtIP.Enabled = false;
            btnConnect.Visible = false;
            btnDisconnect.Visible = true;
            pbCalibrate.Visible = true;
            pbPlay.Visible = true;
            pbStop.Visible = false;
            pbOpen.Visible = false;
        }

        private void stage_connection_closed()
        {
            txtIP.Enabled = true;
            btnConnect.Visible = true;
            btnDisconnect.Visible = false;
            pbPlay.Visible = false;
            pbStop.Visible = false;
            pbCalibrate.Visible = false;
            pnlCalibrate.Visible = false;
            pbStopCalibration.Visible = false;
            pbSave.Visible = false;
            pbOpen.Visible = true;
        }

        private void stage_sampling_started()
        {
            pbLoading.Visible = true;
            pbPlay.Visible = false;
            pbStop.Visible = true;
            pbSave.Visible = false;
            pbCalibrate.Visible = false;
            pbAnalyse.Visible = false;
        }

        private void stage_sampling_stopped()
        {
            pbLoading.Visible = false;
            pbPlay.Visible = true;
            pbStop.Visible = false;
            pbSave.Visible = true;
            pbCalibrate.Visible = true;
            pbAnalyse.Visible = true;
        }

        private void stage_start_calibration()
        {
            pbCalibrate.Visible = false;
            pbStopCalibration.Visible = true;
            pbPlay.Visible = false;
            pnlCalibrate.Visible = true;
            pbSave.Visible = false;
            pbAnalyse.Visible = false;
        }

        private void stage_stop_calibration()
        {
            pbPlay.Visible = true;
            pbCalibrate.Visible = true;
            pbStopCalibration.Visible = false;
            pnlCalibrate.Visible = false;
            pbAnalyse.Visible = false;
        }
    }
}
