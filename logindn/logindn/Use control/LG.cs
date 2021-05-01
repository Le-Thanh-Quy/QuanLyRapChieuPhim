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
            if(textBox_Phone.Text == "Nhập số điện thoại của bạn" || textBox_Pass.Text == "Mật khẩu")
            {
                MessageBox.Show("Không được để trống các mục");
                return;
            }
            QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
            var l = db.TaiKhoans.Where(p => p.Phone == textBox_Phone.Text && p.Pass == textBox_Pass.Text ).Select(p => p);
            if(l.Count() == 0)
            {
                MessageBox.Show("Số điện thoại hoặc mật khẩu không chính xác");
                textBox_Phone.Text = "Nhập số điện thoại của bạn";
                textBox_Pass.Text = "Mật khẩu";
            }
            else
            {
                List<TaiKhoan> taiKhoans = l.ToList<TaiKhoan>();
                if (taiKhoans[0].LoaiTK == 0)
                {
                    MessageBox.Show("Mở form của khách hàng");
                }
                if (taiKhoans[0].LoaiTK == 1)
                {
                    MessageBox.Show("Mở form của nhân viên bán vé");
                }
                if (taiKhoans[0].LoaiTK == 2)
                {
                    MessageBox.Show("Mở form của quản lý");
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
            if(textBox_Pass.Text != "Mật khẩu")
            {
                textBox_Pass.PasswordChar = '*';
            }
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
            string srt = "";
            if(textBox_Phone.Text != "Nhập số điện thoại của bạn")
            {
                srt = textBox_Phone.Text;
            }
            string input = Interaction.InputBox("Nhập vào số điện thoại cần khôi phục", "Quên mật khẩu", srt, 500, 300);

            QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
            var l = db.TaiKhoans.Select(p => p);

            List<TaiKhoan> taiKhoans = l.ToList<TaiKhoan>();
            foreach(TaiKhoan i in taiKhoans)
            {
                if(i.Phone == input)
                {
                    string check1 = Interaction.InputBox("Nhập vào tên của bạn", "Quên mật khẩu", "", 500, 300);
                    string check2 = Interaction.InputBox("Nhập vào ngày-tháng-năm sinh của bạn \n(Định dạng: dd-mm-yy)", "Quên mật khẩu", "", 500, 300);
                    var l1 = db.KhachHangs.Where(p => p.SDT == i.Phone).Select(p => p);
                    List<KhachHang> khachhangs = l1.ToList<KhachHang>();
                    foreach (KhachHang j in khachhangs)
                    {
                        
                        if (check1 == j.HoTen && check2 == (j.NgaySinh.Day.ToString() +"-"+ j.NgaySinh.Month.ToString()+"-"+ j.NgaySinh.Year.ToString()))
                        {
                            MessageBox.Show("Mật khẩu cảu bạn là: " + i.Pass);
                            textBox_Phone.Text = i.Phone;
                            textBox_Pass.Text = i.Pass;
                            return;
                        }
                        MessageBox.Show("Thông tin không chính xác không thể khôi phục mật khẩu");
                    }
                    return;
                }
            }
            if(input != "")
            {
                MessageBox.Show("Không tồn tại số điện thoại: " + input);
            }
            

        }
    }
}
