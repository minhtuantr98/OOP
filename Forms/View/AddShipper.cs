using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShipper.Controller;

namespace QuanLyShipper
{
	public partial class AddShipper : Form
	{
		public AddShipper()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btn_reset_Click(object sender, EventArgs e)
		{

			if (dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu!", "Thông báo");
				return;
			}
			string ma = txt_maShipper.Text;
			if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (shipper1.Delete_Shipper(ma))
				{
					MessageBox.Show("Xóa thành công");
					dataGridView1.DataSource = shipper1.Load_On();
				}

			}
		}

		ShipperController shipper = new ShipperController();
		private void btn_add_Click(object sender, EventArgs e)
		{
			if (txt_maShipper.Text == "" && txt_tenShipper.Text == "")
			{
				MessageBox.Show("Không thể thêm nếu không có dữ liệu.");
			}
			else
			{
				if (shipper.Add_Shipper(txt_maShipper.Text, txt_tenShipper.Text, rNam.Checked ? true : false, txt_mail.Text, txt_birthday.Text, txt_sdt.Text, cbx_Quan.SelectedValue.ToString(), "true"))
				{
					MessageBox.Show("Thêm mới shipper thành công");
					dataGridView1.DataSource = shipper1.Load_On();
				}
				else
				{
					MessageBox.Show("Thêm mới không thành công!");
				}

			}
		}

		private void cbx_City_SelectedIndexChanged(object sender, EventArgs e)
		{
			//cbx_Quan.DataSource = shipper1.load_KhuVuc(cbx_City.SelectedValue);
			//cbx_Quan.ValueMember = "id";
			//cbx_Quan.DisplayMember = "KhuVuc";
		}

		ShipperModel shipper1 = new ShipperModel();
		
		private void AddShipper_Load(object sender, EventArgs e)
		{
			txt_maShipper.Text = QuanLyShipper.Model.XuLy.CreateKey("SHIPPER", "SP");
			txt_maShipper.Enabled = false;

			cbx_City.DataSource = shipper1.load_City();
			cbx_City.ValueMember = "id";
			cbx_City.DisplayMember = "KhuVuc";

			cbx_Quan.DataSource = shipper1.load_KhuVuc(cbx_City.SelectedValue);
			cbx_Quan.ValueMember = "id";
			cbx_Quan.DisplayMember = "KhuVuc";

			dataGridView1.DataSource = shipper1.Load_On();
			dataGridView1.Columns[0].HeaderText = "Mã Shipper";
			dataGridView1.Columns[1].HeaderText = "Tên Shipper";
			dataGridView1.Columns[2].HeaderText = "Giới tính";
			dataGridView1.Columns[3].HeaderText = "Email";
			dataGridView1.Columns[4].HeaderText = "Ngày Sinh";
			dataGridView1.Columns[5].HeaderText = "SDT";
			dataGridView1.Columns[6].HeaderText = "Khu Vực Phụ Trách";
			dataGridView1.Columns[7].HeaderText = "Trạng Thái";

			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

		}

		private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
		{
			txt_maShipper.Text = dataGridView1.CurrentRow.Cells["MaShipper"].Value.ToString();
			txt_sdt.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
			txt_tenShipper.Text = dataGridView1.CurrentRow.Cells["TenShipper"].Value.ToString();
			txt_birthday.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
			txt_mail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
			cbx_Quan.Text = dataGridView1.CurrentRow.Cells["KhuVucPhuTrach"].Value.ToString();
			if (dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString() == "True")
			{
				rNam.Checked = true;

			}
			else
				rNu.Checked = true;
			txt_maShipper.Enabled = false;
		}

		private void btnSua_Click_1(object sender, EventArgs e)
		{
			if (shipper1.ToFix(txt_maShipper.Text, txt_tenShipper.Text, rNam.Checked ? true : false, txt_mail.Text, txt_birthday.Text, txt_sdt.Text, cbx_Quan.Text, "true"))
			{
				MessageBox.Show("Bạn sửa thành công");
			}
			else
			{
				MessageBox.Show("Bạn sửa thất bại");
			}
			dataGridView1.DataSource = shipper1.Load_On();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
			fMenu f = new fMenu();
			f.StartPosition = FormStartPosition.CenterScreen;
			f.Visible = true;
		}

		private void cbx_Quan_SelectionChangeCommitted(object sender, EventArgs e)
		{
		
		}

		private void cbx_City_SelectionChangeCommitted(object sender, EventArgs e)
		{
			cbx_Quan.DataSource = shipper1.load_KhuVuc(cbx_City.SelectedValue);
			cbx_Quan.ValueMember = "id";
			cbx_Quan.DisplayMember = "KhuVuc";
		}
	}
}
