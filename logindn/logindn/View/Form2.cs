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
    public partial class Form2 : Form
    {
        public string SDT = "";
        public Form2(string SDTs)
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
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(130, 40);
            Show("ALL","");
            individual1.Visible = false;
            label6.Visible = false;
            
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
            if(TheLoai == "ALL")
            {
                bunifuDataGridView1.DataSource = BLL_QLRCP.Instance.GetAllFilm();
            }
            else
            {
                bunifuDataGridView1.DataSource = BLL_QLRCP.Instance.GetListFilm(TheLoai , Ten);
            }
            
        }

        private void bunifuDataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            bunifuDataGridView1.Columns["id"].Visible = false;
            bunifuDataGridView1.Columns["MoTa"].Visible = false;
            bunifuDataGridView1.Columns["ApPhich"].Visible = false;
            bunifuDataGridView1.Columns["TheLoai"].Visible = false;
            bunifuDataGridView1.Columns["TrangThai"].Visible = false;
            bunifuDataGridView1.Columns["idTheLoai"].Visible = false;
            bunifuDataGridView1.Columns["LichChieux"].Visible = false;
            bunifuDataGridView1.Columns["DaoDien"].Visible = false;
            bunifuDataGridView1.Columns["TenPhim"].Width = 250;
            bunifuDataGridView1.Columns["NamSX"].Width = 70;

        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            MessageBox.Show(bunifuDataGridView1.CurrentRow.Cells["TenPhim"].Value.ToString());
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
            }
            else
            {
                individual1.Visible = false;
                label6.Visible = false;
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


    }
}
