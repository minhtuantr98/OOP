using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyShipper.Model;

namespace QuanLyShipper
{
	class ThongKeModel
	{
		public DataTable load_On()
		{
			DataTable re;
			String lenh_all = "select * from Shipper";
			re = XuLy.TaoBang(lenh_all);
			return re;
		}

		public DataTable load_On_KhuVuc()
		{
			DataTable re;
			String lenh_KhuVuc = "select * from DIACHI where parent_id != 0";
			re = XuLy.TaoBang(lenh_KhuVuc);
			return re;
		}

		public DataTable load_DoanhThu(object MaShipper)
        {
            DataTable re;
            String lenh_1 = "select TenShipper,sum(PhiShip) as DoanhThu from DONHANG join SHIPPER on DONHANG.Shipper = SHIPPER.MaShipper where Shipper =" + MaShipper +" group by TenShipper " ;
            re = XuLy.TaoBang(lenh_1);
            return re;
        }

		public DataTable load_DonHang(object MaShipper)
		{
			DataTable re;
			String lenh_2 = "select TenShipper,Count(MaDonHang) as TongDonHang from DONHANG join SHIPPER on DONHANG.Shipper = SHIPPER.MaShipper where Shipper = " + MaShipper +" group by TenShipper " ;
			re = XuLy.TaoBang(lenh_2);
			return re;
		}

		public DataTable load_KhuVuc(object KhuVuc)
		{
			DataTable re;
			String lenh_3 = "Select TenShipper,MaDonHang,MaNhanVien,TenKhachHang,DONHANG.SDT,Tinh,Huyen,DCChiTiet,MoTa,TienHang,PhiShip,TongTienDonHang from DonHang join Shipper on DonHang.Shipper = Shipper.MaShipper where Huyen = N'" + KhuVuc+"' "  ;
			re = XuLy.TaoBang(lenh_3);
			return re;
		}

	}
}
