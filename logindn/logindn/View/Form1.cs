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
    }
}
