using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUANLYKHACHSAN.BS_Layer;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using QUANLYKHACHSAN.DB_Layer;

namespace QUANLYKHACHSAN
{
    public partial class frmLogin : Form
    {
        public static string kq;
        SqlConnection conn = null;
        private string iduser = "";
        private string idcrr = "";
        public frmLogin()
        {
            InitializeComponent();
        }
              

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbShowPass_Click(object sender, EventArgs e)
        {
            ptbShowPass.Hide();
            txtPassword.UseSystemPasswordChar = true;
            ptbHidePass.Show();
        }

        private void ptbHidePass_Click(object sender, EventArgs e)
        {
            ptbHidePass.Hide();
            txtPassword.UseSystemPasswordChar = false;
            ptbShowPass.Show();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                KTLogin.username = txtUsername.Text.Trim();
                KTLogin.password = txtPassword.Text.Trim();
                conn = new SqlConnection(DBMain.chuoiketnoi());
                conn.Open();
                string UserNameCurrent = "dbo.proc_KiemTraLogin";
                SqlCommand cmdUsername = new SqlCommand(UserNameCurrent, conn);
                cmdUsername.CommandType = CommandType.StoredProcedure;
                cmdUsername.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmdUsername.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                
                string usercrr = cmdUsername.ExecuteScalar()?.ToString();
              
                if (!string.IsNullOrEmpty(usercrr))
                {
                   
                    iduser = txtUsername.Text.Trim();
                    idcrr = usercrr;
                    cmdUsername.Dispose();
                    conn.Close();
                    frmHotelManagementSystemHome frm = new frmHotelManagementSystemHome();
                    frm.idTaikhoan = iduser;
                    frm.idCurrent = idcrr;
                    this.Hide();
                    frm.ShowDialog();
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu!", "Thông báo");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUsername.Focus();
        }
    }
}
