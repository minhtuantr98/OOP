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
	public partial class ThongKeDoanhThu : Form
	{
		public ThongKeDoanhThu()
		{
			InitializeComponent();
		}
		ThongKeModel thongke1 = new ThongKeModel();
		
		private void ThongKeDoanhThu_Load(object sender, EventArgs e)
		{
			cbx_maShipper.DataSource = thongke1.load_On();
			cbx_maShipper.DisplayMember = "TenShipper";
			cbx_maShipper.ValueMember = "MaShipper";
		}

		private void cbx_maShipper_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbx_maShipper_SelectionChangeCommitted(object sender, EventArgs e)
		{
			dataGridView1.DataSource = thongke1.load_DoanhThu(cbx_maShipper.SelectedValue);
			double dt = 0;
			for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
			{
				dt += Convert.ToDouble(dataGridView1.Rows[i].Cells[11].Value.ToString());
			}
			txtDoanhthu.Text = dt.ToString();

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void date_Start_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void date_End_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
			fMenu f = new fMenu();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Visible = true;
		}
	}
}
