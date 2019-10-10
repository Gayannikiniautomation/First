using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSK
{
    public partial class read_qr : Form
    {
        public read_qr()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            read_qr rq = new read_qr();
            rq.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userVerification uv = new userVerification();
            uv.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            popup_window pw = new popup_window();
            pw.Show();
        }
    }
}
