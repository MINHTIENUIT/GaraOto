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

        public void loadListXe()
        {
            dtgvTìmKiem.DataSource = XeDAO.Instance.getListXe();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rbTheoBS.Checked)
            {
                dtgvTìmKiem.DataSource = XeDAO.Instance.getListXeByBienSo(txbTimKiem.Text);
            }else
            {
                dtgvTìmKiem.DataSource = XeDAO.Instance.getListXeByChuXe(txbTimKiem.Text);                
            }                       
        }

        private void fTimKiem_Load(object sender, EventArgs e)
        {
            loadListXe();
            addBindingXE();
        }
        private void addBindingXE() {
            txbBienSo.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "BIENSO"));
            txbChuXe.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "TENCHUXE"));
            txbDate.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "NGAYTIEPNHAN"));
            txbDienThoai.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "DIENTHOAI"));
            txbEmail.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "EMAIL"));
            txbHieuXe.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "HIEUXE"));
            txbTienNo.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "TIENNO"));
            rtbDiaChi.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "DIACHI"));
        }
    }
}
