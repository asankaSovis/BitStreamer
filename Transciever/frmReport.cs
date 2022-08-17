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
    public partial class frmReport : Form
    {
        public frmReport(string report)
        {
            InitializeComponent();

            rtbMain.Text = report;
            btnSave.Image = Image.FromFile("resources/save.png");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdMain.ShowDialog();
        }

        private void sfdMain_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(sfdMain.FileName, rtbMain.Text);
                MessageBox.Show("Report saved successfully.", "BitStreamer - Bitstream Emulator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not connect to save the report. Please try again later.", "BitStreamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
