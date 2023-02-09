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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            btnMax.Visible = true;
            btnNormal.Visible = false;
            btnTrangChu.Checked = true;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

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

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmNhanVien());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmDanhMuc());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            btnMax.Visible = true;
            btnNormal.Visible = false;
        }
    }
}
