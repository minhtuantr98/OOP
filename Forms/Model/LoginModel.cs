using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyShipper.Model;

namespace QuanLyShipper.Model
{
    class LoginModel
    {
        public bool Confirm(String tk, String mk)
        {
            bool re;
            String lenh = "select * from NHANVIEN where MaNhanVien = '" + tk + "' AND userpassword = '" + mk + "'";
            re = XuLy.Login(lenh);
            return re;
        }
    }
}
