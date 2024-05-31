using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QUANLYKHACHSAN.DB_Layer;
using QUANLYKHACHSAN.User_Form;
using System.Windows.Forms;

namespace QUANLYKHACHSAN.BS_Layer
{
    public class BLPhatSinh

    {
        DBMain db = null;
        public BLPhatSinh()
        {
            db = new DBMain();
        }

        public bool ThemPhatsinh(string MaPhong, string LoaiPhatSinh, string LyDo, float TongChiPhi)
        {
            SqlCommand cmd = new SqlCommand("proc_ThemPhatSinhMoi", db.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            cmd.Parameters.Add("@LoaiPhatSinh", SqlDbType.NVarChar).Value = LoaiPhatSinh;
            cmd.Parameters.Add("@LyDo", SqlDbType.NVarChar).Value = LyDo;
            cmd.Parameters.Add("@TongPhiPhatSinh", SqlDbType.Float).Value = TongChiPhi;

            db.openConnection();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thêm phát sinh", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thêm phát sinh", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }

        public DataTable LayDanhSachHD(string MaPhong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_ChiPhiPhatSinh(@MaPhong)", db.getConnection);
            cmd.Parameters.Add("@MaPhong", SqlDbType.NChar).Value = MaPhong;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }

        public DataTable DanhsachPhatsinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_DSPhatSinh()", db.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
    }
}
