﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using Excel = Microsoft.Office.Interop.Excel;


namespace Mesure
{
    static class DataCOM
    {
        public static object Baud { get; set; }
        public static Int32 DataBits { get; set; }
        public static object StopBits { get; set; }
        public static object Parity { get; set; }
        public static Int32 readTimeout { get; set; }
        public static Int32 writeTimeout { get; set; }

        public static object indata { get; set; }
    }

    static class ArrData
    {
        public static int rowNumber { get; set; }
        public static int[] arrNum { get; set; }
        public static double[] arrValue { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {


            DataCOM.Baud = 9600;
            DataCOM.DataBits = 8;
            DataCOM.StopBits = System.IO.Ports.StopBits.One;
            DataCOM.Parity = System.IO.Ports.Parity.None;
            DataCOM.readTimeout = 1000;
            DataCOM.writeTimeout = 1000;

            //
            ArrData.arrNum = new int[100];
            ArrData.arrValue = new double[100];


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

    }
}
