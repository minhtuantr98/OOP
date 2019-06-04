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
	public partial class TinhTrangHoatDong : Form
	{
		public TinhTrangHoatDong()
		{
			InitializeComponent();
		}
		TinhTrangModel tinhtrang1 = new TinhTrangModel();
		private void TinhTrangHoatDong_Load(object sender, EventArgs e)
		{
			cbx_khuVuc.DataSource = tinhtrang1.Load_On();
			cbx_khuVuc.DisplayMember = "KhuVuc";
			cbx_khuVuc.ValueMember = "id";
		}

		private void cbx_khuVuc_SelectionChangeCommitted(object sender, EventArgs e)
		{
			dataGridView1.DataSource = tinhtrang1.Load_TrangThai_KhuVuc(cbx_khuVuc.SelectedValue);
			cbx_maShipper.DataSource = tinhtrang1.Load_TrangThai_KhuVuc(cbx_khuVuc.SelectedValue);
			cbx_maShipper.DisplayMember = "TenShipper";
			cbx_maShipper.ValueMember = "MaShipper";
		}

		private void cbx_maShipper_SelectionChangeCommitted(object sender, EventArgs e)
		{
			dataGridView1.DataSource = tinhtrang1.Load_TrangThai_MaS(cbx_khuVuc.SelectedValue,cbx_maShipper.SelectedValue);
		}
	}
}
