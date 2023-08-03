using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVCLib;

namespace TekScopeIVITest
{
    public partial class TekOscopeData : Form
    {
        public TekOscopeData()
        {
            InitializeComponent();
        }

        // Create a TekVISA instance 
        Tvc tvc1 = new Tvc();

        private void Form1_Load(object sender, EventArgs e)
        {
            Array TekList;

            // Look for connected devices
            try
            {
                tvc1.SearchCriterion = 0;
                TekList = tvc1.FindList as Array;
                foreach (object item in TekList)
                {
                    listBox1.Items.Add(item);
                }

                listBox1.SetSelected(1, true);
                tvc1.Descriptor = Convert.ToString(listBox1.SelectedItem);
                tekInfoLbl1.Text = "MFG: " + tvc1.InstrumentManufacturer;
                tekInfoLbl2.Text = "Model: " + tvc1.InstrumentModel;
                tekInfoLbl3.Text = "SID: " + tvc1.SoftwareManufacturerID;

            }

            // Display error message if no devices are found
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\nNo device found!");
            }

            infoText.AppendText("Ready\r\n");

        }

        // Close window
        private void Close_btn_Click(object sender, EventArgs e) => this.Close();

        // Button to refresh the connected devices list
        private void refreshBtn_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            Array TekList;

            // Look for connected devices
            try
            {
                tvc1.SearchCriterion = 0;
                TekList = tvc1.FindList as Array;
                foreach (object item in TekList)
                {
                    listBox1.Items.Add(item);
                }

                listBox1.SetSelected(1, true);
                tvc1.Descriptor = Convert.ToString(listBox1.SelectedItem);
                tekInfoLbl1.Text = "MFG: " + tvc1.InstrumentManufacturer;
                tekInfoLbl2.Text = "Model: " + tvc1.InstrumentModel;
                tekInfoLbl3.Text = "SID: " + tvc1.SoftwareManufacturerID;

            }

            // Display error message if no devices are found
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + "No device found!");
            }
        }

        // Toggle Channel 1 on and off
        private void ch1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ch1CheckBox.Checked)
            {
                tvc1.WriteString("Select:CH1 ON");
            }
            else
            {
                tvc1.WriteString("Select:CH1 OFF");
            }
        }

        // Toggle Channel 2 on and off
        private void ch2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ch2CheckBox.Checked)
            {
                tvc1.WriteString("Select:CH2 ON");
            }
            else
            {
                tvc1.WriteString("Select:CH2 OFF");
            }

        }

        // Toggle Channel 3 on and off
        private void ch3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ch3CheckBox.Checked)
            {
                tvc1.WriteString("Select:CH3 ON");
            }
            else
            {
                tvc1.WriteString("Select:CH3 OFF");
            }

        }

        // Toggle Channel 4 on and off
        private void ch4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ch4CheckBox.Checked)
            {
                tvc1.WriteString("Select:CH4 ON");
            }
            else
            {
                tvc1.WriteString("Select:CH4 OFF");
            }

        }

        // Setup the scope for the desired measurement
        private void setupBtn_Click(object sender, EventArgs e)
        {

            infoText.AppendText("Setting up measurement, please wait...\r\n");

            // Set channel 1 horizontal and vertical scale
            tvc1.WriteString("Horizontal:main:scale 4e-4");
            tvc1.WriteString("CH1:scale 1");

            // Set channel 1 position
            tvc1.WriteString("CH1:POSition -3");

            // Set probe magnification
            tvc1.WriteString("CH1:probe 1");

            // Set scope trigger settings
            tvc1.WriteString("TRIGger:MAIn:EDGE:SLOpe RISE");
            tvc1.WriteString("TRIGger:MAIn:TYPe EDGE");
            tvc1.WriteString("TRIGger:MAIn:EDGE:SOUrce CH1");
            tvc1.WriteString("TRIGger:MAIn:LEVel 2.5E0");
            tvc1.WriteString("TRIGger:MAIn:MODe auto");
            tvc1.WriteString("TRIGger:MAIn:EDGE:COUPling DC");

            // Set scope measurement parameters
            tvc1.WriteString("measurement:meas1:source ch1");
            tvc1.WriteString("measurement:meas1:type freq");
            tvc1.WriteString("measurement:meas1:source ch1");
            tvc1.WriteString("measurement:meas1:type ampl");

            infoText.AppendText("Set up complete.\r\n");
        }


        // Button to start and stop taking measurements
        private void readBtn_Click(object sender, EventArgs e)
        {
            if(readBtn.Text == "Start Read")
            {
                readBtn.Text = "Stop Read";
                tmRead.Start();
            }
            else if(readBtn.Text == "Stop Read")
            {
                readBtn.Text = "Start Read";
                infoText.AppendText("\r\nMeasurement Stopped.\r\n\n");
                tmRead.Stop();
            }
        }

        double amp1 = 0, freq1 = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Start and stop timer, whic defines the interval that data is taken
        private void tmRead_Tick(object sender, EventArgs e)
        {
            amp1 = Convert.ToDouble(tvc1.Query("measurement:meas1:value?"));
            freq1 = Convert.ToDouble(tvc1.Query("measurement:meas2:value?"));

            infoText.AppendText("CH1 - Amplitude: " + amp1.ToString() + "V\r\n");
            infoText.AppendText("CH1 - Frequency: " + freq1.ToString() + "Hz\r\n");
        }
    }
}
