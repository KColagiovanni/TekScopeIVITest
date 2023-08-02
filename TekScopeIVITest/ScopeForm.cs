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


        Tvc tvc1 = new Tvc();

        private void Form1_Load(object sender, EventArgs e)
        {
            Array TekList;

            try
            {
                tvc1.SearchCriterion = 0;
                TekList = tvc1.FindList as Array;
                foreach (object item in TekList)
                {
                    listBox1.Items.Add(item);
                }

                listBox1.SetSelected(0, true);
                tvc1.Descriptor = Convert.ToString(listBox1.SelectedItem);
                tekInfoLbl1.Text = "MFG: " + tvc1.InstrumentManufacturer.ToString();
                tekInfoLbl2.Text = "Model: " + tvc1.InstrumentModel.ToString();
                tekInfoLbl3.Text = "SID: " + tvc1.SoftwareManufacturerID;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + "No device found!");
            }

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            // Close window
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

           Array TekList;

            try
            {
                tvc1.SearchCriterion = 0;
                TekList = tvc1.FindList as Array;
                foreach (object item in TekList)
                {
                    listBox1.Items.Add(item);
                }

                listBox1.SetSelected(0, true);
                tvc1.Descriptor = Convert.ToString(listBox1.SelectedItem);
                tekInfoLbl1.Text = "MFG: " + tvc1.InstrumentManufacturer.ToString();
                tekInfoLbl2.Text = "Model: " + tvc1.InstrumentModel.ToString();
                tekInfoLbl3.Text = "SID: " + tvc1.SoftwareManufacturerID;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + "No device found!");
            }
        }

        private void ch1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ch1CheckBox.Checked)
            {
                tvc1.WriteString("Selected: CH1 ON");  
            }
            else
            {
                tvc1.WriteString("Selected: CH1 OFF");
            }
        }

        private void ch2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ch2CheckBox.Checked)
            {
                tvc1.WriteString("Selected: CH2 ON");
            }
            else
            {
                tvc1.WriteString("Selected: CH2 OFF");
            }

        }

        private void ch3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ch3CheckBox.Checked)
            {
                tvc1.WriteString("Selected: CH3 ON");
            }
            else
            {
                tvc1.WriteString("Selected: CH3 OFF");
            }

        }

        private void ch4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ch4CheckBox.Checked)
            {
                tvc1.WriteString("Selected: CH4 ON");
            }
            else
            {
                tvc1.WriteString("Selected: CH4 OFF");
            }

        }

        private void setupBtn_Click(object sender, EventArgs e)
        {
            tvc1.WriteString("Horizontal:main:scale 4e-6");
            tvc1.WriteString("CH1:scale 5");

            tvc1.WriteString("CH1:POSition -3");

            tvc1.WriteString("CH1:probe 10");

            tvc1.WriteString("TRIGger:MAIn:EDGE:SLOpe RISE");
            tvc1.WriteString("TRIGger:MAIn:TYPe EDGE");
            tvc1.WriteString("TRIGger:MAIn:EDGE:SOUrce CH1");
            tvc1.WriteString("TRIGger:MAIn:LEDel 2.5E0");
            tvc1.WriteString("TRIGger:MAIn:MODe auto");
            tvc1.WriteString("TRIGger:MAIn:EDGE:COUPling DC");

            tvc1.WriteString("measurement:meas1:source ch1");
            tvc1.WriteString("measurement:meas1:type freq");
            tvc1.WriteString("measurement:meas1:source ch1");
            tvc1.WriteString("measurement:meas1:type ampl");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
