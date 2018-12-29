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
using Excel = Microsoft.Office.Interop.Excel;


namespace Mesure
{

    public partial class Form1 : Form
    {
        Form2 configureWindow = new Form2();
               
        public static bool flag = true;
        
        SerialPort port;
        string[] ports = SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();


            Com_connect.Items.AddRange(ports);
            port = new SerialPort();
            ports = null;


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


        public void connect()
        {



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
                MessageBox.Show("ERROR: невозможно открыть порт\nПроверьте настройки подключения\nCode:\n" + ex.ToString());
                flag = false;
                Connect.Text = "Подключить";
                Connect.BackColor = Color.Green;
                return;
            }
        }




        private void Connect_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Com_connect.Text))
            {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void countValue_Click(object sender, EventArgs e)
        {


            port.WriteLine(String.Format("3"));
            ArrData.rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[ArrData.rowNumber].Cells[0].Value = ArrData.rowNumber + 1;

            dataGridView1.Rows[ArrData.rowNumber].Cells["Value"].Value = port.ReadLine();

            ArrData.arrNum[ArrData.rowNumber] = ArrData.rowNumber + 1;
            ArrData.arrValue[ArrData.rowNumber] = Convert.ToDouble(dataGridView1.Rows[ArrData.rowNumber].Cells["Value"].Value);


            //ArrData.arrNum[rowNumber]);
            //(ArrData.arrValue[rowNumber]);




        }

        private void clearData_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Array.Clear(ArrData.arrNum, 0, ArrData.arrNum.Length);
            Array.Clear(ArrData.arrValue, 0, ArrData.arrValue.Length);
        }

        private void SaveXLS_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            //Значения [y - строка,x - столбец]
            for (int i = 0; i <= ArrData.rowNumber; i++)
            {
                ObjWorkSheet.Cells[i + 1, 1] = ArrData.arrNum[i];
                ObjWorkSheet.Cells[i + 1, 2] = ArrData.arrValue[i];
            }


            string fileName = String.Empty;
            SaveFileDialog saveFileXLS = new SaveFileDialog();
            saveFileXLS.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileXLS.FilterIndex = 2;
            saveFileXLS.RestoreDirectory = true;
            if (saveFileXLS.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileXLS.FileName;


            }
            else
                return;

            ObjWorkBook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            ObjWorkBook.Close(false, Type.Missing, Type.Missing);
            ObjExcel.Quit();
            saveFileXLS.Dispose();


        }

        private void saveFileXLS_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void CreateChart_Click(object sender, EventArgs e)
        {
            Form3 Chart = new Form3();
            Chart.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void updCOM_Click(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            Com_connect.Items.Clear();
            Com_connect.Items.AddRange(ports);
            port = new SerialPort();
            ports = null;

        }

        private void ClearCurrentString_Click(object sender, EventArgs e)
        {
            bool tmpflag = true;

            try
            {
                if (dataGridView1.CurrentRow.Index == 0) ;
            }
            catch
            {
                MessageBox.Show("Строка не выбрана, или пуста");
                tmpflag = false;
            }

            if (tmpflag == false) { }
            else
            {
                DialogResult result = MessageBox.Show("ВНИМАНИЕ! После нажатия ОК, будет произеден пересчет значения",
               "Пересчет строки",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {


                    //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = dataGridView1.CurrentRow.Index + 1;
                    //dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = port.ReadLine();
                    port.WriteLine(String.Format("3"));
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Value"].Value = port.ReadLine();

                    ArrData.arrNum[dataGridView1.CurrentRow.Index] = dataGridView1.CurrentRow.Index + 1;
                    ArrData.arrValue[dataGridView1.CurrentRow.Index] = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Value"].Value);

                }
            }






            //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            //var tmpNum = ArrData.arrNum.ToList(); // Преобразование в список
            //var tmpValue = ArrData.arrValue.ToList();
            // tmpNum.RemoveAt(dataGridView1.CurrentRow.Index-1); // Удаление элемента
            // tmpValue.RemoveAt(dataGridView1.CurrentRow.Index - 1);
            //ArrData.arrNum = tmpNum.ToArray(); // Преобразование в массив
            //ArrData.arrValue = tmpValue.ToArray();


            //string.Join(" ", ArrData.arrNum.Select(x => x.ToString()).ToArray());
            //int del = dataGridView1.CurrentRow.Index-1;
            //var query = ArrData.arrNum.Where(n => ArrData.arrNum.ElementAt(del) != n);
            // string.Join(" ", query.Select(x => x.ToString()).ToArray());

        }

        private void ClearLastString_Click(object sender, EventArgs e)
        {
            int indexString = ArrData.rowNumber;
            dataGridView1.Rows.RemoveAt(indexString);
            indexString = indexString - 1;
        }
    }
}
