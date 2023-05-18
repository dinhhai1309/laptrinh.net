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
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void lịchĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichDangKy frm = new frmLichDangKy();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe frm = new frmBaoCaoThongKe();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
