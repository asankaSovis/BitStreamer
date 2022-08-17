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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();

            btnOk.Image = Image.FromFile("resources/complete.png");
            pcbIcon.Image = Image.FromFile("resources/icon.png");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
