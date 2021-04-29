using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logindn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetData();
        }
        public void SetData()
        {
            lg1.Phone = "Phone";
            lg1.Password = "Password";
        }
    }
}
