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
    public partial class FormTrailer : Form
    {
        public string idPhim = "";
        public FormTrailer(string id)
        {
            idPhim = id;
            InitializeComponent();
        }

        private void FormTrailer_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(130, 40);
            if (BLL_QLRCP.Instance.GetPhim(idPhim).Trailer != null)
            axWindowsMediaPlayer1.URL =  BLL_QLRCP.Instance.GetPhim(idPhim).Trailer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
            this.Close();
        }
    }
}
