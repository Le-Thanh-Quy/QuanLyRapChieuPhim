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
    public partial class FormFilm : Form
    {
        public FormFilm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn ảnh booster";
            openFile.Filter = "JPG|*.jpg|PNG|*png|GIF|*.gif|ALL|*";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFile.FileName; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
                Phim phim = new Phim();
                phim.id = "2";
                phim.idTheLoai = "2";
                phim.MoTa = "a";
                phim.NgayCongChieu = DateTime.Now;
                phim.HangPhim = "a";
                phim.TenPhim = "aa";
                phim.DienVien = "aaa";
                phim.ThoiLuong = 2;
                phim.DaoDien = "a";
                phim.TrangThai = true;
                phim.ApPhich = BLL_QLRCP.Instance.ConvertFilltoByte(pictureBox1.ImageLocation);
                db.Phims.Add(phim);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");

            }
            catch
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void FormFilm_Load(object sender, EventArgs e)
        {
            //QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();

            //Phim phim = db.Phims.Single(p => p.id == "10");
            //pictureBox1.Image = BLL_QLRCP.Instance.ConvertByteyoImage(phim.ApPhich);
        }
    }
}
