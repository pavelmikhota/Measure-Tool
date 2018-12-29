using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mesure
{
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = "График";
            ClientSize = new Size(600, 400);

            Chart myChart = new Chart();
            myChart.Parent = this;
            myChart.Left = 170;
            myChart.Top = 10;
            myChart.Width = (ClientSize.Width - 180);
            myChart.Height = (ClientSize.Height - 20);
            



            ChartArea myChartArea = new ChartArea();
            myChartArea.Name = "myChartArea";
            myChart.ChartAreas.Add(myChartArea);
            myChartArea.AxisX.MajorGrid.LineColor = SystemColors.ControlLight;
            myChartArea.AxisY.MajorGrid.LineColor = SystemColors.ControlLight;

            Series mySeries1 = new Series();
            mySeries1.ChartType = SeriesChartType.Spline;
            mySeries1.ChartArea = "myChartArea";
            myChart.Series.Add(mySeries1);

            mySeries1.Points.DataBindXY(ArrData.arrNum.Where(x => x != 0).ToArray(), ArrData.arrValue.Where(x => x != 0).ToArray());

           





        }






    }
}
