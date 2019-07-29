﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson11C
{
    public static class Program
    {
        public static Student student; // { get; set; } < don't need anymore
        public static StartForm startForm;
        public static MainForm mainForm;
        public static AboutForm aboutForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startForm = new StartForm();
            mainForm = new MainForm();
            aboutForm = new AboutForm();
            student = new Student();

            Application.Run(startForm); // startForm 부터 시작하기 위함
        }
    }
}
