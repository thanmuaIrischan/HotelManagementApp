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
    public class BLThietBi
    {
        DBMain db = null;
        public BLThietBi()
        {
            db = new DBMain();
        }

        public DataTable LayDanhSachThietBi()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM v_LayDanhSachThietBi", db.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }

        public DataTable DSTB()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM v_DSThietBiChuaSX", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }

        public DataTable LayDanhSachLoaiThietBi()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAITHIETBI", db.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }


        public DataTable LayDanhSachPhong_ThietBi()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM v_LayDanhSachPhong_ThietBi", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTabel = new DataTable();
            adapter.Fill(dataTabel);
            return dataTabel;
        }
        
        public bool ThemThietBi(string MaThietBi, string TenLoaiThietBi)
        {
            SqlCommand command = new SqlCommand("ThemThietBiMoi", db.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaThietBi", SqlDbType.NChar).Value = MaThietBi;
            command.Parameters.Add("@TenLoaiThietBi", SqlDbType.NChar).Value = TenLoaiThietBi;

            db.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {

                MessageBox.Show("Thêm thành công!", "Thêm thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thêm thiết bị", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }
        
        public bool ThemLoaiThietBi(string MaLoaiThietBi, string TenLoaiThietBi, int SoLuong, float Gia)
        {
            SqlCommand command = new SqlCommand("pro_ThemLoaiThietBiMoi", db.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiThietBi", SqlDbType.NChar).Value = MaLoaiThietBi;
            command.Parameters.Add("@TenLoaiThietBi", SqlDbType.NChar).Value = TenLoaiThietBi;
            command.Parameters.Add("@SoLuong", SqlDbType.NChar).Value = SoLuong;
            command.Parameters.Add("@Gia", SqlDbType.NChar).Value = Gia;

            db.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công ", "Thêm loại thiết bị", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thêm loại thiết bị", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }

        public bool ThemPhong_ThietBi(string MaPhong, string MaThietBi)
        {
            SqlCommand command_t = new SqlCommand("proc_ThemThietBiPhong", db.getConnection);
            command_t.CommandType = CommandType.StoredProcedure;
            command_t.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            command_t.Parameters.Add("@MaThietBi", SqlDbType.NChar).Value = MaThietBi;

            db.openConnection();
            if (command_t.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thêm thiết bị vào phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thêm thiết bị vào phòng", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }

        public bool XoaThietBi(string MaThietBi)
        {
            SqlCommand command_x = new SqlCommand("pro_XOATHIETBI", db.getConnection);
            command_x.CommandType = CommandType.StoredProcedure;

            command_x.Parameters.Add("@MaThietBi", SqlDbType.NChar).Value = MaThietBi;

            db.openConnection();
            if (command_x.ExecuteNonQuery() > 0)
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

        public bool XoaLoaiThietBi(string MaThietBi)
        {
            SqlCommand command_x = new SqlCommand("pro_XoaLoaiThietBi", db.getConnection);
            command_x.CommandType = CommandType.StoredProcedure;

            command_x.Parameters.Add("@MaLoaiThietBi", SqlDbType.NChar).Value = MaThietBi;

            db.openConnection();
            if (command_x.ExecuteNonQuery() > 0)
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

        public bool XoaPhong_ThietBi(string MaThietBi)
        {
            SqlCommand command_x = new SqlCommand("pro_XoaPhong_TB", db.getConnection);
            command_x.CommandType = CommandType.StoredProcedure;
            command_x.Parameters.Add("@MaThietBi", SqlDbType.NChar).Value = MaThietBi;

            db.openConnection();
            if (command_x.ExecuteNonQuery() > 0)
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

        public bool CapnhatThietBi(string MaThietBi, string TenLoaiThietBi)
        {
            SqlCommand command_u = new SqlCommand("proc_CapnhatThietbi", db.getConnection);
            command_u.CommandType = CommandType.StoredProcedure;
            command_u.Parameters.Add("@MaThietBi", SqlDbType.NChar).Value = MaThietBi;
            command_u.Parameters.Add("@TenLoaiThietBi", SqlDbType.NVarChar).Value = TenLoaiThietBi;
            db.openConnection();
            if (command_u.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Cập nhật thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();

                return true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Cập nhật thiết bị", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }

        public bool CapNhatLoaiThietBi(string MaLoaiThietBi, string TenLoaiThietBi, int SoLuong, float Gia)
        {
            SqlCommand command = new SqlCommand("proc_CapnhatLoaiThietbi", db.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiThietBi", SqlDbType.NChar).Value = MaLoaiThietBi;
            command.Parameters.Add("@TenLoaiThietBi", SqlDbType.NChar).Value = TenLoaiThietBi;
            command.Parameters.Add("@SoLuong", SqlDbType.NChar).Value = SoLuong;
            command.Parameters.Add("@Gia", SqlDbType.NChar).Value = Gia;

            db.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Cập nhật loại thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Cập nhật loại thiết bị", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }

        public bool CapnhatPhong_ThietBi(string MaPhong, string newMaThietBi, string oldMaThietBi)
        {
            SqlCommand command = new SqlCommand("proc_CapNhatThietBiPhong", db.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@newMaThietBi", SqlDbType.NChar).Value = newMaThietBi;
            command.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            command.Parameters.Add("@oldMaThietBi", SqlDbType.NChar).Value = oldMaThietBi;

            db.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Cập nhật Phòng thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Cập nhật phòng thiết bị", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }

        public DataTable TimkiemTB(string SearchText)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_TimkiemTB(@SearchText)", db.getConnection);
            cmd.Parameters.AddWithValue("@SearchText", SearchText);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable TimkiemLoaiTB(string SearchText)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_TimkiemLoaiTB(@SearchText)", db.getConnection);
            cmd.Parameters.AddWithValue("@SearchText", SearchText);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable TimkiemPTB(string SearchText)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_TimkiemPTB(@SearchText)", db.getConnection);
            cmd.Parameters.AddWithValue("@SearchText", SearchText);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ThongTinPTB(string MaPhong, string MaThietBi)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_ThongTinPTB(@MaPhong, @MaThietBi)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaThietBi", MaThietBi);
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ThongTinLoaiTB(string MaLoaiThietBi)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThongTinLoaiTB(@MaLoaiThietBi)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaLoaiThietBi", MaLoaiThietBi);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ThongTinTB(string MaThietBi)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_ThongTinTB(@MaThietBi)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaThietBi", MaThietBi);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
