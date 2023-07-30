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
    public partial class Form1 : Form
    {
        public Form1()
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
                tek_lbl1.Text = "MFG: " + tvc1.InstrumentManufacturer.ToString();
                tek_lbl1.Text = "Model: " + tvc1.InstrumentModel.ToString();
                tek_lbl1.Text = "SID: " + tvc1.SoftwareManufacturerID.ToString();

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
    }
}
