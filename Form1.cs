using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTwosomeMessager
{
    public partial class fMain : Form
    {
        private Object lbBlock;

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            fConnect Connect = new fConnect();
            Connect.ShowDialog();
            lbBlock = new Object();
            tGettingMessages.Enabled = true;
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            string msg = tbInputMessage.Text.Trim();
            tbInputMessage.Text = "";
            if (msg.Length <= 0)
                return;
            Messaging.SendMsg(msg);
            lock(lbBlock)
            {
                lbMessages.Items.Add(msg);
            }
        }

        private void tGettingMessages_Tick(object sender, EventArgs e)
        {
            string msg = Messaging.GetMsg();
            if (msg == null) return;
            lock (lbBlock)
            {
                lbMessages.Items.Add(msg);
            }
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Messaging.StopGettingMessages();
            tGettingMessages.Stop();
        }
    }
}
