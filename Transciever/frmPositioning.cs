using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Transciever
{
    public partial class frmPositioning : Form
    {
        Image[] connect = { Image.FromFile("resources/connect.png"), Image.FromFile("resources/disconnect.png") };

        public SerialPort myPorts = null;

        int[] usrPosition = { 0, 0 };

        int lastTopAngle = 0;
        int lastSideAngle = 0;

        frmMain parent = null;

        public frmPositioning(frmMain _parent)
        {
            InitializeComponent();

            parent = _parent;
            this.Icon = parent.Icon;
        }

        private void reloadPorts()
        {
            cmbPort.Items.Clear();

            cmbPort.Items.AddRange(SerialPort.GetPortNames());
            if (cmbPort.Items.Count > 0)
                cmbPort.SelectedIndex = 0;

            cmbBaud.SelectedItem= "9600";

            btnConnect.Text = "Connect";
            this.Text = "BitStreamer - Transmitter Positioning";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if ((myPorts == null) || !myPorts.IsOpen)
            {
                connectToPort(cmbPort.Text, int.Parse(cmbBaud.Text));
            }
            else
            {
                myPorts.Close();
                btnConnect.Text = "Connect";
            }
        }

        private void connectToPort(string port, int bitrate)
        {
            btnConnect.Text = "Connect";
            myPorts = null;

            myPorts = new SerialPort(port, bitrate, Parity.None, 8, StopBits.One);
            myPorts.Handshake = Handshake.None;
            myPorts.DataReceived += new SerialDataReceivedEventHandler(portDataRecieved);
            myPorts.WriteTimeout = 500;

            if (!myPorts.IsOpen)
            {
                try
                {
                    myPorts.Open();
                    btnConnect.Text = "Disconnect";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not connect to " + port + ". Check if it is open...", "BitStreamer - Bitstream Emulator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cmbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = ((cmbPort.SelectedIndex >= 0) && (cmbBaud.SelectedIndex >= 0));
        }

        private void portDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            string readString = myPorts.ReadLine();

            if (readString.Contains("done:S1"))
            {
                sendData("S2", lastSideAngle);
            }
            else if (readString.Contains("done:S2"))
            {
                this.Enabled = true;
            } else
            {
                Console.WriteLine(readString);
            }
        }

        private void btnConnect_TextChanged(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Connect")
            {
                ((Button)sender).Image = connect[0];
            }
            else
            {
                ((Button)sender).Image = connect[1];
            }
        }

        private void frmPositioning_Load(object sender, EventArgs e)
        {
            btnRecentre.Image = Image.FromFile("resources/centre.png");
            lblHorizontal.Image = Image.FromFile("resources/horizontal.png");
            lblVertical.Image = Image.FromFile("resources/vertical.png");
            lblHeight.Image = Image.FromFile("resources/height.png");

            usrPosition = new int[] { pcbTop.Size.Width / 2, pcbTop.Size.Height / 2 };

            reloadPorts();

            movePosition(usrPosition[0], usrPosition[1]);
        }

        private void drawTopView(decimal[] realPos, double angle)
        {
            Image bmp = new Bitmap(pcbTop.Size.Width, pcbTop.Size.Height);

            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.Clear(Color.White);
                gr.FillRectangle(Brushes.LightBlue, 0, 0, ((bmp.Width) / 2), ((bmp.Height) / 2));
                gr.FillRectangle(Brushes.LightPink, ((bmp.Width) / 2), 0, ((bmp.Width) / 2 ), ((bmp.Height) / 2));
                gr.FillRectangle(Brushes.LightGreen, 0, (bmp.Height) / 2, (bmp.Width) / 2, (bmp.Height) / 2);
                gr.FillRectangle(Brushes.LightYellow, (bmp.Width) / 2, (bmp.Height) / 2, (bmp.Width) / 2, (bmp.Height) / 2);
                gr.FillEllipse(Brushes.Gray, ((bmp.Width) / 2) - 10, ((bmp.Height) / 2) - 10, 20, 20);
                gr.FillEllipse(Brushes.Red, usrPosition[0] - 5, usrPosition[1] - 5, 10, 10);
                gr.DrawRectangle(Pens.Black, 0, 0, (bmp.Width) - 1, (bmp.Height) - 1);

                

                int[] add = { 10, 10 };

                if (usrPosition[0] > pcbTop.Size.Width - 90)
                {
                    add = new int[] { -90, add[1] };
                }

                if (usrPosition[1] < 20)
                {
                    add = new int[] { add[0], -10 };
                }

                gr.DrawString("(" + realPos[0] + "m, " + realPos[1] + "m" + ")", SystemFonts.DefaultFont, Brushes.Black, usrPosition[0] + add[0], usrPosition[1] - add[1]);

                pcbTop.Image = bmp;
            }
        }

        private void pcbTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (myPorts != null)
            {
                if (myPorts.IsOpen)
                {
                    movePosition(e.X, e.Y, true);
                }
            }
        }

        void movePosition(int X, int Y, bool sendCommand = false)
        {
            trkHorizontal.Maximum = pcbTop.Size.Width;
            trkHorizontal.Value = X;
            trkVertical.Maximum = pcbTop.Size.Height;
            trkVertical.Value = trkVertical.Maximum - Y;

            usrPosition = new int[] { X, Y };
            decimal[] realPos = getRealPosition();
            double topAngle = ConvertRadiansToDegrees(Math.Atan2((double)realPos[0], (double)realPos[1]));
            double sideAngle = ConvertRadiansToDegrees(Math.Atan2(Math.Sqrt((double)((realPos[0] * realPos[0]) + (realPos[1] * realPos[1]))), (double)nudHeight.Value));

            if (topAngle < 0)
            {
                topAngle = 360 + topAngle;
            }

            if (sideAngle < 0)
            {
                sideAngle = 360 + sideAngle;
            }

            lastTopAngle = (int)topAngle;
            lastSideAngle = (int)sideAngle;
            Console.WriteLine(lastSideAngle);

            drawTopView(realPos, topAngle);

            string text = "X Coordinate: " + realPos[0] + "m\n";
            text += "Y Coordinate: " + realPos[1] + "m\n";
            text += "Yaw: " + Math.Round(topAngle, 2) + "°\n";
            text += "Pitch: " + Math.Round(sideAngle, 2) + "°\n";

            lblStatus.Text = text;

            if (sendCommand)
            {
                //this.Enabled = false;
                sendData("S1", (int)topAngle);
            }
                
        }

        private decimal[] getRealPosition()
        {
            return new decimal[] { map(usrPosition[0], -1, pcbTop.Size.Width, -1 * (nudHorizontal.Value / 2), (nudHorizontal.Value / 2)),
                map(usrPosition[1], -1, pcbTop.Size.Height, (nudVertical.Value / 2), -1 * (nudVertical.Value / 2)) };
        }

        public static decimal map(int value, decimal fromSource, decimal toSource, decimal fromTarget, decimal toTarget)
        {
            return Math.Round((value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget, 2);
        }

        public static double ConvertRadiansToDegrees(double radians)
        {
            double degrees = (180 / Math.PI) * radians;
            return (degrees);
        }

        private void sendData(string command, int angle)
        {
            if ((myPorts != null) && (myPorts != null))
            {
                myPorts.WriteLine(command + ":" + angle);
            }
            else
            {
                MessageBox.Show("Could not connect to a port. Check if it is open...", "BitStreamer - Bitstream Emulator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRecentre_Click(object sender, EventArgs e)
        {
            usrPosition = new int[] { pcbTop.Size.Width / 2, pcbTop.Size.Height / 2 };

            if (myPorts != null)
            {
                if (myPorts.IsOpen)
                    movePosition(usrPosition[0], usrPosition[1], true);
                else
                    movePosition(usrPosition[0], usrPosition[1]);
            }
            else
                movePosition(usrPosition[0], usrPosition[1]);
        }

        private void frmPositioning_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.closePositioner();
        }

        private void trkTrackBar_Scroll(object sender, EventArgs e)
        {
            movePosition(trkHorizontal.Value, trkVertical.Maximum - trkVertical.Value, true);
        }

        private void nudHorizontal_ValueChanged(object sender, EventArgs e)
        {
            trkHorizontal.Maximum = (int)nudHorizontal.Value;
            trkVertical.Maximum = (int)nudVertical.Value;
        }

        private void pcbTop_SizeChanged(object sender, EventArgs e)
        {
            decimal[] realPos = getRealPosition();
            double topAngle = ConvertRadiansToDegrees(Math.Atan2((double)realPos[0], (double)realPos[1]));
            double sideAngle = ConvertRadiansToDegrees(Math.Atan2(Math.Sqrt((double)((realPos[0] * realPos[0]) + (realPos[1] * realPos[1]))), (double)nudHeight.Value));

            if (topAngle < 0)
            {
                topAngle = 360 + topAngle;
            }

            drawTopView(realPos, topAngle);
        }
    }
}
