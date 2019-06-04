using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyShipper.Model;

namespace QuanLyShipper
{
    class OrderModel
    {
        //private string maDH { get; set; }
        //private string maNV { get; set; }
        //private string tenKH { get; set; }
        //private string sdt { get; set; }
        //private string tinh { get; set; }
        //private string huyen { get; set; }
        //private string xa { get; set; }
        //private string chiTiet { get; set; }
        //private string ngayLap { get; set; }
        //private string moTa { get; set; }
        //private string tienHang { get; set; }
        //private string phiShip { get; set; }
        //private string shipper { get; set; }
        //private string tongTien { get; set; }
        

        public DataTable load_On()
        {
            DataTable re;
            String lenh = "select * from DONHANG";
            re = XuLy.TaoBang(lenh);
            return re;
        }

        public bool add_Order(String maDH, String maNV, String tenKH, String sdt, String tinh, String huyen, String chiTiet, String moTa, String tienHang, String phiShip, String shipper)
        {
            String lenh_1 = "insert into DONHANG values("+maDH+","+maNV+",N'"+tenKH+"',N'"+sdt+"',N'"+tinh+"',N'"+huyen+"',N'"+chiTiet+"',N'"+moTa+"',"+tienHang.ToString()+","+phiShip.ToString()+",N'"+shipper+"')";
            bool re = false;
            if(XuLy.ExecuteNonQuery(lenh_1) > 0)
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

        public DataTable load_Shipper(object parent_id)
        {
            DataTable re;
            String lenh_4 = "select * from SHIPPER where KhuVucPhuTrach = " + parent_id;
            re = XuLy.TaoBang(lenh_4);
            return re;
        }

    }
}
