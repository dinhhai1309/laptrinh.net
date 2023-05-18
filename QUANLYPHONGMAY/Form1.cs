using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYPHONGMAY
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string truy_van = string.Format("select * from Nguoidung where Taikhoan = '{0}' and Matkhau = '{1}'",
                txtTaiKhoan.Text,
                txtMatKhau.Text
                );
            DataTable tb = kn.LayDuLieu(truy_van);
            if (tb.Rows.Count == 1)
            {
                MessageBox.Show("Đăng Nhập Thành Công!");
                frmHeThong frm = new frmHeThong();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại!");
            }

        }


    }
}
