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

namespace GSK
{
    public partial class startingform : Form
    {
        public startingform()
        {
            
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.ForeColor = Color.Red;
            metroProgressBar1.BackColor = Color.Transparent;
           


            if (metroProgressBar1.Value < 100)
            {
                metroProgressBar1.Value = metroProgressBar1.Value + 2;

            }
            else if (metroProgressBar1.Value == 100)
            {
                loginform lf = new loginform();
                lf.Show();
                this.Hide();
                timer1.Dispose();
            }
        }
    }
}
