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
    public partial class FormVe : Form
    {
        public string idVe = "";
        public FormVe(string id)
        {
            idVe = id;
            InitializeComponent();
        }

        private void FormVe_Load(object sender, EventArgs e)
        {
            Ve ve = BLL_QLRCP.Instance.GetVe(idVe);
            labelid.Text = ve.id.ToString();
            labelGio.Text = ve.GheNgoi.LichChieu.CaChieu.ThoigianBatDau.ToString() + "-" + ve.GheNgoi.LichChieu.CaChieu.ThoiGianKetThuc.ToString();
            labelTen.Text = ve.KhachHang.HoTen;
            labelSDT.Text = ve.KhachHang.SDT;
            labelPhim.Text = ve.GheNgoi.LichChieu.Phim.TenPhim;
            labelGhe.Text = ve.Ghe;
            labelTongTien.Text = ve.TienBanVe.ToString() + " VND";
            labelNgay.Text = ve.GheNgoi.LichChieu.NgayChieu.Day.ToString() + "-" + ve.GheNgoi.LichChieu.NgayChieu.Month.ToString() + "-" + ve.GheNgoi.LichChieu.NgayChieu.Year.ToString();
            pictureBox2.Image = BLL_QLRCP.Instance.ConvertByteyoImage(ve.GheNgoi.LichChieu.Phim.ApPhich);

        }
    }
}
