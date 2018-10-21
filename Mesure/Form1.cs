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
using System.Threading;

namespace Mesure
{
   

    public partial class Form1 : Form
    {
        Form2 configureWindow = new Form2();

        public static bool flag = true;

        
        SerialPort port;
       

        public Form1()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            Com_connect.Items.AddRange(ports);
            port = new SerialPort();

           
        }

        

            private void configure_item_Click(object sender, EventArgs e)
        {
            configureWindow.ShowDialog();
        }

        

        public void port_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            //whatever logic and read procedure we want

            try
            {
               
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void connect() {

            

            try
            {
                port.PortName = Com_connect.SelectedItem.ToString();

                port.BaudRate = Convert.ToInt32(DataCOM.Baud);

                port.DataBits = DataCOM.DataBits;


                if (DataCOM.Parity.ToString() == "System.IO.Ports.Parity.None")
                    port.Parity = System.IO.Ports.Parity.None;
                if (DataCOM.Parity.ToString() == "System.IO.Ports.Parity.Odd")
                    port.Parity = System.IO.Ports.Parity.Odd;
                if (DataCOM.Parity.ToString() == "System.IO.Ports.Parity.Even")
                    port.Parity = System.IO.Ports.Parity.Even;
                if (DataCOM.Parity.ToString() == "System.IO.Ports.Parity.Mark")
                    port.Parity = System.IO.Ports.Parity.Mark;
                if (DataCOM.Parity.ToString() == "System.IO.Ports.Parity.Even")
                    port.Parity = System.IO.Ports.Parity.Space;

                if (DataCOM.StopBits.ToString() == "One")
                    port.StopBits = System.IO.Ports.StopBits.One;
                if (DataCOM.StopBits.ToString() == "OnePointFive")
                    port.StopBits = System.IO.Ports.StopBits.OnePointFive;
                if (DataCOM.StopBits.ToString() == "Two")
                    port.StopBits = System.IO.Ports.StopBits.Two;

                port.ReadTimeout = DataCOM.readTimeout;

                port.WriteTimeout = DataCOM.writeTimeout;
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataRecieved);
                port.Open();
                port.WriteLine(String.Format("1"));
               // textBox1.Text = (DateTime.Now + " : " + port.ReadLine());


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: невозможно открыть порт\nПроверьте настройки подключения\nCode:\n"+ ex.ToString());
                flag = false;
                Connect.Text = "Подключить";
                Connect.BackColor = Color.Green;
                return;
            }
        }

       


        private void Connect_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Com_connect.Text)) {
                MessageBox.Show("Выберите COM-порт");
            }
            else
            {

               if (flag == true)
                {
                    connect();
                    textBox1.Text = (DateTime.Now + " : " + port.ReadLine());
                    Connect.Text = "Отключить";
                    Connect.BackColor = Color.Red;
                    flag = false;
                    toolStripStatus.Text = "Порт Открыт | " + port.PortName + " " + port.BaudRate + "-" + port.DataBits + "-" + DataCOM.Parity.ToString() + "-" + DataCOM.StopBits.ToString();
                }
                else
                {
                    port.WriteLine(String.Format("2"));
                    textBox1.Text = (DateTime.Now + " : " + port.ReadLine());
                    port.Close();
                    Connect.Text = "Подключить";
                    Connect.BackColor = Color.Green;
                    flag = true;
                    toolStripStatus.Text = "Готов";
                }
            }

                                     
        }

        private void exit_item_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatus_Click(object sender, EventArgs e)
        {
           
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
