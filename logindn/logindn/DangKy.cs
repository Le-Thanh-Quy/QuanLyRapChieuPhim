using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logindn
{
    public partial class DangKy : UserControl
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính Năng Sẽ Phát Triển Sau");
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            textBoxPass2.Text = "Nhập lại mật khẩu";
            textBox_Name.Text = "Nhập tên của bạn";
            textBox_Phone.Text = "Nhập số điện thoại của bạn";
            textBoxPass1.Text = "Nhập mật khẩu";
        }

        private void textBox_Name_Enter(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "Nhập tên của bạn")
            {
                textBox_Name.Text = "";
                textBox_Name.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox_Name_Leave(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
            {
                textBox_Name.Text = "Nhập tên của bạn";
                textBox_Name.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox_Phone_Leave(object sender, EventArgs e)
        {
            if (textBox_Phone.Text == "")
            {
                textBox_Phone.Text = "Nhập số điện thoại của bạn";
                textBox_Phone.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox_Phone_Enter(object sender, EventArgs e)
        {
            if (textBox_Phone.Text == "Nhập số điện thoại của bạn")
            {
                textBox_Phone.Text = "";
                textBox_Phone.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxPass1_Leave(object sender, EventArgs e)
        {
            if (textBoxPass1.Text == "")
            {
                textBoxPass1.PasswordChar = '\0';
                textBoxPass1.Text = "Nhập mật khẩu";
                textBoxPass1.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBoxPass1_Enter(object sender, EventArgs e)
        {
            if (textBoxPass1.Text == "Nhập mật khẩu")
            {
                textBoxPass1.PasswordChar = '*';
                textBoxPass1.Text = "";
                textBoxPass1.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxPass2_Leave(object sender, EventArgs e)
        {
            if (textBoxPass2.Text == "")
            {
                textBoxPass2.PasswordChar = '\0';
                textBoxPass2.Text = "Nhập lại mật khẩu";
                textBoxPass2.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBoxPass2_Enter(object sender, EventArgs e)
        {
            if (textBoxPass2.Text == "Nhập lại mật khẩu")
            {
                textBoxPass2.PasswordChar = '*';
                textBoxPass2.Text = "";
                textBoxPass2.ForeColor = SystemColors.WindowText;
            }
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
