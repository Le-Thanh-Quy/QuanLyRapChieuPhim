using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace logindn
{
    public partial class LG : UserControl
    {
        public LG()
        {
            InitializeComponent();
        }
        public string Phone
        {
            get
            {
                return textBox_Phone.Text;
            }
            set
            {
                textBox_Phone.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return textBox_Pass.Text;
            }
            set
            {
                textBox_Pass.Text = value;
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

        private void textBox_Phone_Leave(object sender, EventArgs e)
        {
            if (textBox_Phone.Text == "")
            {
                textBox_Phone.Text = "Nhập số điện thoại của bạn";
                textBox_Phone.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox_Pass_Leave(object sender, EventArgs e)
        {
            if (textBox_Pass.Text == "")
            {
                textBox_Pass.PasswordChar = '\0';
                textBox_Pass.Text = "Mật khẩu";
                textBox_Pass.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox_Pass_Enter(object sender, EventArgs e)
        {
            if (textBox_Pass.Text == "Mật khẩu")
            {
                textBox_Pass.PasswordChar = '*';
                textBox_Pass.Text = "";
                textBox_Pass.ForeColor = SystemColors.WindowText;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Tính Năng Sẽ Phát Triển Sau");
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập được rồi nè");
        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Phone.Text.Length > 0 && textBox_Phone.Text.Length < 18)
            {
                char a = textBox_Phone.Text[textBox_Phone.Text.Length - 1];
                if (textBox_Phone.Text.Length > 11)
                {
                    if (a == '@' || a == '!')
                    {
                        return;
                    }
                    textBox_Phone.Text = textBox_Phone.Text.Remove(textBox_Phone.Text.Length - 1, 1);
                    MessageBox.Show("SDT chỉ bao gồm 11 chữ số");
                    return;
                }
                if (a < '0' || a > '9')
                {
                    textBox_Phone.Text = textBox_Phone.Text.Remove(textBox_Phone.Text.Length - 1, 1);
                    MessageBox.Show("SDT bao gồm các chữ số");
                }
                
            }
        }

        private void textBox_Pass_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Pass.Text.Length > 0)
            {
                char a = textBox_Pass.Text[textBox_Pass.Text.Length - 1];
                if (textBox_Pass.Text.Length > 9)
                {
                    textBox_Pass.Text = textBox_Pass.Text.Remove(textBox_Pass.Text.Length - 1, 1);
                    MessageBox.Show("Mật khẩu chỉ bao gồm 9 ký tự");                   
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            string input = Interaction.InputBox("Nhập vào số điện thoại cần khôi phục", "Quên mật khẩu", "", 500, 300);
        }
    }
}
