using System;    //Chính
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHACHSAN;
using QUANLYKHACHSAN.DB_Layer;

namespace QUANLYKHACHSAN
{
    public partial class frmHotelManagementSystemHome : Form
    {
        // fields

        private Button currentButton;
        private Form activeForm;
        private UserControl activeUserControl;
        public string idTaikhoan { get; set; }
        public string idCurrent { get; set; }
        // contructor 
        public frmHotelManagementSystemHome()
        {
            InitializeComponent();
        }

        public void MovePnl(Control btn)
        {
            pnlSlide.Visible = true;
            pnlSlide.Top = btn.Top;
            pnlSlide.Height = btn.Height;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in tableLayoutPanel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void ActivateButton(object btnSender)
        {

            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.FromArgb(229, 190, 236);
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(childForm);
            this.pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void OpenChildUserControl(UserControl childUserControl, object btnSender)
        {
            // Đóng UserControl hiện tại (nếu có)
            if (activeUserControl != null)
            {
                this.pnlMain.Controls.Remove(activeUserControl);
                activeUserControl.Dispose(); // Xoá khỏi bộ nhớ
            }

            ActivateButton(btnSender);

            // Gán UserControl mới làm UserControl hoạt động
            activeUserControl = childUserControl;
            childUserControl.Dock = DockStyle.Fill;

            // Thêm UserControl mới vào panelMain
            this.pnlMain.Controls.Add(childUserControl);
            this.pnlMain.Tag = childUserControl;
            childUserControl.BringToFront();
            childUserControl.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblDatetime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }
        
        private void frmHotelManagementSystemHome_Load(object sender, EventArgs e)
        {
            //timer1.Start();

            //btnQLThietbi.Hide();
            //btnQLNguoidung.Hide();
            //btnQLCauhinhPhong.Hide();

            //ControlPhatsinh.Hide();
            //ControlKhachhang.Hide();
            //ControlThietbi.Hide();
            //ControlDichvu.Hide();
            //ControlPhong.Hide();
            //ControlNguoidung.Hide();
            //ControlSoDoPhong.Hide();
            string select = "Select HoTen from view_ShowPhienDangNhap where TaiKhoan=N'" + idTaikhoan + "'";

            lbUser.Text = DBMain.laychuoi(select, lbUser.Text);
            pnlMain.Visible = true;
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            MovePnl(btnQLPhong);
           // ControlSoDoPhong.Show();
            OpenChildUserControl(new User_Control.UserControlSoDoPhong(), sender);
            btnQLThietbi.Hide();
            btnQLNguoidung.Hide();
            btnQLCauhinhPhong.Hide();

            //ControlPhatsinh.Hide();
            //ControlNguoidung.Hide();
            //ControlKhachhang.Hide();
            //ControlThietbi.Hide();
            //ControlDichvu.Hide();
        }

        private void btnQLKhachhang_Click(object sender, EventArgs e)
        {
            MovePnl(btnQLKhachhang);
            //ControlKhachhang.Show();
            OpenChildUserControl(new User_Control.UserControlKhachhang(), sender);
            btnQLThietbi.Hide();
            btnQLNguoidung.Hide();
            btnQLCauhinhPhong.Hide();

            //ControlPhatsinh.Hide();
            //ControlNguoidung.Hide();
            //ControlThietbi.Hide();
            //ControlDichvu.Hide();
            //ControlPhong.Hide();
            //ControlSoDoPhong.Hide();
        }

        private void btnQLDichvu_Click(object sender, EventArgs e)
        {
            MovePnl(btnQLDichvu);
            //ControlDichvu.Show();
            OpenChildUserControl(new User_Control.UserControlDichvu(), sender);
            btnQLThietbi.Hide();
            btnQLNguoidung.Hide();
            btnQLCauhinhPhong.Hide();
            
            //ControlPhatsinh.Hide();
            //ControlNguoidung.Hide();
            //ControlKhachhang.Hide();
            //ControlThietbi.Hide();
            //ControlPhong.Hide();
            //ControlSoDoPhong.Hide();
        }

        private void btnQLThietbi_Click(object sender, EventArgs e)
        {
            //ControlThietbi.Show();
            OpenChildUserControl(new User_Control.UserControlThietbi(), sender);
            btnQLThietbi.Hide();
            btnQLNguoidung.Hide();
            btnQLCauhinhPhong.Hide();

            //ControlPhatsinh.Hide();
            //ControlNguoidung.Hide();
            //ControlKhachhang.Hide();
           // ControlDichvu.Hide();
            //ControlPhong.Hide();
            //ControlSoDoPhong.Hide();
        }

        private void btnQLThuchi_Click(object sender, EventArgs e)
        {
            MovePnl(btnPhatsinh);
            //ControlPhatsinh.Show();
            OpenChildUserControl(new User_Control.UserControlPhatsinh(), sender);

            btnQLThietbi.Hide();
            btnQLNguoidung.Hide();
            btnQLCauhinhPhong.Hide();

            //ControlNguoidung.Hide();
            //ControlKhachhang.Hide();
            //ControlThietbi.Hide();
            //ControlDichvu.Hide();
            //ControlPhong.Hide();
            //ControlSoDoPhong.Hide();
        }

        private void btnTKBC_Click(object sender, EventArgs e)
        {
            MovePnl(btnTKBC);

            btnQLThietbi.Hide();
            btnQLNguoidung.Hide();
            btnQLCauhinhPhong.Hide();

            //ControlPhatsinh.Hide();
            //ControlNguoidung.Hide();
            //ControlKhachhang.Hide();
            //ControlThietbi.Hide();
            //ControlDichvu.Hide();
            //ControlPhong.Hide();
            //ControlSoDoPhong.Hide();
        }

        
        private void btnThietdatHT_Click(object sender, EventArgs e)
        {
            MovePnl(btnThietdatHT);
            btnQLThietbi.Show();
            btnQLNguoidung.Show();
            btnQLCauhinhPhong.Show();
        }
       
        private void btnQLNguoidung_Click(object sender, EventArgs e)
        {
            //btnQLThietbi.Hide();
            //btnQLNguoidung.Hide();
            //btnQLCauhinhPhong.Hide();
            //frmNhanvien frmNhanvien = new frmNhanvien();
            
            OpenChildForm(new User_Form.frmNhanvien(), sender);
            //ControlPhatsinh.Hide();
            //ControlKhachhang.Hide();
            //ControlThietbi.Hide();
            //ControlDichvu.Hide();
            //ControlPhong.Hide();
            //ControlSoDoPhong.Hide();
        }

        private void btnDangxuat_Click_1(object sender, EventArgs e)
        {
            //timer1.Stop();
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnQLCauhinhPhong_Click(object sender, EventArgs e)
        {
            //btnQLThietbi.Hide();
            //btnQLNguoidung.Hide();
            //btnQLCauhinhPhong.Hide();
            OpenChildUserControl(new User_Control.UserControlPhong(), sender);
            //ControlPhong.Show();
            //ControlPhatsinh.Hide();
            //ControlNguoidung.Hide();
            //ControlKhachhang.Hide();
            //ControlThietbi.Hide();
            //ControlDichvu.Hide();
            //ControlSoDoPhong.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ControlPhatsinh_Load(object sender, EventArgs e)
        {

        }
    }
}
