using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyShipper.Model
{
    class XuLy
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static DataTable dt;
        public static SqlDataAdapter da;
        //public static string lenh = "Data Source=TRANBAOKHANH;Initial Catalog=QLSHIPPER;Integrated Security=True";
        public static string lenh = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="
											+ System.IO.Directory.GetCurrentDirectory().ToString()
											+ "\\Database\\Shipper.mdf;Integrated Security=True";
		public static DataTable TaoBang(String sql)
        {
            conn = new SqlConnection(lenh);
            conn.Open();
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecuteNonQuery(String sql)
        {
            int re = 0;
            try
            {
                conn = new SqlConnection(lenh);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                re = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                
            }
            return re;
        }

        public static bool Login(String sql)
        {
            bool re = false; 
            try
            {
                conn = new SqlConnection(lenh);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read() == true)
                {
                    re = true;
                }
                conn.Close();
            }
            catch
            {

            }
            return re;
        }
		public static string CreateKey(string table, string Key)// hàm tạo giá trị mã cho các bảng
		{
			DataTable dt = new DataTable();
			dt = XuLy.TaoBang("Select * from " + table + " ");
			int coso = 0;

			if (dt.Rows.Count == 0)
			{
				coso = 1;
			}
			else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1) // nếu danh sách nhân viên có 1 nhân viên và mã người này là NV001
			{
				coso = 2;
			}
			else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) > 1) // nếu danh sách có 1 nhân viên mà mã người này khác NV001
			{
				coso = 1;
			}
			else
			{
				for (int i = 0; i < dt.Rows.Count - 1; i++)
				{
					if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(2, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) > 1)
					{
						coso = int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) + 1;
						break;
					}
				}
				coso = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3)) + 1;
			}
			string ma = "";
			if (coso < 10)
				return ma = Key + "00" + coso;
			else if (coso < 100)
				return ma = Key + "0" + coso;
			else
				return ma = Key + coso;

		}
	}
}
