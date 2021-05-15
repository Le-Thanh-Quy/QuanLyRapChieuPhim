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
    public partial class FormManager4 : Form
    {
        public int LoaiVe = 0;
        public FormManager4()
        {
            InitializeComponent();
        }

        private void FormManager4_Load(object sender, EventArgs e)
        {
            labelLoaiVe.Visible = false;
            textBoxGia.Enabled = false;
            buttonGia.Enabled = false;
            List<ViewGia> viewGias = new List<ViewGia>();
            foreach (LoaiVe i in BLL_QLRCP.Instance.GetLaoiVes())
            {
                ViewGia viewGia = new ViewGia();
                if(i.LoaiVe1 == 1)
                {
                    viewGia.LoaiVe = "Người Lớn";
                }
                else if( i.LoaiVe1 == 2)
                {
                    viewGia.LoaiVe = "Học Sinh/Sinh Viên";
                }
                else
                {
                    viewGia.LoaiVe = "Trẻ Em";
                }
                viewGia.Gia = i.Gia.ToString();
                viewGias.Add(viewGia);
                
            }
            dataGridViewVe.DataSource = viewGias;
        }

        private void dataGridViewVe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewVe.CurrentRow.Cells["LoaiVe"].Value.ToString() == "Người Lớn")
            {
                LoaiVe = 1;
                labelLoaiVe.Text = "Vé người lớn";
                labelLoaiVe.Visible = true;
            }
            else if(dataGridViewVe.CurrentRow.Cells["LoaiVe"].Value.ToString() == "Trẻ Em")
            {
                LoaiVe = 3;
                labelLoaiVe.Text = "Vé trẻ em";
                labelLoaiVe.Visible = true;
            }
            else
            {
                LoaiVe = 2;
                labelLoaiVe.Text = "Vé học sinh-sinh viên";
                labelLoaiVe.Visible = true;
            }
            textBoxGia.Text = BLL_QLRCP.Instance.GetTienVe(LoaiVe).ToString() + " VND";
            textBoxGia.Enabled = true;
            buttonGia.Enabled = true;
        }

        private void textBoxGia_TextChanged(object sender, EventArgs e)
        {
            
            
            if (textBoxGia.Text.Length > 0)
            {
                char a = textBoxGia.Text[textBoxGia.Text.Length - 1];
                if (a == ' ' || a == 'V' || a == 'N' || a == 'D')
                {
                    return;
                }
                if (a < '0' || a > '9')
                {
                    textBoxGia.Text = textBoxGia.Text.Remove(textBoxGia.Text.Length - 1, 1);
                    MessageBox.Show("Yêu cầu nhập số");
                }
            }
            if (textBoxGia.Text.Length > 6)
            {
                MessageBox.Show("Số tiền quá lớn");
                textBoxGia.Text = "100000";
            }
        }

        private void textBoxGia_Leave(object sender, EventArgs e)
        {
            textBoxGia.Text += " VND";
        }

        private void textBoxGia_Enter(object sender, EventArgs e)
        {
            string srt = textBoxGia.Text;
            textBoxGia.Text = "";
            foreach (char i in srt)
            {
                if (i >= '0' && i <= '9')
                {
                    textBoxGia.Text += i;
                }
            }
        }

        private void buttonGia_Click(object sender, EventArgs e)
        {
            if(textBoxGia.Text == " VND")
            {
                MessageBox.Show("Yêu cầu nhập vào số tiền cho vé");
                return;
            }
            LoaiVe loaiVe = new LoaiVe();
            loaiVe.LoaiVe1 = LoaiVe;
            string srt = textBoxGia.Text;
            textBoxGia.Text = "";
            foreach (char i in srt)
            {
                if (i >= '0' && i <= '9')
                {
                    textBoxGia.Text += i;
                }
            }
            loaiVe.Gia = Convert.ToInt32(textBoxGia.Text);
            BLL_QLRCP.Instance.UpdateGiaVe(loaiVe);
            MessageBox.Show("Cập nhật thành công");
            labelLoaiVe.Visible = false;
            textBoxGia.Enabled = false;
            textBoxGia.Text = "";
            buttonGia.Enabled = false;
            List<ViewGia> viewGias = new List<ViewGia>();
            foreach (LoaiVe i in BLL_QLRCP.Instance.GetLaoiVes())
            {
                ViewGia viewGia = new ViewGia();
                if (i.LoaiVe1 == 1)
                {
                    viewGia.LoaiVe = "Người Lớn";
                }
                else if (i.LoaiVe1 == 2)
                {
                    viewGia.LoaiVe = "Học Sinh/Sinh Viên";
                }
                else
                {
                    viewGia.LoaiVe = "Trẻ Em";
                }
                viewGia.Gia = i.Gia.ToString();
                viewGias.Add(viewGia);

            }
            dataGridViewVe.DataSource = viewGias;
        }
    }
}
