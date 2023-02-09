using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LUTATCoffee.BUS;

namespace LUTATCoffee.Datalayer
{
    internal class NhanVienData
    {

        DataProvider cls = new DataProvider();

        public DataSet LayDSNV()
        {
            SqlCommand sqlcmd = new SqlCommand("select MaNV, TenNV, SDT, CCCD, NgayVaoLam, TenQuyen from tb_NhanVien, tb_PhanQuyen where tb_NhanVien.PhanQuyen = tb_PhanQuyen.MaQuyen");
            return cls.LayDuLieu(sqlcmd);
        }

        public int Them(NhanVien nv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO tb_NhanVien (MaNV ,TenNV, SDT ,CCCD, NgayVaoLam, PhanQuyen, UserName, PassWord) VALUES (@manv,@tennv,@sdt, @cccd, @ngayvaolam, @phanquyen, @username, @password)";
            cmd.Parameters.Add("manv", SqlDbType.Int).Value = nv.MaNV;
            cmd.Parameters.Add("tennv", SqlDbType.NVarChar).Value = nv.TenNV;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = nv.SDT;
            cmd.Parameters.Add("cccd", SqlDbType.NChar).Value = nv.CCCD;
            cmd.Parameters.Add("ngayvaolam", SqlDbType.Date).Value = nv.NgayVaoLam;
            cmd.Parameters.Add("phanquyen", SqlDbType.Int).Value = nv.PhanQuyen;
            cmd.Parameters.Add("username", SqlDbType.NVarChar).Value = nv.UserName;
            cmd.Parameters.Add("password", SqlDbType.NVarChar).Value = nv.Password;
            return cls.CapNhatDL(cmd);
        }
        public bool KiemTraTenTonTai(string tensp)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from tb_SanPham where TenSP=@tensp";

            cmd.Parameters.Add("tensp", SqlDbType.NVarChar).Value = tensp;

            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }
        public bool KiemTraMaTonTai(string username)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from tb_NhanVien where UserName=@username";

            cmd.Parameters.Add("username", SqlDbType.NVarChar).Value = username;

            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }

    }
}
