﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DNSQuary());
            //Application.Run(new UIPAddress());
            //Application.Run(new webClient());
            //Application.Run(new webRequest());
            Application.Run(new UwebBrower());

        }
    }
}
