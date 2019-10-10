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
    public partial class popup_window : Form
    {
        public popup_window()
        {
            InitializeComponent();
            

        }

        private void popup_window_Load(object sender, EventArgs e)
        {
            this.Location = new Point(54,67);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            read_qr rq = new read_qr();
            rq.Show();
            this.Hide();
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
