
namespace Transciever
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.sfdMain = new System.Windows.Forms.SaveFileDialog();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tssMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.tlpTools = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tltMain = new System.Windows.Forms.ToolTip(this.components);
            this.stsMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfdMain
            // 
            this.sfdMain.FileName = "Transciever Report.txt";
            this.sfdMain.Filter = "Text File | *.txt";
            this.sfdMain.Title = "Save Report to File";
            this.sfdMain.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdMain_FileOk);
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMain});
            this.stsMain.Location = new System.Drawing.Point(0, 463);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(518, 22);
            this.stsMain.TabIndex = 1;
            this.stsMain.Text = "Test Result";
            // 
            // tssMain
            // 
            this.tssMain.Name = "tssMain";
            this.tssMain.Size = new System.Drawing.Size(503, 17);
            this.tssMain.Spring = true;
            this.tssMain.Text = "Report Generated";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.rtbMain, 0, 1);
            this.tlpMain.Controls.Add(this.tlpTools, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(518, 463);
            this.tlpMain.TabIndex = 2;
            // 
            // rtbMain
            // 
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMain.Location = new System.Drawing.Point(3, 51);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(512, 409);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            // 
            // tlpTools
            // 
            this.tlpTools.ColumnCount = 2;
            this.tlpTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTools.Controls.Add(this.btnSave, 0, 0);
            this.tlpTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTools.Location = new System.Drawing.Point(3, 3);
            this.tlpTools.Name = "tlpTools";
            this.tlpTools.RowCount = 1;
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTools.Size = new System.Drawing.Size(512, 42);
            this.tlpTools.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 36);
            this.btnSave.TabIndex = 0;
            this.tltMain.SetToolTip(this.btnSave, "Save the report to a file");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tltMain
            // 
            this.tltMain.ToolTipTitle = "BitStreamer";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 485);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.stsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(534, 524);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BitStreamer - Test Results";
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog sfdMain;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.TableLayoutPanel tlpTools;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripStatusLabel tssMain;
        private System.Windows.Forms.ToolTip tltMain;
    }
}