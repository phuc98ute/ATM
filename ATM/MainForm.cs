using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            lblHienThongTin.Text = "Dang rut tien! ok";
        }

        private void btnGuiTien_Click(object sender, EventArgs e)
        {

        }
    }
}
