namespace WSClient
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.sfdSaveXml = new System.Windows.Forms.SaveFileDialog();
            this.pnlCalibrate = new System.Windows.Forms.Panel();
            this.lblRightRearRight = new System.Windows.Forms.Label();
            this.lblRightTopRight = new System.Windows.Forms.Label();
            this.lblLeftRearRight = new System.Windows.Forms.Label();
            this.lblLeftTopRight = new System.Windows.Forms.Label();
            this.lblRightTopLeft = new System.Windows.Forms.Label();
            this.lblLeftTopLeft = new System.Windows.Forms.Label();
            this.lblRightRearLeft = new System.Windows.Forms.Label();
            this.lblLeftRearLeft = new System.Windows.Forms.Label();
            this.pbRightHoof = new System.Windows.Forms.PictureBox();
            this.pbLeftHoof = new System.Windows.Forms.PictureBox();
            this.ofdOpenXml = new System.Windows.Forms.OpenFileDialog();
            this.pnlAnalysis = new System.Windows.Forms.Panel();
            this.cbSteps = new System.Windows.Forms.CheckBox();
            this.cbRawData = new System.Windows.Forms.CheckBox();
            this.pbLess = new System.Windows.Forms.PictureBox();
            this.pbMore = new System.Windows.Forms.PictureBox();
            this.lblNumberOfSteps = new System.Windows.Forms.Label();
            this.chLeft = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chRight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbUp = new System.Windows.Forms.PictureBox();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAnalyse = new System.Windows.Forms.PictureBox();
            this.pbOpen = new System.Windows.Forms.PictureBox();
            this.pbStopCalibration = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbCalibrate = new System.Windows.Forms.PictureBox();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.cbDelta = new System.Windows.Forms.CheckBox();
            this.lblFileName = new System.Windows.Forms.TextBox();
            this.pnlCalibrate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightHoof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftHoof)).BeginInit();
            this.pnlAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalyse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStopCalibration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalibrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.FlatAppearance.BorderSize = 5;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(297, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(181, 47);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to horse";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.SteelBlue;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.Color.White;
            this.txtIP.Location = new System.Drawing.Point(134, 23);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(157, 23);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.43.71:20";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.White;
            this.lblIP.Location = new System.Drawing.Point(12, 23);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(116, 25);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "IPaddress:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatAppearance.BorderSize = 5;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(297, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(181, 47);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Visible = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // sfdSaveXml
            // 
            this.sfdSaveXml.DefaultExt = "xml";
            this.sfdSaveXml.Filter = "Xml file (*.xml)|*.xml";
            this.sfdSaveXml.RestoreDirectory = true;
            this.sfdSaveXml.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSaveXml_FileOk);
            // 
            // pnlCalibrate
            // 
            this.pnlCalibrate.Controls.Add(this.lblRightRearRight);
            this.pnlCalibrate.Controls.Add(this.lblRightTopRight);
            this.pnlCalibrate.Controls.Add(this.lblLeftRearRight);
            this.pnlCalibrate.Controls.Add(this.lblLeftTopRight);
            this.pnlCalibrate.Controls.Add(this.lblRightTopLeft);
            this.pnlCalibrate.Controls.Add(this.lblLeftTopLeft);
            this.pnlCalibrate.Controls.Add(this.lblRightRearLeft);
            this.pnlCalibrate.Controls.Add(this.lblLeftRearLeft);
            this.pnlCalibrate.Controls.Add(this.pbRightHoof);
            this.pnlCalibrate.Controls.Add(this.pbLeftHoof);
            this.pnlCalibrate.Location = new System.Drawing.Point(297, 99);
            this.pnlCalibrate.Name = "pnlCalibrate";
            this.pnlCalibrate.Size = new System.Drawing.Size(904, 519);
            this.pnlCalibrate.TabIndex = 18;
            this.pnlCalibrate.Visible = false;
            // 
            // lblRightRearRight
            // 
            this.lblRightRearRight.AutoSize = true;
            this.lblRightRearRight.BackColor = System.Drawing.Color.Transparent;
            this.lblRightRearRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightRearRight.Location = new System.Drawing.Point(715, 451);
            this.lblRightRearRight.Name = "lblRightRearRight";
            this.lblRightRearRight.Size = new System.Drawing.Size(43, 46);
            this.lblRightRearRight.TabIndex = 26;
            this.lblRightRearRight.Text = "0";
            // 
            // lblRightTopRight
            // 
            this.lblRightTopRight.AutoSize = true;
            this.lblRightTopRight.BackColor = System.Drawing.Color.Transparent;
            this.lblRightTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightTopRight.Location = new System.Drawing.Point(715, 13);
            this.lblRightTopRight.Name = "lblRightTopRight";
            this.lblRightTopRight.Size = new System.Drawing.Size(43, 46);
            this.lblRightTopRight.TabIndex = 25;
            this.lblRightTopRight.Text = "0";
            // 
            // lblLeftRearRight
            // 
            this.lblLeftRearRight.AutoSize = true;
            this.lblLeftRearRight.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftRearRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftRearRight.Location = new System.Drawing.Point(294, 451);
            this.lblLeftRearRight.Name = "lblLeftRearRight";
            this.lblLeftRearRight.Size = new System.Drawing.Size(43, 46);
            this.lblLeftRearRight.TabIndex = 24;
            this.lblLeftRearRight.Text = "0";
            // 
            // lblLeftTopRight
            // 
            this.lblLeftTopRight.AutoSize = true;
            this.lblLeftTopRight.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftTopRight.Location = new System.Drawing.Point(294, 13);
            this.lblLeftTopRight.Name = "lblLeftTopRight";
            this.lblLeftTopRight.Size = new System.Drawing.Size(43, 46);
            this.lblLeftTopRight.TabIndex = 23;
            this.lblLeftTopRight.Text = "0";
            // 
            // lblRightTopLeft
            // 
            this.lblRightTopLeft.AutoSize = true;
            this.lblRightTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblRightTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightTopLeft.Location = new System.Drawing.Point(498, 13);
            this.lblRightTopLeft.Name = "lblRightTopLeft";
            this.lblRightTopLeft.Size = new System.Drawing.Size(43, 46);
            this.lblRightTopLeft.TabIndex = 22;
            this.lblRightTopLeft.Text = "0";
            // 
            // lblLeftTopLeft
            // 
            this.lblLeftTopLeft.AutoSize = true;
            this.lblLeftTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftTopLeft.Location = new System.Drawing.Point(81, 13);
            this.lblLeftTopLeft.Name = "lblLeftTopLeft";
            this.lblLeftTopLeft.Size = new System.Drawing.Size(43, 46);
            this.lblLeftTopLeft.TabIndex = 21;
            this.lblLeftTopLeft.Text = "0";
            // 
            // lblRightRearLeft
            // 
            this.lblRightRearLeft.AutoSize = true;
            this.lblRightRearLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblRightRearLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightRearLeft.Location = new System.Drawing.Point(498, 451);
            this.lblRightRearLeft.Name = "lblRightRearLeft";
            this.lblRightRearLeft.Size = new System.Drawing.Size(43, 46);
            this.lblRightRearLeft.TabIndex = 20;
            this.lblRightRearLeft.Text = "0";
            // 
            // lblLeftRearLeft
            // 
            this.lblLeftRearLeft.AutoSize = true;
            this.lblLeftRearLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftRearLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftRearLeft.Location = new System.Drawing.Point(81, 451);
            this.lblLeftRearLeft.Name = "lblLeftRearLeft";
            this.lblLeftRearLeft.Size = new System.Drawing.Size(43, 46);
            this.lblLeftRearLeft.TabIndex = 19;
            this.lblLeftRearLeft.Text = "0";
            // 
            // pbRightHoof
            // 
            this.pbRightHoof.Image = global::WSClient.Properties.Resources.hoof;
            this.pbRightHoof.Location = new System.Drawing.Point(421, 62);
            this.pbRightHoof.Name = "pbRightHoof";
            this.pbRightHoof.Size = new System.Drawing.Size(408, 386);
            this.pbRightHoof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRightHoof.TabIndex = 18;
            this.pbRightHoof.TabStop = false;
            // 
            // pbLeftHoof
            // 
            this.pbLeftHoof.Image = global::WSClient.Properties.Resources.hoof;
            this.pbLeftHoof.Location = new System.Drawing.Point(7, 62);
            this.pbLeftHoof.Name = "pbLeftHoof";
            this.pbLeftHoof.Size = new System.Drawing.Size(408, 386);
            this.pbLeftHoof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeftHoof.TabIndex = 17;
            this.pbLeftHoof.TabStop = false;
            // 
            // ofdOpenXml
            // 
            this.ofdOpenXml.DefaultExt = "xml";
            this.ofdOpenXml.Filter = "Xml file (*.xml)|*.xml";
            this.ofdOpenXml.RestoreDirectory = true;
            this.ofdOpenXml.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpenXml_FileOk);
            // 
            // pnlAnalysis
            // 
            this.pnlAnalysis.Controls.Add(this.cbDelta);
            this.pnlAnalysis.Controls.Add(this.cbSteps);
            this.pnlAnalysis.Controls.Add(this.cbRawData);
            this.pnlAnalysis.Controls.Add(this.pbLess);
            this.pnlAnalysis.Controls.Add(this.pbMore);
            this.pnlAnalysis.Controls.Add(this.lblNumberOfSteps);
            this.pnlAnalysis.Controls.Add(this.chLeft);
            this.pnlAnalysis.Controls.Add(this.chRight);
            this.pnlAnalysis.Controls.Add(this.pbUp);
            this.pnlAnalysis.Controls.Add(this.pbDown);
            this.pnlAnalysis.Controls.Add(this.lblStep);
            this.pnlAnalysis.Controls.Add(this.label1);
            this.pnlAnalysis.Location = new System.Drawing.Point(17, 161);
            this.pnlAnalysis.Name = "pnlAnalysis";
            this.pnlAnalysis.Size = new System.Drawing.Size(1755, 809);
            this.pnlAnalysis.TabIndex = 33;
            this.pnlAnalysis.Visible = false;
            // 
            // cbSteps
            // 
            this.cbSteps.AutoSize = true;
            this.cbSteps.Checked = true;
            this.cbSteps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSteps.ForeColor = System.Drawing.Color.White;
            this.cbSteps.Location = new System.Drawing.Point(531, 73);
            this.cbSteps.Name = "cbSteps";
            this.cbSteps.Size = new System.Drawing.Size(140, 29);
            this.cbSteps.TabIndex = 44;
            this.cbSteps.Text = "Show Steps";
            this.cbSteps.UseVisualStyleBackColor = true;
            this.cbSteps.CheckedChanged += new System.EventHandler(this.cbSteps_CheckedChanged);
            // 
            // cbRawData
            // 
            this.cbRawData.AutoSize = true;
            this.cbRawData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRawData.ForeColor = System.Drawing.Color.White;
            this.cbRawData.Location = new System.Drawing.Point(531, 26);
            this.cbRawData.Name = "cbRawData";
            this.cbRawData.Size = new System.Drawing.Size(173, 29);
            this.cbRawData.TabIndex = 43;
            this.cbRawData.Text = "Show Raw Data";
            this.cbRawData.UseVisualStyleBackColor = true;
            this.cbRawData.CheckedChanged += new System.EventHandler(this.cbRawData_CheckedChanged);
            // 
            // pbLess
            // 
            this.pbLess.Image = global::WSClient.Properties.Resources.arrow_down;
            this.pbLess.Location = new System.Drawing.Point(369, 100);
            this.pbLess.Name = "pbLess";
            this.pbLess.Size = new System.Drawing.Size(55, 47);
            this.pbLess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLess.TabIndex = 42;
            this.pbLess.TabStop = false;
            this.pbLess.Click += new System.EventHandler(this.pbLess_Click);
            // 
            // pbMore
            // 
            this.pbMore.Image = global::WSClient.Properties.Resources.arrow_up;
            this.pbMore.Location = new System.Drawing.Point(369, 8);
            this.pbMore.Name = "pbMore";
            this.pbMore.Size = new System.Drawing.Size(55, 47);
            this.pbMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMore.TabIndex = 41;
            this.pbMore.TabStop = false;
            this.pbMore.Click += new System.EventHandler(this.pbMore_Click);
            // 
            // lblNumberOfSteps
            // 
            this.lblNumberOfSteps.AutoSize = true;
            this.lblNumberOfSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSteps.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfSteps.Location = new System.Drawing.Point(326, 63);
            this.lblNumberOfSteps.Name = "lblNumberOfSteps";
            this.lblNumberOfSteps.Size = new System.Drawing.Size(135, 25);
            this.lblNumberOfSteps.TabIndex = 40;
            this.lblNumberOfSteps.Text = "lblNrOfSteps";
            // 
            // chLeft
            // 
            this.chLeft.BackColor = System.Drawing.Color.SteelBlue;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.SteelBlue;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chLeft.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.SteelBlue;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.chLeft.Legends.Add(legend3);
            this.chLeft.Location = new System.Drawing.Point(220, 506);
            this.chLeft.Name = "chLeft";
            this.chLeft.Size = new System.Drawing.Size(1513, 300);
            this.chLeft.TabIndex = 39;
            this.chLeft.Text = "chLeft";
            // 
            // chRight
            // 
            this.chRight.BackColor = System.Drawing.Color.SteelBlue;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.SteelBlue;
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chRight.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.SteelBlue;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.Name = "Legend1";
            this.chRight.Legends.Add(legend4);
            this.chRight.Location = new System.Drawing.Point(220, 184);
            this.chRight.Name = "chRight";
            this.chRight.Size = new System.Drawing.Size(1513, 300);
            this.chRight.TabIndex = 38;
            this.chRight.Text = "chLeft";
            // 
            // pbUp
            // 
            this.pbUp.Image = global::WSClient.Properties.Resources.arrow_up;
            this.pbUp.Location = new System.Drawing.Point(219, 8);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(55, 47);
            this.pbUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUp.TabIndex = 37;
            this.pbUp.TabStop = false;
            this.pbUp.Click += new System.EventHandler(this.pbUp_Click);
            // 
            // pbDown
            // 
            this.pbDown.Image = global::WSClient.Properties.Resources.arrow_down;
            this.pbDown.Location = new System.Drawing.Point(219, 100);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(55, 47);
            this.pbDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDown.TabIndex = 36;
            this.pbDown.TabStop = false;
            this.pbDown.Click += new System.EventHandler(this.pbDown_Click);
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep.ForeColor = System.Drawing.Color.White;
            this.lblStep.Location = new System.Drawing.Point(215, 63);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(79, 25);
            this.lblStep.TabIndex = 35;
            this.lblStep.Text = "lblStep";
            this.lblStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Right hoof step:";
            // 
            // pbAnalyse
            // 
            this.pbAnalyse.Image = global::WSClient.Properties.Resources._194045_200;
            this.pbAnalyse.Location = new System.Drawing.Point(594, 12);
            this.pbAnalyse.Name = "pbAnalyse";
            this.pbAnalyse.Size = new System.Drawing.Size(104, 61);
            this.pbAnalyse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnalyse.TabIndex = 25;
            this.pbAnalyse.TabStop = false;
            this.pbAnalyse.Visible = false;
            this.pbAnalyse.Click += new System.EventHandler(this.pbAnalyse_Click);
            // 
            // pbOpen
            // 
            this.pbOpen.Image = global::WSClient.Properties.Resources.open;
            this.pbOpen.Location = new System.Drawing.Point(484, 0);
            this.pbOpen.Name = "pbOpen";
            this.pbOpen.Size = new System.Drawing.Size(104, 73);
            this.pbOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOpen.TabIndex = 20;
            this.pbOpen.TabStop = false;
            this.pbOpen.Click += new System.EventHandler(this.pbOpen_Click);
            // 
            // pbStopCalibration
            // 
            this.pbStopCalibration.Image = global::WSClient.Properties.Resources.stop;
            this.pbStopCalibration.Location = new System.Drawing.Point(1778, 130);
            this.pbStopCalibration.Name = "pbStopCalibration";
            this.pbStopCalibration.Size = new System.Drawing.Size(134, 86);
            this.pbStopCalibration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStopCalibration.TabIndex = 19;
            this.pbStopCalibration.TabStop = false;
            this.pbStopCalibration.Visible = false;
            this.pbStopCalibration.Click += new System.EventHandler(this.pbStopCalibration_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = global::WSClient.Properties.Resources.save;
            this.pbSave.Location = new System.Drawing.Point(1688, 26);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(62, 73);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 17;
            this.pbSave.TabStop = false;
            this.pbSave.Visible = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbCalibrate
            // 
            this.pbCalibrate.Image = global::WSClient.Properties.Resources.calibrate;
            this.pbCalibrate.Location = new System.Drawing.Point(1778, 130);
            this.pbCalibrate.Name = "pbCalibrate";
            this.pbCalibrate.Size = new System.Drawing.Size(134, 86);
            this.pbCalibrate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCalibrate.TabIndex = 16;
            this.pbCalibrate.TabStop = false;
            this.pbCalibrate.Visible = false;
            this.pbCalibrate.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Image = global::WSClient.Properties.Resources.loading_animation;
            this.pbLoading.InitialImage = null;
            this.pbLoading.Location = new System.Drawing.Point(1656, 12);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(116, 101);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 15;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // pbStop
            // 
            this.pbStop.Image = global::WSClient.Properties.Resources.stop;
            this.pbStop.Location = new System.Drawing.Point(1778, 22);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(134, 86);
            this.pbStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStop.TabIndex = 13;
            this.pbStop.TabStop = false;
            this.pbStop.Visible = false;
            this.pbStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pbPlay
            // 
            this.pbPlay.Image = global::WSClient.Properties.Resources.play1;
            this.pbPlay.Location = new System.Drawing.Point(1778, 26);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(134, 73);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlay.TabIndex = 12;
            this.pbPlay.TabStop = false;
            this.pbPlay.Visible = false;
            this.pbPlay.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbDelta
            // 
            this.cbDelta.AutoSize = true;
            this.cbDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelta.ForeColor = System.Drawing.Color.White;
            this.cbDelta.Location = new System.Drawing.Point(531, 118);
            this.cbDelta.Name = "cbDelta";
            this.cbDelta.Size = new System.Drawing.Size(134, 29);
            this.cbDelta.TabIndex = 45;
            this.cbDelta.Text = "Show Delta";
            this.cbDelta.UseVisualStyleBackColor = true;
            this.cbDelta.CheckedChanged += new System.EventHandler(this.cbDelta_CheckedChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(704, 12);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(316, 20);
            this.lblFileName.TabIndex = 34;
            this.lblFileName.Text = "lblFileName";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1914, 1000);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.pnlAnalysis);
            this.Controls.Add(this.pbAnalyse);
            this.Controls.Add(this.pbOpen);
            this.Controls.Add(this.pbStopCalibration);
            this.Controls.Add(this.pnlCalibrate);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbCalibrate);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.pbStop);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnConnect);
            this.Name = "frmMain";
            this.Text = "VetSoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlCalibrate.ResumeLayout(false);
            this.pnlCalibrate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightHoof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftHoof)).EndInit();
            this.pnlAnalysis.ResumeLayout(false);
            this.pnlAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalyse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStopCalibration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalibrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbStop;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.SaveFileDialog sfdSaveXml;
        private System.Windows.Forms.PictureBox pbCalibrate;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbLeftHoof;
        private System.Windows.Forms.Panel pnlCalibrate;
        private System.Windows.Forms.PictureBox pbRightHoof;
        private System.Windows.Forms.PictureBox pbStopCalibration;
        private System.Windows.Forms.Label lblLeftRearLeft;
        private System.Windows.Forms.Label lblRightRearRight;
        private System.Windows.Forms.Label lblRightTopRight;
        private System.Windows.Forms.Label lblLeftRearRight;
        private System.Windows.Forms.Label lblLeftTopRight;
        private System.Windows.Forms.Label lblRightTopLeft;
        private System.Windows.Forms.Label lblLeftTopLeft;
        private System.Windows.Forms.Label lblRightRearLeft;
        private System.Windows.Forms.PictureBox pbOpen;
        private System.Windows.Forms.OpenFileDialog ofdOpenXml;
        private System.Windows.Forms.PictureBox pbAnalyse;
        private System.Windows.Forms.Panel pnlAnalysis;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbUp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chLeft;
        private System.Windows.Forms.Label lblNumberOfSteps;
        private System.Windows.Forms.PictureBox pbLess;
        private System.Windows.Forms.PictureBox pbMore;
        private System.Windows.Forms.CheckBox cbRawData;
        private System.Windows.Forms.CheckBox cbSteps;
        private System.Windows.Forms.CheckBox cbDelta;
        private System.Windows.Forms.TextBox lblFileName;
    }
}

