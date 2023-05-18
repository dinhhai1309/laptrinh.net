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
    public partial class frmLichDangKy : Form
    {
        public frmLichDangKy()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        private void frmLichDangKy_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string truy_van = "select * from LichDangKy";
            dgvHienThi.DataSource = kn.LayDuLieu(truy_van);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string truy_van = string.Format("select LichDangKy.* from LichDangKy ,PhongMay,LoaiPhong where LichDangKy.MaPM = PhongMay.MaPM and PhongMay.MaLoaiP = LoaiPhong.MaLoaiP and TenLoaiPhong like '%{0}%'",
                txtTimKiem.Text
                );
            dgvHienThi.DataSource = kn.LayDuLieu(truy_van);
        }

        // xóa dữ liệu

        public void ClearText()
        {
            txtMaPhongMay.Text = "";
            txtMaGV.Text = "";
            txtBatDau.Text = "";
            txtKetThuc.Text = "";
            txtNamHoc.Text = "2023";
            txtID.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
            GetData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string truy_van = string.Format("insert into LichDangKy values('{0}','{1}','{2}','{3}',{4},'{5}')",
                txtMaPhongMay.Text,
                txtMaGV.Text,
                txtBatDau.Text,
                txtKetThuc.Text,
                txtNamHoc.Text,
                txtID.Text
                );
            if (kn.ThucThi(truy_van) == true)
            {
                MessageBox.Show("Thêm thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string truy_van = string.Format("update LichDangKy set MaPM ='{1}' , MaGV ='{2}', BatDau = '{3}', KetThuc = '{4}', NamHoc = {5}",
                txtMaPhongMay.Text,
                txtMaGV.Text,
                txtBatDau.Text,
                txtKetThuc.Text,
                txtNamHoc.Text
                );
            if (kn.ThucThi(truy_van) == true)
            {
                MessageBox.Show("Sửa thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string truy_van = string.Format("delete LichDangKy where ID = '{0}'",
                txtID.Text
                );
            if (kn.ThucThi(truy_van) == true)
            {
                MessageBox.Show("Xóa thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
    }
}
