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
	public partial class LapDonHang : Form
	{
		public LapDonHang()
		{
			InitializeComponent();
		}

        public void setNull()
        {
            txt_maDH.Text = "";
            txt_maNV.Text = "";
            txt_tenKH.Text = "";
            txt_sdt.Text = "";
            txt_diaChi.Text = "";
            txt_moTa.Text = "";
            txt_tienHang.Text = "";
            txt_tienShip.Text = "";
            txt_tongTien.Text = "";
            Cbx_City.Text = "";
            Cbx_Quan.Text = "";
            cbx_maShipper.Text = "";
        }

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
            update();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            setNull();
            fMenu f = new fMenu();
            f.Show();
            Visible = false;
        }
	
        OrderController order = new OrderController();
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if(txt_maDH.Text == "" && txt_tenKH.Text == "")
            {
                MessageBox.Show("Không thể thêm nếu không có dữ liệu");
            }
            else
            {
                DataRow selectedShipper = ((DataRowView)cbx_maShipper.SelectedItem).Row;
                string shipperId = selectedShipper["MaShipper"].ToString();
                string tienHang = txt_tienHang.Text == "" ? "null" : txt_tienHang.Text;
                string tienShip = txt_tienShip.Text == "" ? "null" : txt_tienShip.Text;
                if (order.add_Order(txt_maDH.Text,txt_maNV.Text,txt_tenKH.Text,txt_sdt.Text,Cbx_City.Text,Cbx_Quan.Text,txt_diaChi.Text,txt_moTa.Text,tienHang,tienShip, shipperId))
                {
                    MessageBox.Show("Thêm đơn hàng thành công.");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }

        OrderModel order1 = new OrderModel();

        private void LapDonHang_Load(object sender, EventArgs e)
        {
            Cbx_City.DataSource = order1.load_City();
            Cbx_City.DisplayMember = "KhuVuc";
            Cbx_City.ValueMember = "id";
        }

        private void Cbx_City_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            //Console.Write(Cbx_City.SelectedValu)
            Cbx_Quan.DataSource = order1.load_KhuVuc(Cbx_City.SelectedValue);
            Cbx_Quan.DisplayMember = "KhuVuc";
            Cbx_Quan.ValueMember = "id";
        }

        private void Cbx_Quan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbx_maShipper.DataSource = order1.load_Shipper(Cbx_Quan.SelectedValue);
            cbx_maShipper.DisplayMember = "TenShipper";
            cbx_maShipper.ValueMember = "MaShipper";
        }

        private void update()
        {
            try
            {
                double tienHang = Convert.ToDouble(txt_tienHang.Text);
                double tienShip = Convert.ToDouble(txt_tienShip.Text);
                double tong = tienHang + tienShip;
                txt_tongTien.Text = tong.ToString();
            }
            catch
            {

            }
        }

        private void txt_tienShip_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void cbx_maShipper_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
