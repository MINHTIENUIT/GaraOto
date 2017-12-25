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
    public partial class fLogin : Form
    {        
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            if (AccountDAO.Instance.Login(username, password)){
                HomePage fHP = new HomePage();
                this.Hide();
                fHP.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
