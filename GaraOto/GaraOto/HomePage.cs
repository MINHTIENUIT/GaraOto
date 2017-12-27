using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraOto
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnTiepNhanXe_Click(object sender, EventArgs e)
        {
            tbBienSo.Clear();
            tbBienSo.Enabled = true;
            tbChuXe.Clear();
            tbChuXe.Enabled = true;
            tbEmail.Clear();
            tbEmail.Enabled = true;
            txbDiaChi.Clear();
            txbDiaChi.Enabled = true;
            txbDienThoai.Clear();
            txbDienThoai.Enabled = true;
            cbHieuXe.Enabled = true;
            dtpNgayTiepNhan.Value = DateTime.Now;
        }
    }
}
