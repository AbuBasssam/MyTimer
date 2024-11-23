namespace MyTimer
{
    partial class frmArabic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArabic));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.SecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pbar = new CircularProgressBar.CircularProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblLap = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmLapNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmLapTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmOvertime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLap = new System.Windows.Forms.Button();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.btnStopStart = new System.Windows.Forms.Button();
            this.cmsPresntTimer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditPresentTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeletePresentTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddPresentTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangeToEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHidePresentTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteAllPresentTimers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowClock = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyDone = new System.Windows.Forms.NotifyIcon(this.components);
            this.BlinkingTmer = new System.Windows.Forms.Timer(this.components);
            this.StopWatchtimer = new System.Windows.Forms.Timer(this.components);
            this.Laptimer = new System.Windows.Forms.Timer(this.components);
            this.EndTimer = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsPresntTimer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1197, 656);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnPlay);
            this.tabPage1.Controls.Add(this.btnRestart);
            this.tabPage1.Controls.Add(this.pbar);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1167, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "المؤقت";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(969, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(173, 54);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "00:00:00";
            this.lblDate.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(22, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(196, 47);
            this.lblTime.TabIndex = 29;
            this.lblTime.Text = "00:00:00";
            this.lblTime.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStop.Location = new System.Drawing.Point(151, 438);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(241, 38);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "إيقاف";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HoursUpDown);
            this.panel2.Controls.Add(this.MinutesUpDown);
            this.panel2.Controls.Add(this.SecondsUpDown);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Location = new System.Drawing.Point(10, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 166);
            this.panel2.TabIndex = 27;
            // 
            // HoursUpDown
            // 
            this.HoursUpDown.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.HoursUpDown.Location = new System.Drawing.Point(187, 9);
            this.HoursUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.HoursUpDown.Name = "HoursUpDown";
            this.HoursUpDown.Size = new System.Drawing.Size(120, 30);
            this.HoursUpDown.TabIndex = 23;
            this.HoursUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.HoursUpDown.ValueChanged += new System.EventHandler(this.NumreicalUpDown_ValueChanged);
            // 
            // MinutesUpDown
            // 
            this.MinutesUpDown.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MinutesUpDown.Location = new System.Drawing.Point(500, 9);
            this.MinutesUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinutesUpDown.Name = "MinutesUpDown";
            this.MinutesUpDown.Size = new System.Drawing.Size(120, 30);
            this.MinutesUpDown.TabIndex = 22;
            this.MinutesUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.MinutesUpDown.ValueChanged += new System.EventHandler(this.NumreicalUpDown_ValueChanged);
            // 
            // SecondsUpDown
            // 
            this.SecondsUpDown.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SecondsUpDown.Location = new System.Drawing.Point(762, 13);
            this.SecondsUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SecondsUpDown.Name = "SecondsUpDown";
            this.SecondsUpDown.Size = new System.Drawing.Size(120, 30);
            this.SecondsUpDown.TabIndex = 21;
            this.SecondsUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.SecondsUpDown.ValueChanged += new System.EventHandler(this.NumreicalUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(888, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "الثواني :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(626, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "الدقائق :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "الساعات :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(459, 97);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(241, 35);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "أبدا";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPlay.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.Location = new System.Drawing.Point(469, 438);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(241, 38);
            this.btnPlay.TabIndex = 26;
            this.btnPlay.Text = "تشغيل";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.AutoSize = true;
            this.btnRestart.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestart.Location = new System.Drawing.Point(772, 438);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(214, 38);
            this.btnRestart.TabIndex = 25;
            this.btnRestart.Text = "إعادة تعيين";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pbar
            // 
            this.pbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbar.AnimationSpeed = 1000;
            this.pbar.BackColor = System.Drawing.Color.Transparent;
            this.pbar.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold);
            this.pbar.ForeColor = System.Drawing.Color.White;
            this.pbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pbar.InnerMargin = 2;
            this.pbar.InnerWidth = -1;
            this.pbar.Location = new System.Drawing.Point(415, 60);
            this.pbar.MarqueeAnimationSpeed = 2000;
            this.pbar.Name = "pbar";
            this.pbar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pbar.OuterMargin = -25;
            this.pbar.OuterWidth = 26;
            this.pbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pbar.ProgressWidth = 15;
            this.pbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbar.Size = new System.Drawing.Size(298, 287);
            this.pbar.StartAngle = 270;
            this.pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbar.SubscriptText = "";
            this.pbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbar.SuperscriptText = "";
            this.pbar.TabIndex = 23;
            this.pbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbar.Value = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.tabPage2.Controls.Add(this.lblLap);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnLap);
            this.tabPage2.Controls.Add(this.lblStopWatch);
            this.tabPage2.Controls.Add(this.btnStopStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(1167, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ساعة التوقف";
            // 
            // lblLap
            // 
            this.lblLap.AutoSize = true;
            this.lblLap.BackColor = System.Drawing.Color.Transparent;
            this.lblLap.Font = new System.Drawing.Font("Yu Gothic UI", 24F);
            this.lblLap.ForeColor = System.Drawing.Color.Turquoise;
            this.lblLap.Location = new System.Drawing.Point(653, 119);
            this.lblLap.Name = "lblLap";
            this.lblLap.Size = new System.Drawing.Size(173, 54);
            this.lblLap.TabIndex = 10;
            this.lblLap.Text = "00:00:00";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(53)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmLapNumber,
            this.ClmLapTime,
            this.ClmOvertime});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(423, 397);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(743, 248);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmLapNumber
            // 
            this.clmLapNumber.Text = "جولة";
            this.clmLapNumber.Width = 150;
            // 
            // ClmLapTime
            // 
            this.ClmLapTime.Text = "وقت الجولة";
            this.ClmLapTime.Width = 200;
            // 
            // ClmOvertime
            // 
            this.ClmOvertime.Text = "الوقت الكلي";
            this.ClmOvertime.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLap
            // 
            this.btnLap.BackColor = System.Drawing.Color.Cyan;
            this.btnLap.Enabled = false;
            this.btnLap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLap.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLap.Location = new System.Drawing.Point(753, 256);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(105, 46);
            this.btnLap.TabIndex = 7;
            this.btnLap.Text = "جولة";
            this.btnLap.UseVisualStyleBackColor = false;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.AutoSize = true;
            this.lblStopWatch.BackColor = System.Drawing.Color.Transparent;
            this.lblStopWatch.Font = new System.Drawing.Font("Arabic Typesetting", 49.8F, System.Drawing.FontStyle.Bold);
            this.lblStopWatch.ForeColor = System.Drawing.Color.Turquoise;
            this.lblStopWatch.Location = new System.Drawing.Point(620, 32);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(238, 96);
            this.lblStopWatch.TabIndex = 5;
            this.lblStopWatch.Text = "00:00:00";
            // 
            // btnStopStart
            // 
            this.btnStopStart.BackColor = System.Drawing.Color.Green;
            this.btnStopStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnStopStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopStart.Font = new System.Drawing.Font("Britannic Bold", 15F);
            this.btnStopStart.ForeColor = System.Drawing.Color.White;
            this.btnStopStart.Location = new System.Drawing.Point(636, 257);
            this.btnStopStart.Name = "btnStopStart";
            this.btnStopStart.Size = new System.Drawing.Size(105, 46);
            this.btnStopStart.TabIndex = 6;
            this.btnStopStart.Text = "ابدأ";
            this.btnStopStart.UseVisualStyleBackColor = false;
            this.btnStopStart.Click += new System.EventHandler(this.btnStopStartWatch_Click);
            // 
            // cmsPresntTimer
            // 
            this.cmsPresntTimer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPresntTimer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditPresentTimer,
            this.cmsDeletePresentTimer});
            this.cmsPresntTimer.Name = "cmsPresntTimer";
            this.cmsPresntTimer.Size = new System.Drawing.Size(213, 52);
            this.cmsPresntTimer.Text = "cmsEditButton";
            this.cmsPresntTimer.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPresntTimer_Opening);
            // 
            // cmsEditPresentTimer
            // 
            this.cmsEditPresentTimer.Name = "cmsEditPresentTimer";
            this.cmsEditPresentTimer.Size = new System.Drawing.Size(212, 24);
            this.cmsEditPresentTimer.Text = "تعديل المؤقت الفوري";
            this.cmsEditPresentTimer.Click += new System.EventHandler(this.cmsEditPresentTimer_Click);
            // 
            // cmsDeletePresentTimer
            // 
            this.cmsDeletePresentTimer.Name = "cmsDeletePresentTimer";
            this.cmsDeletePresentTimer.Size = new System.Drawing.Size(212, 24);
            this.cmsDeletePresentTimer.Text = "حذف المؤقت الفوري";
            this.cmsDeletePresentTimer.Click += new System.EventHandler(this.cmsDeletePresentTimer_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "الاعدادات";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddPresentTimer,
            this.tsmChangeToEnglish,
            this.tsmHidePresentTimer,
            this.tsmDeleteAllPresentTimers,
            this.tsmShowClock});
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.addToolStripMenuItem.Text = "الإعدادات";
            // 
            // tsmAddPresentTimer
            // 
            this.tsmAddPresentTimer.Image = ((System.Drawing.Image)(resources.GetObject("tsmAddPresentTimer.Image")));
            this.tsmAddPresentTimer.Name = "tsmAddPresentTimer";
            this.tsmAddPresentTimer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.tsmAddPresentTimer.Size = new System.Drawing.Size(254, 26);
            this.tsmAddPresentTimer.Text = "إضافة مؤقت فوري";
            this.tsmAddPresentTimer.Click += new System.EventHandler(this.tsmAddPresentTimer_Click);
            // 
            // tsmChangeToEnglish
            // 
            this.tsmChangeToEnglish.Image = ((System.Drawing.Image)(resources.GetObject("tsmChangeToEnglish.Image")));
            this.tsmChangeToEnglish.Name = "tsmChangeToEnglish";
            this.tsmChangeToEnglish.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.tsmChangeToEnglish.Size = new System.Drawing.Size(254, 26);
            this.tsmChangeToEnglish.Text = "تغيير اللغة";
            this.tsmChangeToEnglish.Click += new System.EventHandler(this.tsmChangeToEnglish_Click);
            // 
            // tsmHidePresentTimer
            // 
            this.tsmHidePresentTimer.CheckOnClick = true;
            this.tsmHidePresentTimer.Image = ((System.Drawing.Image)(resources.GetObject("tsmHidePresentTimer.Image")));
            this.tsmHidePresentTimer.Name = "tsmHidePresentTimer";
            this.tsmHidePresentTimer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.tsmHidePresentTimer.Size = new System.Drawing.Size(254, 26);
            this.tsmHidePresentTimer.Text = "إخفاء المؤقتات الفورية";
            this.tsmHidePresentTimer.Click += new System.EventHandler(this.tsmHidePresentTimer_Click);
            // 
            // tsmDeleteAllPresentTimers
            // 
            this.tsmDeleteAllPresentTimers.Image = ((System.Drawing.Image)(resources.GetObject("tsmDeleteAllPresentTimers.Image")));
            this.tsmDeleteAllPresentTimers.Name = "tsmDeleteAllPresentTimers";
            this.tsmDeleteAllPresentTimers.Size = new System.Drawing.Size(254, 26);
            this.tsmDeleteAllPresentTimers.Text = "حذف المؤقتات الفورية";
            this.tsmDeleteAllPresentTimers.Click += new System.EventHandler(this.tsmDeleteAllPresentTimers_Click);
            // 
            // tsmShowClock
            // 
            this.tsmShowClock.Image = ((System.Drawing.Image)(resources.GetObject("tsmShowClock.Image")));
            this.tsmShowClock.Name = "tsmShowClock";
            this.tsmShowClock.Size = new System.Drawing.Size(254, 26);
            this.tsmShowClock.Text = "إظهار الساعة";
            this.tsmShowClock.Click += new System.EventHandler(this.tsmShowClock_Click);
            // 
            // notifyDone
            // 
            this.notifyDone.BalloonTipText = "نهاية الوقت";
            this.notifyDone.BalloonTipTitle = "انتهى";
            this.notifyDone.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyDone.Icon")));
            this.notifyDone.Text = "notifyIcon1";
            this.notifyDone.Visible = true;
            // 
            // BlinkingTmer
            // 
            this.BlinkingTmer.Interval = 500;
            this.BlinkingTmer.Tick += new System.EventHandler(this.BlinkingTmer_Tick);
            // 
            // StopWatchtimer
            // 
            this.StopWatchtimer.Interval = 10;
            this.StopWatchtimer.Tick += new System.EventHandler(this.StopWatchtimer_Tick);
            // 
            // Laptimer
            // 
            this.Laptimer.Interval = 10;
            this.Laptimer.Tick += new System.EventHandler(this.Laptimer_Tick);
            // 
            // EndTimer
            // 
            this.EndTimer.Interval = 1000;
            this.EndTimer.Tick += new System.EventHandler(this.EndTimer_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // frmArabic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1196, 656);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1214, 703);
            this.Name = "frmArabic";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "الساعة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArabicForm_FormClosed);
            this.Load += new System.EventHandler(this.frmArabic_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsPresntTimer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRestart;
        private CircularProgressBar.CircularProgressBar pbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown HoursUpDown;
        private System.Windows.Forms.NumericUpDown MinutesUpDown;
        private System.Windows.Forms.NumericUpDown SecondsUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.Button btnStopStart;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmLapNumber;
        private System.Windows.Forms.ColumnHeader ClmLapTime;
        private System.Windows.Forms.ColumnHeader ClmOvertime;
        private System.Windows.Forms.ContextMenuStrip cmsPresntTimer;
        private System.Windows.Forms.ToolStripMenuItem cmsEditPresentTimer;
        private System.Windows.Forms.ToolStripMenuItem cmsDeletePresentTimer;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddPresentTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeToEnglish;
        private System.Windows.Forms.ToolStripMenuItem tsmHidePresentTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteAllPresentTimers;
        private System.Windows.Forms.NotifyIcon notifyDone;
        private System.Windows.Forms.Timer BlinkingTmer;
        private System.Windows.Forms.Timer StopWatchtimer;
        private System.Windows.Forms.Timer Laptimer;
        private System.Windows.Forms.Timer EndTimer;
        private System.Windows.Forms.Label lblLap;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ToolStripMenuItem tsmShowClock;
    }
}