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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void bHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, world!");
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            fConnect Connect = new fConnect();
            Connect.ShowDialog();
        }
    }
}
