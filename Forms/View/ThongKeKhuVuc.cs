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
	public partial class ThongKeKhuVuc : Form
	{
		public ThongKeKhuVuc()
		{
			InitializeComponent();
		}
		
		ThongKeModel thongke1 = new ThongKeModel();

		private void ThongKeKhuVuc_Load_1(object sender, EventArgs e)
		{
			cbx_khuVuc.DataSource = thongke1.load_On_KhuVuc();
			cbx_khuVuc.DisplayMember = "KhuVuc";
			cbx_khuVuc.ValueMember = "KhuVuc";
		}

		private void cbx_khuVuc_SelectionChangeCommitted(object sender, EventArgs e)
		{
			dataGridView1.DataSource = thongke1.load_KhuVuc(cbx_khuVuc.SelectedValue);
		}

	}
}
