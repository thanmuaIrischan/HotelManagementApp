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
    public class BLPhong
    {
        DBMain db = null;

        public string MaPhong;
        public string LoaiPhong;
        public string Trangthai;

        public BLPhong()
        {
            db = new DBMain();
        }

        public DataTable LayDanhSachP()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM V_DSPhong", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }

        public DataTable LayDanhSachLP()
        {
            SqlCommand cmd = new SqlCommand("SELECT *FROM LOAIPHONG", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }

        public DataTable LayDanhSachBangGia()
        {
            SqlCommand cmd = new SqlCommand("SELECT *FROM BANGGIA", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }

        public bool XoaP(string MaPhong, ref string err)
        {
            SqlCommand command = new SqlCommand("proc_xoaPhong", db.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            db.openConnection();
            if (command.ExecuteNonQuery() > 0)
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

        public bool ThemPhong(string MaPhong, string LoaiPhong)
        {

            SqlCommand cmd = new SqlCommand("proc_ThemPhong", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            cmd.Parameters.Add("@LoaiPhong", SqlDbType.NChar).Value = LoaiPhong;
            cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = "Trong";
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

        public bool CapnhatP(string MaPhong, string MaLoaiPhong, string TrangThai)
        {
            SqlCommand cmd = new SqlCommand("proc_SuaPhong", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            cmd.Parameters.Add("@LoaiPhong", SqlDbType.NChar).Value = MaLoaiPhong;
            cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = TrangThai;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Cập nhật phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Cập nhật phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }

        public bool XoaLP(string MaLoaiPhong, ref string err)
        {
            SqlCommand command = new SqlCommand("proc_XoaLoaiPhong", db.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiPhong", SqlDbType.NChar).Value = MaLoaiPhong;
            db.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                db.closeConnection();
                return false;
            }
            else
            {
                db.closeConnection();
                return true;
            }
        }

        public DataTable DanhSachDatPhong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHangDatTruoc", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }

        public DataTable DanhSachDangThue()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHangDaThue", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }

        public DataTable DanhSachTaoSoDoPhong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[func_DSSoDoPhong]()", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool CapnhatDanhSachDatPhongTruoc(string MaKH, string TenKH, string Quoctich, string SoCCCD, string SDT, string LoaiKH, DateTime NgayDatPhong, int SoLuongPhong, string MaPhong, DateTime Ngayden, DateTime Ngaydi, int Songuoio, float TraTruoc, float GiaPhong, string GhiChu)
        {
            SqlCommand cmd = new SqlCommand("proc_SuaDanhSachDatPhongTruoc", db.getConnection); 
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = MaKH;
            cmd.Parameters.Add("@TenKH", SqlDbType.NChar).Value = TenKH;
            cmd.Parameters.Add("@Quoctich", SqlDbType.NChar).Value = Quoctich;
            cmd.Parameters.Add("@SoCCCD", SqlDbType.NVarChar).Value = SoCCCD;
            cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = SDT;
            cmd.Parameters.Add("@LoaiKH", SqlDbType.NChar).Value = LoaiKH;
            cmd.Parameters.Add("@NgayDatPhong", SqlDbType.DateTime).Value = NgayDatPhong;
            cmd.Parameters.Add("@SoLuongPhong", SqlDbType.Int).Value = SoLuongPhong;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            cmd.Parameters.Add("@Ngayden", SqlDbType.DateTime).Value = Ngayden;
            cmd.Parameters.Add("@Ngaydi", SqlDbType.DateTime).Value = Ngaydi;
            cmd.Parameters.Add("@Songuoio", SqlDbType.Int).Value = Songuoio;
            cmd.Parameters.Add("@TraTruoc", SqlDbType.Float).Value = TraTruoc;
            cmd.Parameters.Add("@GiaPhong", SqlDbType.Float).Value = GiaPhong;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = GhiChu;
            if (cmd.ExecuteNonQuery() > 0)
            {
                db.closeConnection();
                MessageBox.Show("Cập nhật thành công!", "", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                return true;
            }
            else
            {
                db.closeConnection();
                MessageBox.Show("Cập nhật thất bại", "", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable LayThongTinSuaPhong(string MaKH)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [TraVeThongTinDatPhong](@MaKH)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }
        public DataTable LayThongTinTraPhongKhachHang(string maphong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[func_LayThongTinTraPhongKhachHang](@MaPhong)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaPhong", maphong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable LayThongTinTraPhongPhieuDangKy(string maphong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[func_LayThongTinTraPhongPhieuDangKy](@MaPhong)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaPhong", maphong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }
        public DataTable LayThongTinTraPhongDichVu(string maphong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[func_LayThongTinTraPhongDichVu](@MaPhong)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaPhong", maphong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }
        public DataTable LayThongTinTraPhongPhiPhatSinh(string maphong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[func_LayThongTinTraPhongPhiPhatSinh](@MaPhong)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaPhong", maphong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }
        public string LayMaKH(string tenLoaiKH)
        {
            string MaLKH = "";
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT [dbo].[func_LayMaLoaiKH](@TenLoaiKH)", db.getConnection);
            cmd.Parameters.AddWithValue("@TenLoaiKH", tenLoaiKH);
            var result = cmd.ExecuteScalar();
            MaLKH= result.ToString();
            return MaLKH;
        }
        public string LayMaLoaiPhong(string TenLoaiPhong)
        {
            string MaLoaiPhong = "";
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT [dbo].[LayMaLoaiPhongBangTenLoaiPhong](@TenLoaiPhong)", db.getConnection);
            cmd.Parameters.AddWithValue("@TenLoaiPhong", TenLoaiPhong);
            var result = cmd.ExecuteScalar();
            MaLoaiPhong = result.ToString();
            return MaLoaiPhong;
        }

        public bool CapNhatTrangThaiPhong(string maphong, string trangthai)
        {

            SqlCommand cmd = new SqlCommand("proc_CapnhatTrangThaiPhong", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhong", maphong);
            cmd.Parameters.AddWithValue("@TrangThai", trangthai);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật trạng thái phòng thành công!", "", MessageBoxButtons.OK);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }

        public List<string> LayLoaiKhachHang()
        {
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT TenLoaiKH FROM V_LoaiKhachHang", db.getConnection);
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string tenLoaiKhachHang = row["TenLoaiKH"].ToString();
                    list.Add(tenLoaiKhachHang);
                }
            }
            return list;
        }
        public DataTable LayLoaiPhong(string maPhong)
        {
            SqlCommand cmd = new SqlCommand("proc_LayThongTinPhong", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool NhanPhong(string TenKH, string Quoctich, string SoCCCD, string SDT, string LoaiKH, DateTime NgayDatPhong, int SoLuongPhong, string MaPhong, DateTime Ngayden, DateTime Ngaydi, int Songuoio, float TraTruoc, float GiaPhong, string GhiChu, ref string err)
        {
           
                SqlCommand cmd = new SqlCommand("proc_NhanPhong", db.getConnection);
                db.openConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = TenKH;
                cmd.Parameters.Add("@Quoctich", SqlDbType.NChar).Value = Quoctich;
                cmd.Parameters.Add("@SoCCCD", SqlDbType.NChar).Value = SoCCCD;
                cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = SDT;
                cmd.Parameters.Add("@LoaiKH", SqlDbType.NChar).Value = LoaiKH;
                cmd.Parameters.Add("@NgayDatPhong", SqlDbType.DateTime).Value = NgayDatPhong;
                cmd.Parameters.Add("@SoLuongPhong", SqlDbType.Int).Value = SoLuongPhong;
                cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
                cmd.Parameters.Add("@Ngayden", SqlDbType.DateTime).Value = Ngayden;
                cmd.Parameters.Add("@Ngaydi", SqlDbType.DateTime).Value = Ngaydi;
                cmd.Parameters.Add("@Songuoio", SqlDbType.Int).Value = Songuoio;
                cmd.Parameters.Add("@TraTruoc", SqlDbType.Float).Value = TraTruoc;
                cmd.Parameters.Add("@GiaPhong", SqlDbType.Float).Value = GiaPhong;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = GhiChu;


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
        public bool DatPhong(string TenKH, string Quoctich, string SoCCCD, string SDT, string LoaiKH, DateTime NgayDatPhong, int SoLuongPhong, string MaPhong, DateTime Ngayden, DateTime Ngaydi, int Songuoio, float TraTruoc, float GiaPhong, string GhiChu, ref string err)
        {
            SqlCommand cmd = new SqlCommand("proc_DatPhong", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = TenKH;
            cmd.Parameters.Add("@Quoctich", SqlDbType.NChar).Value = Quoctich;
            cmd.Parameters.Add("@SoCCCD", SqlDbType.NChar).Value = SoCCCD;
            cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = SDT;
            cmd.Parameters.Add("@LoaiKH", SqlDbType.NChar).Value = LoaiKH;
            cmd.Parameters.Add("@NgayDatPhong", SqlDbType.DateTime).Value = NgayDatPhong;
            cmd.Parameters.Add("@SoLuongPhong", SqlDbType.Int).Value = SoLuongPhong;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            cmd.Parameters.Add("@Ngayden", SqlDbType.DateTime).Value = Ngayden;
            cmd.Parameters.Add("@Ngaydi", SqlDbType.DateTime).Value = Ngaydi;
            cmd.Parameters.Add("@Songuoio", SqlDbType.Int).Value = Songuoio;
            cmd.Parameters.Add("@TraTruoc", SqlDbType.Float).Value = TraTruoc;
            cmd.Parameters.Add("@GiaPhong", SqlDbType.Float).Value = GiaPhong;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = GhiChu;


            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("đặt phòng thành công!", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Đặt phòng thất bại!", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }
        public float PhamTramGiamGia(string LoaiKH)
        {
            float phanTram = 0;
            db.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT [dbo].[func_LayPhanTramGiamGia](@LoaiKH)", db.getConnection);
            cmd.Parameters.AddWithValue("@LoaiKH", LoaiKH);
            var result = cmd.ExecuteScalar();
            phanTram = float.Parse(result.ToString());
            return phanTram;
        }
        public bool ThemLoaiPhong(string MaLP, string TenLP, int SoLuong, float GiaPhong, int Songuoitoida)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("ThemLoaiPhong", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLoaiPhong", SqlDbType.NChar).Value = MaLP;
            cmd.Parameters.Add("@TenLoaiPhong", SqlDbType.NVarChar).Value = TenLP;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
            cmd.Parameters.Add("@Gia", SqlDbType.Float).Value = GiaPhong;
            cmd.Parameters.Add("@SoNguoiToiDa", SqlDbType.Int).Value = Songuoitoida;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công!", "Loại Phòng", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Loại Phòng", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }
        public bool SuaLoaiPhong(string MaLP, string TenLP, int SoLuong, float GiaPhong, int Songuoitoida)
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand("proc_SuaLoaiPhong", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLoaiPhong", SqlDbType.NChar).Value = MaLP;
            cmd.Parameters.Add("@TenLoaiPhong", SqlDbType.NVarChar).Value = TenLP;
            cmd.Parameters.Add("@SoLuong", SqlDbType.NChar).Value = SoLuong;
            cmd.Parameters.Add("@Gia", SqlDbType.NChar).Value = GiaPhong;
            cmd.Parameters.Add("@SoNguoiToiDa", SqlDbType.NChar).Value = Songuoitoida;

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Loại Phòng", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Loại Phòng", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }
    }
}
