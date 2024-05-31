using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYKHACHSAN.DB_Layer;

namespace QUANLYKHACHSAN.BS_Layer
{
    public class BLHoaDon
    {
        DBMain db = null;
        public BLHoaDon()
        {
            db = new DBMain();
        }

        public DataTable LayHD()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }
        public bool ThemChiTietHoaDon(string MaPhong)
        {

            SqlCommand cmd = new SqlCommand("proc_ThemChiTietHoaDon", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;

            if (cmd.ExecuteNonQuery() > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool XoaKhachHang(string MaPhong)
        {

            SqlCommand cmd = new SqlCommand("proc_xoaKHSauKhiThanhToan", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;

            if (cmd.ExecuteNonQuery() > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public string LayMaKhachHang(string MaPhong)
        {
            string Maphong = "";
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT [dbo].[func_MaPhongTraVeMaKhachHang](@MaPhong)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            var result = cmd.ExecuteScalar();
            Maphong = result.ToString();
            return Maphong;
        }
        public bool ThanhToan(string MaPhong)
        {
            SqlCommand cmd = new SqlCommand("proc_ThanhToan", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            if (cmd.ExecuteNonQuery() > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
