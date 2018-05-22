using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace ArduinoUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            comboxComports.Items.Clear();
            String[] portName = SerialPort.GetPortNames();
            comboxComports.Items.AddRange(portName);
            comboxComports.SelectedIndex = 0;
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboxComports.SelectedItem.ToString() != "")
                {
                    btnEraseSAM_Click(null, null);
                    Thread.Sleep(2000);
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/c bossac.exe -i -d --port=" + comboxComports.SelectedItem.ToString() + " -U false -e -w -b arduinocode.cpp.bin -R ";
                    System.Diagnostics.Process.Start(startInfo);
                    Thread.Sleep(15000);
                    MessageBox.Show("Code Uploaded Successfully.");
                }
                else
                    MessageBox.Show("Could not find COM Port, select COM port and re-run.");
            }
            catch (Exception ex)
            {
            }
        }

        private void btnEraseSAM_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort(comboxComports.SelectedItem.ToString(), 1200);
            port.Open();
            Thread.Sleep(1000);
            port.Close();
        }
    }
}
