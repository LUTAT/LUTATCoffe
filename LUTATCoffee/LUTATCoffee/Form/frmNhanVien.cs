using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LUTATCoffee.Controller;

namespace LUTATCoffee
{
    public partial class frmNhanVien : Form
    {
        NhanVienController nvCtrl = new NhanVienController();

        public frmNhanVien()
        {
            InitializeComponent();
            HienThiDanhSachNhanVien();
        }

        #region Hiển Thị danh sách loại sản phẩm
        private void HienThiDanhSachNhanVien()
        {
            nvCtrl.HienThiDGV(dgvNhanVien);
            dgvNhanVien.Columns[0].HeaderText = "Mã";
            dgvNhanVien.Columns[0].Width = 50;
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns[3].HeaderText = "CCCD";
            dgvNhanVien.Columns[4].HeaderText = "Ngày Vào Làm";
            dgvNhanVien.Columns[5].HeaderText = "Phân Quyền";
        }
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddNhanVien frm = new frmAddNhanVien();
            frm.Show();
        }
    }
}
