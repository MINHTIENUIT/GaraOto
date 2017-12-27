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
    public partial class HomePage : Form
    {
        BindingSource listXe = new BindingSource();
        public HomePage()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dgvXe.DataSource = listXe;

            loadListXe();

        }

        public void loadListXe() {
            listXe.DataSource = XeDAO.Instance.getListXe();
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

            btnTiepNhanXe.Enabled = false;
            btnSuaThongTin.Enabled = false;
            btnLapPSC.Enabled = false;
            btnLapPTT.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            tbChuXe.Enabled = true;
            tbEmail.Enabled = true;
            txbDiaChi.Enabled = true;
            txbDienThoai.Enabled = true;

            btnTiepNhanXe.Enabled = false;
            btnSuaThongTin.Enabled = false;
            btnLapPSC.Enabled = false;
            btnLapPTT.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tbBienSo.Clear();
            tbBienSo.Enabled = false;
            tbChuXe.Clear();
            tbChuXe.Enabled = false;
            tbEmail.Clear();
            tbEmail.Enabled = false;
            txbDiaChi.Clear();
            txbDiaChi.Enabled = false;
            txbDienThoai.Clear();
            txbDienThoai.Enabled = false;
            cbHieuXe.Enabled = false;

            btnTiepNhanXe.Enabled = true;
            btnSuaThongTin.Enabled = true;
            btnLapPSC.Enabled = true;
            btnLapPTT.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbBienSo.Clear();
            tbBienSo.Enabled = false;
            tbChuXe.Clear();
            tbChuXe.Enabled = false;
            tbEmail.Clear();
            tbEmail.Enabled = false;
            txbDiaChi.Clear();
            txbDiaChi.Enabled = false;
            txbDienThoai.Clear();
            txbDienThoai.Enabled = false;
            cbHieuXe.Enabled = false;
            btnXoa.Enabled = true;

            btnTiepNhanXe.Enabled = true;
            btnSuaThongTin.Enabled = true;
            btnLapPSC.Enabled = true;
            btnLapPTT.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
    }
}
