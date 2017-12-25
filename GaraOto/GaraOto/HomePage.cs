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

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            pnlPage.Controls.Clear();
            fTiepNhanXe f = new fTiepNhanXe();
            f.TopLevel = false;
            pnlPage.Controls.Add(f);
            f.Show();
        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            pnlPage.Controls.Clear();
            fPhieuSuaChua f = new fPhieuSuaChua();
            f.TopLevel = false;
            pnlPage.Controls.Add(f);
            f.Show();
        }

        private void btnThuTien_Click(object sender, EventArgs e)
        {
            pnlPage.Controls.Clear();
            fPhieuThuTien f = new fPhieuThuTien();
            f.TopLevel = false;
            pnlPage.Controls.Add(f);
            f.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            pnlPage.Controls.Clear();
            fTimKiem f = new fTimKiem();
            f.TopLevel = false;
            pnlPage.Controls.Add(f);
            f.Show();
        }
    }
}
