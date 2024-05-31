using QUANLYKHACHSAN.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class HoaDon : Form
    {
        public string MaPhong;
       
        public HoaDon(string maPhong)
        {
            InitializeComponent();
            MaPhong = maPhong;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            this.billTableAdapter.Fill(this.dataSet2.Bill, MaPhong);
            this.reportViewer1.RefreshReport();
        }

        private void HoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
