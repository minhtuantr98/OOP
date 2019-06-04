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
using QuanLyShipper.Controller;
using QuanLyShipper.Model;
namespace QuanLyShipper
{
	public partial class ThongKeDonHang : Form
	{
		public ThongKeDonHang()
		{
			InitializeComponent();
		}

		ThongKeModel thongke1 = new ThongKeModel();

		private void ThongKeDonHang_Load(object sender, EventArgs e)
		{
			cbx_maShipper.DataSource = thongke1.load_On();
			cbx_maShipper.DisplayMember = "TenShipper";
			cbx_maShipper.ValueMember = "MaShipper";
		}

		private void cbx_maShipper_SelectionChangeCommitted(object sender, EventArgs e)
		{
			dataGridView1.DataSource = thongke1.load_DonHang(cbx_maShipper.SelectedValue);
		}
	}
}
