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
    public partial class frmMain : Form
    {
        Image loadingIcon = Image.FromFile("resources/loading.png");
        Image[] connect = { Image.FromFile("resources/connect.png"), Image.FromFile("resources/disconnect.png") };
        Image[] error = { Image.FromFile("resources/complete.png"), Image.FromFile("resources/error.png") };

        public SerialPort[] myPorts = { null, null };
        Button[] portButtons = null;
        CheckBox[] sendBits = null;
        Label[] recieveBits = null;

        bool dataSent = false;
        bool dataRecieved = false;
        DateTime sentTime = DateTime.Now;

        int currentTestID = -1;
        int currentErrorcount = 0;

        string report = "";

        DateTime textChangeTime = DateTime.Now;

        Byte[] recievedBytes = null;

        frmMain partner = null;

        bool slaveMode = false;

        public frmMain(bool _slaveMode = false, frmMain _parent = null)
        {
            InitializeComponent();

            portButtons = new Button[] { btnTransConnect, btnRecConnect };
            sendBits = new CheckBox[] { chkOne, chkTwo, chkThree, chkFour, chkFive, chkSix, chkSeven, chkEight };
            recieveBits = new Label[] { lblRec1, lblRec2, lblRec3, lblRec4, lblRec5, lblRec6, lblRec7, lblRec8 };

            slaveMode = _slaveMode;
            partner = _parent;
        }

        private void chkBits_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                ((CheckBox)sender).Text = "1";
                ((CheckBox)sender).ForeColor = Color.DarkGreen;
            }
            else
            {
                ((CheckBox)sender).Text = "0";
                ((CheckBox)sender).ForeColor = Color.DarkRed;
            }
        }

        private void lblBits_TextChanged(object sender, EventArgs e)
        {
            if (((Label)sender).Text == "1")
            {
                ((Label)sender).ForeColor = Color.DarkGreen;
            }
            else if (((Label)sender).Text == "0")
            {
                ((Label)sender).ForeColor = Color.DarkRed;
            }
            else
            {
                ((Label)sender).ForeColor = Color.DarkBlue;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsmSend.Image = btnSend.Image = Image.FromFile("resources/send.png");
            btnAbout.Image = Image.FromFile("resources/about.png");
            tsmTest.Image = btnDock.Image = Image.FromFile("resources/test.png");
            tsmGenerate.Image = Image.FromFile("resources/shuffle.png");
            tsmReload.Image = Image.FromFile("resources/reload.png");
            tsmExit.Image = Image.FromFile("resources/exit.png");
            tssFile.Image = Image.FromFile("resources/save.png");
            tssBitstream.Image = Image.FromFile("resources/bit.png");
            tssOptions.Image = Image.FromFile("resources/options.png");
            tssMode.Image = Image.FromFile("resources/mode.png");
            tsmBi.Image = Image.FromFile("resources/bi.png");
            tsmUni.Image = Image.FromFile("resources/uni.png");
            tssEachGenerate.Image = Image.FromFile("resources/generate.png");

            btnTransConnect.Image = btnRecConnect.Image = connect[0];
            tsmDisconnect.Image = connect[0];

            

            enableBits(false);

            randomBits();

            if (slaveMode)
            {
                bidirectionalMode();

                tsmBi.Checked = true;

                tssOptions.Enabled = false;
            }
            else
            {
                unidirectionalMode();

                tsmUni.Checked = true;
            }
                
        }

        private void reloadPorts()
        {
            cmbRecPort.Items.Clear(); cmbTransPort.Items.Clear();

            cmbTransPort.Items.AddRange(SerialPort.GetPortNames());
            if (cmbTransPort.Items.Count > 0)
                cmbTransPort.SelectedIndex = 0;
            cmbRecPort.Items.AddRange(SerialPort.GetPortNames());
            if (cmbRecPort.Items.Count > 1)
                if (slaveMode)
                    cmbTransPort.SelectedIndex = 1;
                else
                    cmbRecPort.SelectedIndex = 1;

            cmbTransBitrate.SelectedItem = cmbRecBitrate.SelectedItem = "9600";
        }

        private void randomBits()
        {
            Random rnd = new Random();

            foreach (CheckBox bit in sendBits)
            {
                bit.Checked = (rnd.Next(0, 10) < 5);
            }
        }

        private void cmbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTransConnect.Enabled = ((cmbTransPort.SelectedIndex >= 0) && (cmbTransBitrate.SelectedIndex >= 0)) ;
            btnRecConnect.Enabled = (((cmbRecPort.SelectedIndex >= 0) && (cmbRecBitrate.SelectedIndex >= 0)) && tsmUni.Checked) ;

            if (tsmBi.Checked)
            {
                cmbRecPort.SelectedItem = cmbTransPort.SelectedItem;
                cmbRecBitrate.SelectedItem = cmbTransBitrate.SelectedItem;
            }
                
        }

        private void connectToPort(string port, int bitrate, int portID)
        {
            portButtons[portID].Text = "Connect";
            myPorts[portID] = null;

            myPorts[portID] = new SerialPort(port, bitrate, Parity.None, 8, StopBits.One);
            myPorts[portID].Handshake = Handshake.None;
            myPorts[portID].DataReceived += new SerialDataReceivedEventHandler(portDataRecieved);
            myPorts[portID].WriteTimeout = 500;

            if (!myPorts[portID].IsOpen)
            {
                try
                {
                    myPorts[portID].Open();
                    portButtons[portID].Text = "Disconnect";
                    enableBits(true);
                    tssStatus.Text = "Connection to " + port + " established successfully...";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not connect to " + port + ". Check if it is open...", "BitStreamer - Bitstream Emulator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tssStatus.Text = "Could not connect to " + port + ". Check if it is open...";
                }
            }
        }

        private void portDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            if ((SerialPort) sender == myPorts[1])
            {
                recievedBytes = new byte[] { (byte)myPorts[1].ReadByte() };
            }

            if ((SerialPort)sender == myPorts[0])
            {
                recievedBytes = new byte[] { (byte)myPorts[0].ReadByte() };
            }
        }

        private void btnTransConnect_Click(object sender, EventArgs e)
        {
            if ((myPorts[0] == null) || !myPorts[0].IsOpen)
            {
                connectToPort(cmbTransPort.Text, int.Parse(cmbTransBitrate.Text), 0);
            }
            else
            {
                myPorts[0].Close();
                btnTransConnect.Text = "Connect";
                enableBits(false);
            }

           if (tsmBi.Checked)
                btnRecConnect.Text = btnTransConnect.Text;
            
        }

        private void btnRecConnect_Click(object sender, EventArgs e)
        {
            if ((myPorts[1] == null) || !myPorts[1].IsOpen)
            {
                connectToPort(cmbRecPort.Text, int.Parse(cmbRecBitrate.Text), 1);
            }
            else
            {
                myPorts[1].Close();
                btnRecConnect.Text = "Connect";
            }
        }

        private void enableBits(bool value)
        {
            foreach (CheckBox bit in sendBits)
            {
                bit.Enabled = value;
            }

            btnSend.Enabled = value;
        }

        private void sendData(byte[] bits)
        {
            if ((myPorts[0] != null) && (myPorts[1] != null) && (tsmUni.Checked))
            {
                if ((myPorts[0].IsOpen && myPorts[1].IsOpen && tsmUni.Checked))
                {
                    myPorts[0].Write(bits, 0, 1);
                    dataSent = true;
                    dataRecieved = false;
                    sentTime = DateTime.Now;
                    spcButton.Panel1Collapsed = true;
                    enableInterface(false);
                }
                else
                {
                    MessageBox.Show("Could not connect to a port. Check if it is open...", "BitStreamer - Bitstream Emulator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if ((myPorts[0] != null) && (partner.myPorts[0] != null) && (tsmBi.Checked))
            {
                if ((myPorts[0].IsOpen && partner.myPorts[0].IsOpen && tsmBi.Checked))
                {
                    myPorts[0].Write(bits, 0, 1);
                    dataSent = true;
                    dataRecieved = false;
                    sentTime = DateTime.Now;
                    spcButton.Panel1Collapsed = true;
                    enableInterface(false);
                }
                else
                {
                    MessageBox.Show("Could not connect to a port. Check if it is open...", "BitStreamer - Bitstream Emulator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Could not connect to a port. Check if it is open...", "BitStreamer - Bitstream Emulator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool[] bitValues = new bool[8];

            for(int i = sendBits.Length - 1; i >= 0; i--)
            {
                bitValues[sendBits.Length - i - 1] = sendBits[i].Checked;
            }

            byte[] sendBytes = ToByteArray(bitValues);

            if (tsmBi.Checked)
            {
                if (partner.btnSend.Enabled)
                {
                    sendData(sendBytes);
                    partner.btnSend.PerformClick();
                }
            }
            else
            {
                sendData(sendBytes);
            }
            
            resetRecBits();
        }

        static byte[] ToByteArray(bool[] input)
        {
            if (input.Length % 8 != 0)
            {
                throw new ArgumentException("input");
            }
            byte[] ret = new byte[input.Length / 8];
            for (int i = 0; i < input.Length; i += 8)
            {
                int value = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (input[i + j])
                    {
                        value += 1 << (7 - j);
                    }
                }
                ret[i / 8] = (byte)value;
            }
            return ret;
        }

        public void bitsRecieved(byte recievedBytes)
        {
            int errorCount = 0;

            for (int i = 0; i < 8; i++)
            {
                bool bitValue = (recievedBytes & (1 << i)) != 0;

                errorCount += setRecBit(i, bitValue);
            }

            report += DateTime.Now + " Recieved bit Pattern: " + getBitPattern(recievedBytes) + "\n";

            if (errorCount > 0)
            {
                if(currentTestID == -1)
                    tssStatus.Text = "Data recieved. " + errorCount.ToString() + "  errors detected.";
                report += DateTime.Now + " " + errorCount.ToString() + " errors detected." + "\n\n";
                pcbRecieve.Image = error[1];
                currentErrorcount++;
            }
            else
            {
                if (currentTestID == -1)
                    tssStatus.Text = "Data recieved. No errors detected.";
                report += DateTime.Now + " No errors detected. " + "\n\n";
                pcbRecieve.Image = error[0];
            }

            
            

            dataRecieved = true;
            spcButton.Panel2Collapsed = true;
            enableInterface(true);
        }

        private void resetRecBits()
        {
            foreach(Label recBit in recieveBits)
            {
                recBit.Text = "?";
                recBit.BackColor = Color.Transparent;
            }
        }

        private int setRecBit(int position, bool value)
        {
            if (value)
            {
                recieveBits[position].Text = "1";
            }
            else
            {
                recieveBits[position].Text = "0";
            }

            if (tsmBi.Checked)
            {
                if (partner.sendBits[position].Checked == value)
                {
                    recieveBits[position].BackColor = Color.LightGreen;
                    return 0;
                }
                else
                {
                    recieveBits[position].BackColor = Color.LightPink;
                    return 1;
                }
            }
            else
            {
                if (sendBits[position].Checked == value)
                {
                    recieveBits[position].BackColor = Color.LightGreen;
                    return 0;
                }
                else
                {
                    recieveBits[position].BackColor = Color.LightPink;
                    return 1;
                }
            }
            
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if ((currentTestID > -1) && (currentTestID < nudTest.Value))
            {
                tssStatus.Text = "Running test " + currentTestID + " of " + nudTest.Value + "...";
                loadingIcon.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                pcbTest.Image = loadingIcon;
            }

            if (dataSent)
            {
                if ((DateTime.Now.Subtract(sentTime).TotalSeconds > 10) && !dataRecieved)
                {
                    dataSent = false;
                    resetRecBits();
                    tssStatus.Text = "Did not recieve data. Timed out...";
                    pcbRecieve.Image = error[1];
                    currentErrorcount++;

                    if ((currentTestID > 0) && (currentTestID < nudTest.Value))
                    {
                        report += DateTime.Now + " Did not recieve bit pattern. Reciever timed out!" + "\n\n";
                    }
                    spcButton.Panel2Collapsed = true;
                    enableInterface(true);
                }
            }
            
            if (recievedBytes != null)
            {
                bitsRecieved(recievedBytes[0]);

                recievedBytes = null;

                if ((currentTestID > 0) && (currentTestID < nudTest.Value))
                {
                    if (recievedBytes != null)
                        report += DateTime.Now + " Recieved bit Pattern: " + getBitPattern(recievedBytes[0]) + "\n\n";

                    if (tssEachGenerate.Checked)
                        randomBits();

                    report += DateTime.Now + " Initializing Test " + (currentTestID + 1).ToString() + " of " + nudTest.Value.ToString() + "\n";
                    report += DateTime.Now + " Sending bit Pattern: " + getBitPattern() + "\n";
                    btnSend.PerformClick();
                    currentTestID++;
                    prgTest.Value = currentTestID;
                }
                else
                {
                    btnDock.Enabled = true;
                    prgTest.Value = 0; prgTest.Visible = false;
                    pcbTest.Image = error[0];

                    if (currentTestID >= nudTest.Value-1)
                    {
                        report += DateTime.Now + " Test Completed: " + (nudTest.Value - currentErrorcount).ToString() + " of " + nudTest.Value.ToString() + " successful." + "\n\n";
                        tssStatus.Text = "Test Completed: " + (nudTest.Value - currentErrorcount).ToString() + " of " + nudTest.Value.ToString() + " successful.";
                        frmReport reportForm = new frmReport(report);
                        reportForm.ShowDialog();
                    }

                    currentTestID = -1;
                }
            }

            if (DateTime.Now.Subtract(textChangeTime).TotalSeconds > 5)
            {
                tssStatus.Text = "";
            }

            if (spcButton.Panel1Collapsed)
            {
                loadingIcon.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pcbRecieve.Image = pcbSend.Image = loadingIcon;
            }

            tssTime.Text = DateTime.Now.ToString("T");
        }

        private string getBitPattern()
        {
            string bitPattern = "";

            for (int i = sendBits.Length - 1; i >= 0; i--)
            {
                if (sendBits[i].Checked)
                {
                    bitPattern += "1";
                }
                else
                {
                    bitPattern += "0";
                }
            }

            return bitPattern;
        }

        private string getBitPattern(byte recievedBytes)
        {
            string bitPattern = "";

            for (int i = 7; i >= 0; i--)
            {
                bool bitValue = (recievedBytes & (1 << i)) != 0;

                if (bitValue)
                {
                    bitPattern += "1";
                }
                else
                {
                    bitPattern += "0";
                }
            }

            return bitPattern;
        }

        private void btnSend_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnSend.Enabled)
            {
                resetRecBits();
            }

            tsmSend.Enabled = btnSend.Enabled;
        }

        private void tssStatus_TextChanged(object sender, EventArgs e)
        {
            textChangeTime = DateTime.Now;
        }

        private void btnDock_Click(object sender, EventArgs e)
        {
            if (tsmUni.Checked && ((myPorts[0] != null) && (myPorts[1] != null)))
            {
                if (myPorts[0].IsOpen && myPorts[1].IsOpen)
                {
                    runUniTest();
                }
                else
                {
                    MessageBox.Show("No port is open for sending and/or recieving. Please connect to COM ports to each send and recieve.", "BitStreamer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (tsmBi.Checked && ((myPorts[0] != null) && (partner.myPorts[0] != null)))
            {
                if (myPorts[0].IsOpen && partner.myPorts[0].IsOpen)
                {
                    MessageBox.Show("Bidirectional test program not written yet!", "BitStreamer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No port is open for sending and/or recieving. Please connect to COM ports to each send and recieve.", "BitStreamer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No port is open for sending and/or recieving. Please connect to COM ports to each send and recieve.", "BitStreamer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void runUniTest()
        {
            currentTestID = 0; currentErrorcount = 0;
            btnDock.Enabled = false;
            prgTest.Visible = true; prgTest.Value = 1;
            prgTest.Maximum = (int)nudTest.Value;
            report = "Bitstreamer Test-----------------------------------------------------\n";
            report += "Sending: " + cmbTransPort.SelectedItem + " at " + cmbTransBitrate.SelectedItem + " baud | ";
            report += "Recieving: " + cmbRecPort.SelectedItem + " at " + cmbRecBitrate.SelectedItem + " baud" + "\n\n";
            report += DateTime.Now + " Transciever Test Started...\n\n";

            if (tssEachGenerate.Checked)
                randomBits();

            report += DateTime.Now + " Initializing Test " + (currentTestID + 1).ToString() + " of " + nudTest.Value.ToString() + "\n";
            report += DateTime.Now + " Sending bit Pattern: " + getBitPattern() + "\n";
            btnSend.PerformClick();
            currentTestID++;
        }

        private void tsmReload_Click(object sender, EventArgs e)
        {
            reloadPorts();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmDisconnect_Click(object sender, EventArgs e)
        {
            if ((myPorts[0] != null))
            {
                if (myPorts[0].IsOpen)
                {
                    myPorts[0].Close();
                }
            }

            if ((myPorts[1] != null))
            {
                if (myPorts[1].IsOpen)
                {
                    myPorts[1].Close();
                }
            }

            btnTransConnect.Text = "Connect";
            btnRecConnect.Text = "Connect";

            enableBits(false);
            tssStatus.Text = "All ports disconnected...";
        }

        private void tsmGenerate_Click(object sender, EventArgs e)
        {
            randomBits();
        }

        private void tsmSend_Click(object sender, EventArgs e)
        {
            btnSend.PerformClick();
        }

        private void tsmTest_Click(object sender, EventArgs e)
        {
            btnDock.PerformClick();
        }

        private void enableInterface(bool value)
        {
            tsmReload.Enabled = value;
            tsmDisconnect.Enabled = value;
            tsmGenerate.Enabled = value;
            tsmSend.Enabled = value;
            tsmTest.Enabled = value;

            cmbTransPort.Enabled = value;
            cmbTransBitrate.Enabled = value;
            
            btnTransConnect.Enabled = value;

            if (tsmUni.Checked)
            {
                btnRecConnect.Enabled = value;
                cmbRecPort.Enabled = value;
                cmbRecBitrate.Enabled = value;
            }
                

            nudTest.Enabled = value;

            foreach (CheckBox bit in sendBits)
            {
                bit.Enabled = value;
            }
        }

        private void bidirectionalMode()
        {
            reloadPorts();

            cmbRecPort.Enabled = false;
            cmbRecBitrate.Enabled = false;
            cmbRecPort.SelectedItem = cmbTransPort.SelectedItem;
            cmbRecBitrate.SelectedItem = cmbTransBitrate.SelectedItem;

            btnRecConnect.Enabled = false;

            if (slaveMode)
                this.Text = "BitStreamer - Bitstream Emulator (Transciever 02)";
            else
                this.Text = "BitStreamer - Bitstream Emulator (Transciever 01)";
        }

        private void unidirectionalMode()
        {
            reloadPorts();

            cmbRecPort.Enabled = true;
            cmbRecBitrate.Enabled = true;

            btnRecConnect.Enabled = true;

            this.Text = "BitStreamer - Bitstream Emulator";
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
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

        private void tsmUni_CheckedChanged(object sender, EventArgs e)
        {
            tsmBi.Checked = !tsmUni.Checked;
        }

        private void tsmBi_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmBi_CheckedChanged(object sender, EventArgs e)
        {
            switchMode();
        }

        public void switchMode()
        {
            tsmUni.Checked = !tsmBi.Checked;

            if (!slaveMode)
            {
                if (tsmBi.Checked)
                {
                    partner = new frmMain(true, this);
                    partner.Show();
                    bidirectionalMode();

                }
                else
                {
                    if (partner != null)
                        partner.Close();

                    unidirectionalMode();
                }

                tsmDisconnect.PerformClick();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (partner != null)
            {
                partner.tsmBi.Checked = false;
                tsmDisconnect.PerformClick();
            }
        }

        private void nudTest_ValueChanged(object sender, EventArgs e)
        {
            if (tsmBi.Checked)
                partner.nudTest.Value = nudTest.Value;
        }
    }
}
