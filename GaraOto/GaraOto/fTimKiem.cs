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
        BindingSource listXe = new BindingSource();

        public fTimKiem()
        {
            InitializeComponent();            
            load();
        }

        private void load()
        {
            dtgvTìmKiem.DataSource = listXe;
            loadListXe();
            addXeBinding();
            loadPTT();
        }

        public void loadListXe()
        {
            listXe.DataSource = XeDAO.Instance.getListXe();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rbTheoBS.Checked)
            {
                listXe.DataSource = XeDAO.Instance.getListXeByBienSo(txbTimKiem.Text);
            }else
            {
                listXe.DataSource = XeDAO.Instance.getListXeByChuXe(txbTimKiem.Text);                
            }

            loadPTT();                       
        }


        private void addXeBinding() {
            txbBienSo.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "BIENSO"));
            txbChuXe.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "TENCHUXE"));
            txbDate.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "NGAYTIEPNHAN"));
            txbDienThoai.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "DIENTHOAI"));
            txbEmail.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "EMAIL"));
            txbHieuXe.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "HIEUXE"));
            txbTienNo.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "TIENNO"));
            rtbDiaChi.DataBindings.Add(new Binding("Text", dtgvTìmKiem.DataSource, "DIACHI"));
        }

        private void loadPTT() { 
            if (dtgvTìmKiem.RowCount > 1)
            {
                string bs = dtgvTìmKiem.Rows[dtgvTìmKiem.CurrentCell.RowIndex].Cells["BIENSO"].Value.ToString();
                dtgvPThuTien.DataSource = PhieuThuTienDAO.Instance.GetListPhieuThuTienByBS(bs);
            }                       
        }

        private void dtgvTìmKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            loadPTT();
        }
    }
}
