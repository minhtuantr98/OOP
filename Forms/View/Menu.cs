using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShipper
{
	public partial class fMenu : Form
	{
		public fMenu()
		{
			InitializeComponent();
		}


		private void lậpĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LapDonHang f = new LapDonHang();
			f.Show();
			Visible = false;
		}

		private void cậpNhậtShipperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddShipper f = new AddShipper();
			f.Show();
		}

		private void kiểmTraTìnhTrạngGiaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TinhTrangGiaoHang f = new TinhTrangGiaoHang();
			f.Show();
			Visible = false;
		}

		private void kiểmTraTìnhTrạngHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TinhTrangHoatDong f = new TinhTrangHoatDong();
			f.Show();
			Visible = false;
		}

		private void thốngKêDoanhThuTheoShipperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ThongKeDoanhThu f = new ThongKeDoanhThu();
			f.Show();
			Visible = false;
		}

		private void thốngKêDoanhThuTheoKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ThongKeKhuVuc f = new ThongKeKhuVuc();
			f.Show();
			Visible = false;
		}

		private void thốngKêĐơnHàngTheoShipperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ThongKeDonHang f = new ThongKeDonHang();
			f.Show();
			Visible = false;
		}

		private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void fMenu_Load(object sender, EventArgs e)
		{

		}
	}
}
