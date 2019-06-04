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
	public partial class TinhTrangGiaoHang : Form
	{
		public TinhTrangGiaoHang()
		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btn_lapDH_Click(object sender, EventArgs e)
		{
			GanShipper f = new GanShipper();
			f.Show();
		}
	}
}
