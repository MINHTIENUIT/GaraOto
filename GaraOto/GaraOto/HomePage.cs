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
        }

        int flag = 0;

        public void HienThiDanhSachXe()
        {
            dgvXe.DataSource = listXe;

            listXe.DataSource = DAO.XeMod.FillDataSetXe().Tables[0];
            dgvXe.Dock = DockStyle.Fill;
            dgvXe.BorderStyle = BorderStyle.Fixed3D;
            dgvXe.RowHeadersVisible = false;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            HienThiDanhSachXe();
            dis_end(false);
            bingding();
        }

        void bingding()
        {
            tbBienSo.DataBindings.Clear();
            tbBienSo.DataBindings.Add("Text", dgvXe.DataSource, "BienSo");
            tbChuXe.DataBindings.Clear();
            tbChuXe.DataBindings.Add("Text", dgvXe.DataSource, "TenChuXe");
            cbHieuXe.DataBindings.Clear();
            cbHieuXe.DataBindings.Add("Text", dgvXe.DataSource, "HieuXe");
            txbDiaChi.DataBindings.Clear();
            txbDiaChi.DataBindings.Add("Text", dgvXe.DataSource, "DiaChi");
            txbDienThoai.DataBindings.Clear();
            txbDienThoai.DataBindings.Add("Text", dgvXe.DataSource, "DienThoai");
            dtpNgayTiepNhan.DataBindings.Clear();
            dtpNgayTiepNhan.DataBindings.Add("Text", dgvXe.DataSource, "NgayTiepNhan");
            tbEmail.DataBindings.Clear();
            tbEmail.DataBindings.Add("Text", dgvXe.DataSource, "Email");
        }

        void dis_end(bool e)
        {
            txbDiaChi.Enabled = e;
            cbHieuXe.Enabled = e;
            tbEmail.Enabled = e;
            tbEmail.Enabled = e;
            tbBienSo.Enabled = e;
            tbChuXe.Enabled = e;
            txbDienThoai.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnTiepNhanXe.Enabled = !e;
            btnSuaThongTin.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLapPTT.Enabled = !e;
        }

        void clearData()
        {
            tbBienSo.Clear();
            tbChuXe.Clear();
           
            tbEmail.Clear();
            
            txbDiaChi.Clear();
            
            txbDienThoai.Clear();
        }
        private void btnTiepNhanXe_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          
            string _BienSo = "";
            try
            {
                _BienSo = tbBienSo.Text;
            }
            catch { }

            string _HieuXe = "";
            try
            {
                _HieuXe = cbHieuXe.Text;
            }
            catch { }

            string _TenChuXe = "";
            try
            {
                _TenChuXe = tbChuXe.Text;
            }
            catch { }

            string _DienThoai = "";
            try
            {
                _DienThoai = txbDienThoai.Text;
            }
            catch { }

            string _DiaChi = "";
            try
            {
                _DiaChi = txbDiaChi.Text;
            }
            catch { }

            string _Email = "";
            try
            {
                _Email = tbEmail.Text;
            }
            catch { }

            DateTime _NgayTiepNhan = DateTime.Now;
            try
            {

            }
            catch { }

            if (flag == 0)
            {
                if (_BienSo == "" || _TenChuXe == "")
                    MessageBox.Show("Nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = DTO.XeCtrl.InsertXe(_BienSo, _HieuXe, _TenChuXe, _DienThoai, _DiaChi, _Email, _NgayTiepNhan);
                    if (i == 0)
                    {
                        MessageBox.Show("Đã thêm vào danh sách xe");
                        HienThiDanhSachXe();
                    }
                    else
                    {
                        MessageBox.Show("Thêm xe thất bại");
                    }
                }

            }
            else
            {
                int i = 0;
                i = DTO.XeCtrl.UpdateXe(_BienSo, _HieuXe, _TenChuXe, _DienThoai, _DiaChi, _Email, _NgayTiepNhan);
                if (i == 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    HienThiDanhSachXe();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            HomePage_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HomePage_Load(sender, e);
            dis_end(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _IdXe = "";
            try
            {
                _IdXe = tbBienSo.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = DTO.XeCtrl.DeleteXe(_IdXe);
                if (i == 0)
                {
                    MessageBox.Show("Đã xóa");
                }
                else
                    MessageBox.Show("Xóa không thành công");
                HienThiDanhSachXe();
                HomePage_Load(sender, e);
            }
            else return;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rbBienSo.Checked)
            {
                listXe.DataSource = XeDAO.Instance.getListXeByBienSo(tbTimKiem.Text);
            }
            else
            {
                listXe.DataSource = XeDAO.Instance.getListXeByChuXe(tbTimKiem.Text);
            }
        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            listXe.DataSource = XeDAO.Instance.getListXe();
        }
    }
}
