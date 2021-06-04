﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ABD_7__Proyecto_Final
{
    public partial class FrPantallaCarga : Form
    {
        public FrPantallaCarga()
        {
            InitializeComponent();
        }

        private void FrPantallaCarga_Load(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 0; i < 5; i++)
            {
                Dormir();
                bgWorker.ReportProgress(i * 20);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            probarInicio.Value = e.ProgressPercentage;
            lblPorcentaje.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        void Dormir()
        {
            Thread.Sleep(1000);
        }
    }
}
