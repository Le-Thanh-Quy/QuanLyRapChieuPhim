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
    public partial class FormUse : Form
    {
        public string SDT = "";
        public FormUse(string SDTs)
        {
            SDT = SDTs;
            
            InitializeComponent();
            
            SetCBBFilm();
        }
        public void SetCBBFilm()
        {
            cbbFilm.Items.Add(new CBBItem { Value = "0", Text = "ALL" });
            foreach (TheLoai i in BLL_QLRCP.Instance.GetListGenre())
            {
                cbbFilm.Items.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.TenTheLoai
                });
            }
            cbbFilm.SelectedIndex = 0;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (BLL_QLRCP.Instance.GetTaiKhoan(SDT).LoaiTK == 1)
                label2.Text = "Danh sách vé hôm nay";
            dataGridViewLichSuMua.Visible = false;
            List<DateTime> lichChieus = BLL_QLRCP.Instance.GetLichChieuTheoNgays();
            foreach (DateTime i in lichChieus)
            {
                if (i.Date == DateTime.Now.Date)
                {
                    comboBoxNgayChieu.Items.Add("Hôm nay");
                }
                else
                {
                    comboBoxNgayChieu.Items.Add(i.Month + "-" + i.Day + "-" + i.Year);
                }
                comboBoxNgayChieu.SelectedIndex = 0;
            }
            
            this.SetDesktopLocation(130, 40);
            Show("ALL", "");
            individual1.Visible = false;
            label6.Visible = false;
            label2.Visible = false;


        }

        private void bunifuPictureBox1_MouseHover(object sender, EventArgs e)
        {
            lbname.Text = BLL_QLRCP.Instance.getInforUse(SDT).HoTen;
        }

        private void bunifuPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lbname.Text = "";
        }
        public void Show(string TheLoai , string Ten)
        {
            DateTime dateTime = new DateTime();
            if (comboBoxNgayChieu.Text == "Hôm nay")
            {

                dateTime = DateTime.Now.Date;
            }
            else
            {
                dateTime = Convert.ToDateTime(comboBoxNgayChieu.SelectedItem).Date;
            }
            if (TheLoai == "ALL")
            {                

                DataGridViewFilm.DataSource = BLL_QLRCP.Instance.GetAllFilm(1 , dateTime.Date);
            }
            else
            {
                DataGridViewFilm.DataSource = BLL_QLRCP.Instance.GetListFilm(TheLoai , Ten , 1 , dateTime.Date);
            }
            
        }

        private void bunifuDataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridViewFilm.Columns["id"].Visible = false;
            DataGridViewFilm.Columns["MoTa"].Visible = false;
            DataGridViewFilm.Columns["ApPhich"].Visible = false;
            DataGridViewFilm.Columns["TheLoai"].Visible = false;
            DataGridViewFilm.Columns["idTheLoai"].Visible = false;
            DataGridViewFilm.Columns["LichChieux"].Visible = false;
            DataGridViewFilm.Columns["Trailer"].Visible = false;           
            DataGridViewFilm.Columns["HangPhim"].Visible = false;
            DataGridViewFilm.Columns["DienVien"].Visible = false;
            DataGridViewFilm.Columns["ThoiLuong"].Width = 85;
            DataGridViewFilm.Columns["TenPhim"].Width = 210;
            DataGridViewFilm.Columns["NgayCongChieu"].Width = 130;

        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dateTime = new DateTime();
            if (comboBoxNgayChieu.Text == "Hôm nay")
            {

                dateTime = DateTime.Now.Date;
            }
            else
            {
                dateTime = Convert.ToDateTime(comboBoxNgayChieu.SelectedItem).Date;
            }
            string idPhim = DataGridViewFilm.CurrentRow.Cells["id"].Value.ToString();
            this.Hide();
            FormTLFilm formTLFilm = new FormTLFilm(idPhim , dateTime.Date , BLL_QLRCP.Instance.getInforUse(SDT).id);
            formTLFilm.ShowDialog();
            this.Show();
        }

        private void cbbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string check = cbbFilm.SelectedItem.ToString();
            Show(check, "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string check = textBox1.Text;
            Show("", check);
        }
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            individual1.SetDB(SDT);
            if (individual1.Visible == false)
            {
                individual1.Visible = true;
                label6.Visible = true;
                label2.Visible = true;
            }
            else
            {
                individual1.Visible = false;
                label6.Visible = false;
                label2.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = SystemColors.HotTrack;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = SystemColors.Control;
        }

        private void comboBoxNgayChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show(cbbFilm.Text , "");
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = SystemColors.HotTrack;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = SystemColors.Control;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (dataGridViewLichSuMua.Visible == false)
            {
                if (BLL_QLRCP.Instance.GetTaiKhoan(SDT).LoaiTK == 1)
                {
                    textBoxSearch.Visible = true;
                    textBoxSDT.Visible = true;
                }
                    
                dataGridViewLichSuMua.Visible = true;
                dataGridViewLichSuMua.DataSource = BLL_QLRCP.Instance.GetVes(BLL_QLRCP.Instance.getInforUse(SDT).id);
            }
            else
            {
                dataGridViewLichSuMua.Visible = false;
                textBoxSearch.Visible = false;
                textBoxSDT.Visible = false;
            }
           
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<ViewVe> viewVes = new List<ViewVe>();
            foreach (ViewVe i in BLL_QLRCP.Instance.GetVes(BLL_QLRCP.Instance.getInforUse(SDT).id))
            {
                if (i.id.ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
                {
                    viewVes.Add(i);
                }
            }
            dataGridViewLichSuMua.DataSource = viewVes;
        }

        private void textBoxSDT_TextChanged(object sender, EventArgs e)
        {
            List<ViewVe> viewVes = new List<ViewVe>();
            foreach (ViewVe i in BLL_QLRCP.Instance.GetVes(BLL_QLRCP.Instance.getInforUse(SDT).id))
            {
                if (i.SDT.ToString().ToLower().Contains(textBoxSDT.Text.ToLower()))
                {
                    viewVes.Add(i);
                }
            }
            dataGridViewLichSuMua.DataSource = viewVes;
        }

        private void dataGridViewLichSuMua_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewLichSuMua.CurrentRow != null)
            {
                FormVe formVe = new FormVe(dataGridViewLichSuMua.CurrentRow.Cells["id"].Value.ToString());
                formVe.ShowDialog();
                
                
            }
        }
    }
}
