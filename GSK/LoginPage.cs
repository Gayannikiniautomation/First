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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void login_btn1_Click(object sender, EventArgs e)
        {

            Main_Window mw = new Main_Window();
            mw.Show();
            //mw.Enabled = false;

            
            popup_window pw = new popup_window();
            pw.Location = new Point(100,100);
            pw.Show();            
            this.Hide();
            
        }

    }
}
