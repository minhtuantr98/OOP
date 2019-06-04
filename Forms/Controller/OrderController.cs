using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShipper.Controller
{
    class OrderController
    {
        OrderModel order = new OrderModel();

        public bool add_Order(String maDH, String maNV, String tenKH, String sdt, String tinh, String huyen, String chiTiet, String moTa, String tienHang, String phiShip, String shipper)
        {
            return order.add_Order(maDH, maNV, tenKH, sdt, tinh, huyen, chiTiet, moTa, tienHang, phiShip, shipper);
        }
    }
}
