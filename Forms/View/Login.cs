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
using System.Data;
using QuanLyShipper.Model;

namespace QuanLyShipper
{
	public partial class fLogin : Form
	{
		public fLogin()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        LoginModel login = new LoginModel();
        private void login_btn_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=TRANBAOKHANH;Initial Catalog=QLSHIPPER;Integrated Security=True");
            //try
            //{
            //    conn.Open();
            //    string tk = login_tk.Text;
            //    string mk = login_mk.Text;
            //    string sql = "select * from TAIKHOAN where  USERNAME = '" + tk + "' AND USERPASSWORD = '" + mk + "'";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataReader dta = cmd.ExecuteReader();
            //    if (dta.Read() == true)
            //    {
            //        fMenu f = new fMenu();
            //        f.Show();
            //        //close
            //        Visible = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("đăng nhập thất bại!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show("Lỗi kết nối abc!");
            //}
            String tk = login_tk.Text;
            String mk = login_mk.Text;
            if (login.Confirm(tk, mk))
            {
                fMenu f = new fMenu();
                f.Show();
                //close
                Visible = false;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
        }

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint_1(object sender, PaintEventArgs e)
		{

		}
	}
}
