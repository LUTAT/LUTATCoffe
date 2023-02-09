using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LUTATCoffee.Datalayer;
namespace LUTATCoffee.Controller
{
    internal class NhanVienController
    {
        NhanVienData nvData = new NhanVienData();
        public void HienThiDGV(DataGridView dgv)
        {
            dgv.DataSource = nvData.LayDSNV().Tables[0];
        }

    }
}
