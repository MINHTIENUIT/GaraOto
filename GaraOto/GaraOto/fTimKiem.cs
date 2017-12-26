using GaraOto.DAO;
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
    public partial class fTimKiem : Form
    {
        public fTimKiem()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rbTheoBS.Checked)
            {
                dtgvTìmKiem.DataSource = XeDAO.Instance.getListXeByBienSo(txbTimKiem.Text);
            }
            
            if (rbTheoTen.Checked)
            {
                dtgvTìmKiem.DataSource = XeDAO.Instance.getListXeByChuXe(txbTimKiem.Text);
            }
        }
    }
}
