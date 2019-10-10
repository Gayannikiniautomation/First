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

    
    public partial class Main_Window : Form   
        {
        
        int panelWidth;
        bool Hidden;
        
        public Main_Window()
        {
            InitializeComponent();         
            
            panelWidth = sidepanel.Width;
            panelWidth = settings_submenu.Width;
            panelWidth = reports_submenu.Width;
            panelWidth = user_submenu.Width;
            customizeDesing();
            

        }
        private void customizeDesing()
        {           
            settings_submenu.Visible = false;
            reports_submenu.Visible = false;
            user_submenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (user_submenu.Visible == true)
                user_submenu.Visible = false;
            if (settings_submenu.Visible == true)
                settings_submenu.Visible = false;
            if (reports_submenu.Visible == true)
                reports_submenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel_open_timer.Start();
            
        }

        private void sidepanel_open_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {

                sidepanel.Width = sidepanel.Width + 218;
                
                if (sidepanel.Width >= sidepanel.Width)
                {
                    sidepanel_open_timer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                sidepanel.Width = sidepanel.Width - 218;                
                if (sidepanel.Width <= 0)
                {
                    sidepanel_open_timer.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void plc_config_btn_Click(object sender, EventArgs e)
        {

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            userVerification uv = new userVerification();
            uv.Show();
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
          
        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void user_btn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(user_submenu);
        }

        private void system_btn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(settings_submenu);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showSubMenu(reports_submenu);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            loginform lf = new loginform();
            lf.Show();
        }

        private void maximize_btn_Click_1(object sender, EventArgs e)
        {
           
        }

        private void user_pic_btn_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }
            
    }
}
