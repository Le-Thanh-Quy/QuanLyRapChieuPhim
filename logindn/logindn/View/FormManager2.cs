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
using logindn.DTO;

namespace logindn.View
{
    public partial class FormManager2 : Form
    {
        public string idPhim = "";
        public string idCaCHieu = "";
        public string idPhong = "";
        public FormManager2()
        {
            InitializeComponent();
        }

        private void dataGridViewPhim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhim.CurrentRow != null)
            {
                idPhim = dataGridViewPhim.CurrentRow.Cells["id"].Value.ToString();
                textBoxPhim.Text = BLL_QLRCP.Instance.GetPhim(idPhim).TenPhim;
            }
        }

        private void dataGridViewCaChieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCaChieu.CurrentRow != null)
            {
                idCaCHieu = dataGridViewCaChieu.CurrentRow.Cells["id"].Value.ToString();
                textBoxCaChieu.Text = BLL_QLRCP.Instance.GetCaChieu(idCaCHieu).Tenca;
            }
        }

        private void dataGridViewPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhong.CurrentRow != null)
            {
                idPhong = dataGridViewPhong.CurrentRow.Cells["id"].Value.ToString();
                textBoxPhong.Text = BLL_QLRCP.Instance.GetPhong(idPhong).TenPhong;
            }
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            if (panelThemMoi.Visible == false)
            {
                buttonThemMoi.BackColor = SystemColors.ButtonHighlight;
                dataGridViewCaChieu.Visible = false;
                dataGridViewPhim.Visible = true;
                dataGridViewPhong.Visible = false;

                panelThemMoi.Visible = true;
                panelDanhSachLichChieu.Visible = false;
                panelChinhSua.Visible = false;
                buttonDanhSachLichChieu.BackColor = SystemColors.Control;
                buttonChinhSua.BackColor = SystemColors.Control;
            }

        }
        private void buttonDanhSachLichChieu_Click(object sender, EventArgs e)
        {
            if (panelDanhSachLichChieu.Visible == false)
            {

                dataGridViewCaChieu.Visible = false;
                dataGridViewPhim.Visible = true;
                dataGridViewPhong.Visible = false;

                panelThemMoi.Visible = false;
                panelDanhSachLichChieu.Visible = true;
                panelChinhSua.Visible = false;
                buttonDanhSachLichChieu.BackColor = SystemColors.ButtonHighlight;
                buttonThemMoi.BackColor = SystemColors.Control;
                buttonChinhSua.BackColor = SystemColors.Control;
                List<ViewLichChieu> viewLichChieus = new List<ViewLichChieu>();
                foreach (LichChieu i in BLL_QLRCP.Instance.GetLichChieus())
                {
                    ViewLichChieu viewLichChieu = new ViewLichChieu();
                    viewLichChieu.ID = i.id;
                    viewLichChieu.TenPhim = i.Phim.TenPhim;
                    viewLichChieu.NgayChieu = i.NgayChieu.ToString();
                    viewLichChieu.CaChieu = i.CaChieu.Tenca;
                    viewLichChieu.Phong = i.PhongChieu.TenPhong;
                    viewLichChieus.Add(viewLichChieu);
                }
                dataLichChieu.DataSource = viewLichChieus;
            }
        }
        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            if (panelDanhSachLichChieu.Visible != false && dataLichChieu.CurrentRow != null)
            {

                panelThemMoi.Visible = false;
                panelDanhSachLichChieu.Visible = false;
                panelChinhSua.Visible = true;
                buttonDanhSachLichChieu.BackColor = SystemColors.Control;
                buttonThemMoi.BackColor = SystemColors.Control;
                buttonChinhSua.BackColor = SystemColors.ButtonHighlight;
                string idLichChieu = dataLichChieu.CurrentRow.Cells["id"].Value.ToString();            
                idPhim = BLL_QLRCP.Instance.GetLichChieu(idLichChieu).idPhim;
                idCaCHieu = BLL_QLRCP.Instance.GetLichChieu(idLichChieu).idCaChieu;
                idPhong = BLL_QLRCP.Instance.GetLichChieu(idLichChieu).idPhong;
                LichChieu lichChieu = new LichChieu();
                lichChieu = BLL_QLRCP.Instance.GetLichChieu(idLichChieu);
                textBoxPhim1.Text = lichChieu.Phim.TenPhim;
                textBoxCaChieu1.Text = lichChieu.CaChieu.Tenca;
                textBoxPhong1.Text = lichChieu.PhongChieu.TenPhong;
                dateTimePickerNgayChieuEdit.Value = lichChieu.NgayChieu.Date;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu bạn muốn chỉnh sửa");
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (panelDanhSachLichChieu.Visible != false && dataLichChieu.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa phim trên!", "DELETE", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dataLichChieu.CurrentRow.Cells["id"].Value.ToString();
                    BLL_QLRCP.Instance.DeleteLichChieu(id);
                    List<ViewLichChieu> viewLichChieus = new List<ViewLichChieu>();
                    foreach (LichChieu i in BLL_QLRCP.Instance.GetLichChieus())
                    {
                        ViewLichChieu viewLichChieu = new ViewLichChieu();
                        viewLichChieu.ID = i.id;
                        viewLichChieu.TenPhim = i.Phim.TenPhim;
                        viewLichChieu.NgayChieu = i.NgayChieu.ToString();
                        viewLichChieu.CaChieu = i.CaChieu.Tenca;
                        viewLichChieu.Phong = i.PhongChieu.TenPhong;
                        viewLichChieus.Add(viewLichChieu);
                    }
                    dataLichChieu.DataSource = viewLichChieus;


                }
                else if (dialogResult == DialogResult.No)
                {
                    List<ViewLichChieu> viewLichChieus = new List<ViewLichChieu>();
                    foreach (LichChieu i in BLL_QLRCP.Instance.GetLichChieus())
                    {
                        ViewLichChieu viewLichChieu = new ViewLichChieu();
                        viewLichChieu.ID = i.id;
                        viewLichChieu.TenPhim = i.Phim.TenPhim;
                        viewLichChieu.NgayChieu = i.NgayChieu.ToString();
                        viewLichChieu.CaChieu = i.CaChieu.Tenca;
                        viewLichChieu.Phong = i.PhongChieu.TenPhong;
                        viewLichChieus.Add(viewLichChieu);
                    }
                    dataLichChieu.DataSource = viewLichChieus;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch chiếu bạn muốn xóa");
            }
        }
        private void buttonPhim_Click(object sender, EventArgs e)
        {
            buttonPhim.BackColor = SystemColors.ButtonHighlight;
            buttonCaChieu.BackColor = SystemColors.Control;
            buttonPhong.BackColor = SystemColors.Control;
            dataGridViewCaChieu.Visible = false;
            dataGridViewPhim.Visible = true;
            dataGridViewPhong.Visible = false;
            dataGridViewPhim.DataSource = BLL_QLRCP.Instance.GetAllFilm(0 , DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonPhim.BackColor = SystemColors.Control;
            buttonCaChieu.BackColor = SystemColors.ButtonHighlight;
            buttonPhong.BackColor = SystemColors.Control;
            dataGridViewCaChieu.Visible = true;
            dataGridViewPhim.Visible = false;
            dataGridViewPhong.Visible = false;
            dataGridViewCaChieu.DataSource = BLL_QLRCP.Instance.GetCaChieus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonPhim.BackColor = SystemColors.Control;
            buttonCaChieu.BackColor = SystemColors.Control;
            buttonPhong.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCaChieu.Visible = false;
            dataGridViewPhim.Visible = false;
            dataGridViewPhong.Visible = true;
            dataGridViewPhong.DataSource = BLL_QLRCP.Instance.GetPhongChieus(-1);
        }

        private void FormManager2_Load(object sender, EventArgs e)
        {
            buttonDanhSachLichChieu.BackColor = SystemColors.ButtonHighlight;
            panelDanhSachLichChieu.Visible = true;
            panelThemMoi.Visible = false;
            panelChinhSua.Visible = false;
            dateTimePicker2.Value = dateTimePicker1.Value;
            List<ViewLichChieu> viewLichChieus = new List<ViewLichChieu>();
            foreach (LichChieu i in BLL_QLRCP.Instance.GetLichChieus())
            {
                ViewLichChieu viewLichChieu = new ViewLichChieu();
                viewLichChieu.ID = i.id;
                viewLichChieu.TenPhim = i.Phim.TenPhim;
                viewLichChieu.NgayChieu = i.NgayChieu.ToString();
                viewLichChieu.CaChieu = i.CaChieu.Tenca;
                viewLichChieu.Phong = i.PhongChieu.TenPhong;
                viewLichChieus.Add(viewLichChieu);
            }
            dataLichChieu.DataSource = viewLichChieus;
            comboBox1.SelectedIndex = 0;
            textBoxSearch.Visible = true;
            dateTimePicker3.Visible = false;
            textBoxsearch1.Visible = false;
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {

                MessageBox.Show("Thời gian bắt dầu phải từ ngày hôm nay trở đi");
                dateTimePicker1.Value = DateTime.Now;
                return;
            }
            dateTimePicker2.Value = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
                MessageBox.Show("Thời gian kết thúc phải từ ngày bắt đầu trở đi");
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (textBoxPhim.Text == "" || textBoxCaChieu.Text == "" || textBoxPhong.Text == "")
            {
                MessageBox.Show("Không được để trống các mục");
                return;
            }
            else
            {
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    LichChieu lichChieu = new LichChieu();
                    lichChieu.id = BLL_QLRCP.Instance.GetIdLichChieu().ToString();
                    lichChieu.idPhim = idPhim;
                    lichChieu.idPhong = idPhong;
                    lichChieu.idCaChieu = idCaCHieu;
                    lichChieu.NgayChieu = dateTimePicker1.Value.Date;
                    if (BLL_QLRCP.Instance.CheckLichChieu(lichChieu))
                    {

                        MessageBox.Show("Lịch chiếu bị trùng lặp");
                        textBoxCaChieu.Text = "";
                        textBoxPhim.Text = "";
                        textBoxPhong.Text = "";
                        return;
                    }
                    BLL_QLRCP.Instance.AddLichChieu(lichChieu);
                    MessageBox.Show("Thêm thành công");
                    textBoxCaChieu.Text = "";
                    textBoxPhim.Text = "";
                    textBoxPhong.Text = "";
                }
                else
                {
                    int i = 0;
                    for (DateTime dateTime = dateTimePicker1.Value; dateTime <= (dateTimePicker2.Value + TimeSpan.FromDays(1)); dateTime += TimeSpan.FromDays(1))
                    {
                        LichChieu lichChieu = new LichChieu();
                        lichChieu.id = BLL_QLRCP.Instance.GetIdLichChieu().ToString();
                        lichChieu.idPhim = idPhim;
                        lichChieu.idPhong = idPhong;
                        lichChieu.idCaChieu = idCaCHieu;
                        lichChieu.NgayChieu = dateTime.Date;

                        if (BLL_QLRCP.Instance.CheckLichChieu(lichChieu))
                        {
                            MessageBox.Show(dateTime.Date.ToString() + " không được thêm vi bị trùng");
                            continue;
                        }
                        BLL_QLRCP.Instance.AddLichChieu(lichChieu);
                        i++;
                    }
                    if (i != 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        textBoxCaChieu.Text = "";
                        textBoxPhim.Text = "";
                        textBoxPhong.Text = "";
                    }

                }


            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Tên Phim")
            {
                textBoxSearch.Visible = true;
                dateTimePicker3.Visible = false;
                textBoxsearch1.Visible = false;
            }
            else if (comboBox1.Text == "Tên Phòng")
            {
                dateTimePicker3.Visible = false;
                textBoxSearch.Visible = false;
                textBoxsearch1.Visible = true;
            }
            else
            {
                dateTimePicker3.Visible = true;
                textBoxSearch.Visible = false;
                textBoxsearch1.Visible = false;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<ViewLichChieu> viewLichChieus = new List<ViewLichChieu>();
            foreach (LichChieu i in BLL_QLRCP.Instance.GetLichChieus())
            {
                ViewLichChieu viewLichChieu = new ViewLichChieu();
                viewLichChieu.ID = i.id;
                viewLichChieu.TenPhim = i.Phim.TenPhim;
                viewLichChieu.NgayChieu = i.NgayChieu.ToString();
                viewLichChieu.CaChieu = i.CaChieu.Tenca;
                viewLichChieu.Phong = i.PhongChieu.TenPhong;
                if (viewLichChieu.TenPhim.ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
                {
                    viewLichChieus.Add(viewLichChieu);
                }      
            }
            dataLichChieu.DataSource = viewLichChieus;
        }

        private void textBoxsearch1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                idPhim = dataGridView3.CurrentRow.Cells["id"].Value.ToString();
                textBoxPhim1.Text = BLL_QLRCP.Instance.GetPhim(idPhim).TenPhim;
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                idCaCHieu = dataGridView2.CurrentRow.Cells["id"].Value.ToString();
                textBoxCaChieu1.Text = BLL_QLRCP.Instance.GetCaChieu(idCaCHieu).Tenca;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                idPhong = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                textBoxPhong1.Text = BLL_QLRCP.Instance.GetPhong(idPhong).TenPhong;
            }
        }

        private void buttonChonPhim_Click(object sender, EventArgs e)
        {
            buttonChonPhim.BackColor = SystemColors.ButtonHighlight;
            buttonChonCaChieu.BackColor = SystemColors.Control;
            buttonChonPhong.BackColor = SystemColors.Control;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView3.DataSource = BLL_QLRCP.Instance.GetAllFilm(0 , DateTime.Now);
        }

        private void buttonChonCaChieu_Click(object sender, EventArgs e)
        {
            buttonChonPhim.BackColor = SystemColors.Control;
            buttonChonCaChieu.BackColor = SystemColors.ButtonHighlight;
            buttonChonPhong.BackColor = SystemColors.Control;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView2.DataSource = BLL_QLRCP.Instance.GetCaChieus();
        }

        private void buttonChonPhong_Click(object sender, EventArgs e)
        {
            buttonChonPhim.BackColor = SystemColors.Control;
            buttonChonCaChieu.BackColor = SystemColors.Control;
            buttonChonPhong.BackColor = SystemColors.ButtonHighlight;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.DataSource = BLL_QLRCP.Instance.GetPhongChieus(-1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxPhim1.Text == "" || textBoxCaChieu1.Text == "" || textBoxPhong1.Text == "")
            {
                MessageBox.Show("Không được để trống các mục");
                return;
            }
            else
            {

                LichChieu lichChieu = new LichChieu();
                string idLichChieu = dataLichChieu.CurrentRow.Cells["id"].Value.ToString();
                lichChieu.id = idLichChieu;
                lichChieu.idPhim = idPhim;
                lichChieu.idPhong = idPhong;
                lichChieu.idCaChieu = idCaCHieu;
                lichChieu.NgayChieu = dateTimePickerNgayChieuEdit.Value.Date;
                QuanLyRapChieuPhimDB db = new QuanLyRapChieuPhimDB();
                int count = db.LichChieux.Where(p => p.id == lichChieu.id && p.NgayChieu == lichChieu.NgayChieu && p.idPhong == lichChieu.idPhong && p.idCaChieu == lichChieu.idCaChieu).Select(p => p).Count();
                if( count != 0)
                {
                    var result = db.LichChieux.SingleOrDefault(b => b.id == lichChieu.id);
                    if (result != null)
                    {
                        if(result.idPhim != lichChieu.idPhim)
                        {
                            MessageBox.Show("Chỉnh sửa thành công");
                        }
                        result.idPhim = lichChieu.idPhim;
                        db.SaveChanges();
                    }
                    return;
                }
                if (BLL_QLRCP.Instance.CheckLichChieu(lichChieu))
                {

                    MessageBox.Show("Lịch chiếu bị trùng lặp");
                    return;
                }
                BLL_QLRCP.Instance.UpdateLichChieu(lichChieu);
                MessageBox.Show("Chỉnh sửa thành công");

            }
        }
    }
}
