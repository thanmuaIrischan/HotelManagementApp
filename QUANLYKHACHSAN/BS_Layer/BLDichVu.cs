using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QUANLYKHACHSAN.DB_Layer;
using System.Windows.Forms;

namespace QUANLYKHACHSAN.BS_Layer
{
    public class BLDichVu
    {
        DBMain db = null;
        public BLDichVu()
        {
            db = new DBMain();
        }

        public DataTable LayDanhSachDV()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM v_LayDanhSachDichVu", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }

        public DataTable LayDanhSachHD(string MaPhong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_DangkyDV(@MaPhong)", db.getConnection);
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        public DataTable LayDanhSachPhongDKDV()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_DSPhongDKDV()", db.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        public bool ThemDV(string MaDV, string LoaiDV, string DonViTinh, float GiaDV, ref string err)
        {
            
            SqlCommand cmd = new SqlCommand("proc_InsertDichVuMoi", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDV", SqlDbType.NChar).Value = MaDV;
            cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = LoaiDV;
            cmd.Parameters.Add("@Donvitinh", SqlDbType.NVarChar).Value = DonViTinh;
            cmd.Parameters.Add("@Gia", SqlDbType.Float).Value = GiaDV;

            db.openConnection();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thêm dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thêm dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }

        public bool ThemDV_Phong(string MaPhong, string MaDichVu, int SoLuong, float ThanhTien)
        {
            SqlCommand cmd = new SqlCommand("proc_DangkyDichVu", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            cmd.Parameters.Add("@MaDichVu", SqlDbType.NChar).Value = MaDichVu;
            cmd.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = SoLuong;
            cmd.Parameters.Add("@ThanhTien", SqlDbType.NVarChar).Value = ThanhTien;

            db.openConnection();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thêm dịch vụ phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thêm dịch vụ phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
                return false;
            }
        }

        public bool XoaDV(string MaDV, ref string err)
        {
            SqlCommand cmd = new SqlCommand("proc_xoaDichVu1", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDV", SqlDbType.NChar).Value = MaDV;

            db.openConnection();

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

        public bool CapNhatDV(string MaDV, string TenDV, string Donvitinh, float Gia)
        {
            SqlCommand cmd = new SqlCommand("proc_SuaDichVu", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDV", SqlDbType.NChar).Value = MaDV;
            cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = TenDV;
            cmd.Parameters.Add("@Donvitinh", SqlDbType.NVarChar).Value = Donvitinh;
            cmd.Parameters.Add("@Gia", SqlDbType.Float).Value = Gia;

            db.openConnection();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Cập nhật dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Cập nhật dịch vụ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
                return false;
            }
        }

        public float TongTienDichVu(string MaPhong)
        {
            float TongTien = 0;
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT [dbo].[func_TongPhiDichVu](@MaPhong)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            var result = cmd.ExecuteScalar();
            TongTien = float.Parse(result.ToString());
            return TongTien;
        }

        public bool XoaDangkyDV(string TenDichVu)
        {
            SqlCommand cmd = new SqlCommand("proc_xoaDangkyDV", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDichVu", SqlDbType.NChar).Value = TenDichVu;

            db.openConnection();

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

        public bool HoaDonChiPhi(string MaPhong, float TongChiPhi)
        {
            SqlCommand cmd = new SqlCommand("proc_ChiPhiDV", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            cmd.Parameters.Add("@TongChiPhi", SqlDbType.NVarChar).Value = TongChiPhi;

            db.openConnection();
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
