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
    public partial class FormManager : Form
    {
        FormManager1 formManager1 = new FormManager1();
        FormManager2 formManager2 = new FormManager2();
        FormManager3 formManager3 = new FormManager3();
        FormManager4 formManager4 = new FormManager4();

        public FormManager()
        {
            InitializeComponent();
            SetCBBFilm();
        }
        public void SetCBBFilm()
        {
            comboBoxPhim.Items.Add(new CBBItem { Value = "0", Text = "ALL" });
            foreach (Phim i in BLL_QLRCP.Instance.GetAllFilm(0 , DateTime.Now.Date))
            {
                comboBoxPhim.Items.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.TenPhim
                });
               
            }
            comboBoxPhim.SelectedIndex = 0;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelThongKe.Visible = false;
            formManager1.TopLevel = false;
            panelView.Controls.Add(formManager1);
            panelView.Controls.Remove(formManager2);
            panelView.Controls.Remove(formManager3);
            formManager1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formManager1.Dock = DockStyle.Fill;
            formManager1.Show();
           
        }

        private void quảnLýLịchChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelThongKe.Visible = false;
            formManager2.TopLevel = false;
            panelView.Controls.Add(formManager2);
            panelView.Controls.Remove(formManager1);
            panelView.Controls.Remove(formManager3);
            panelView.Controls.Remove(formManager4);
            formManager2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formManager2.Dock = DockStyle.Fill;
            formManager2.Show();
            
        }

        private void quảnLýPhòngChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelThongKe.Visible = false;
            formManager3.TopLevel = false;
            panelView.Controls.Add(formManager3);
            panelView.Controls.Remove(formManager1);
            panelView.Controls.Remove(formManager2);
            panelView.Controls.Remove(formManager4);
            formManager3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formManager3.Dock = DockStyle.Fill;
            formManager3.Show();
        }

        private void quảnLýVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelThongKe.Visible = false;
            formManager4.TopLevel = false;
            panelView.Controls.Add(formManager4);
            panelView.Controls.Remove(formManager1);
            panelView.Controls.Remove(formManager2);
            panelView.Controls.Remove(formManager3);
            formManager4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formManager4.Dock = DockStyle.Fill;
            formManager4.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelThongKe.Visible = true;
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            dataGridViewThongKe.DataSource = BLL_QLRCP.Instance.GetAllVes();
            double TienBanVe = 0;
            foreach (ViewThongKe i in BLL_QLRCP.Instance.GetAllVes())
            {

                string srt = "0";
                    
                foreach (char j in i.TienBanVe)
                {
                    if (j == ' ')
                    {
                        break;
                    }
                    srt += j;
                }
                TienBanVe += Convert.ToDouble(srt);
            }
            textBoxTongDoanhThu.Text = TienBanVe.ToString() + " VND";
            buttonThongKe.Enabled = false; 
            dateTimePickerBD.Enabled = false;
            dateTimePickerKT.Enabled = false;

        }

        private void comboBoxPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxPhim.Text == "ALL")
            {
                dataGridViewThongKe.DataSource = BLL_QLRCP.Instance.GetAllVes();
                double TienBanVe = 0;
                foreach (ViewThongKe i in BLL_QLRCP.Instance.GetAllVes())
                {

                    string srt = "0";

                    foreach (char j in i.TienBanVe)
                    {
                        if (j == ' ')
                        {
                            break;
                        }
                        srt += j;
                    }
                    TienBanVe += Convert.ToDouble(srt);
                }
                buttonThongKe.Enabled = false;
                dateTimePickerBD.Enabled = false;
                dateTimePickerKT.Enabled = false;
                textBoxTongDoanhThu.Text = TienBanVe.ToString() + " VND";

            }
            else
            {
                buttonThongKe.Enabled = true;
                dateTimePickerBD.Enabled = true;
                dateTimePickerKT.Enabled = true;
            }
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            CBBItem index = (CBBItem)comboBoxPhim.SelectedItem;
            string idPhim = index.Value;
            dataGridViewThongKe.DataSource = BLL_QLRCP.Instance.GetVes(idPhim, dateTimePickerBD.Value.Date, dateTimePickerKT.Value.Date);
            double TienBanVe = 0;
            foreach (ViewThongKe i in BLL_QLRCP.Instance.GetVes(idPhim, dateTimePickerBD.Value.Date, dateTimePickerKT.Value.Date))
            {

                string srt = "0";

                foreach (char j in i.TienBanVe)
                {
                    if (j == ' ')
                    {
                        break;
                    }
                    srt += j;
                }
                TienBanVe += Convert.ToDouble(srt);
            }
            textBoxTongDoanhThu.Text = TienBanVe.ToString() + " VND";
        }

        

        private void dateTimePickerKT_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePickerKT.Value.Date < dateTimePickerBD.Value.Date)
            {
                MessageBox.Show("Vui lòng chọn ngày sau ngày bắt đầu");
                dateTimePickerKT.Value = dateTimePickerBD.Value.Date;
            }
        }
    }
}
