using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUTATCoffee.BUS
{
    internal class NhanVien
    {

        private int maNV;
        private string tenNV;
        private string sDT;
        private string cCCD;
        private DateTime ngayVaoLam;
        private int phanQuyen;
        private string userName;
        private string password;

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public int PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
