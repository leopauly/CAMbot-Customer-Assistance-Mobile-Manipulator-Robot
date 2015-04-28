using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Robocom_1
{
    public partial class RoBo : Form
    {
        public RoBo()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
          
        }


        public void callme(string AA)
        {
            if (txtport.Text == "")
            {
                MessageBox.Show("Enter port name");
                return;
            }
            if (!serialPort1.IsOpen)
            {
                 
                serialPort1.PortName = txtport.Text.Trim();
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                serialPort1.Write(AA);
                MessageBox.Show(AA);
                serialPort1.Close();
               
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            callme("A");
           
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            callme("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            callme("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            callme("D");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            callme("E");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            callme("F");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            callme("G");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            callme("H");
        }



    }
}
