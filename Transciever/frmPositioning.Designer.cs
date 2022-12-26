
namespace Transciever
{
    partial class frmPositioning
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.grpPort = new System.Windows.Forms.GroupBox();
            this.tlpPort = new System.Windows.Forms.TableLayoutPanel();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudVertical = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblVertical = new System.Windows.Forms.Label();
            this.lblHorizontal = new System.Windows.Forms.Label();
            this.nudHorizontal = new System.Windows.Forms.NumericUpDown();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRecentre = new System.Windows.Forms.Button();
            this.grpTop = new System.Windows.Forms.GroupBox();
            this.tlpView = new System.Windows.Forms.TableLayoutPanel();
            this.pcbTop = new System.Windows.Forms.PictureBox();
            this.trkHorizontal = new System.Windows.Forms.TrackBar();
            this.trkVertical = new System.Windows.Forms.TrackBar();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.grpPort.SuspendLayout();
            this.tlpPort.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.tlpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.grpTop.SuspendLayout();
            this.tlpView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpControls, 0, 0);
            this.tlpMain.Controls.Add(this.grpTop, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(800, 480);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 1;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Controls.Add(this.grpPort, 0, 0);
            this.tlpControls.Controls.Add(this.grpSettings, 0, 1);
            this.tlpControls.Controls.Add(this.grpStatus, 0, 2);
            this.tlpControls.Controls.Add(this.btnRecentre, 0, 4);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(3, 3);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 5;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpControls.Size = new System.Drawing.Size(181, 474);
            this.tlpControls.TabIndex = 0;
            // 
            // grpPort
            // 
            this.grpPort.Controls.Add(this.tlpPort);
            this.grpPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPort.Location = new System.Drawing.Point(3, 3);
            this.grpPort.Name = "grpPort";
            this.grpPort.Size = new System.Drawing.Size(175, 125);
            this.grpPort.TabIndex = 0;
            this.grpPort.TabStop = false;
            this.grpPort.Text = "Port Configuration";
            // 
            // tlpPort
            // 
            this.tlpPort.ColumnCount = 1;
            this.tlpPort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPort.Controls.Add(this.cmbPort, 0, 0);
            this.tlpPort.Controls.Add(this.cmbBaud, 0, 1);
            this.tlpPort.Controls.Add(this.btnConnect, 0, 2);
            this.tlpPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPort.Location = new System.Drawing.Point(3, 16);
            this.tlpPort.Name = "tlpPort";
            this.tlpPort.RowCount = 3;
            this.tlpPort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpPort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpPort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPort.Size = new System.Drawing.Size(169, 106);
            this.tlpPort.TabIndex = 0;
            // 
            // cmbPort
            // 
            this.cmbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(3, 4);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(163, 21);
            this.cmbPort.TabIndex = 0;
            this.tltMain.SetToolTip(this.cmbPort, "List of ports to send positioning commands");
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbCombo_SelectedIndexChanged);
            // 
            // cmbBaud
            // 
            this.cmbBaud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "115200",
            "1200",
            "19200",
            "2400",
            "38400",
            "4800",
            "57600",
            "9600"});
            this.cmbBaud.Location = new System.Drawing.Point(3, 34);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(163, 21);
            this.cmbBaud.TabIndex = 1;
            this.tltMain.SetToolTip(this.cmbBaud, "Baud rate to send to positioning device");
            this.cmbBaud.SelectedIndexChanged += new System.EventHandler(this.cmbCombo_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(3, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(163, 40);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "-";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tltMain.SetToolTip(this.btnConnect, "Connect to the specified COM port for positioning");
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.TextChanged += new System.EventHandler(this.btnConnect_TextChanged);
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.tlpSettings);
            this.grpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSettings.Location = new System.Drawing.Point(3, 134);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(175, 99);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Spatial Settings";
            // 
            // tlpSettings
            // 
            this.tlpSettings.ColumnCount = 2;
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.23077F));
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tlpSettings.Controls.Add(this.nudHeight, 1, 2);
            this.tlpSettings.Controls.Add(this.nudVertical, 1, 1);
            this.tlpSettings.Controls.Add(this.lblHeight, 0, 2);
            this.tlpSettings.Controls.Add(this.lblVertical, 0, 1);
            this.tlpSettings.Controls.Add(this.lblHorizontal, 0, 0);
            this.tlpSettings.Controls.Add(this.nudHorizontal, 1, 0);
            this.tlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettings.Location = new System.Drawing.Point(3, 16);
            this.tlpSettings.Name = "tlpSettings";
            this.tlpSettings.RowCount = 4;
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettings.Size = new System.Drawing.Size(169, 80);
            this.tlpSettings.TabIndex = 0;
            // 
            // nudHeight
            // 
            this.nudHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHeight.Location = new System.Drawing.Point(119, 54);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(47, 20);
            this.nudHeight.TabIndex = 7;
            this.tltMain.SetToolTip(this.nudHeight, "Height at which the transmitter sits");
            this.nudHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudVertical
            // 
            this.nudVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVertical.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudVertical.Location = new System.Drawing.Point(119, 28);
            this.nudVertical.Name = "nudVertical";
            this.nudVertical.Size = new System.Drawing.Size(47, 20);
            this.nudVertical.TabIndex = 6;
            this.tltMain.SetToolTip(this.nudVertical, "Distance from one end to the other in Y direction");
            this.nudVertical.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblHeight
            // 
            this.lblHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeight.Location = new System.Drawing.Point(3, 51);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(110, 25);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "          Height";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVertical
            // 
            this.lblVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVertical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVertical.Location = new System.Drawing.Point(3, 25);
            this.lblVertical.Name = "lblVertical";
            this.lblVertical.Size = new System.Drawing.Size(110, 26);
            this.lblVertical.TabIndex = 2;
            this.lblVertical.Text = "          Y Direction";
            this.lblVertical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorizontal
            // 
            this.lblHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorizontal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHorizontal.Location = new System.Drawing.Point(3, 0);
            this.lblHorizontal.Name = "lblHorizontal";
            this.lblHorizontal.Size = new System.Drawing.Size(110, 25);
            this.lblHorizontal.TabIndex = 0;
            this.lblHorizontal.Text = "          X Direction";
            this.lblHorizontal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudHorizontal
            // 
            this.nudHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHorizontal.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudHorizontal.Location = new System.Drawing.Point(119, 3);
            this.nudHorizontal.Name = "nudHorizontal";
            this.nudHorizontal.Size = new System.Drawing.Size(47, 20);
            this.nudHorizontal.TabIndex = 5;
            this.tltMain.SetToolTip(this.nudHorizontal, "Distance from one end to the other in X direction");
            this.nudHorizontal.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHorizontal.ValueChanged += new System.EventHandler(this.nudHorizontal_ValueChanged);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.lblStatus);
            this.grpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStatus.Location = new System.Drawing.Point(3, 239);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(175, 136);
            this.grpStatus.TabIndex = 2;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(169, 117);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "-";
            this.tltMain.SetToolTip(this.lblStatus, "Stats of the positioning");
            // 
            // btnRecentre
            // 
            this.btnRecentre.BackColor = System.Drawing.Color.MistyRose;
            this.btnRecentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecentre.Location = new System.Drawing.Point(10, 422);
            this.btnRecentre.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.btnRecentre.Name = "btnRecentre";
            this.btnRecentre.Size = new System.Drawing.Size(161, 42);
            this.btnRecentre.TabIndex = 3;
            this.btnRecentre.Text = "Recentre";
            this.btnRecentre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tltMain.SetToolTip(this.btnRecentre, "Recentre the transmitter");
            this.btnRecentre.UseVisualStyleBackColor = false;
            this.btnRecentre.Click += new System.EventHandler(this.btnRecentre_Click);
            // 
            // grpTop
            // 
            this.grpTop.Controls.Add(this.tlpView);
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTop.Location = new System.Drawing.Point(190, 3);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(607, 474);
            this.grpTop.TabIndex = 1;
            this.grpTop.TabStop = false;
            this.grpTop.Text = "Overhead View";
            // 
            // tlpView
            // 
            this.tlpView.ColumnCount = 2;
            this.tlpView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpView.Controls.Add(this.pcbTop, 1, 1);
            this.tlpView.Controls.Add(this.trkHorizontal, 1, 0);
            this.tlpView.Controls.Add(this.trkVertical, 0, 1);
            this.tlpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpView.Location = new System.Drawing.Point(3, 16);
            this.tlpView.Name = "tlpView";
            this.tlpView.RowCount = 2;
            this.tlpView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpView.Size = new System.Drawing.Size(601, 455);
            this.tlpView.TabIndex = 0;
            // 
            // pcbTop
            // 
            this.pcbTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbTop.Location = new System.Drawing.Point(30, 27);
            this.pcbTop.Name = "pcbTop";
            this.pcbTop.Size = new System.Drawing.Size(568, 425);
            this.pcbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTop.TabIndex = 0;
            this.pcbTop.TabStop = false;
            this.pcbTop.SizeChanged += new System.EventHandler(this.pcbTop_SizeChanged);
            this.pcbTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbTop_MouseUp);
            // 
            // trkHorizontal
            // 
            this.trkHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkHorizontal.Location = new System.Drawing.Point(30, 3);
            this.trkHorizontal.Name = "trkHorizontal";
            this.trkHorizontal.Size = new System.Drawing.Size(568, 18);
            this.trkHorizontal.TabIndex = 1;
            this.trkHorizontal.Scroll += new System.EventHandler(this.trkTrackBar_Scroll);
            // 
            // trkVertical
            // 
            this.trkVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trkVertical.Location = new System.Drawing.Point(3, 27);
            this.trkVertical.Name = "trkVertical";
            this.trkVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVertical.Size = new System.Drawing.Size(21, 425);
            this.trkVertical.TabIndex = 2;
            this.trkVertical.Scroll += new System.EventHandler(this.trkTrackBar_Scroll);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipTitle = "BitStreamer";
            // 
            // frmPositioning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(816, 519);
            this.Name = "frmPositioning";
            this.Text = "Positioning";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPositioning_FormClosing);
            this.Load += new System.EventHandler(this.frmPositioning_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.grpPort.ResumeLayout(false);
            this.tlpPort.ResumeLayout(false);
            this.grpSettings.ResumeLayout(false);
            this.tlpSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpTop.ResumeLayout(false);
            this.tlpView.ResumeLayout(false);
            this.tlpView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVertical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.GroupBox grpPort;
        private System.Windows.Forms.TableLayoutPanel tlpPort;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.TableLayoutPanel tlpSettings;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblVertical;
        private System.Windows.Forms.Label lblHorizontal;
        private System.Windows.Forms.NumericUpDown nudHorizontal;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudVertical;
        private System.Windows.Forms.GroupBox grpTop;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRecentre;
        private System.Windows.Forms.ToolTip tltMain;
        private System.Windows.Forms.TableLayoutPanel tlpView;
        private System.Windows.Forms.PictureBox pcbTop;
        private System.Windows.Forms.TrackBar trkHorizontal;
        private System.Windows.Forms.TrackBar trkVertical;
    }
}