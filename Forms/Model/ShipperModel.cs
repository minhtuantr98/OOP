using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShipper.Model;
using System.Data;

namespace QuanLyShipper
{
    class ShipperModel
    {
        public DataTable Load_On()
        {
            DataTable re;
            String lenh = "select * from SHIPPER";
            re = XuLy.TaoBang(lenh);
            return re;
        }

        public bool Add_Shipper(String maShipper, String tenShipper, bool gioiTinh, String email, String ngaySinh, String sdt, String khuVuc, String trangThai)
        {
            String lenh1 = "insert into SHIPPER(MaShipper,TenShipper,GioiTinh,Email,NgaySinh,SDT,KhuVucPhuTrach,TrangThai) values('"+maShipper+"',N'"+tenShipper+"','"+gioiTinh+"',N'"+email+"','"+ngaySinh+"','"+sdt+"',"+khuVuc+",'"+trangThai+"')";
            bool re = false;
            if(XuLy.ExecuteNonQuery(lenh1) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool Delete_Shipper(String maShipper)
        {
            //luu y kiem tra neu tinh trang shipper = false thi khong duoc xoa
            String lenh2 = "delete from SHIPPER where MaShipper = '" + maShipper + "'";
            bool re = false;
            if(XuLy.ExecuteNonQuery(lenh2) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool ToFix(String maShipper, String tenShipper, bool gioiTinh, String email, String ngaySinh, String sdt, String khuVuc, String trangThai)
        {
            String lenh3 = "update SHIPPER set TenShipper = N'" + tenShipper + "', GioiTinh = N'" + gioiTinh + "', Email = N'" + email + "', Ngaysinh = N'" + ngaySinh + "', SDT = N'" + sdt + "', KhuVucPhuTrach = N'" + khuVuc + "', TrangThai = N'" + trangThai+"' ";
            bool re = false;
            if (XuLy.ExecuteNonQuery(lenh3) > 0)
            {
                re = true;
            }
            return re;
        }

        public DataTable load_City()
        {
            DataTable re;
            String lenh_2 = "select * from DIACHI where parent_id = 0";
            re = XuLy.TaoBang(lenh_2);
            return re;
        }

        public DataTable load_KhuVuc(object parent_id)
        {
            DataTable re;
            String lenh_3 = "select * from DIACHI where parent_id = " + parent_id;
            re = XuLy.TaoBang(lenh_3);
            return re;
        }
	}
}
