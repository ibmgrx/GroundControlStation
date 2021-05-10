namespace GCS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel panel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel5 = new System.Windows.Forms.Panel();
            this.saveWP = new System.Windows.Forms.Button();
            this.sendWP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WPLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WPLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routBtn = new System.Windows.Forms.Button();
            this.addPos = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clrData = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bearing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PWMValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clrBtn = new System.Windows.Forms.Button();
            this.sendGPS = new System.Windows.Forms.Button();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.OpenClose = new System.Windows.Forms.Button();
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnEmg = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.Sp = new System.Windows.Forms.NumericUpDown();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.Kd = new System.Windows.Forms.NumericUpDown();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.Ki = new System.Windows.Forms.NumericUpDown();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTuning = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.Kp = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SendTab = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ReceiveTab = new System.Windows.Forms.TabPage();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedVal = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.StateASV = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.TuningVal = new System.Windows.Forms.TabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Emergency = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Logo_Bio = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Waktu = new System.Windows.Forms.Label();
            this.Tanggal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            panel2 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sp)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kd)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ki)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SendTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.ReceiveTab.SuspendLayout();
            this.SpeedVal.SuspendLayout();
            this.StateASV.SuspendLayout();
            this.TuningVal.SuspendLayout();
            this.Emergency.SuspendLayout();
            this.Logo_Bio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel2.BackColor = System.Drawing.Color.SteelBlue;
            panel2.Controls.Add(this.panel5);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(266, 71);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(241, 605);
            panel2.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.saveWP);
            this.panel5.Controls.Add(this.sendWP);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.routBtn);
            this.panel5.Controls.Add(this.addPos);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.clrBtn);
            this.panel5.Controls.Add(this.sendGPS);
            this.panel5.Controls.Add(this.txtLon);
            this.panel5.Controls.Add(this.txtLat);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(12, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 605);
            this.panel5.TabIndex = 29;
            // 
            // saveWP
            // 
            this.saveWP.BackColor = System.Drawing.Color.SkyBlue;
            this.saveWP.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveWP.FlatAppearance.BorderSize = 0;
            this.saveWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveWP.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveWP.ForeColor = System.Drawing.Color.Black;
            this.saveWP.Location = new System.Drawing.Point(0, 315);
            this.saveWP.Name = "saveWP";
            this.saveWP.Size = new System.Drawing.Size(229, 25);
            this.saveWP.TabIndex = 32;
            this.saveWP.Text = "SAVE   WAYPOINT";
            this.saveWP.UseVisualStyleBackColor = false;
            this.saveWP.Click += new System.EventHandler(this.saveWP_Click);
            // 
            // sendWP
            // 
            this.sendWP.BackColor = System.Drawing.Color.MidnightBlue;
            this.sendWP.Dock = System.Windows.Forms.DockStyle.Top;
            this.sendWP.FlatAppearance.BorderSize = 0;
            this.sendWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendWP.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendWP.ForeColor = System.Drawing.Color.White;
            this.sendWP.Location = new System.Drawing.Point(0, 290);
            this.sendWP.Name = "sendWP";
            this.sendWP.Size = new System.Drawing.Size(229, 25);
            this.sendWP.TabIndex = 28;
            this.sendWP.Text = "SEND   WAYPOINT";
            this.sendWP.UseVisualStyleBackColor = false;
            this.sendWP.Click += new System.EventHandler(this.sendWP_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WPLat,
            this.WPLon});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(229, 124);
            this.dataGridView1.TabIndex = 26;
            // 
            // WPLat
            // 
            this.WPLat.HeaderText = "WPLat";
            this.WPLat.Name = "WPLat";
            // 
            // WPLon
            // 
            this.WPLon.HeaderText = "WPLon";
            this.WPLon.Name = "WPLon";
            // 
            // routBtn
            // 
            this.routBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.routBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.routBtn.FlatAppearance.BorderSize = 0;
            this.routBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routBtn.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routBtn.ForeColor = System.Drawing.Color.Black;
            this.routBtn.Location = new System.Drawing.Point(0, 141);
            this.routBtn.Name = "routBtn";
            this.routBtn.Size = new System.Drawing.Size(229, 25);
            this.routBtn.TabIndex = 19;
            this.routBtn.Text = "Route";
            this.routBtn.UseVisualStyleBackColor = false;
            this.routBtn.Click += new System.EventHandler(this.routBtn_Click);
            // 
            // addPos
            // 
            this.addPos.BackColor = System.Drawing.Color.MidnightBlue;
            this.addPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPos.FlatAppearance.BorderSize = 0;
            this.addPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPos.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPos.ForeColor = System.Drawing.Color.White;
            this.addPos.Location = new System.Drawing.Point(0, 116);
            this.addPos.Name = "addPos";
            this.addPos.Size = new System.Drawing.Size(229, 25);
            this.addPos.TabIndex = 18;
            this.addPos.Text = "Add";
            this.addPos.UseVisualStyleBackColor = false;
            this.addPos.Click += new System.EventHandler(this.addPos_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.Controls.Add(this.saveBtn);
            this.panel8.Controls.Add(this.clrData);
            this.panel8.Controls.Add(this.dataGridView2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 397);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 208);
            this.panel8.TabIndex = 30;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(0, 167);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(229, 25);
            this.saveBtn.TabIndex = 28;
            this.saveBtn.Text = "SAVE   DATA";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clrData
            // 
            this.clrData.BackColor = System.Drawing.Color.SkyBlue;
            this.clrData.Dock = System.Windows.Forms.DockStyle.Top;
            this.clrData.FlatAppearance.BorderSize = 0;
            this.clrData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrData.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrData.ForeColor = System.Drawing.Color.Black;
            this.clrData.Location = new System.Drawing.Point(0, 142);
            this.clrData.Name = "clrData";
            this.clrData.Size = new System.Drawing.Size(229, 25);
            this.clrData.TabIndex = 29;
            this.clrData.Text = "Clear   Data";
            this.clrData.UseVisualStyleBackColor = false;
            this.clrData.Click += new System.EventHandler(this.clrData_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.Heading,
            this.Latitude,
            this.Longitude,
            this.Bearing,
            this.ErrorK,
            this.Distance,
            this.PWMValue,
            this.StartState});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(229, 142);
            this.dataGridView2.TabIndex = 27;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Heading
            // 
            this.Heading.HeaderText = "Heading";
            this.Heading.Name = "Heading";
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.Name = "Latitude";
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "Longitude";
            this.Longitude.Name = "Longitude";
            // 
            // Bearing
            // 
            this.Bearing.HeaderText = "Bearing";
            this.Bearing.Name = "Bearing";
            // 
            // ErrorK
            // 
            this.ErrorK.HeaderText = "ErrorK";
            this.ErrorK.Name = "ErrorK";
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            // 
            // PWMValue
            // 
            this.PWMValue.HeaderText = "PWM";
            this.PWMValue.Name = "PWMValue";
            // 
            // StartState
            // 
            this.StartState.HeaderText = "StartState";
            this.StartState.Name = "StartState";
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.clrBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clrBtn.FlatAppearance.BorderSize = 0;
            this.clrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrBtn.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.ForeColor = System.Drawing.Color.Black;
            this.clrBtn.Location = new System.Drawing.Point(0, 91);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(229, 25);
            this.clrBtn.TabIndex = 20;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // sendGPS
            // 
            this.sendGPS.BackColor = System.Drawing.Color.MidnightBlue;
            this.sendGPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.sendGPS.FlatAppearance.BorderSize = 0;
            this.sendGPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendGPS.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendGPS.ForeColor = System.Drawing.Color.White;
            this.sendGPS.Location = new System.Drawing.Point(0, 66);
            this.sendGPS.Name = "sendGPS";
            this.sendGPS.Size = new System.Drawing.Size(229, 25);
            this.sendGPS.TabIndex = 2;
            this.sendGPS.Text = "Load";
            this.sendGPS.UseVisualStyleBackColor = false;
            this.sendGPS.Click += new System.EventHandler(this.loadGPS_Click);
            // 
            // txtLon
            // 
            this.txtLon.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLon.Location = new System.Drawing.Point(0, 44);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(229, 22);
            this.txtLon.TabIndex = 17;
            this.txtLon.Text = "Longitude";
            // 
            // txtLat
            // 
            this.txtLat.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.Location = new System.Drawing.Point(0, 22);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(229, 22);
            this.txtLat.TabIndex = 16;
            this.txtLat.Text = "Latitude";
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(229, 22);
            this.panel9.TabIndex = 31;
            // 
            // OpenClose
            // 
            this.OpenClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.OpenClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenClose.FlatAppearance.BorderSize = 0;
            this.OpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenClose.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenClose.ForeColor = System.Drawing.Color.White;
            this.OpenClose.Location = new System.Drawing.Point(0, 161);
            this.OpenClose.Name = "OpenClose";
            this.OpenClose.Size = new System.Drawing.Size(266, 25);
            this.OpenClose.TabIndex = 5;
            this.OpenClose.Text = "CONNECT HERE";
            this.OpenClose.UseVisualStyleBackColor = false;
            this.OpenClose.Click += new System.EventHandler(this.OpenClose_Click);
            // 
            // PortNumber
            // 
            this.PortNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.PortNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.PortNumber.DropDownHeight = 110;
            this.PortNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.IntegralHeight = false;
            this.PortNumber.Location = new System.Drawing.Point(0, 140);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(266, 21);
            this.PortNumber.TabIndex = 4;
            this.PortNumber.Click += new System.EventHandler(this.ComboBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.SkyBlue;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 115);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(266, 25);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.AutoScroll = true;
            this.gmap.BackColor = System.Drawing.SystemColors.Control;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(12, 22);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 100;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(647, 571);
            this.gmap.TabIndex = 15;
            this.gmap.Zoom = 3D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.OpenClose);
            this.panel1.Controls.Add(this.PortNumber);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.Logo_Bio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 676);
            this.panel1.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnEmg);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 635);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(266, 41);
            this.panel7.TabIndex = 30;
            // 
            // btnEmg
            // 
            this.btnEmg.BackColor = System.Drawing.Color.Crimson;
            this.btnEmg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmg.FlatAppearance.BorderSize = 0;
            this.btnEmg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmg.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmg.ForeColor = System.Drawing.Color.White;
            this.btnEmg.Location = new System.Drawing.Point(0, 0);
            this.btnEmg.Name = "btnEmg";
            this.btnEmg.Size = new System.Drawing.Size(266, 25);
            this.btnEmg.TabIndex = 30;
            this.btnEmg.Text = "FAILSAFE   BUTTON";
            this.btnEmg.UseVisualStyleBackColor = false;
            this.btnEmg.Click += new System.EventHandler(this.btnEmg_Click);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.panel15);
            this.panel6.Controls.Add(this.panel14);
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.btnTuning);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.btnStop);
            this.panel6.Controls.Add(this.btnStart);
            this.panel6.Location = new System.Drawing.Point(0, 376);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 259);
            this.panel6.TabIndex = 30;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Controls.Add(this.label43);
            this.panel15.Controls.Add(this.Sp);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel15.ForeColor = System.Drawing.Color.Black;
            this.panel15.Location = new System.Drawing.Point(0, 113);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(266, 21);
            this.panel15.TabIndex = 40;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(7, 2);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(125, 16);
            this.label43.TabIndex = 35;
            this.label43.Text = "Set   Point   Heading ( ° ) =";
            // 
            // Sp
            // 
            this.Sp.BackColor = System.Drawing.Color.White;
            this.Sp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sp.Dock = System.Windows.Forms.DockStyle.Right;
            this.Sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sp.ForeColor = System.Drawing.Color.Black;
            this.Sp.Location = new System.Drawing.Point(190, 0);
            this.Sp.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Sp.Name = "Sp";
            this.Sp.Size = new System.Drawing.Size(76, 18);
            this.Sp.TabIndex = 37;
            this.Sp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sp.ValueChanged += new System.EventHandler(this.Sp_ValueChanged);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.label42);
            this.panel14.Controls.Add(this.Kd);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.ForeColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(0, 92);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(266, 21);
            this.panel14.TabIndex = 39;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(9, 2);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(29, 16);
            this.label42.TabIndex = 34;
            this.label42.Text = "Kd =";
            // 
            // Kd
            // 
            this.Kd.BackColor = System.Drawing.Color.White;
            this.Kd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Kd.DecimalPlaces = 1;
            this.Kd.Dock = System.Windows.Forms.DockStyle.Right;
            this.Kd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kd.ForeColor = System.Drawing.Color.Black;
            this.Kd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Kd.Location = new System.Drawing.Point(190, 0);
            this.Kd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Kd.Name = "Kd";
            this.Kd.Size = new System.Drawing.Size(76, 18);
            this.Kd.TabIndex = 33;
            this.Kd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kd.ValueChanged += new System.EventHandler(this.Kd_ValueChanged);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.label41);
            this.panel13.Controls.Add(this.Ki);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.ForeColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(0, 71);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(266, 21);
            this.panel13.TabIndex = 38;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(9, 2);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(26, 16);
            this.label41.TabIndex = 33;
            this.label41.Text = "Ki =";
            // 
            // Ki
            // 
            this.Ki.BackColor = System.Drawing.Color.White;
            this.Ki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ki.DecimalPlaces = 1;
            this.Ki.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ki.ForeColor = System.Drawing.Color.Black;
            this.Ki.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Ki.Location = new System.Drawing.Point(190, 0);
            this.Ki.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Ki.Name = "Ki";
            this.Ki.Size = new System.Drawing.Size(76, 18);
            this.Ki.TabIndex = 32;
            this.Ki.Tag = "";
            this.Ki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ki.ValueChanged += new System.EventHandler(this.Ki_ValueChanged);
            // 
            // panel12
            // 
            this.panel12.AutoScroll = true;
            this.panel12.Controls.Add(this.label9);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 190);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(266, 69);
            this.panel12.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 208);
            this.label9.TabIndex = 30;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // btnTuning
            // 
            this.btnTuning.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTuning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTuning.FlatAppearance.BorderSize = 0;
            this.btnTuning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuning.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuning.ForeColor = System.Drawing.Color.White;
            this.btnTuning.Location = new System.Drawing.Point(0, 139);
            this.btnTuning.Name = "btnTuning";
            this.btnTuning.Size = new System.Drawing.Size(266, 25);
            this.btnTuning.TabIndex = 34;
            this.btnTuning.Text = "Tuning   ASV";
            this.btnTuning.UseVisualStyleBackColor = false;
            this.btnTuning.Click += new System.EventHandler(this.btnTuning_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.label40);
            this.panel11.Controls.Add(this.Kp);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.ForeColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(0, 50);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(266, 21);
            this.panel11.TabIndex = 35;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(9, 2);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(29, 16);
            this.label40.TabIndex = 32;
            this.label40.Text = "Kp =";
            // 
            // Kp
            // 
            this.Kp.BackColor = System.Drawing.Color.White;
            this.Kp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Kp.DecimalPlaces = 1;
            this.Kp.Dock = System.Windows.Forms.DockStyle.Right;
            this.Kp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kp.ForeColor = System.Drawing.Color.Black;
            this.Kp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Kp.Location = new System.Drawing.Point(190, 0);
            this.Kp.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Kp.Name = "Kp";
            this.Kp.Size = new System.Drawing.Size(76, 18);
            this.Kp.TabIndex = 31;
            this.Kp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kp.ValueChanged += new System.EventHandler(this.Kp_ValueChanged);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(0, 25);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(266, 25);
            this.btnStop.TabIndex = 36;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(266, 25);
            this.btnStart.TabIndex = 30;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.SendTab);
            this.tabControl1.Controls.Add(this.ReceiveTab);
            this.tabControl1.Controls.Add(this.SpeedVal);
            this.tabControl1.Controls.Add(this.StateASV);
            this.tabControl1.Controls.Add(this.TuningVal);
            this.tabControl1.Controls.Add(this.Emergency);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 186);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 167);
            this.tabControl1.TabIndex = 9;
            // 
            // SendTab
            // 
            this.SendTab.BackColor = System.Drawing.Color.White;
            this.SendTab.Controls.Add(this.label20);
            this.SendTab.Controls.Add(this.speed);
            this.SendTab.Controls.Add(this.label8);
            this.SendTab.Controls.Add(this.button1);
            this.SendTab.Location = new System.Drawing.Point(4, 25);
            this.SendTab.Name = "SendTab";
            this.SendTab.Padding = new System.Windows.Forms.Padding(3);
            this.SendTab.Size = new System.Drawing.Size(258, 138);
            this.SendTab.TabIndex = 0;
            this.SendTab.Text = "SendTab";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(231, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 21);
            this.label20.TabIndex = 26;
            this.label20.Text = "%";
            // 
            // speed
            // 
            this.speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.Location = new System.Drawing.Point(2, 50);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(228, 30);
            this.speed.TabIndex = 25;
            this.speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speed.ValueChanged += new System.EventHandler(this.speed_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Speed   ASV";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Speed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSend);
            // 
            // ReceiveTab
            // 
            this.ReceiveTab.BackColor = System.Drawing.Color.White;
            this.ReceiveTab.Controls.Add(this.label39);
            this.ReceiveTab.Controls.Add(this.label38);
            this.ReceiveTab.Controls.Add(this.label37);
            this.ReceiveTab.Controls.Add(this.label36);
            this.ReceiveTab.Controls.Add(this.label35);
            this.ReceiveTab.Controls.Add(this.label34);
            this.ReceiveTab.Controls.Add(this.label17);
            this.ReceiveTab.Controls.Add(this.label16);
            this.ReceiveTab.Controls.Add(this.label15);
            this.ReceiveTab.Controls.Add(this.label14);
            this.ReceiveTab.Controls.Add(this.label13);
            this.ReceiveTab.Controls.Add(this.label12);
            this.ReceiveTab.Controls.Add(this.label7);
            this.ReceiveTab.Controls.Add(this.label6);
            this.ReceiveTab.Controls.Add(this.label5);
            this.ReceiveTab.Controls.Add(this.label4);
            this.ReceiveTab.Controls.Add(this.label3);
            this.ReceiveTab.Controls.Add(this.label2);
            this.ReceiveTab.Location = new System.Drawing.Point(4, 25);
            this.ReceiveTab.Name = "ReceiveTab";
            this.ReceiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReceiveTab.Size = new System.Drawing.Size(258, 138);
            this.ReceiveTab.TabIndex = 1;
            this.ReceiveTab.Text = "ReceiveTab";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(183, 116);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 13);
            this.label39.TabIndex = 18;
            this.label39.Text = "( m )";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(183, 94);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(23, 13);
            this.label38.TabIndex = 17;
            this.label38.Text = "( ° )";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(183, 72);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 13);
            this.label37.TabIndex = 16;
            this.label37.Text = "( ° )";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(183, 51);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 13);
            this.label36.TabIndex = 15;
            this.label36.Text = "( ° )";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(183, 29);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(23, 13);
            this.label35.TabIndex = 14;
            this.label35.Text = "( ° )";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(183, 8);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 13);
            this.label34.TabIndex = 13;
            this.label34.Text = "( ° )";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(100, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Distance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "ErrorK";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Bearing";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Heading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Longitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latitude";
            // 
            // SpeedVal
            // 
            this.SpeedVal.BackColor = System.Drawing.Color.White;
            this.SpeedVal.Controls.Add(this.label33);
            this.SpeedVal.Controls.Add(this.label19);
            this.SpeedVal.Controls.Add(this.label18);
            this.SpeedVal.Location = new System.Drawing.Point(4, 25);
            this.SpeedVal.Name = "SpeedVal";
            this.SpeedVal.Padding = new System.Windows.Forms.Padding(3);
            this.SpeedVal.Size = new System.Drawing.Size(258, 138);
            this.SpeedVal.TabIndex = 2;
            this.SpeedVal.Text = "SpeedVal";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(166, 55);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 29);
            this.label33.TabIndex = 17;
            this.label33.Text = "us";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(98, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 29);
            this.label19.TabIndex = 16;
            this.label19.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(94, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 29);
            this.label18.TabIndex = 15;
            this.label18.Text = "PWM";
            // 
            // StateASV
            // 
            this.StateASV.BackColor = System.Drawing.Color.White;
            this.StateASV.Controls.Add(this.label31);
            this.StateASV.Controls.Add(this.label32);
            this.StateASV.Location = new System.Drawing.Point(4, 25);
            this.StateASV.Name = "StateASV";
            this.StateASV.Size = new System.Drawing.Size(258, 138);
            this.StateASV.TabIndex = 3;
            this.StateASV.Text = "StateASV";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(119, 57);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(21, 29);
            this.label31.TabIndex = 18;
            this.label31.Text = "-";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(86, 15);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(92, 29);
            this.label32.TabIndex = 17;
            this.label32.Text = "STATE";
            // 
            // TuningVal
            // 
            this.TuningVal.BackColor = System.Drawing.Color.White;
            this.TuningVal.Controls.Add(this.label44);
            this.TuningVal.Controls.Add(this.label30);
            this.TuningVal.Controls.Add(this.label29);
            this.TuningVal.Controls.Add(this.label28);
            this.TuningVal.Controls.Add(this.label27);
            this.TuningVal.Controls.Add(this.label26);
            this.TuningVal.Controls.Add(this.label25);
            this.TuningVal.Controls.Add(this.label24);
            this.TuningVal.Controls.Add(this.label23);
            this.TuningVal.Location = new System.Drawing.Point(4, 25);
            this.TuningVal.Name = "TuningVal";
            this.TuningVal.Size = new System.Drawing.Size(258, 138);
            this.TuningVal.TabIndex = 4;
            this.TuningVal.Text = "TuningVal";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(221, 52);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(11, 13);
            this.label44.TabIndex = 33;
            this.label44.Text = "°";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(205, 52);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(10, 13);
            this.label30.TabIndex = 32;
            this.label30.Text = "-";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(205, 31);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(10, 13);
            this.label29.TabIndex = 31;
            this.label29.Text = "-";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(78, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(10, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "-";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(78, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(10, 13);
            this.label27.TabIndex = 29;
            this.label27.Text = "-";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(145, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "Sp:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(145, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 13);
            this.label25.TabIndex = 27;
            this.label25.Text = "Kd:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(36, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 13);
            this.label24.TabIndex = 26;
            this.label24.Text = "Ki:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(36, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "Kp:";
            // 
            // Emergency
            // 
            this.Emergency.BackColor = System.Drawing.Color.White;
            this.Emergency.Controls.Add(this.label22);
            this.Emergency.Controls.Add(this.label21);
            this.Emergency.Location = new System.Drawing.Point(4, 25);
            this.Emergency.Name = "Emergency";
            this.Emergency.Size = new System.Drawing.Size(258, 138);
            this.Emergency.TabIndex = 5;
            this.Emergency.Text = "Emergency";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Crimson;
            this.label22.Location = new System.Drawing.Point(125, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 25);
            this.label22.TabIndex = 18;
            this.label22.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Crimson;
            this.label21.Location = new System.Drawing.Point(37, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(191, 25);
            this.label21.TabIndex = 17;
            this.label21.Text = "Emergency State";
            // 
            // Logo_Bio
            // 
            this.Logo_Bio.Controls.Add(this.label10);
            this.Logo_Bio.Controls.Add(this.pictureBox1);
            this.Logo_Bio.Controls.Add(this.shapeContainer2);
            this.Logo_Bio.Controls.Add(this.label11);
            this.Logo_Bio.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_Bio.Location = new System.Drawing.Point(0, 0);
            this.Logo_Bio.Name = "Logo_Bio";
            this.Logo_Bio.Size = new System.Drawing.Size(266, 115);
            this.Logo_Bio.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("OpTic", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "GCS 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GCS.Properties.Resources.Undip;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(266, 115);
            this.shapeContainer2.TabIndex = 28;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 107;
            this.lineShape1.X2 = 256;
            this.lineShape1.Y1 = 61;
            this.lineShape1.Y2 = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(130, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tugas Akhir";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.gmap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(507, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 605);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Waktu);
            this.panel4.Controls.Add(this.Tanggal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(266, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(912, 71);
            this.panel4.TabIndex = 29;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(17, 15);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 41);
            this.panel10.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OpTic", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(733, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "GCS 1.0";
            // 
            // Waktu
            // 
            this.Waktu.AutoSize = true;
            this.Waktu.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Waktu.ForeColor = System.Drawing.Color.White;
            this.Waktu.Location = new System.Drawing.Point(26, 38);
            this.Waktu.Name = "Waktu";
            this.Waktu.Size = new System.Drawing.Size(49, 15);
            this.Waktu.TabIndex = 1;
            this.Waktu.Text = "Waktu";
            // 
            // Tanggal
            // 
            this.Tanggal.AutoSize = true;
            this.Tanggal.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tanggal.ForeColor = System.Drawing.Color.White;
            this.Tanggal.Location = new System.Drawing.Point(26, 15);
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Size = new System.Drawing.Size(60, 15);
            this.Tanggal.TabIndex = 0;
            this.Tanggal.Text = "Tanggal";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1178, 676);
            this.Controls.Add(this.panel3);
            this.Controls.Add(panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCS";
            panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sp)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kd)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ki)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.SendTab.ResumeLayout(false);
            this.SendTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.ReceiveTab.ResumeLayout(false);
            this.ReceiveTab.PerformLayout();
            this.SpeedVal.ResumeLayout(false);
            this.SpeedVal.PerformLayout();
            this.StateASV.ResumeLayout(false);
            this.StateASV.PerformLayout();
            this.TuningVal.ResumeLayout(false);
            this.TuningVal.PerformLayout();
            this.Emergency.ResumeLayout(false);
            this.Emergency.PerformLayout();
            this.Logo_Bio.ResumeLayout(false);
            this.Logo_Bio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        public System.Windows.Forms.Button OpenClose;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SendTab;
        private System.Windows.Forms.NumericUpDown speed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage ReceiveTab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Logo_Bio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Waktu;
        private System.Windows.Forms.Label Tanggal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEmg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button sendWP;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button routBtn;
        private System.Windows.Forms.Button addPos;
        private System.Windows.Forms.Button sendGPS;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTuning;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.NumericUpDown Ki;
        private System.Windows.Forms.NumericUpDown Kp;
        private System.Windows.Forms.NumericUpDown Kd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown Sp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button clrData;
        private System.Windows.Forms.Button saveWP;
        private System.Windows.Forms.DataGridViewTextBoxColumn WPLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn WPLon;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage SpeedVal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage StateASV;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage TuningVal;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage Emergency;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bearing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PWMValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartState;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label44;
    }
}

