using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Keyence.AutoID;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Barcode_Keyence
{
    public partial class Form1 : Form
    {
        //Integer variable to store command port
        private int commandport;
        //Integer variable to store data port
        private int dataport;
        //StreamWriter variables to write data into file and logs into log file
        private StreamWriter streamWriter,streamLogWriter;
        //Data object to hold the barcode data
        private BarcodeData barcodeData;
        //Holds the path where the data file should be
        private string filePath;
        /// <summary>
        /// A default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method to create a StreamWriter object to write barcode data
        /// </summary>
        /// <param name="filePath">Location of the file</param>
        /// <returns></returns>
        private StreamWriter getWriter(string filePath)
        {
            if (streamWriter == null)
            {
                streamWriter = new StreamWriter(filePath,true);
            }
            return streamWriter;
        }
        /// <summary>
        /// Method to create a StreamWriter object to write log data
        /// </summary>
        /// <param name="filePath">Location of the file</param>
        /// <returns></returns>
        private StreamWriter getLogWriter(string filePath)
        {
            if (streamLogWriter == null)
            {
                streamLogWriter = new StreamWriter(filePath, true);
            }
            return streamLogWriter;
        }
        /// <summary>
        /// Method to write logs into log file
        /// </summary>
        /// <param name="status">Log Details</param>
        private void WriteLog(string status)
        {
            getLogWriter("log.log").WriteLine(status);
            getLogWriter("log.log").Flush();
        }
        /// <summary>
        /// Method to write data into data file
        /// </summary>
        /// <param name="data">Barcode data details</param>
        private void WriteData(string data)
        {
            getWriter(filePath).WriteLine(data);
            getWriter(filePath).Flush();
        }
        private void OnFocusCommunicationPort(object Sender,EventArgs e)
        {
            textBox_communicationport.Text = "";
        }
        private void OnLostFocusCommunicationPort(object Sender, EventArgs e)
        {
            if (textBox_communicationport.Text.Equals(""))
            {
                textBox_communicationport.Text = "9003";
            }
        }
        private void OnFocusDataPort(object Sender, EventArgs e)
        {
            textBox_dataport.Text = "";
        }
        private void OnLostFocusDataPort(object Sender, EventArgs e)
        {
            if (textBox_dataport.Text.Equals(""))
            {
                textBox_dataport.Text = "9004";
            }
        }
        private void OnFocusIPAddress1(object Sender, EventArgs e)
        {
            textBox_ipaddress1.Text = "";
        }
        private void OnLostFocusIPAddress1(object Sender, EventArgs e)
        {
            if (textBox_ipaddress1.Text.Equals(""))
            {
                textBox_ipaddress1.Text = "192";
            }
            else if (Convert.ToInt32(textBox_ipaddress1.Text) > 255)
            {
                textBox_ipaddress1.Text = "192";
            }
        }
        private void OnFocusIPAddress2(object Sender, EventArgs e)
        {
            textBox_ipaddress2.Text = "";
        }
        private void OnLostFocusIPAddress2(object Sender, EventArgs e)
        {
            if (textBox_ipaddress2.Text.Equals(""))
            {
                textBox_ipaddress2.Text = "168";
            }
            else if (Convert.ToInt32(textBox_ipaddress2.Text) > 255)
            {
                textBox_ipaddress2.Text = "168";
            }
        }
        private void OnFocusIPAddress3(object Sender, EventArgs e)
        {
            textBox_ipaddress3.Text = "";
        }
        private void OnLostFocusIPAddress3(object Sender, EventArgs e)
        {
            if (textBox_ipaddress3.Text.Equals(""))
            {
                textBox_ipaddress3.Text = "1";
            }
            else if (Convert.ToInt32(textBox_ipaddress3.Text) > 255)
            {
                textBox_ipaddress3.Text = "1";
            }
        }
        private void OnFocusIPAddress4(object Sender, EventArgs e)
        {
            textBox_ipaddress4.Text = "";
        }
        private void OnLostFocusIPAddress4(object Sender, EventArgs e)
        {
            if (textBox_ipaddress4.Text.Equals(""))
            {
                textBox_ipaddress4.Text = "1";
            }
            else if(Convert.ToInt32(textBox_ipaddress4.Text)>255)
            {
                textBox_ipaddress4.Text = "1";
            }
        }
        /// <summary>
        /// This is the method to initialize controls when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_ipaddress1.Text = "192";
            textBox_ipaddress2.Text = "168";
            textBox_ipaddress3.Text = "1";
            textBox_ipaddress4.Text = "1";
            textBox_communicationport.Text = "9003";
            textBox_dataport.Text = "9004";
            textBox_communicationport.GotFocus += OnFocusCommunicationPort;
            textBox_communicationport.LostFocus += OnLostFocusCommunicationPort;
            textBox_dataport.GotFocus += OnFocusDataPort;
            textBox_dataport.LostFocus += OnLostFocusDataPort;
            textBox_ipaddress1.GotFocus += OnFocusIPAddress1;
            textBox_ipaddress1.LostFocus += OnLostFocusIPAddress1;
            textBox_ipaddress2.GotFocus += OnFocusIPAddress2;
            textBox_ipaddress2.LostFocus += OnLostFocusIPAddress2;
            textBox_ipaddress3.GotFocus += OnFocusIPAddress3;
            textBox_ipaddress3.LostFocus += OnLostFocusIPAddress3;
            textBox_ipaddress4.GotFocus += OnFocusIPAddress4;
            textBox_ipaddress4.LostFocus += OnLostFocusIPAddress4;
        }
        public TextBox getTextBoxStatus()
        {
            return textBox_status;
        }
        /// <summary>
        /// This is the method to handle close button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_connect_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                filePath = saveFileDialog1.FileName;
                WriteLog("Data will be written to "+filePath+"     \n");
                textBox_status.Text = "Data will be written to "+filePath+"     \n";
                try
                {
                    Byte[] ipaddress = new byte[4];
                    ipaddress[0] = Convert.ToByte(textBox_ipaddress1.Text.Trim());
                    ipaddress[1] = Convert.ToByte(textBox_ipaddress2.Text.Trim());
                    ipaddress[2] = Convert.ToByte(textBox_ipaddress3.Text.Trim());
                    ipaddress[3] = Convert.ToByte(textBox_ipaddress4.Text.Trim());
                    commandport = Convert.ToInt32(textBox_communicationport.Text.Trim());
                    dataport = Convert.ToInt32(textBox_dataport.Text.Trim());
                    IPAddress ip = new IPAddress(ipaddress);
                    this.barcodeReaderControl1.IpAddress = ip.ToString();
                    WriteLog("IP Address is " + ip.ToString() + "\n");
                    textBox_status.Text = "IP Address is " + ip.ToString() + "\n";
                    this.barcodeReaderControl1.Ether.CommandPort = commandport;
                    WriteLog("Command Port is " + commandport.ToString() + "\n");
                    textBox_status.Text = "Command Port is " + commandport.ToString() + "\n";
                    this.barcodeReaderControl1.Ether.DataPort = dataport;
                    WriteLog("Data Port is " + dataport.ToString() + "\n");
                    textBox_status.Text = "Data Port is " + dataport.ToString() + "\n";
                    this.barcodeReaderControl1.Comm.Interface = Interface.Ethernet;
                    WriteLog("Interface is " + Interface.Ethernet.ToString() + "\n");
                    textBox_status.Text = "Interface is " + Interface.Ethernet.ToString() + "\n";
                    this.barcodeReaderControl1.ReaderType = ReaderType.SR_1000;
                    WriteLog("Reader Type is " + ReaderType.SR_1000.ToString() + "\n");
                    textBox_status.Text = "Reader Type is " + ReaderType.SR_1000.ToString() + "\n";
                    textBox_status.AppendText("Socket Connecting...\n");
                    this.barcodeReaderControl1.Connect();
                    textBox_status.AppendText("Socket Connected...\n");
                    this.barcodeReaderControl1.OnDataReceived += dataReceived;
                    textBox_status.AppendText("Live View Starting...\n");
                    this.barcodeReaderControl1.StartLiveView();
                    textBox_status.AppendText("Live View Started...\n");
                }
                catch (SocketException ex)
                {
                    WriteLog(ex.StackTrace + Environment.NewLine + "   at " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss:fff"));
                    textBox_status.AppendText("Socket Exception Occured. Please refer log file." + "\n");
                }
                catch (Exception ex)
                {
                    WriteLog(ex.StackTrace + Environment.NewLine + "   at " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss:fff"));
                    textBox_status.AppendText("Exception Occured. Please refer log file." + "\n");
                }
                finally
                {
                    getLogWriter("log.log").Close();
                }
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// This is the function to write barcode data into file and it is called whenever there is an OnDataReceived event occurs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataReceived(object sender,OnDataReceivedEventArgs e)
        {
            try
            {
                barcodeData = new BarcodeData();
                barcodeData.DataBytes = e.data;
                WriteData(barcodeData.ToString() + "   " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss:fff"));
                textBox_status.AppendText(barcodeData.ToString());
            }
            catch (Exception ex)
            {
                textBox_status.AppendText(ex.ToString() + "\n");
            }
            finally
            {
                getWriter(filePath).Close();
            }
        }
        /// <summary>
        /// This is the method to handle close button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                this.barcodeReaderControl1.OnDataReceived -= dataReceived;
                this.barcodeReaderControl1.StopLiveView();
                this.barcodeReaderControl1.Disconnect();
                textBox_status.AppendText("Socked Closed...\n");
            }
            catch (Exception ex)
            {
                textBox_status.AppendText(ex.ToString() + "\n");
            }
        }

        
        
    }
}
