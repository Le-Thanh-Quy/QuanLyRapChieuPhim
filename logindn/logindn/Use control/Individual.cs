using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logindn.BLL;
using Microsoft.VisualBasic;

namespace logindn.Use_control
{
    public partial class Individual : UserControl
    {
        QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
        public string phone = "";
        public Individual()
        {
            InitializeComponent();
        }
        
        public void SetDB(string SDT)
        {

            phone = SDT;
            label1.Text = BLL_QLRCP.Instance.getInforUse(SDT).HoTen;
            label2.Text = BLL_QLRCP.Instance.getInforUse(SDT).SDT;
            label3.Text = BLL_QLRCP.Instance.getInforUse(SDT).NgaySinh.Month.ToString() + "-" + BLL_QLRCP.Instance.getInforUse(SDT).NgaySinh.Day.ToString() + "-" + BLL_QLRCP.Instance.getInforUse(SDT).NgaySinh.Year.ToString();
            label6.Text = "Thay đổi mật khẩu";
            label5.Text = "Điểm tích lũy: " + BLL_QLRCP.Instance.getInforUse(SDT).DiemTichLuy;

        }
        

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = SystemColors.HotTrack;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = SystemColors.Control;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = SystemColors.HotTrack;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = SystemColors.Control;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = SystemColors.HotTrack;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = SystemColors.Control;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = SystemColors.HotTrack;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = SystemColors.Control;
        }
        private void label1_Click(object sender, EventArgs e)
        { 
            string input = Interaction.InputBox("Nhập tên bạn muốn thay dổi", "Thay đổi họ tên", label1.Text, 500, 300);
            if (input == "" || input == label1.Text)
            {
                return;
            }
            else
            {
                var result = db.KhachHangs.Where(b => b.SDT == phone).FirstOrDefault();
                if (result != null)
                {
                    result.HoTen = input;
                    db.SaveChanges();
                    label1.Text = input;
                }       
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không thể thay đổi thông tin số điện thoại");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            string input = Interaction.InputBox("Nhập vào tháng-ngày-năm sinh của bạn \n(Định dạng: mm-dd-yy)", "Thay đổi ngày sinh", label3.Text, 500, 300);
            if (input == "") return;
            try
            {
                date = Convert.ToDateTime(input);
            }
            catch( Exception erorr)
            {
                MessageBox.Show("Nhập sai kiểu định dạng");
                return;
            }

            var result = db.KhachHangs.Where(b => b.SDT == phone).FirstOrDefault();
            if (result != null)
            {
                result.NgaySinh = date;
                db.SaveChanges();
                label3.Text = input;
            }

        }
 
        private void label6_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Nhập mật khẩu cũ", "Thay đổi mật khẩu", "", 500, 300);
            if (input == "") return;
            int count = db.TaiKhoans.Where(p => p.Phone == phone && p.Pass == input).Count();
            if(count == 0)
            {
                MessageBox.Show("Mật khẩu không chính xác");
            }
            else
            {
                string inputMK = Interaction.InputBox("Nhập mật khẩu mới", "Thay đổi mật khẩu", "", 500, 300);
                if (inputMK == "" || inputMK == label6.Text)
                {
                    return;
                }
                else
                {
                    var result = db.TaiKhoans.SingleOrDefault(b => b.Phone == phone);
                    if (result != null)
                    {
                        result.Pass = inputMK;
                        db.SaveChanges();
                    }
                }
            }
        }

        
    }
}
