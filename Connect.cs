using System;
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
        private bool connected = false;
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
            if(!connected)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbServer.Checked)
                {
                    Messaging.CreateServer(Convert.ToInt32(tbPort.Text));
                }
                else if (rbClient.Checked)
                {
                    Messaging.CreateClient(tbHostName.Text, Convert.ToInt32(tbPort.Text), Convert.ToInt32(tbPort2.Text));
                }
                else
                {
                    MessageBox.Show("Choose 'server' or 'client'");
                    return;
                }
                connected = true;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            this.Close();
        }
    }
}
