using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUTATCoffee
{
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
            btnKhuVuc.Checked= true;
            AbrirFormEnPanel(new frmKhuVuc());
        }

        #region sự kiện API
        private void AbrirFormEnPanel(Form form)
        {
            Form[] child = this.MdiChildren;
            foreach (Form childForm in child)
            {
                childForm.Close();
            }
            if (!pnShow.Controls.Contains(form))
            {
                if (pnShow.Controls.Count > 0)
                {
                    pnShow.Controls.Clear();
                }
                form.TopLevel = false;
                pnShow.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
        }
        #endregion

        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmKhuVuc());
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmBan());
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmLoaiHang());
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmThucDon());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmNhaCungCap());
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmKhuyenMai());
        }

        private void btnDonVi_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmDVT());
        }
    }
}
