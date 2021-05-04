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
                return textBoxPass1.Text;
            }
            set
            {
                textBoxPass1.Text = value;
            }
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

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Name.Text.Length > 0)
            {
                char a = textBox_Name.Text[textBox_Name.Text.Length - 1];
                if (a >= '0' && a <= '9')
                {
                    textBox_Name.Text = textBox_Name.Text.Remove(textBox_Name.Text.Length - 1, 1);
                    MessageBox.Show("Tên bao gồm các chữ cái");
                }
                if (textBox_Name.Text.Length > 25)
                {
                    textBox_Name.Text = textBox_Name.Text.Remove(textBox_Name.Text.Length - 1, 1);
                    MessageBox.Show("Tên tối đa chỉ bao gồm 25 ký tự");
                }
            }
        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Phone.Text.Length > 0 && textBox_Phone.Text.Length < 18)
            {
                char a = textBox_Phone.Text[textBox_Phone.Text.Length - 1];
                if (textBox_Phone.Text.Length > 11)
                { 
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

        private void textBoxPass1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPass1.Text.Length > 0 && textBoxPass1.Text.Length < 11)
            {
                char a = textBoxPass1.Text[textBoxPass1.Text.Length - 1];
                if (textBoxPass1.Text.Length > 9)
                {
                    textBoxPass1.Text = textBoxPass1.Text.Remove(textBoxPass1.Text.Length - 1, 1);
                    MessageBox.Show("Mật khẩu chỉ bao gồm 9 ký tự");
                }
            }
        }

        private void textBoxPass2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPass2.Text.Length > 0 && textBoxPass2.Text.Length < 11)
            {
                char a = textBoxPass2.Text[textBoxPass2.Text.Length - 1];
                if (textBoxPass2.Text.Length > 9)
                {
                    textBoxPass2.Text = textBoxPass2.Text.Remove(textBoxPass2.Text.Length - 1, 1);
                    MessageBox.Show("Mật khẩu chỉ bao gồm 9 ký tự");
                }
            }
        }
        public int GetId()
        {
            QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
            int count = db.KhachHangs.Select(p => p).Count();
            if(count == 0)
            {
                return 99;
            }
            var l = db.KhachHangs.OrderByDescending(p => p.id).First();          
            return 1;
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            if(textBoxPass2.Text == "Nhập lại mật khẩu" || textBox_Name.Text == "Nhập tên của bạn" 
                || textBox_Phone.Text == "Nhập số điện thoại của bạn" || textBoxPass1.Text == "Nhập mật khẩu"
                || label3.Visible == true)
            {
                MessageBox.Show("Không được để trống các mục");
                return;
            }
            if( textBoxPass2.Text != textBoxPass1.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }
            QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
            int count = db.TaiKhoans.Where(p => p.Phone == textBox_Phone.Text).Count();
            if(count != 0)
            {
                MessageBox.Show("Số điện thoại " + textBox_Phone.Text +" đã đăng ký sử dụng dịch vụ" );
                return;
            }

            KhachHang s = new KhachHang()
            {
                id = (GetId() + 1).ToString() ,
                HoTen = textBox_Name.Text,
                NgaySinh = dateTimePicker1.Value,
                SDT = textBox_Phone.Text,
                DiemTichLuy = 0
            };
            TaiKhoan tk = new TaiKhoan()
            {
                Phone = textBox_Phone.Text,
                Pass = textBoxPass2.Text,
                LoaiTK = 0
            };
            db.KhachHangs.Add(s);
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
            MessageBox.Show("Đăng ký tài khoản thành công");
            this.Visible = false;
        }
    }
}
