using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transciever
{
    public partial class frmGraph : Form
    {
        double[] values = { 5, 4.5, 2, 3.3, 0, 8 };

        public frmGraph()
        {
            InitializeComponent();
        }

        private void frmGraph_Load(object sender, EventArgs e)
        {
            chtMain.Series.Clear();
            chtMain.Series.Add("Voltage").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;;
            chtMain.Series.Add("Logic").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;;
            chtMain.Series.Add("Threshold").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;;

            int i = 0;

            foreach (double item in values)
            {
                chtMain.Series[0].Points.AddXY(i, item);
                i++;
            }
        }
    }
}
