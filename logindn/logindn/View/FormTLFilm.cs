using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logindn.BLL;

namespace logindn.View
{
    public partial class FormTLFilm : Form
    {
        public string idKhachhang = "";
        public string idPhim = "";
        public DateTime NgayChieu = DateTime.Now;
        public FormTLFilm(string id , DateTime dateTime , string idKhachHang)
        {
            idKhachhang = idKhachHang;
            idPhim = id;
            NgayChieu = dateTime;
            InitializeComponent();
        }

        private void FormTLFilm_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(130, 40);
            Phim phim = BLL_QLRCP.Instance.GetPhim(idPhim);
            pictureBox1.Image = BLL_QLRCP.Instance.ConvertByteyoImage(phim.ApPhich);
            pictureBox3.Visible = false;
            pictureBox3.Image = BLL_QLRCP.Instance.ConvertByteyoImage(phim.ApPhich);
            bunifuLabelName.Text =  phim.TenPhim;
            LableCongChieu.Text = phim.NgayCongChieu.Day.ToString() + "-"+ phim.NgayCongChieu.Month.ToString() + "-" + phim.NgayCongChieu.Year.ToString();
            LableDienVien.Text = phim.DienVien;
            lableDaoDien.Text = phim.DaoDien;
            lableHangPhim.Text = phim.HangPhim;
            LableTheLoai.Text = phim.TheLoai.TenTheLoai;
            LableThoiLuong.Text = phim.ThoiLuong.ToString() + " phút";
            TextMoTa.Text = phim.MoTa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            FormChonCho formChonCho = new FormChonCho(idPhim , NgayChieu , idKhachhang);
            this.Hide();
            formChonCho.ShowDialog();
            this.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FormTrailer formTrailer = new FormTrailer(idPhim);
            formTrailer.ShowDialog();
            
        }
    }
}
