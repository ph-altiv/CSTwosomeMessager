﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTwosomeMessager
{
    public partial class fConnect : Form
    {
        public fConnect()
        {
            InitializeComponent();
        }

        private void lHostName_Click(object sender, EventArgs e)
        {

        }

        private void fConnect_Load(object sender, EventArgs e)
        {

        }

        private void fConnect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbServer.Checked)
                {
                    Messaging.CreateServer(Convert.ToInt32(tbPort.Text));
                    return;
                }
                else if (rbClient.Checked)
                {
                    Messaging.CreateClient(tbHostName.Text, Convert.ToInt32(tbPort.Text), Convert.ToInt32(tbPort2.Text));
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                Application.Exit();
            }
        }
    }
}
