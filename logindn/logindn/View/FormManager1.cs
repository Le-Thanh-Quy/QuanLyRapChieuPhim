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
    public partial class FormManager1 : Form
    {
        public string idPhim = "";
        public FormManager1()
        {
            InitializeComponent();
            SetCBBFilm();
        }
        public void SetCBBFilm()
        {
            comboBox1.Items.Add(new CBBItem { Value = "0", Text = "ALL" });
            foreach (TheLoai i in BLL_QLRCP.Instance.GetListGenre())
            {
                comboBox1.Items.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.TenTheLoai
                });
                comboBoxTL.Items.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.TenTheLoai
                });
                comboBoxTheLoai.Items.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.TenTheLoai
                });
            }
            comboBox1.SelectedIndex = 0;
            comboBoxTL.SelectedIndex = 0;
            comboBoxTheLoai.SelectedIndex = 0;

        }
        private void buttonDanhSachPhim_Click(object sender, EventArgs e)
        {
            if (panelDanhSachPhim.Visible == false)
            {

                panelDanhSachPhim.Visible = true;
                panelChinhSua.Visible = false;
                panelAddPhim.Visible = false;
                panelTheLoai.Visible = false;
                buttonTheLoai.BackColor = SystemColors.Control;
                buttonThemMoi.BackColor = SystemColors.Control;
                buttonChinhSua.BackColor = SystemColors.Control;
                buttonDanhSachPhim.BackColor = SystemColors.ButtonHighlight;
                DataGridViewFilm.DataSource = BLL_QLRCP.Instance.GetAllFilm(0 , DateTime.Now);
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            
            if ( textBoxDaoDien.Text == "" || textBoxHangPhim.Text == "" || textBoxTenPhim.Text == "" || richTextBoxDienVien.Text == "" || richTextBoxMoTa.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Không để trống các mục");
                return;
            }
            try
            {
                Phim phim = new Phim();
                phim.id = (BLL_QLRCP.Instance.GetIdPhim() + 1).ToString();
                CBBItem cBBItem = (CBBItem)comboBoxTheLoai.SelectedItem;
                phim.idTheLoai = cBBItem.Value;
                phim.MoTa = richTextBoxMoTa.Text;
                phim.NgayCongChieu = dateTimePickerNgayCongChieu.Value.Date;
                phim.HangPhim = textBoxHangPhim.Text;
                phim.TenPhim = textBoxTenPhim.Text;
                phim.DienVien = richTextBoxDienVien.Text;
                phim.Trailer = textBox1.Text;
                string thoiluong = "";
                foreach (char i in textBoxThoiLuong.Text)
                {
                    if (i >= '0' && i <= '9')
                    {
                        thoiluong += i;
                    }
                }
                phim.ThoiLuong = Convert.ToDouble(thoiluong);
                phim.DaoDien = textBoxDaoDien.Text;
                phim.ApPhich = BLL_QLRCP.Instance.ConvertFilltoByte(booster.ImageLocation);

                if (BLL_QLRCP.Instance.CheckPhim(phim))
                {
                    textBoxTenPhim.Text = "";
                    textBoxHangPhim.Text = "";
                    textBoxDaoDien.Text = "";
                    textBoxThoiLuong.Text = "";
                    richTextBoxDienVien.Text = "";
                    richTextBoxMoTa.Text = "";
                    textBox1.Text = "";
                    comboBoxTheLoai.SelectedIndex = 0;
                    booster.Image = null;
                    MessageBox.Show("Phim đã tồn tại");
                    return;
                }
                BLL_QLRCP.Instance.AddPhim(phim);
                textBoxTenPhim.Text = "";
                textBoxHangPhim.Text = "";
                textBoxDaoDien.Text = "";
                textBoxThoiLuong.Text = "";
                richTextBoxDienVien.Text = "";
                textBox1.Text = "";
                richTextBoxMoTa.Text = "";
                comboBoxTheLoai.SelectedIndex = 0;
                booster.Image = null;
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không để trống các mục!");
            }

        }

        private void booster_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn ảnh booster";
            openFile.Filter = "JPG|*.jpg|PNG|*png|GIF|*.gif|ALL|*";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                booster.ImageLocation = openFile.FileName;
            }
        }
        private void pictureBoxBooster_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn ảnh booster";
            openFile.Filter = "JPG|*.jpg|PNG|*png|GIF|*.gif|ALL|*";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBoxBooster.ImageLocation = openFile.FileName;
            }
        }
        private void dateTimePickerNgayCongChieu_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerNgayCongChieu.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày Công Chiếu phải là ngày hôm nay trở đi");
                dateTimePickerNgayCongChieu.Value = DateTime.Now;
            }
        }

        private void richTextBoxDienVien_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxDienVien.Text.Length >= 99)
            {
                richTextBoxDienVien.Text = richTextBoxDienVien.Text.Remove(richTextBoxDienVien.Text.Length - 1, 1);
                MessageBox.Show("Tối đi chỉ bao gồm 100 ký tự");
            }
            if (richTextBoxDV.Text.Length >= 99)
            {
                richTextBoxDV.Text = richTextBoxDV.Text.Remove(richTextBoxDV.Text.Length - 1, 1);
                MessageBox.Show("Tối đi chỉ bao gồm 100 ký tự");
            }
        }



        private void textBoxThoiLuong_TextChanged(object sender, EventArgs e)
        {
            if (textBoxThoiLuong.Text.Length > 0)
            {
                char a = textBoxThoiLuong.Text[textBoxThoiLuong.Text.Length - 1];
                if (a == ' ' || a == 'P' || a == 'h' || a == 'ú' || a == 't')
                {
                    return;
                }
                if (a < '0' || a > '9')
                {
                    textBoxThoiLuong.Text = textBoxThoiLuong.Text.Remove(textBoxThoiLuong.Text.Length - 1, 1);
                    MessageBox.Show("Yêu cầu nhập số");
                }
            }
            if (textBoxTL.Text.Length > 0)
            {
                char a = textBoxTL.Text[textBoxTL.Text.Length - 1];
                if (a == ' ' || a == 'P' || a == 'h' || a == 'ú' || a == 't')
                {
                    return;
                }
                if (a < '0' || a > '9')
                {
                    textBoxTL.Text = textBoxTL.Text.Remove(textBoxTL.Text.Length - 1, 1);
                    MessageBox.Show("Yêu cầu nhập số");
                }
            }
        }

        private void FormManager1_Load(object sender, EventArgs e)
        {
            buttonThemTL.Visible = false;
            buttonChinhSuaTheLoai.Enabled = false;
            panelTheLoai.Visible = false;
            panelChinhSua.Visible = false;
            panelAddPhim.Visible = false;
            buttonDanhSachPhim.BackColor = SystemColors.ButtonHighlight;
            DataGridViewFilm.DataSource = BLL_QLRCP.Instance.GetAllFilm(0 , DateTime.Now);
            dataGridViewTheLoai.DataSource = BLL_QLRCP.Instance.GetListGenre();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            if (panelAddPhim.Visible == false)
            {
                panelTheLoai.Visible = false;
                buttonTheLoai.BackColor = SystemColors.Control;
                panelDanhSachPhim.Visible = false;
                panelChinhSua.Visible = false;
                panelAddPhim.Visible = true;
                buttonThemMoi.BackColor = SystemColors.ButtonHighlight;
                buttonChinhSua.BackColor = SystemColors.Control;
                buttonDanhSachPhim.BackColor = SystemColors.Control;
            }
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            if (panelChinhSua.Visible == true) return;
            if (DataGridViewFilm.CurrentRow != null && panelDanhSachPhim.Visible == true)
            {
                if (panelChinhSua.Visible == false)
                {
                    panelTheLoai.Visible = false;
                    buttonTheLoai.BackColor = SystemColors.Control;
                    panelDanhSachPhim.Visible = false;
                    panelChinhSua.Visible = true;
                    panelAddPhim.Visible = false;
                    buttonThemMoi.BackColor = SystemColors.Control;
                    buttonChinhSua.BackColor = SystemColors.ButtonHighlight;
                    buttonDanhSachPhim.BackColor = SystemColors.Control;
                    idPhim = DataGridViewFilm.CurrentRow.Cells["id"].Value.ToString();
                    Phim phim = BLL_QLRCP.Instance.GetPhim(idPhim);
                    textBoxDD.Text = phim.DaoDien;
                    textBoxTrailer.Text = phim.Trailer;
                    textBoxName.Text = phim.TenPhim;
                    textBoxHang.Text = phim.HangPhim;
                    richTextBoxDV.Text = phim.DienVien;
                    richTextBoxMT.Text = phim.MoTa;
                    dateTimePickerNCC.Value = phim.NgayCongChieu;
                    textBoxTL.Text = phim.ThoiLuong.ToString() + " Phút";
                    comboBoxTL.Text = phim.TheLoai.TenTheLoai;
                    pictureBoxBooster.Image = BLL_QLRCP.Instance.ConvertByteyoImage(phim.ApPhich);
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phim muốn chỉnh sửa");
            }
            
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
           
            if (DataGridViewFilm.CurrentRow != null && panelDanhSachPhim.Visible == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa thể loại phim trên!", "DELETE", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = DataGridViewFilm.CurrentRow.Cells["id"].Value.ToString();
                    BLL_QLRCP.Instance.DeletePhim(id);
                    DataGridViewFilm.DataSource = BLL_QLRCP.Instance.GetAllFilm(0 , DateTime.Now);


                }
                else if (dialogResult == DialogResult.No)
                {
                    DataGridViewFilm.DataSource = BLL_QLRCP.Instance.GetAllFilm(0 , DateTime.Now);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phim muốn xóa");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theloai = comboBox1.SelectedItem.ToString();
            if (theloai == "ALL")
            {
                DataGridViewFilm.DataSource = BLL_QLRCP.Instance.GetAllFilm(0 , DateTime.Now);
            }
            else
            {
                DataGridViewFilm.DataSource = BLL_QLRCP.Instance.GetListFilm(theloai, "" , 0 , DateTime.Now);
            }
        }

        private void textBoxThoiLuong_Leave(object sender, EventArgs e)
        {
            textBoxThoiLuong.Text += " Phút";
            textBoxTL.Text += " Phút";
        }

        private void textBoxThoiLuong_Enter(object sender, EventArgs e)
        {
            string srt = textBoxThoiLuong.Text;
            textBoxThoiLuong.Text = "";
            foreach (char i in srt)
            {
                if (i >= '0' && i <= '9')
                {
                    textBoxThoiLuong.Text += i;
                }
            }
            string srt1 = textBoxTL.Text;
            textBoxTL.Text = "";
            foreach (char i in srt1)
            {
                if (i >= '0' && i <= '9')
                {
                    textBoxTL.Text += i;
                }
            }
        }

        private void DataGridViewFilm_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridViewFilm.Columns["TheLoai"].Visible = false;
            DataGridViewFilm.Columns["LichChieux"].Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataGridViewFilm.DataSource = BLL_QLRCP.Instance.GetListFilm("", textBox2.Text , 0 , DateTime.Now);
        }

        private void textBoxTenPhim_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTenPhim.Text.Length > 99)
            {
                char a = textBoxTenPhim.Text[textBoxTenPhim.Text.Length - 1];

                textBoxTenPhim.Text = textBoxTenPhim.Text.Remove(textBoxTenPhim.Text.Length - 1, 1);
                MessageBox.Show("Tối đa gồm 100 ký tự");

            }
            if (textBoxName.Text.Length > 99)
            {
                char a = textBoxName.Text[textBoxName.Text.Length - 1];

                textBoxName.Text = textBoxName.Text.Remove(textBoxName.Text.Length - 1, 1);
                MessageBox.Show("Tối đa gồm 100 ký tự");

            }
        }

        private void textBoxHangPhim_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHangPhim.Text.Length > 49)
            {
                char a = textBoxHangPhim.Text[textBoxHangPhim.Text.Length - 1];

                textBoxHangPhim.Text = textBoxHangPhim.Text.Remove(textBoxHangPhim.Text.Length - 1, 1);
                MessageBox.Show("Tối đa gồm 50 ký tự");

            }
            if (textBoxHang.Text.Length > 49)
            {
                char a = textBoxHang.Text[textBoxHang.Text.Length - 1];

                textBoxHang.Text = textBoxHang.Text.Remove(textBoxHang.Text.Length - 1, 1);
                MessageBox.Show("Tối đa gồm 50 ký tự");

            }
        }

        private void textBoxDaoDien_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDaoDien.Text.Length > 99)
            {
                char a = textBoxDaoDien.Text[textBoxDaoDien.Text.Length - 1];

                textBoxDaoDien.Text = textBoxDaoDien.Text.Remove(textBoxDaoDien.Text.Length - 1, 1);
                MessageBox.Show("Tối đa gồm 100 ký tự");

            }
            if (textBoxDD.Text.Length > 99)
            {
                char a = textBoxDD.Text[textBoxDD.Text.Length - 1];

                textBoxDD.Text = textBoxDD.Text.Remove(textBoxDD.Text.Length - 1, 1);
                MessageBox.Show("Tối đa gồm 100 ký tự");

            }
        }

        private void buttonUpadte_Click(object sender, EventArgs e)
        {
            if (textBoxDD.Text == "" || textBoxHang.Text == "" || textBoxName.Text == "" || richTextBoxDV.Text == "" || richTextBoxMT.Text == "" || textBoxTrailer.Text == "")
            {
                MessageBox.Show("Không để trống các mục");
                return;
            }
            try
           {
                Phim phim = new Phim();
                phim.id = idPhim;
                CBBItem cBBItem = (CBBItem)comboBoxTL.SelectedItem;
                phim.idTheLoai = cBBItem.Value;
                phim.MoTa = richTextBoxMT.Text;
                phim.NgayCongChieu = dateTimePickerNCC.Value.Date;
                phim.HangPhim = textBoxHang.Text;
                phim.TenPhim = textBoxName.Text;
                phim.DienVien = richTextBoxDV.Text;
                phim.Trailer = textBoxTrailer.Text;
                string thoiluong = "";
                foreach (char i in textBoxTL.Text)
                {
                    if (i >= '0' && i <= '9')
                    {
                        thoiluong += i;
                    }
                }
                phim.ThoiLuong = Convert.ToDouble(thoiluong);
                phim.DaoDien = textBoxDD.Text;
                if (pictureBoxBooster.ImageLocation != null)
                phim.ApPhich = BLL_QLRCP.Instance.ConvertFilltoByte(pictureBoxBooster.ImageLocation);
                

                BLL_QLRCP.Instance.UpdatePhim(phim);
                
                MessageBox.Show("Chỉnh sửa thành công");
            }
            catch (Exception error)
            {
                MessageBox.Show("Không để trống các mục!");
            }
        }

        private void buttonTheLoai_Click(object sender, EventArgs e)
        {
            if(panelTheLoai.Visible == false)
            {
                panelTheLoai.Visible = true;
                buttonTheLoai.BackColor = SystemColors.ButtonHighlight;
                panelDanhSachPhim.Visible = false;
                panelChinhSua.Visible = false;
                panelAddPhim.Visible = false;
                buttonThemMoi.BackColor = SystemColors.Control;
                buttonChinhSua.BackColor = SystemColors.Control;
                buttonDanhSachPhim.BackColor = SystemColors.Control;
            }
           
        }

        private void dataGridViewTheLoai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewTheLoai.CurrentRow != null)
            {
                textBoxTenTheLoai.Text = dataGridViewTheLoai.CurrentRow.Cells["TenTheLoai"].Value.ToString();
                richTextBoxMoTaTheLoai.Text = dataGridViewTheLoai.CurrentRow.Cells["MoTa"].Value.ToString();
                buttonThemTheLoai.Visible = false;
                buttonThemTL.Visible = true;
                buttonChinhSuaTheLoai.Enabled = true;
            }
        }

        private void buttonThemTheLoai_Click(object sender, EventArgs e)
        {
            if(textBoxTenTheLoai.Text == "" || richTextBoxMoTaTheLoai.Text == "")
            {
                MessageBox.Show("Không được để trống các mục");
                return;
            }
            else
            {
                TheLoai theLoai = new TheLoai();
                theLoai.id = BLL_QLRCP.Instance.GetIdTheLoai().ToString();
                theLoai.TenTheLoai = textBoxTenTheLoai.Text;
                theLoai.MoTa = richTextBoxMoTaTheLoai.Text;
                BLL_QLRCP.Instance.AddTheLoai(theLoai);
                MessageBox.Show("Thêm thành công");
                dataGridViewTheLoai.DataSource = BLL_QLRCP.Instance.GetListGenre();
                comboBox1.Items.Add(new CBBItem
                {
                    Value = theLoai.id,
                    Text = theLoai.TenTheLoai
                });
                comboBoxTL.Items.Add(new CBBItem
                {
                    Value = theLoai.id,
                    Text = theLoai.TenTheLoai
                });
                comboBoxTheLoai.Items.Add(new CBBItem
                {
                    Value = theLoai.id,
                    Text = theLoai.TenTheLoai
                });
            }
        }

        private void buttonThemTL_Click(object sender, EventArgs e)
        {
            textBoxTenTheLoai.Text = "";
            richTextBoxMoTaTheLoai.Text = "";
            buttonThemTheLoai.Visible = true;
            buttonThemTL.Visible = false;
            buttonChinhSuaTheLoai.Enabled = false;
        }

        private void buttonChinhSuaTheLoai_Click(object sender, EventArgs e)
        {
            if (textBoxTenTheLoai.Text == "" || richTextBoxMoTaTheLoai.Text == "")
            {
                MessageBox.Show("Không được để trống các mục");
                return;
            }
            else
            {
                string id = dataGridViewTheLoai.CurrentRow.Cells["id"].Value.ToString();
                TheLoai theLoai = new TheLoai();
                theLoai.id = id;
                theLoai.TenTheLoai = textBoxTenTheLoai.Text;
                theLoai.MoTa = richTextBoxMoTaTheLoai.Text;
                BLL_QLRCP.Instance.UpdateTheLoai(theLoai);
                MessageBox.Show("Chỉnh sửa thành công");
                dataGridViewTheLoai.DataSource = BLL_QLRCP.Instance.GetListGenre();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridViewTheLoai.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa phim trên!", "DELETE", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dataGridViewTheLoai.CurrentRow.Cells["id"].Value.ToString();
                    BLL_QLRCP.Instance.DeleteTheLoai(id);
                    dataGridViewTheLoai.DataSource = BLL_QLRCP.Instance.GetListGenre();
                }
                else if (dialogResult == DialogResult.No)
                {
                    dataGridViewTheLoai.DataSource = BLL_QLRCP.Instance.GetListGenre();
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn video trailer";
            openFile.Filter = "MP4|*.mp4|WAV|*wav|MOV|*.mov|WMV|*.wmv|MPG|*.mpg|ALL|*";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFile.FileName;
            }
        }

        private void buttonTraiLer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn video trailer";
            openFile.Filter = "MP4|*.mp4|WAV|*wav|MOV|*.mov|WMV|*.wmv|MPG|*.mpg|ALL|*";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTrailer.Text = openFile.FileName;
            }
        }
    }
}
