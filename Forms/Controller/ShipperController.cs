using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShipper.Controller
{
    class ShipperController
    {
        ShipperModel shipper = new ShipperModel();
        public bool Add_Shipper(String maShipper, String tenShipper, bool gioiTinh, String email, String ngaySinh, String sdt, String khuVuc, String trangThai)
        {
            return shipper.Add_Shipper(maShipper, tenShipper, gioiTinh, email, ngaySinh, sdt, khuVuc, trangThai);
        }

        public bool Delete_Shipper(String maShipper)
        {
            return shipper.Delete_Shipper(maShipper);
        }

        public bool ToFix(String maShipper, String tenShipper, bool gioiTinh, String email, String ngaySinh, String sdt, String khuVuc, String trangThai)
        {
            return shipper.ToFix(maShipper, tenShipper, gioiTinh, email, ngaySinh, sdt, khuVuc, trangThai);
        }
    }
}
