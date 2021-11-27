using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class B_KH
    {
        D_KH d_KH = new D_KH();

        public List<khachhang> GetKhachHang()
        {
            return d_KH.GetKhachHang();
        }

        public List<dynamic> GetListDetailsKhachHang(int maSoKhachHang)
        {
            return d_KH.GetListDetailsKhachHang(maSoKhachHang);
        }


        public bool ThemKhachHang(khachhang objKhachHang)
        {
            return d_KH.ThemKhachHang(objKhachHang);
        }

        public bool XoaKhachHang(khachhang objKhachHang, int maSoKhachHang)
        {
            return d_KH.XoaKhachHang(objKhachHang, maSoKhachHang);
        }

        public bool SuaKhachHang(khachhang objKhachHang, int maSoKhachHang)
        {
            return d_KH.SuaKhachHang(objKhachHang, maSoKhachHang);
        }

    }


}
