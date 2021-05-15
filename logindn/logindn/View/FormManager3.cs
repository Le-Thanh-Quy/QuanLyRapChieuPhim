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
    public partial class FormManager3 : Form
    {
        public FormManager3()
        {
            InitializeComponent();
        }

        private void FormManager3_Load(object sender, EventArgs e)
        {
            buttonDanhSachPhong.BackColor = SystemColors.ButtonHighlight;
            panelChinhSua.Visible = false;
            panelThemMoi.Visible = false;
            dataPhong.DataSource = BLL_QLRCP.Instance.GetPhongChieus(0);
        }


        private void buttonDanhSachLichChieu_Click(object sender, EventArgs e)
        {
            dataPhong.Enabled = true;
            buttonDanhSachPhong.BackColor = SystemColors.ButtonHighlight;
            buttonThemMoi.BackColor = SystemColors.Control;
            buttonChinhSua.BackColor = SystemColors.Control;
            panelChinhSua.Visible = false;
            panelThemMoi.Visible = false;
            dataPhong.DataSource = BLL_QLRCP.Instance.GetPhongChieus(0);
        }
        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            dataPhong.Enabled = false;
            buttonDanhSachPhong.BackColor = SystemColors.Control;
            buttonThemMoi.BackColor = SystemColors.ButtonHighlight;
            buttonChinhSua.BackColor = SystemColors.Control;
            panelChinhSua.Visible = false;
            panelThemMoi.Visible = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataPhong.CurrentRow != null && buttonDanhSachPhong.BackColor == SystemColors.ButtonHighlight)

            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa phòng trên!", "DELETE", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dataPhong.CurrentRow.Cells["id"].Value.ToString();
                    BLL_QLRCP.Instance.DeletePhong(id);
                    dataPhong.DataSource = BLL_QLRCP.Instance.GetPhongChieus(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    dataPhong.DataSource = BLL_QLRCP.Instance.GetPhongChieus(0);
                }    
            }
           
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            if (dataPhong.CurrentRow != null && buttonDanhSachPhong.BackColor == SystemColors.ButtonHighlight)

            {
                dataPhong.Enabled = false;
                buttonDanhSachPhong.BackColor = SystemColors.Control;
                buttonThemMoi.BackColor = SystemColors.Control;
                buttonChinhSua.BackColor = SystemColors.ButtonHighlight;
                panelChinhSua.Visible = true;
                panelThemMoi.Visible = false;
                PhongChieu phongChieu = BLL_QLRCP.Instance.GetPhong(dataPhong.CurrentRow.Cells["id"].Value.ToString());
                textBox3.Text = phongChieu.TenPhong;
                textBox4.Text = phongChieu.SoChoNgoi.ToString();
                checkBoxTTE.Checked = Convert.ToBoolean(phongChieu.TinhTrang);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Không để trống các mục");
            }
            else if (Convert.ToInt32(textBox2.Text) < 50)
            {
                MessageBox.Show("Tối thiểu phải có 50 ghế trong 1 phòng");
                textBox2.Text = "50";
            }
            else
            {
                PhongChieu phongChieu = new PhongChieu();
                phongChieu.id = BLL_QLRCP.Instance.GetIdPhong().ToString();
                phongChieu.TenPhong = textBox1.Text;
                phongChieu.SoChoNgoi = Convert.ToInt32(textBox2.Text);
                if (checkBoxTT.Checked == true)
                    phongChieu.TinhTrang = 1;
                else
                    phongChieu.TinhTrang = 0;
                BLL_QLRCP.Instance.AddPhong(phongChieu);
                dataPhong.Enabled = true;
                panelThemMoi.Visible = false;
                dataPhong.DataSource = BLL_QLRCP.Instance.GetPhongChieus(0);
                buttonDanhSachPhong.BackColor = SystemColors.ButtonHighlight;
                buttonThemMoi.BackColor = SystemColors.Control;
                textBox1.Text = "";
                textBox2.Text = "";
            }
            
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Không để trống các mục");
            }
            else if (Convert.ToInt32(textBox4.Text) < 50)
            {
                MessageBox.Show("Tối thiểu phải có 50 ghế trong 1 phòng");
                textBox4.Text = "50";
            }
            else
            {
                PhongChieu phongChieu = new PhongChieu();
                phongChieu.id = dataPhong.CurrentRow.Cells["id"].Value.ToString();
                phongChieu.TenPhong = textBox3.Text;
                phongChieu.SoChoNgoi = Convert.ToInt32(textBox4.Text);
                if (checkBoxTTE.Checked == true)
                    phongChieu.TinhTrang = 1;
                else
                    phongChieu.TinhTrang = 0;
                BLL_QLRCP.Instance.UpdatePhong(phongChieu);
                dataPhong.Enabled = true;
                panelChinhSua.Visible = false;
                dataPhong.DataSource = BLL_QLRCP.Instance.GetPhongChieus(0);
                buttonDanhSachPhong.BackColor = SystemColors.ButtonHighlight;
                buttonChinhSua.BackColor = SystemColors.Control;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                char a = textBox2.Text[textBox2.Text.Length - 1];
                if (a < '0' || a > '9')
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
                    MessageBox.Show("Số chỗ bao gồm các chữ số");
                    return;
                }
                if (Convert.ToInt32(textBox2.Text) > 70)
                {
                    MessageBox.Show("Số ghế tối đa là 70");
                    textBox2.Text = "70";
                }
                

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                char a = textBox4.Text[textBox4.Text.Length - 1];
                if (a < '0' || a > '9')
                {
                    textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1, 1);
                    MessageBox.Show("Số chỗ bao gồm các chữ số");
                    return;
                }
                if (Convert.ToInt32(textBox4.Text) > 70)
                {
                    MessageBox.Show("Số ghế tối đa là 70");
                    textBox4.Text = "70";
                }
                

            }
        }

        private void dataPhong_DataSourceChanged(object sender, EventArgs e)
        {
            dataPhong.Columns["LichChieux"].Visible = false;
        }
    }
}
