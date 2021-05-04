using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logindn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetData();
        }
        public void SetData()
        {
            lg1.Phone = "Nhập số điện thoại của bạn";
            lg1.Password = "Mật khẩu";
            dangKy1.Visible = false;
            linkLabel_login.Visible = false;
        }

        private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lg1.Visible = false;
            linkLabel_login.Visible = true;
            dangKy1.Visible = true;
        }

        private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lg1.Visible = true;
            dangKy1.Visible = false;
            linkLabel_login.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(130, 40);
        }

        private void dangKy1_VisibleChanged(object sender, EventArgs e)
        {
            if (dangKy1.Visible == false)
            {
                lg1.Visible = true;
                linkLabel_login.Visible = false;
                lg1.Phone = dangKy1.Phone;
                if (dangKy1.Password != "Nhập mật khẩu")
                {
                    
                    lg1.Password = dangKy1.Password;
                }
                
            }
            
        }

        private void lg1_BackColorChanged(object sender, EventArgs e)
        {
            if(lg1.BackColor == SystemColors.AppWorkspace)
            {
                this.Show();
            }
            else
            {
                this.Hide();
                lg1.Password = "Mật khẩu";
            }
        }
    }
}
