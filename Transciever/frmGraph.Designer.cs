
namespace Transciever
{
    partial class frmGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtMain)).BeginInit();
            this.SuspendLayout();
            // 
            // chtMain
            // 
            chartArea1.Name = "ChartArea1";
            this.chtMain.ChartAreas.Add(chartArea1);
            this.chtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtMain.Legends.Add(legend1);
            this.chtMain.Location = new System.Drawing.Point(0, 0);
            this.chtMain.Name = "chtMain";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtMain.Series.Add(series1);
            this.chtMain.Size = new System.Drawing.Size(800, 450);
            this.chtMain.TabIndex = 0;
            this.chtMain.Text = "chart1";
            // 
            // frmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chtMain);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmGraph";
            this.Text = "frmGraph";
            this.Load += new System.EventHandler(this.frmGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtMain;
    }
}