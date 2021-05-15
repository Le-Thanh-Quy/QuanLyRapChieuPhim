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
    public partial class FormChonCho : Form
    {
        public string idKhachHang = "";
        public string idPhim = "";
        public DateTime NgayChieu = DateTime.Now.Date;
        public string idGheNgoi = "";
        public int SoVe = 0;
        public int VeFree = 0;
        public FormChonCho(string id , DateTime dateTime , string idUse)
        {
            idKhachHang = idUse;
            idPhim = id;
            NgayChieu = dateTime.Date;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void G1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Gold)
            {
                ((Button)sender).BackColor = SystemColors.Control;
                VeTEXT.Text = VeTEXT.Text.Replace(((Button)sender).Text + " " , "");
                SoVe--;
                textBoxDiemCongThem.Text = SoVe.ToString();
                if (LoaiVe1.Checked == true)
                {
                    textBoxGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                    textBoxTongGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                    textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                }
                else if (LoaiVe2.Checked == true)
                {
                    textBoxGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
                    textBoxTongGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
                    textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
                }
                else
                {
                    textBoxGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
                    textBoxTongGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
                    textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
                }
            }
            else
            {
                ((Button)sender).BackColor = Color.Gold;
                VeTEXT.Text += ((Button)sender).Text + " ";
                SoVe++;
                textBoxDiemCongThem.Text = SoVe.ToString();
                if (LoaiVe1.Checked == true)
                {
                    textBoxGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                    textBoxTongGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                    textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                }
                else if(LoaiVe2.Checked == true)
                {
                    textBoxGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
                    textBoxTongGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
                    textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
                }
                else
                {
                    textBoxGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
                    textBoxTongGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
                    textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
                }
                
            }
        }

        private void FormChonCho_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(130, 40);
            if (BLL_QLRCP.Instance.getKhachHang(idKhachHang).TaiKhoan.LoaiTK == 1)
            {
                groupBoxUse.Enabled = false;
            }
            NameKhachhang.Text = BLL_QLRCP.Instance.getKhachHang(idKhachHang).HoTen;
            textBoxDiemCongThem.Text = "0";
            textBoxDiemTichLuy.Text = BLL_QLRCP.Instance.getKhachHang(idKhachHang).DiemTichLuy.ToString();
            textBoxFreeVe.Text = (BLL_QLRCP.Instance.getKhachHang(idKhachHang).DiemTichLuy / 20).ToString();
            dataGridViewphong.Visible = false;
            Phim phim = BLL_QLRCP.Instance.GetPhim(idPhim);
            pictureBoxAvatar.Image = BLL_QLRCP.Instance.ConvertByteyoImage(phim.ApPhich);
            for (int i = 1; i <= 10; i++)
            {
                var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("A" + i.ToString()));
                button.Enabled = false;
            }
            for (int i = 1; i <= 10; i++)
            {
                var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("B" + i.ToString()));
                button.Enabled = false;
            }
            for (int i = 1; i <= 10; i++)
            {
                var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("C" + i.ToString()));
                button.Enabled = false;
            }
            for (int i = 1; i <= 10; i++)
            {
                var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("E" + i.ToString()));           
                button.Enabled = false;
            }
            for (int i = 1; i <= 10; i++)
            {
                var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("D" + i.ToString()));
                button.Enabled = false;
            }
            for (int i = 1; i <= 10; i++)
            {
                var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("F" + i.ToString()));
                button.Enabled = false;

            }
            for (int i = 1; i <= 10; i++)
            {
                var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("G" + i.ToString()));
                button.Enabled = false;
            }
        }
        private void dataGridViewphong_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridViewphong.Columns["idGheNgoi"].Visible = false;
        }
        private void Ca5_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked == true)
            {
                SoVe = 0;
                VeFree = 0;
                textBoxDiemCongThem.Text = "0";
                textBoxFreeVe.Text = "0";
                textBoxDiscount.Text = "0 VND";
                textBoxGiaVe.Text = "0 VND";
                textBoxTongGiaVe.Text = "0 VND";
                textBoxMoney.Text = "0 VND";
                VeTEXT.Text = "";
                dataGridViewphong.Visible = true;
                dataGridViewphong.DataSource = BLL_QLRCP.Instance.GetGheNgois(idPhim, NgayChieu, ((RadioButton)sender).Name.ToString());
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("A" + i.ToString()));
                    if (button.Visible == false)
                    {
                        button.Visible = true;
                    }
                    button.BackColor = SystemColors.Control;
                    button.Enabled = false;
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("B" + i.ToString()));
                    if (button.Visible == false)
                    {
                        button.Visible = true;
                    }
                    button.BackColor = SystemColors.Control;
                    button.Enabled = false;
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("C" + i.ToString()));
                    if (button.Visible == false)
                    {
                        button.Visible = true;
                    }
                    button.BackColor = SystemColors.Control;
                    button.Enabled = false;
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("E" + i.ToString()));
                    if (button.Visible == false)
                    {
                        button.Visible = true;
                    }
                    button.BackColor = SystemColors.Control;
                    button.Enabled = false;
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("D" + i.ToString()));
                    if (button.Visible == false)
                    {
                        button.Visible = true;
                    }
                    button.BackColor = SystemColors.Control;
                    button.Enabled = false;
                }      
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("F" + i.ToString()));
                    if(button.Visible == false)
                    {
                        button.Visible = true;
                    }
                    button.BackColor = SystemColors.Control;
                    button.Enabled = false;
                   
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("G" + i.ToString()));
                    if (button.Visible == false)
                    {
                        button.Visible = true;
                    }
                    button.BackColor = SystemColors.Control;
                    button.Enabled = false;
                }
            }    
        }

        private void dataGridViewphong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewphong.CurrentRow != null)
            {
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("A" + i.ToString()));
                    button.Enabled = true;
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("B" + i.ToString()));
                    button.Enabled = true;
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("C" + i.ToString()));
                    button.Enabled = true;
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("E" + i.ToString()));
                    button.Enabled = true;
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("D" + i.ToString()));
                    button.Enabled = true;
                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("F" + i.ToString()));
                    button.Enabled = true;

                }
                for (int i = 1; i <= 10; i++)
                {
                    var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("G" + i.ToString()));
                    button.Enabled = true;
                }
                idGheNgoi = dataGridViewphong.CurrentRow.Cells["idGheNgoi"].Value.ToString();
                dataGridViewphong.Visible = false;
                GheNgoi gheNgoi = new GheNgoi();
                gheNgoi = BLL_QLRCP.Instance.GetGheNgoi(idGheNgoi);
                int sochongoi = 70 - gheNgoi.LichChieu.PhongChieu.SoChoNgoi;
                if(sochongoi != 0)
                {
                    if(sochongoi < 11)
                    {
                        for(int i = sochongoi; i >= 1; i--)
                        {
                            var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("G" + i.ToString()));
                            button.Visible = false;
                        }
                    }
                    else 
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == ("G" + i.ToString()));
                            button.Visible = false;
                        }
                        for (int j = sochongoi - 10; j >= 1; j--)
                        {
                            var button1 = Controls.OfType<Button>().FirstOrDefault(p => p.Name == ("F" + j.ToString()));
                            button1.Visible = false;
                        }
                    }

                }
                if (gheNgoi.TrangThai != null)
                {
                    string[] arrGheNgoi = BLL_QLRCP.Instance.TachChuoi(gheNgoi.TrangThai);
                    
                    foreach (string i in arrGheNgoi)
                    {
                        if(i == "")
                        {
                            continue;
                        }
                        var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == i);
                        button.BackColor = Color.Red;
                        button.Enabled = false;       
                    }
                }
               
                
            }
        }

        private void LoaiVe3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                if (((RadioButton)sender).Name == "LoaiVe1") 
                {
                    textBoxGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                    textBoxTongGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                    textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                }
                else if (((RadioButton)sender).Name == "LoaiVe2")
                {
                    textBoxGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
                    textBoxTongGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
                    textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
                }
                else
                {
                    textBoxGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
                    textBoxTongGiaVe.Text = (SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
                    textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
                }

            }
        }

        private void textBoxFreeVe_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFreeVe.Text.Length > 0)
            {
                char a = textBoxFreeVe.Text[textBoxFreeVe.Text.Length - 1];
                
                if (a < '0' || a > '9')
                {
                    textBoxFreeVe.Text = textBoxFreeVe.Text.Remove(textBoxFreeVe.Text.Length - 1, 1);
                    MessageBox.Show("Yêu cầu nhập số");
                    return;
                }
                if (Convert.ToInt32(textBoxFreeVe.Text) > ((BLL_QLRCP.Instance.getKhachHang(idKhachHang).DiemTichLuy + Convert.ToInt32(textBoxDiemCongThem.Text))/20) )
                {
                    MessageBox.Show("Số điểm tích lũy không đủ");
                    textBoxFreeVe.Text = "0";
                }

            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if(textBoxTongGiaVe.Text == "" || textBoxTongGiaVe.Text == "0 VND")
            {
                MessageBox.Show("Vui lọng chọn chỗ ngồi trước khi thanh toán");
               
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn đặt vé!", "Đặt Vé", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GheNgoi gheNgoi = new GheNgoi();
                    gheNgoi = BLL_QLRCP.Instance.GetGheNgoi(idGheNgoi);
                    gheNgoi.TrangThai += VeTEXT.Text;
                    BLL_QLRCP.Instance.SetTrangThaiGheNgoi(gheNgoi);
                    string[] arrGheNgoi = BLL_QLRCP.Instance.TachChuoi(gheNgoi.TrangThai);
                    foreach (string i in arrGheNgoi)
                    {
                        if (i == "")
                        {
                            continue;
                        }
                        var button = Controls.OfType<Button>().FirstOrDefault(b => b.Name == i);
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                    Ve ve = new Ve();
                    ve.id = BLL_QLRCP.Instance.GetIdVe().ToString();
                    ve.idGheNgoi = idGheNgoi;
                    ve.idKhachHang = idKhachHang;
                    if (LoaiVe1.Checked == true)
                    {
                        ve.LoaiVe = 1;
                        ve.TienBanVe = SoVe * BLL_QLRCP.Instance.GetTienVe(1) - VeFree * BLL_QLRCP.Instance.GetTienVe(1);
                    }
                    else if (LoaiVe2.Checked == true)
                    {
                        ve.LoaiVe = 2;
                        ve.TienBanVe = SoVe * BLL_QLRCP.Instance.GetTienVe(2) - VeFree * BLL_QLRCP.Instance.GetTienVe(1);
                    }
                    else
                    {
                        ve.LoaiVe = 3;
                        ve.TienBanVe = SoVe * BLL_QLRCP.Instance.GetTienVe(3) - VeFree * BLL_QLRCP.Instance.GetTienVe(1);
                    }
                    
                    ve.Ghe = VeTEXT.Text;
                    BLL_QLRCP.Instance.AddVe(ve);

                    FormVe formVe = new FormVe(ve.id);
                    formVe.ShowDialog();

                    if (BLL_QLRCP.Instance.getKhachHang(idKhachHang).TaiKhoan.LoaiTK == 1)
                    {

                    }
                    else
                    {
                        BLL_QLRCP.Instance.UpdateKhachHang(idKhachHang, (Convert.ToInt32(textBoxDiemTichLuy.Text) + Convert.ToInt32(textBoxDiemCongThem.Text) - VeFree * 20));
                    }
                    SoVe = 0;
                    VeFree = 0;
                    textBoxDiemTichLuy.Text = BLL_QLRCP.Instance.getKhachHang(idKhachHang).DiemTichLuy.ToString();
                    textBoxDiemCongThem.Text = "0";
                    textBoxFreeVe.Text = "0";
                    textBoxDiscount.Text = "0 VND";
                    textBoxGiaVe.Text = "0 VND";
                    textBoxTongGiaVe.Text = "0 VND";
                    textBoxMoney.Text = "0 VND";
                    VeTEXT.Text = "";                              
                }
            }
        }

        private void bunifuButtonFreeVe_Click(object sender, EventArgs e)
        {
            VeFree = Convert.ToInt32(textBoxFreeVe.Text);
            if (LoaiVe1.Checked == true)
            {               
                textBoxDiscount.Text = (VeFree * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
            }
            else if (LoaiVe2.Checked == true)
            {

                textBoxDiscount.Text = (VeFree * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(2)).ToString() + " VND";
            }
            else
            {
                textBoxDiscount.Text = (VeFree * BLL_QLRCP.Instance.GetTienVe(1)).ToString() + " VND";
                textBoxMoney.Text = (-VeFree*BLL_QLRCP.Instance.GetTienVe(1) + SoVe * BLL_QLRCP.Instance.GetTienVe(3)).ToString() + " VND";
            }
        }
    }
}
