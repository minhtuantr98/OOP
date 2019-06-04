using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyShipper.Model;


namespace QuanLyShipper.Model
{
	class TinhTrangModel
	{
		public DataTable Load_On()
		{
			DataTable re;
			String lenh = "select * from DIACHI where parent_id != 0";
			re = XuLy.TaoBang(lenh);
			return re;
		}
	
		public DataTable Load_TrangThai_KhuVuc(object MaKhuVuc)
		{
			DataTable re;
			String lenh = "select * from SHIPPER where KhuVucPhuTrach =" + MaKhuVuc;
			re = XuLy.TaoBang(lenh);
			return re;
		}
		public DataTable Load_TrangThai_MaS(object MaKhuVuc,object MaShipper)
		{
			DataTable re;
			String lenh = "select * from SHIPPER where KhuVucPhuTrach =" + MaKhuVuc +" And MaShipper =" +MaShipper ;
			re = XuLy.TaoBang(lenh);
			return re;
		}
	}
}
