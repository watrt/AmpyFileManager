﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmpyFileManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ESPRoutines ESP = new ESPRoutines();
            while (ESP.COMM_PORT == "")
            {
                MessageBox.Show("必须选择COM端口设备。");
                ESP = new ESPRoutines();
            }

            if (ESP.COMM_PORT != "EXIT")
                Application.Run(new frmMain(ESP));
        }
    }
}
