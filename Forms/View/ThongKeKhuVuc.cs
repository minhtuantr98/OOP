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
			cbx_khuVuc.SelectedValue = -1;
		}

		private void cbx_khuVuc_SelectionChangeCommitted(object sender, EventArgs e)
		{
			dataGridView1.DataSource = thongke1.load_KhuVuc(cbx_khuVuc.SelectedValue);
			double dt = 0;
			for(int i=0;i<dataGridView1.Rows.Count-1;i++)
			{
				dt += Convert.ToDouble(dataGridView1.Rows[i].Cells[11].Value.ToString());
			}
			txtDoanhthu.Text = dt.ToString();
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
