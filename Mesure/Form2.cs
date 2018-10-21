using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Mesure
{
    
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            baudRate.Text = baudRate.Items[4].ToString();
            
        }

       

        private void baudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void submit_settings_Click(object sender, EventArgs e)
        {

            DataCOM.Baud = baudRate.SelectedItem.ToString();

            DataCOM.readTimeout = Convert.ToInt32(numericUpDown1.Value);
            DataCOM.writeTimeout = Convert.ToInt32(numericUpDown2.Value);

            if (DataBits_5.Checked)
                DataCOM.DataBits = 5;
            if(DataBits_6.Checked)
                DataCOM.DataBits = 6;
            if(DataBits_7.Checked)
                DataCOM.DataBits = 7;
            if(DataBits_8.Checked)
                DataCOM.DataBits = 8;

            if (StopBits_1.Checked)
                DataCOM.StopBits = "One";
            if (StopBits_1_5.Checked)
                DataCOM.StopBits = "OnePointFive";
            if (StopBits_2.Checked)
                DataCOM.StopBits = "Two";

            
            if (Parity_none.Checked)
                DataCOM.Parity = System.IO.Ports.Parity.None;
            if (Parity_odd.Checked)
                DataCOM.Parity = System.IO.Ports.Parity.Odd;
            if(Parity_even.Checked)
                DataCOM.Parity = System.IO.Ports.Parity.Even;
            if (Parity_mark.Checked)
                DataCOM.Parity = System.IO.Ports.Parity.Mark;
            if (Parity_space.Checked)
                DataCOM.Parity = System.IO.Ports.Parity.Space;


            DialogResult = System.Windows.Forms.DialogResult.OK;
            MessageBox.Show("Настройки успешно сохранены");
            Close();
        }
    }
}
