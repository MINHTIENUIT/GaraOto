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
    public partial class fHieuXe : Form
    {
        BindingSource listHieuXe = new BindingSource();
        public fHieuXe()
        {
            InitializeComponent();
            Load();
        }

        public new void Load()
        {
            dgvHieuXe.DataSource = listHieuXe;
            listHieuXe.DataSource = HieuXeDAO.Instance.getListHieuXe();
            tbHieuXe.DataBindings.Add(new Binding("Text", dgvHieuXe.DataSource, "HIEUXE"));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tbHieuXe.Clear();
            tbHieuXe.Enabled = true;

            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hiệu xe " + tbHieuXe.Text + "?", "Thông báo", MessageBoxButtons.OKCancel)
                == System.Windows.Forms.DialogResult.OK) {
                HieuXeDAO.Instance.delHieuXe(tbHieuXe.Text);
                listHieuXe.DataSource = HieuXeDAO.Instance.getListHieuXe();
            };            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {            
            tbHieuXe.Enabled = false;

            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            
            btnThem.Enabled = true;
            btnXoa.Enabled = true;

            if (tbHieuXe.Text != "")
            {
                DataTable numrow = HieuXeDAO.Instance.addHieuXe(tbHieuXe.Text);
                int i = (int) numrow.Rows[0].ItemArray[0];
                if (i == 0)
                {
                    MessageBox.Show("Thêm hiệu xe thành công");
                }
                else
                {
                    MessageBox.Show("Thêm hiệu xe đã tồn tại");
                }           
            }else
            {
                MessageBox.Show("Hiệu xe không để trống");
            }
            listHieuXe.DataSource = HieuXeDAO.Instance.getListHieuXe();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbHieuXe.Enabled = false;

            btnHuy.Enabled = false;
            btnLuu.Enabled = false;            

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
