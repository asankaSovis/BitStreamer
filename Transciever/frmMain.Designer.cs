
namespace Transciever
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.tlpTest = new System.Windows.Forms.TableLayoutPanel();
            this.nudTest = new System.Windows.Forms.NumericUpDown();
            this.prgTest = new System.Windows.Forms.ProgressBar();
            this.btnDock = new System.Windows.Forms.Button();
            this.pcbTest = new System.Windows.Forms.PictureBox();
            this.grpReciever = new System.Windows.Forms.GroupBox();
            this.tlpReciever = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRecBits = new System.Windows.Forms.TableLayoutPanel();
            this.lblRec8 = new System.Windows.Forms.Label();
            this.lblRec7 = new System.Windows.Forms.Label();
            this.lblRec6 = new System.Windows.Forms.Label();
            this.lblRec5 = new System.Windows.Forms.Label();
            this.lblRec4 = new System.Windows.Forms.Label();
            this.lblRec3 = new System.Windows.Forms.Label();
            this.lblRec2 = new System.Windows.Forms.Label();
            this.lblRecBit8 = new System.Windows.Forms.Label();
            this.lblRecBit7 = new System.Windows.Forms.Label();
            this.lblRecBit6 = new System.Windows.Forms.Label();
            this.lblRecBit5 = new System.Windows.Forms.Label();
            this.lblRecBit4 = new System.Windows.Forms.Label();
            this.lblRecBit3 = new System.Windows.Forms.Label();
            this.lblRecBit2 = new System.Windows.Forms.Label();
            this.lblRecBit1 = new System.Windows.Forms.Label();
            this.lblRec1 = new System.Windows.Forms.Label();
            this.tlpRecieveOptions = new System.Windows.Forms.TableLayoutPanel();
            this.cmbRecPort = new System.Windows.Forms.ComboBox();
            this.cmbRecBitrate = new System.Windows.Forms.ComboBox();
            this.btnRecConnect = new System.Windows.Forms.Button();
            this.pcbRecieve = new System.Windows.Forms.PictureBox();
            this.grpTransmitter = new System.Windows.Forms.GroupBox();
            this.tlpTransmitter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTransOptions = new System.Windows.Forms.TableLayoutPanel();
            this.cmbTransPort = new System.Windows.Forms.ComboBox();
            this.cmbTransBitrate = new System.Windows.Forms.ComboBox();
            this.btnTransConnect = new System.Windows.Forms.Button();
            this.tlpBits = new System.Windows.Forms.TableLayoutPanel();
            this.lblTransBit8 = new System.Windows.Forms.Label();
            this.lblTransBit7 = new System.Windows.Forms.Label();
            this.lblTransBit6 = new System.Windows.Forms.Label();
            this.lblTransBit5 = new System.Windows.Forms.Label();
            this.lblTransBit4 = new System.Windows.Forms.Label();
            this.lblTransBit3 = new System.Windows.Forms.Label();
            this.bitTrans2 = new System.Windows.Forms.Label();
            this.chkEight = new System.Windows.Forms.CheckBox();
            this.chkSeven = new System.Windows.Forms.CheckBox();
            this.chkSix = new System.Windows.Forms.CheckBox();
            this.chkFive = new System.Windows.Forms.CheckBox();
            this.chkFour = new System.Windows.Forms.CheckBox();
            this.chkThree = new System.Windows.Forms.CheckBox();
            this.chkTwo = new System.Windows.Forms.CheckBox();
            this.chkOne = new System.Windows.Forms.CheckBox();
            this.lblTrans1 = new System.Windows.Forms.Label();
            this.spcButton = new System.Windows.Forms.SplitContainer();
            this.btnSend = new System.Windows.Forms.Button();
            this.pcbSend = new System.Windows.Forms.PictureBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tssMain = new System.Windows.Forms.ToolStrip();
            this.tssFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmReload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tstSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tssBitstream = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSend = new System.Windows.Forms.ToolStripMenuItem();
            this.tstSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.tssOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.tssMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUni = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBi = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.tssEachGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmPositioning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFourBit = new System.Windows.Forms.ToolStripMenuItem();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.stsMain.SuspendLayout();
            this.grpTest.SuspendLayout();
            this.tlpTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTest)).BeginInit();
            this.grpReciever.SuspendLayout();
            this.tlpReciever.SuspendLayout();
            this.tlpRecBits.SuspendLayout();
            this.tlpRecieveOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecieve)).BeginInit();
            this.grpTransmitter.SuspendLayout();
            this.tlpTransmitter.SuspendLayout();
            this.tlpTransOptions.SuspendLayout();
            this.tlpBits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).BeginInit();
            this.spcButton.Panel1.SuspendLayout();
            this.spcButton.Panel2.SuspendLayout();
            this.spcButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSend)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.tssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssTime});
            this.stsMain.Location = new System.Drawing.Point(0, 337);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(883, 22);
            this.stsMain.TabIndex = 0;
            this.stsMain.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(836, 17);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "Welcome to BitStreamer....";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssStatus.TextChanged += new System.EventHandler(this.tssStatus_TextChanged);
            // 
            // tssTime
            // 
            this.tssTime.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.tssTime.Name = "tssTime";
            this.tssTime.Size = new System.Drawing.Size(12, 17);
            this.tssTime.Text = "-";
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 500;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.tlpTest);
            this.grpTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTest.Location = new System.Drawing.Point(3, 280);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(877, 54);
            this.grpTest.TabIndex = 2;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Simulation";
            // 
            // tlpTest
            // 
            this.tlpTest.ColumnCount = 4;
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpTest.Controls.Add(this.nudTest, 0, 0);
            this.tlpTest.Controls.Add(this.prgTest, 2, 0);
            this.tlpTest.Controls.Add(this.btnDock, 1, 0);
            this.tlpTest.Controls.Add(this.pcbTest, 3, 0);
            this.tlpTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTest.Location = new System.Drawing.Point(3, 16);
            this.tlpTest.Name = "tlpTest";
            this.tlpTest.RowCount = 1;
            this.tlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpTest.Size = new System.Drawing.Size(871, 35);
            this.tlpTest.TabIndex = 0;
            // 
            // nudTest
            // 
            this.nudTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTest.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTest.Location = new System.Drawing.Point(3, 7);
            this.nudTest.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTest.Name = "nudTest";
            this.nudTest.Size = new System.Drawing.Size(61, 20);
            this.nudTest.TabIndex = 0;
            this.nudTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tltMain.SetToolTip(this.nudTest, "Number of times to repeat the test");
            this.nudTest.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTest.ValueChanged += new System.EventHandler(this.nudTest_ValueChanged);
            // 
            // prgTest
            // 
            this.prgTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prgTest.Location = new System.Drawing.Point(300, 8);
            this.prgTest.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.prgTest.Name = "prgTest";
            this.prgTest.Size = new System.Drawing.Size(515, 18);
            this.prgTest.TabIndex = 1;
            this.prgTest.Visible = false;
            // 
            // btnDock
            // 
            this.btnDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDock.Location = new System.Drawing.Point(70, 3);
            this.btnDock.Name = "btnDock";
            this.btnDock.Size = new System.Drawing.Size(207, 29);
            this.btnDock.TabIndex = 2;
            this.btnDock.Text = "Run Test";
            this.tltMain.SetToolTip(this.btnDock, "Send a random bitstream multiple times as specified");
            this.btnDock.UseVisualStyleBackColor = true;
            this.btnDock.Click += new System.EventHandler(this.btnDock_Click);
            // 
            // pcbTest
            // 
            this.pcbTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbTest.Location = new System.Drawing.Point(838, 3);
            this.pcbTest.Name = "pcbTest";
            this.pcbTest.Size = new System.Drawing.Size(30, 29);
            this.pcbTest.TabIndex = 3;
            this.pcbTest.TabStop = false;
            // 
            // grpReciever
            // 
            this.grpReciever.Controls.Add(this.tlpReciever);
            this.grpReciever.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReciever.Location = new System.Drawing.Point(3, 154);
            this.grpReciever.Name = "grpReciever";
            this.grpReciever.Size = new System.Drawing.Size(877, 120);
            this.grpReciever.TabIndex = 1;
            this.grpReciever.TabStop = false;
            this.grpReciever.Text = "Reciever";
            // 
            // tlpReciever
            // 
            this.tlpReciever.ColumnCount = 3;
            this.tlpReciever.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tlpReciever.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReciever.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpReciever.Controls.Add(this.tlpRecBits, 0, 0);
            this.tlpReciever.Controls.Add(this.tlpRecieveOptions, 0, 0);
            this.tlpReciever.Controls.Add(this.pcbRecieve, 2, 0);
            this.tlpReciever.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpReciever.Location = new System.Drawing.Point(3, 16);
            this.tlpReciever.Name = "tlpReciever";
            this.tlpReciever.RowCount = 1;
            this.tlpReciever.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReciever.Size = new System.Drawing.Size(871, 101);
            this.tlpReciever.TabIndex = 1;
            // 
            // tlpRecBits
            // 
            this.tlpRecBits.ColumnCount = 8;
            this.tlpRecBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRecBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRecBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRecBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRecBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRecBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRecBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRecBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpRecBits.Controls.Add(this.lblRec8, 7, 0);
            this.tlpRecBits.Controls.Add(this.lblRec7, 6, 0);
            this.tlpRecBits.Controls.Add(this.lblRec6, 5, 0);
            this.tlpRecBits.Controls.Add(this.lblRec5, 4, 0);
            this.tlpRecBits.Controls.Add(this.lblRec4, 3, 0);
            this.tlpRecBits.Controls.Add(this.lblRec3, 2, 0);
            this.tlpRecBits.Controls.Add(this.lblRec2, 1, 0);
            this.tlpRecBits.Controls.Add(this.lblRecBit8, 7, 1);
            this.tlpRecBits.Controls.Add(this.lblRecBit7, 6, 1);
            this.tlpRecBits.Controls.Add(this.lblRecBit6, 5, 1);
            this.tlpRecBits.Controls.Add(this.lblRecBit5, 4, 1);
            this.tlpRecBits.Controls.Add(this.lblRecBit4, 3, 1);
            this.tlpRecBits.Controls.Add(this.lblRecBit3, 2, 1);
            this.tlpRecBits.Controls.Add(this.lblRecBit2, 1, 1);
            this.tlpRecBits.Controls.Add(this.lblRecBit1, 0, 1);
            this.tlpRecBits.Controls.Add(this.lblRec1, 0, 0);
            this.tlpRecBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRecBits.Location = new System.Drawing.Point(153, 10);
            this.tlpRecBits.Margin = new System.Windows.Forms.Padding(10);
            this.tlpRecBits.Name = "tlpRecBits";
            this.tlpRecBits.RowCount = 2;
            this.tlpRecBits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRecBits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpRecBits.Size = new System.Drawing.Size(668, 81);
            this.tlpRecBits.TabIndex = 3;
            // 
            // lblRec8
            // 
            this.lblRec8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRec8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRec8.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRec8.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRec8.Location = new System.Drawing.Point(584, 0);
            this.lblRec8.Name = "lblRec8";
            this.lblRec8.Size = new System.Drawing.Size(81, 51);
            this.lblRec8.TabIndex = 23;
            this.lblRec8.Text = "?";
            this.lblRec8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.lblRec8, "Eighth Bit");
            this.lblRec8.TextChanged += new System.EventHandler(this.lblBits_TextChanged);
            // 
            // lblRec7
            // 
            this.lblRec7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRec7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRec7.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRec7.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRec7.Location = new System.Drawing.Point(501, 0);
            this.lblRec7.Name = "lblRec7";
            this.lblRec7.Size = new System.Drawing.Size(77, 51);
            this.lblRec7.TabIndex = 22;
            this.lblRec7.Text = "?";
            this.lblRec7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.lblRec7, "Seventh Bit");
            this.lblRec7.TextChanged += new System.EventHandler(this.lblBits_TextChanged);
            // 
            // lblRec6
            // 
            this.lblRec6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRec6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRec6.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRec6.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRec6.Location = new System.Drawing.Point(418, 0);
            this.lblRec6.Name = "lblRec6";
            this.lblRec6.Size = new System.Drawing.Size(77, 51);
            this.lblRec6.TabIndex = 21;
            this.lblRec6.Text = "?";
            this.lblRec6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.lblRec6, "Sixth Bit");
            this.lblRec6.TextChanged += new System.EventHandler(this.lblBits_TextChanged);
            // 
            // lblRec5
            // 
            this.lblRec5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRec5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRec5.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRec5.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRec5.Location = new System.Drawing.Point(335, 0);
            this.lblRec5.Name = "lblRec5";
            this.lblRec5.Size = new System.Drawing.Size(77, 51);
            this.lblRec5.TabIndex = 20;
            this.lblRec5.Text = "?";
            this.lblRec5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.lblRec5, "Fifth Bit");
            this.lblRec5.TextChanged += new System.EventHandler(this.lblBits_TextChanged);
            // 
            // lblRec4
            // 
            this.lblRec4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRec4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRec4.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRec4.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRec4.Location = new System.Drawing.Point(252, 0);
            this.lblRec4.Name = "lblRec4";
            this.lblRec4.Size = new System.Drawing.Size(77, 51);
            this.lblRec4.TabIndex = 19;
            this.lblRec4.Text = "?";
            this.lblRec4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.lblRec4, "Fourth Bit");
            this.lblRec4.TextChanged += new System.EventHandler(this.lblBits_TextChanged);
            // 
            // lblRec3
            // 
            this.lblRec3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRec3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRec3.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRec3.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRec3.Location = new System.Drawing.Point(169, 0);
            this.lblRec3.Name = "lblRec3";
            this.lblRec3.Size = new System.Drawing.Size(77, 51);
            this.lblRec3.TabIndex = 18;
            this.lblRec3.Text = "?";
            this.lblRec3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.lblRec3, "Third Bit");
            this.lblRec3.TextChanged += new System.EventHandler(this.lblBits_TextChanged);
            // 
            // lblRec2
            // 
            this.lblRec2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRec2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRec2.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRec2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRec2.Location = new System.Drawing.Point(86, 0);
            this.lblRec2.Name = "lblRec2";
            this.lblRec2.Size = new System.Drawing.Size(77, 51);
            this.lblRec2.TabIndex = 17;
            this.lblRec2.Text = "?";
            this.lblRec2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.lblRec2, "Second Bit");
            this.lblRec2.TextChanged += new System.EventHandler(this.lblBits_TextChanged);
            // 
            // lblRecBit8
            // 
            this.lblRecBit8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecBit8.Location = new System.Drawing.Point(584, 51);
            this.lblRecBit8.Name = "lblRecBit8";
            this.lblRecBit8.Size = new System.Drawing.Size(81, 30);
            this.lblRecBit8.TabIndex = 15;
            this.lblRecBit8.Text = "Bit 8";
            this.lblRecBit8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecBit7
            // 
            this.lblRecBit7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecBit7.Location = new System.Drawing.Point(501, 51);
            this.lblRecBit7.Name = "lblRecBit7";
            this.lblRecBit7.Size = new System.Drawing.Size(77, 30);
            this.lblRecBit7.TabIndex = 14;
            this.lblRecBit7.Text = "Bit 7";
            this.lblRecBit7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecBit6
            // 
            this.lblRecBit6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecBit6.Location = new System.Drawing.Point(418, 51);
            this.lblRecBit6.Name = "lblRecBit6";
            this.lblRecBit6.Size = new System.Drawing.Size(77, 30);
            this.lblRecBit6.TabIndex = 13;
            this.lblRecBit6.Text = "Bit 6";
            this.lblRecBit6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecBit5
            // 
            this.lblRecBit5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecBit5.Location = new System.Drawing.Point(335, 51);
            this.lblRecBit5.Name = "lblRecBit5";
            this.lblRecBit5.Size = new System.Drawing.Size(77, 30);
            this.lblRecBit5.TabIndex = 12;
            this.lblRecBit5.Text = "Bit 5";
            this.lblRecBit5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecBit4
            // 
            this.lblRecBit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecBit4.Location = new System.Drawing.Point(252, 51);
            this.lblRecBit4.Name = "lblRecBit4";
            this.lblRecBit4.Size = new System.Drawing.Size(77, 30);
            this.lblRecBit4.TabIndex = 11;
            this.lblRecBit4.Text = "Bit 4";
            this.lblRecBit4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecBit3
            // 
            this.lblRecBit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecBit3.Location = new System.Drawing.Point(169, 51);
            this.lblRecBit3.Name = "lblRecBit3";
            this.lblRecBit3.Size = new System.Drawing.Size(77, 30);
            this.lblRecBit3.TabIndex = 10;
            this.lblRecBit3.Text = "Bit 3";
            this.lblRecBit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecBit2
            // 
            this.lblRecBit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecBit2.Location = new System.Drawing.Point(86, 51);
            this.lblRecBit2.Name = "lblRecBit2";
            this.lblRecBit2.Size = new System.Drawing.Size(77, 30);
            this.lblRecBit2.TabIndex = 9;
            this.lblRecBit2.Text = "Bit 2";
            this.lblRecBit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecBit1
            // 
            this.lblRecBit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecBit1.Location = new System.Drawing.Point(3, 51);
            this.lblRecBit1.Name = "lblRecBit1";
            this.lblRecBit1.Size = new System.Drawing.Size(77, 30);
            this.lblRecBit1.TabIndex = 1;
            this.lblRecBit1.Text = "Bit 1";
            this.lblRecBit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRec1
            // 
            this.lblRec1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRec1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRec1.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRec1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRec1.Location = new System.Drawing.Point(3, 0);
            this.lblRec1.Name = "lblRec1";
            this.lblRec1.Size = new System.Drawing.Size(77, 51);
            this.lblRec1.TabIndex = 16;
            this.lblRec1.Text = "?";
            this.lblRec1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.lblRec1, "First Bit");
            this.lblRec1.TextChanged += new System.EventHandler(this.lblBits_TextChanged);
            // 
            // tlpRecieveOptions
            // 
            this.tlpRecieveOptions.ColumnCount = 1;
            this.tlpRecieveOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRecieveOptions.Controls.Add(this.cmbRecPort, 0, 0);
            this.tlpRecieveOptions.Controls.Add(this.cmbRecBitrate, 0, 1);
            this.tlpRecieveOptions.Controls.Add(this.btnRecConnect, 0, 2);
            this.tlpRecieveOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRecieveOptions.Location = new System.Drawing.Point(3, 3);
            this.tlpRecieveOptions.Name = "tlpRecieveOptions";
            this.tlpRecieveOptions.RowCount = 4;
            this.tlpRecieveOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpRecieveOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpRecieveOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRecieveOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRecieveOptions.Size = new System.Drawing.Size(137, 95);
            this.tlpRecieveOptions.TabIndex = 0;
            // 
            // cmbRecPort
            // 
            this.cmbRecPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRecPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecPort.FormattingEnabled = true;
            this.cmbRecPort.Location = new System.Drawing.Point(3, 3);
            this.cmbRecPort.Name = "cmbRecPort";
            this.cmbRecPort.Size = new System.Drawing.Size(131, 21);
            this.cmbRecPort.TabIndex = 0;
            this.tltMain.SetToolTip(this.cmbRecPort, "List of ports to connect as reciever");
            this.cmbRecPort.SelectedIndexChanged += new System.EventHandler(this.cmbCombo_SelectedIndexChanged);
            // 
            // cmbRecBitrate
            // 
            this.cmbRecBitrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRecBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecBitrate.FormattingEnabled = true;
            this.cmbRecBitrate.Items.AddRange(new object[] {
            "115200",
            "1200",
            "19200",
            "2400",
            "38400",
            "4800",
            "57600",
            "9600"});
            this.cmbRecBitrate.Location = new System.Drawing.Point(3, 28);
            this.cmbRecBitrate.Name = "cmbRecBitrate";
            this.cmbRecBitrate.Size = new System.Drawing.Size(131, 21);
            this.cmbRecBitrate.TabIndex = 1;
            this.tltMain.SetToolTip(this.cmbRecBitrate, "Baud rate for reciever port");
            this.cmbRecBitrate.SelectedIndexChanged += new System.EventHandler(this.cmbCombo_SelectedIndexChanged);
            // 
            // btnRecConnect
            // 
            this.btnRecConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecConnect.Location = new System.Drawing.Point(3, 57);
            this.btnRecConnect.Name = "btnRecConnect";
            this.btnRecConnect.Size = new System.Drawing.Size(131, 34);
            this.btnRecConnect.TabIndex = 2;
            this.btnRecConnect.Text = "Connect";
            this.tltMain.SetToolTip(this.btnRecConnect, "Connect to the specified COM port as the reciever");
            this.btnRecConnect.UseVisualStyleBackColor = true;
            this.btnRecConnect.TextChanged += new System.EventHandler(this.btnConnect_TextChanged);
            this.btnRecConnect.Click += new System.EventHandler(this.btnRecConnect_Click);
            // 
            // pcbRecieve
            // 
            this.pcbRecieve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbRecieve.Location = new System.Drawing.Point(834, 3);
            this.pcbRecieve.Name = "pcbRecieve";
            this.pcbRecieve.Size = new System.Drawing.Size(34, 95);
            this.pcbRecieve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbRecieve.TabIndex = 4;
            this.pcbRecieve.TabStop = false;
            // 
            // grpTransmitter
            // 
            this.grpTransmitter.Controls.Add(this.tlpTransmitter);
            this.grpTransmitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTransmitter.Location = new System.Drawing.Point(3, 28);
            this.grpTransmitter.Name = "grpTransmitter";
            this.grpTransmitter.Size = new System.Drawing.Size(877, 120);
            this.grpTransmitter.TabIndex = 0;
            this.grpTransmitter.TabStop = false;
            this.grpTransmitter.Text = "Transmitter";
            // 
            // tlpTransmitter
            // 
            this.tlpTransmitter.ColumnCount = 3;
            this.tlpTransmitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tlpTransmitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTransmitter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTransmitter.Controls.Add(this.tlpTransOptions, 0, 0);
            this.tlpTransmitter.Controls.Add(this.tlpBits, 1, 0);
            this.tlpTransmitter.Controls.Add(this.spcButton, 2, 0);
            this.tlpTransmitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTransmitter.Location = new System.Drawing.Point(3, 16);
            this.tlpTransmitter.Name = "tlpTransmitter";
            this.tlpTransmitter.RowCount = 1;
            this.tlpTransmitter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTransmitter.Size = new System.Drawing.Size(871, 101);
            this.tlpTransmitter.TabIndex = 0;
            // 
            // tlpTransOptions
            // 
            this.tlpTransOptions.ColumnCount = 1;
            this.tlpTransOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTransOptions.Controls.Add(this.cmbTransPort, 0, 0);
            this.tlpTransOptions.Controls.Add(this.cmbTransBitrate, 0, 1);
            this.tlpTransOptions.Controls.Add(this.btnTransConnect, 0, 2);
            this.tlpTransOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTransOptions.Location = new System.Drawing.Point(3, 3);
            this.tlpTransOptions.Name = "tlpTransOptions";
            this.tlpTransOptions.RowCount = 4;
            this.tlpTransOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpTransOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpTransOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTransOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTransOptions.Size = new System.Drawing.Size(137, 95);
            this.tlpTransOptions.TabIndex = 0;
            // 
            // cmbTransPort
            // 
            this.cmbTransPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTransPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransPort.FormattingEnabled = true;
            this.cmbTransPort.Location = new System.Drawing.Point(3, 3);
            this.cmbTransPort.Name = "cmbTransPort";
            this.cmbTransPort.Size = new System.Drawing.Size(131, 21);
            this.cmbTransPort.TabIndex = 0;
            this.tltMain.SetToolTip(this.cmbTransPort, "List of ports to connect as transmitter");
            this.cmbTransPort.SelectedIndexChanged += new System.EventHandler(this.cmbCombo_SelectedIndexChanged);
            // 
            // cmbTransBitrate
            // 
            this.cmbTransBitrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTransBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransBitrate.FormattingEnabled = true;
            this.cmbTransBitrate.Items.AddRange(new object[] {
            "115200",
            "1200",
            "19200",
            "2400",
            "38400",
            "4800",
            "57600",
            "9600"});
            this.cmbTransBitrate.Location = new System.Drawing.Point(3, 28);
            this.cmbTransBitrate.Name = "cmbTransBitrate";
            this.cmbTransBitrate.Size = new System.Drawing.Size(131, 21);
            this.cmbTransBitrate.TabIndex = 1;
            this.tltMain.SetToolTip(this.cmbTransBitrate, "Baud rate for transmitter port");
            this.cmbTransBitrate.SelectedIndexChanged += new System.EventHandler(this.cmbCombo_SelectedIndexChanged);
            // 
            // btnTransConnect
            // 
            this.btnTransConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransConnect.Location = new System.Drawing.Point(3, 57);
            this.btnTransConnect.Name = "btnTransConnect";
            this.btnTransConnect.Size = new System.Drawing.Size(131, 34);
            this.btnTransConnect.TabIndex = 2;
            this.btnTransConnect.Text = "Connect";
            this.tltMain.SetToolTip(this.btnTransConnect, "Connect to the specified COM port as the transmitter");
            this.btnTransConnect.UseVisualStyleBackColor = true;
            this.btnTransConnect.TextChanged += new System.EventHandler(this.btnConnect_TextChanged);
            this.btnTransConnect.Click += new System.EventHandler(this.btnTransConnect_Click);
            // 
            // tlpBits
            // 
            this.tlpBits.ColumnCount = 8;
            this.tlpBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpBits.Controls.Add(this.lblTransBit8, 7, 1);
            this.tlpBits.Controls.Add(this.lblTransBit7, 6, 1);
            this.tlpBits.Controls.Add(this.lblTransBit6, 5, 1);
            this.tlpBits.Controls.Add(this.lblTransBit5, 4, 1);
            this.tlpBits.Controls.Add(this.lblTransBit4, 3, 1);
            this.tlpBits.Controls.Add(this.lblTransBit3, 2, 1);
            this.tlpBits.Controls.Add(this.bitTrans2, 1, 1);
            this.tlpBits.Controls.Add(this.chkEight, 7, 0);
            this.tlpBits.Controls.Add(this.chkSeven, 6, 0);
            this.tlpBits.Controls.Add(this.chkSix, 5, 0);
            this.tlpBits.Controls.Add(this.chkFive, 4, 0);
            this.tlpBits.Controls.Add(this.chkFour, 3, 0);
            this.tlpBits.Controls.Add(this.chkThree, 2, 0);
            this.tlpBits.Controls.Add(this.chkTwo, 1, 0);
            this.tlpBits.Controls.Add(this.chkOne, 0, 0);
            this.tlpBits.Controls.Add(this.lblTrans1, 0, 1);
            this.tlpBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBits.Location = new System.Drawing.Point(153, 10);
            this.tlpBits.Margin = new System.Windows.Forms.Padding(10);
            this.tlpBits.Name = "tlpBits";
            this.tlpBits.RowCount = 2;
            this.tlpBits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBits.Size = new System.Drawing.Size(668, 81);
            this.tlpBits.TabIndex = 2;
            // 
            // lblTransBit8
            // 
            this.lblTransBit8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransBit8.Location = new System.Drawing.Point(584, 51);
            this.lblTransBit8.Name = "lblTransBit8";
            this.lblTransBit8.Size = new System.Drawing.Size(81, 30);
            this.lblTransBit8.TabIndex = 15;
            this.lblTransBit8.Text = "Bit 8";
            this.lblTransBit8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransBit7
            // 
            this.lblTransBit7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransBit7.Location = new System.Drawing.Point(501, 51);
            this.lblTransBit7.Name = "lblTransBit7";
            this.lblTransBit7.Size = new System.Drawing.Size(77, 30);
            this.lblTransBit7.TabIndex = 14;
            this.lblTransBit7.Text = "Bit 7";
            this.lblTransBit7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransBit6
            // 
            this.lblTransBit6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransBit6.Location = new System.Drawing.Point(418, 51);
            this.lblTransBit6.Name = "lblTransBit6";
            this.lblTransBit6.Size = new System.Drawing.Size(77, 30);
            this.lblTransBit6.TabIndex = 13;
            this.lblTransBit6.Text = "Bit 6";
            this.lblTransBit6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransBit5
            // 
            this.lblTransBit5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransBit5.Location = new System.Drawing.Point(335, 51);
            this.lblTransBit5.Name = "lblTransBit5";
            this.lblTransBit5.Size = new System.Drawing.Size(77, 30);
            this.lblTransBit5.TabIndex = 12;
            this.lblTransBit5.Text = "Bit 5";
            this.lblTransBit5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransBit4
            // 
            this.lblTransBit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransBit4.Location = new System.Drawing.Point(252, 51);
            this.lblTransBit4.Name = "lblTransBit4";
            this.lblTransBit4.Size = new System.Drawing.Size(77, 30);
            this.lblTransBit4.TabIndex = 11;
            this.lblTransBit4.Text = "Bit 4";
            this.lblTransBit4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransBit3
            // 
            this.lblTransBit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransBit3.Location = new System.Drawing.Point(169, 51);
            this.lblTransBit3.Name = "lblTransBit3";
            this.lblTransBit3.Size = new System.Drawing.Size(77, 30);
            this.lblTransBit3.TabIndex = 10;
            this.lblTransBit3.Text = "Bit 3";
            this.lblTransBit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bitTrans2
            // 
            this.bitTrans2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bitTrans2.Location = new System.Drawing.Point(86, 51);
            this.bitTrans2.Name = "bitTrans2";
            this.bitTrans2.Size = new System.Drawing.Size(77, 30);
            this.bitTrans2.TabIndex = 9;
            this.bitTrans2.Text = "Bit 2";
            this.bitTrans2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkEight
            // 
            this.chkEight.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEight.AutoSize = true;
            this.chkEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEight.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkEight.ForeColor = System.Drawing.Color.DarkRed;
            this.chkEight.Location = new System.Drawing.Point(584, 3);
            this.chkEight.Name = "chkEight";
            this.chkEight.Size = new System.Drawing.Size(81, 45);
            this.chkEight.TabIndex = 8;
            this.chkEight.Text = "0";
            this.chkEight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.chkEight, "Eight Bit");
            this.chkEight.UseVisualStyleBackColor = true;
            this.chkEight.CheckedChanged += new System.EventHandler(this.chkBits_CheckedChanged);
            // 
            // chkSeven
            // 
            this.chkSeven.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSeven.AutoSize = true;
            this.chkSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSeven.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkSeven.ForeColor = System.Drawing.Color.DarkRed;
            this.chkSeven.Location = new System.Drawing.Point(501, 3);
            this.chkSeven.Name = "chkSeven";
            this.chkSeven.Size = new System.Drawing.Size(77, 45);
            this.chkSeven.TabIndex = 7;
            this.chkSeven.Text = "0";
            this.chkSeven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.chkSeven, "Seventh Bit");
            this.chkSeven.UseVisualStyleBackColor = true;
            this.chkSeven.CheckedChanged += new System.EventHandler(this.chkBits_CheckedChanged);
            // 
            // chkSix
            // 
            this.chkSix.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSix.AutoSize = true;
            this.chkSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSix.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkSix.ForeColor = System.Drawing.Color.DarkRed;
            this.chkSix.Location = new System.Drawing.Point(418, 3);
            this.chkSix.Name = "chkSix";
            this.chkSix.Size = new System.Drawing.Size(77, 45);
            this.chkSix.TabIndex = 6;
            this.chkSix.Text = "0";
            this.chkSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.chkSix, "Sixth Bit");
            this.chkSix.UseVisualStyleBackColor = true;
            this.chkSix.CheckedChanged += new System.EventHandler(this.chkBits_CheckedChanged);
            // 
            // chkFive
            // 
            this.chkFive.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFive.AutoSize = true;
            this.chkFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFive.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkFive.ForeColor = System.Drawing.Color.DarkRed;
            this.chkFive.Location = new System.Drawing.Point(335, 3);
            this.chkFive.Name = "chkFive";
            this.chkFive.Size = new System.Drawing.Size(77, 45);
            this.chkFive.TabIndex = 5;
            this.chkFive.Text = "0";
            this.chkFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.chkFive, "Fifth Bit");
            this.chkFive.UseVisualStyleBackColor = true;
            this.chkFive.CheckedChanged += new System.EventHandler(this.chkBits_CheckedChanged);
            // 
            // chkFour
            // 
            this.chkFour.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFour.AutoSize = true;
            this.chkFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFour.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkFour.ForeColor = System.Drawing.Color.DarkRed;
            this.chkFour.Location = new System.Drawing.Point(252, 3);
            this.chkFour.Name = "chkFour";
            this.chkFour.Size = new System.Drawing.Size(77, 45);
            this.chkFour.TabIndex = 4;
            this.chkFour.Text = "0";
            this.chkFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.chkFour, "Fourth Bit");
            this.chkFour.UseVisualStyleBackColor = true;
            this.chkFour.CheckedChanged += new System.EventHandler(this.chkBits_CheckedChanged);
            // 
            // chkThree
            // 
            this.chkThree.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkThree.AutoSize = true;
            this.chkThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkThree.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkThree.ForeColor = System.Drawing.Color.DarkRed;
            this.chkThree.Location = new System.Drawing.Point(169, 3);
            this.chkThree.Name = "chkThree";
            this.chkThree.Size = new System.Drawing.Size(77, 45);
            this.chkThree.TabIndex = 3;
            this.chkThree.Text = "0";
            this.chkThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.chkThree, "Third Bit");
            this.chkThree.UseVisualStyleBackColor = true;
            this.chkThree.CheckedChanged += new System.EventHandler(this.chkBits_CheckedChanged);
            // 
            // chkTwo
            // 
            this.chkTwo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTwo.AutoSize = true;
            this.chkTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTwo.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkTwo.ForeColor = System.Drawing.Color.DarkRed;
            this.chkTwo.Location = new System.Drawing.Point(86, 3);
            this.chkTwo.Name = "chkTwo";
            this.chkTwo.Size = new System.Drawing.Size(77, 45);
            this.chkTwo.TabIndex = 2;
            this.chkTwo.Text = "0";
            this.chkTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.chkTwo, "Second Bit");
            this.chkTwo.UseVisualStyleBackColor = true;
            this.chkTwo.CheckedChanged += new System.EventHandler(this.chkBits_CheckedChanged);
            // 
            // chkOne
            // 
            this.chkOne.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOne.AutoSize = true;
            this.chkOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOne.Font = new System.Drawing.Font("Miriam Mono CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkOne.ForeColor = System.Drawing.Color.DarkRed;
            this.chkOne.Location = new System.Drawing.Point(3, 3);
            this.chkOne.Name = "chkOne";
            this.chkOne.Size = new System.Drawing.Size(77, 45);
            this.chkOne.TabIndex = 0;
            this.chkOne.Text = "0";
            this.chkOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltMain.SetToolTip(this.chkOne, "First Bit");
            this.chkOne.UseVisualStyleBackColor = true;
            this.chkOne.CheckedChanged += new System.EventHandler(this.chkBits_CheckedChanged);
            // 
            // lblTrans1
            // 
            this.lblTrans1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrans1.Location = new System.Drawing.Point(3, 51);
            this.lblTrans1.Name = "lblTrans1";
            this.lblTrans1.Size = new System.Drawing.Size(77, 30);
            this.lblTrans1.TabIndex = 1;
            this.lblTrans1.Text = "Bit 1";
            this.lblTrans1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spcButton
            // 
            this.spcButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcButton.IsSplitterFixed = true;
            this.spcButton.Location = new System.Drawing.Point(834, 3);
            this.spcButton.Name = "spcButton";
            this.spcButton.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcButton.Panel1
            // 
            this.spcButton.Panel1.Controls.Add(this.btnSend);
            // 
            // spcButton.Panel2
            // 
            this.spcButton.Panel2.Controls.Add(this.pcbSend);
            this.spcButton.Panel2Collapsed = true;
            this.spcButton.Size = new System.Drawing.Size(34, 95);
            this.spcButton.SplitterDistance = 48;
            this.spcButton.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(34, 95);
            this.btnSend.TabIndex = 2;
            this.tltMain.SetToolTip(this.btnSend, "Send bitstream to the port");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.EnabledChanged += new System.EventHandler(this.btnSend_EnabledChanged);
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pcbSend
            // 
            this.pcbSend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pcbSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbSend.Location = new System.Drawing.Point(0, 0);
            this.pcbSend.Name = "pcbSend";
            this.pcbSend.Size = new System.Drawing.Size(150, 46);
            this.pcbSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbSend.TabIndex = 0;
            this.pcbSend.TabStop = false;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpTransmitter, 0, 1);
            this.tlpMain.Controls.Add(this.grpReciever, 0, 2);
            this.tlpMain.Controls.Add(this.grpTest, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.Size = new System.Drawing.Size(883, 337);
            this.tlpMain.TabIndex = 1;
            // 
            // tssMain
            // 
            this.tssMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssFile,
            this.tssBitstream,
            this.btnAbout,
            this.tssOptions});
            this.tssMain.Location = new System.Drawing.Point(0, 0);
            this.tssMain.Name = "tssMain";
            this.tssMain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tssMain.Size = new System.Drawing.Size(883, 25);
            this.tssMain.TabIndex = 2;
            this.tssMain.Text = "Tool Strip";
            // 
            // tssFile
            // 
            this.tssFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReload,
            this.tsmDisconnect,
            this.tstSep1,
            this.tsmExit});
            this.tssFile.Image = ((System.Drawing.Image)(resources.GetObject("tssFile.Image")));
            this.tssFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssFile.Name = "tssFile";
            this.tssFile.Size = new System.Drawing.Size(54, 22);
            this.tssFile.Text = "File";
            // 
            // tsmReload
            // 
            this.tsmReload.Name = "tsmReload";
            this.tsmReload.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmReload.Size = new System.Drawing.Size(204, 22);
            this.tsmReload.Text = "Reload Ports";
            this.tsmReload.ToolTipText = "Reload all ports";
            this.tsmReload.Click += new System.EventHandler(this.tsmReload_Click);
            // 
            // tsmDisconnect
            // 
            this.tsmDisconnect.Name = "tsmDisconnect";
            this.tsmDisconnect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.tsmDisconnect.Size = new System.Drawing.Size(204, 22);
            this.tsmDisconnect.Text = "Disconnect All";
            this.tsmDisconnect.ToolTipText = "Disconnect from all ports";
            this.tsmDisconnect.Click += new System.EventHandler(this.tsmDisconnect_Click);
            // 
            // tstSep1
            // 
            this.tstSep1.Name = "tstSep1";
            this.tstSep1.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmExit.Size = new System.Drawing.Size(204, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.ToolTipText = "Exit Application";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tssBitstream
            // 
            this.tssBitstream.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGenerate,
            this.tsmSend,
            this.tstSep2,
            this.tsmTest});
            this.tssBitstream.Image = ((System.Drawing.Image)(resources.GetObject("tssBitstream.Image")));
            this.tssBitstream.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssBitstream.Name = "tssBitstream";
            this.tssBitstream.Size = new System.Drawing.Size(86, 22);
            this.tssBitstream.Text = "Bitstream";
            // 
            // tsmGenerate
            // 
            this.tsmGenerate.Name = "tsmGenerate";
            this.tsmGenerate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmGenerate.Size = new System.Drawing.Size(215, 22);
            this.tsmGenerate.Text = "Generate Bitstream";
            this.tsmGenerate.ToolTipText = "Generate a new random bitstream";
            this.tsmGenerate.Click += new System.EventHandler(this.tsmGenerate_Click);
            // 
            // tsmSend
            // 
            this.tsmSend.Name = "tsmSend";
            this.tsmSend.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmSend.Size = new System.Drawing.Size(215, 22);
            this.tsmSend.Text = "Send Bitstream";
            this.tsmSend.ToolTipText = "Send the bitstream";
            this.tsmSend.Click += new System.EventHandler(this.tsmSend_Click);
            // 
            // tstSep2
            // 
            this.tstSep2.Name = "tstSep2";
            this.tstSep2.Size = new System.Drawing.Size(212, 6);
            // 
            // tsmTest
            // 
            this.tsmTest.Name = "tsmTest";
            this.tsmTest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.tsmTest.Size = new System.Drawing.Size(215, 22);
            this.tsmTest.Text = "Run Test";
            this.tsmTest.ToolTipText = "Run the test";
            this.tsmTest.Click += new System.EventHandler(this.tsmTest_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.ToolTipText = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tssOptions
            // 
            this.tssOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMode,
            this.tssSep3,
            this.tssEachGenerate,
            this.toolStripSeparator1,
            this.tsmPositioning,
            this.tsmFourBit});
            this.tssOptions.Image = ((System.Drawing.Image)(resources.GetObject("tssOptions.Image")));
            this.tssOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssOptions.Name = "tssOptions";
            this.tssOptions.Size = new System.Drawing.Size(78, 22);
            this.tssOptions.Text = "Options";
            // 
            // tssMode
            // 
            this.tssMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUni,
            this.tsmBi});
            this.tssMode.Name = "tssMode";
            this.tssMode.Size = new System.Drawing.Size(237, 22);
            this.tssMode.Text = "Directional Mode";
            this.tssMode.ToolTipText = "Direction at which communication happens";
            // 
            // tsmUni
            // 
            this.tsmUni.CheckOnClick = true;
            this.tsmUni.Name = "tsmUni";
            this.tsmUni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.tsmUni.Size = new System.Drawing.Size(205, 22);
            this.tsmUni.Text = "Unidirectional";
            this.tsmUni.ToolTipText = "Communication happens only in one direction";
            this.tsmUni.CheckedChanged += new System.EventHandler(this.tsmUni_CheckedChanged);
            // 
            // tsmBi
            // 
            this.tsmBi.CheckOnClick = true;
            this.tsmBi.Name = "tsmBi";
            this.tsmBi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.tsmBi.Size = new System.Drawing.Size(205, 22);
            this.tsmBi.Text = "Bidirectional";
            this.tsmBi.ToolTipText = "Communication happens in both directions";
            this.tsmBi.CheckedChanged += new System.EventHandler(this.tsmBi_CheckedChanged);
            this.tsmBi.Click += new System.EventHandler(this.tsmBi_Click);
            // 
            // tssSep3
            // 
            this.tssSep3.Name = "tssSep3";
            this.tssSep3.Size = new System.Drawing.Size(234, 6);
            // 
            // tssEachGenerate
            // 
            this.tssEachGenerate.Checked = true;
            this.tssEachGenerate.CheckOnClick = true;
            this.tssEachGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tssEachGenerate.Name = "tssEachGenerate";
            this.tssEachGenerate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tssEachGenerate.Size = new System.Drawing.Size(237, 22);
            this.tssEachGenerate.Text = "Generate for Each Test";
            this.tssEachGenerate.ToolTipText = "When checked, a new random bit stream will be generated for each test pass";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // tsmPositioning
            // 
            this.tsmPositioning.CheckOnClick = true;
            this.tsmPositioning.Name = "tsmPositioning";
            this.tsmPositioning.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmPositioning.Size = new System.Drawing.Size(237, 22);
            this.tsmPositioning.Text = "Transmitter Positioning";
            this.tsmPositioning.ToolTipText = "Open positioning window for the transmitter";
            this.tsmPositioning.Click += new System.EventHandler(this.tsmPositioning_Click);
            // 
            // tsmFourBit
            // 
            this.tsmFourBit.CheckOnClick = true;
            this.tsmFourBit.Name = "tsmFourBit";
            this.tsmFourBit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.tsmFourBit.Size = new System.Drawing.Size(237, 22);
            this.tsmFourBit.Text = "Four-Bit Mode";
            this.tsmFourBit.ToolTipText = "Only four bits are being transmitted and recieved (Only available in Unidirection" +
    "al Mode)";
            this.tsmFourBit.Click += new System.EventHandler(this.tsmFourBit_Click);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipTitle = "BitStreamer";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 359);
            this.Controls.Add(this.tssMain);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.stsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(899, 398);
            this.Name = "frmMain";
            this.Text = "BitStreamer - Bitstream Emulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.grpTest.ResumeLayout(false);
            this.tlpTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTest)).EndInit();
            this.grpReciever.ResumeLayout(false);
            this.tlpReciever.ResumeLayout(false);
            this.tlpRecBits.ResumeLayout(false);
            this.tlpRecieveOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecieve)).EndInit();
            this.grpTransmitter.ResumeLayout(false);
            this.tlpTransmitter.ResumeLayout(false);
            this.tlpTransOptions.ResumeLayout(false);
            this.tlpBits.ResumeLayout(false);
            this.tlpBits.PerformLayout();
            this.spcButton.Panel1.ResumeLayout(false);
            this.spcButton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcButton)).EndInit();
            this.spcButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSend)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tssMain.ResumeLayout(false);
            this.tssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssTime;
        private System.Windows.Forms.GroupBox grpTest;
        private System.Windows.Forms.TableLayoutPanel tlpTest;
        private System.Windows.Forms.NumericUpDown nudTest;
        private System.Windows.Forms.ProgressBar prgTest;
        private System.Windows.Forms.Button btnDock;
        private System.Windows.Forms.PictureBox pcbTest;
        private System.Windows.Forms.GroupBox grpReciever;
        private System.Windows.Forms.TableLayoutPanel tlpReciever;
        private System.Windows.Forms.TableLayoutPanel tlpRecBits;
        private System.Windows.Forms.Label lblRec8;
        private System.Windows.Forms.Label lblRec7;
        private System.Windows.Forms.Label lblRec6;
        private System.Windows.Forms.Label lblRec5;
        private System.Windows.Forms.Label lblRec4;
        private System.Windows.Forms.Label lblRec3;
        private System.Windows.Forms.Label lblRec2;
        private System.Windows.Forms.Label lblRecBit8;
        private System.Windows.Forms.Label lblRecBit7;
        private System.Windows.Forms.Label lblRecBit6;
        private System.Windows.Forms.Label lblRecBit5;
        private System.Windows.Forms.Label lblRecBit4;
        private System.Windows.Forms.Label lblRecBit3;
        private System.Windows.Forms.Label lblRecBit2;
        private System.Windows.Forms.Label lblRecBit1;
        private System.Windows.Forms.Label lblRec1;
        private System.Windows.Forms.TableLayoutPanel tlpRecieveOptions;
        private System.Windows.Forms.ComboBox cmbRecPort;
        private System.Windows.Forms.ComboBox cmbRecBitrate;
        private System.Windows.Forms.Button btnRecConnect;
        private System.Windows.Forms.PictureBox pcbRecieve;
        private System.Windows.Forms.GroupBox grpTransmitter;
        private System.Windows.Forms.TableLayoutPanel tlpTransmitter;
        private System.Windows.Forms.TableLayoutPanel tlpTransOptions;
        private System.Windows.Forms.ComboBox cmbTransPort;
        private System.Windows.Forms.ComboBox cmbTransBitrate;
        private System.Windows.Forms.Button btnTransConnect;
        private System.Windows.Forms.TableLayoutPanel tlpBits;
        private System.Windows.Forms.Label lblTransBit8;
        private System.Windows.Forms.Label lblTransBit7;
        private System.Windows.Forms.Label lblTransBit6;
        private System.Windows.Forms.Label lblTransBit5;
        private System.Windows.Forms.Label lblTransBit4;
        private System.Windows.Forms.Label lblTransBit3;
        private System.Windows.Forms.Label bitTrans2;
        private System.Windows.Forms.CheckBox chkEight;
        private System.Windows.Forms.CheckBox chkSeven;
        private System.Windows.Forms.CheckBox chkSix;
        private System.Windows.Forms.CheckBox chkFive;
        private System.Windows.Forms.CheckBox chkFour;
        private System.Windows.Forms.CheckBox chkThree;
        private System.Windows.Forms.CheckBox chkTwo;
        private System.Windows.Forms.CheckBox chkOne;
        private System.Windows.Forms.Label lblTrans1;
        private System.Windows.Forms.SplitContainer spcButton;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pcbSend;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ToolStrip tssMain;
        private System.Windows.Forms.ToolStripDropDownButton tssFile;
        private System.Windows.Forms.ToolStripDropDownButton tssBitstream;
        private System.Windows.Forms.ToolStripMenuItem tsmReload;
        private System.Windows.Forms.ToolStripSeparator tstSep1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmGenerate;
        private System.Windows.Forms.ToolStripMenuItem tsmSend;
        private System.Windows.Forms.ToolStripSeparator tstSep2;
        private System.Windows.Forms.ToolStripMenuItem tsmTest;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmDisconnect;
        private System.Windows.Forms.ToolTip tltMain;
        private System.Windows.Forms.ToolStripDropDownButton tssOptions;
        private System.Windows.Forms.ToolStripMenuItem tssMode;
        private System.Windows.Forms.ToolStripMenuItem tsmUni;
        private System.Windows.Forms.ToolStripMenuItem tsmBi;
        private System.Windows.Forms.ToolStripSeparator tssSep3;
        private System.Windows.Forms.ToolStripMenuItem tssEachGenerate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmPositioning;
        private System.Windows.Forms.ToolStripMenuItem tsmFourBit;
    }
}

