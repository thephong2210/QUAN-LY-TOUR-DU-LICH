using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_LoaiKH
    {
        D_LoaiKH d_LoaiKH = new D_LoaiKH();

        public List<loaikhachhang> GetLoaikhachhangs()
        {
            return d_LoaiKH.GetLoaikhachhangs();
        }

        public bool ThemLoaiKH(loaikhachhang objLoaiKH)
        {
            return d_LoaiKH.ThemLoaiKH(objLoaiKH);
        }

        public bool XoaLoaiKH(loaikhachhang objLoaiKH,int maLoaiKH)
        {
            return d_LoaiKH.XoaLoaiKH(objLoaiKH,maLoaiKH);
        }

        public bool SuaLoaiKH(loaikhachhang objLoaiKH,int maLoaiKH)
        {
            return d_LoaiKH.SuaLoaiKH(objLoaiKH, maLoaiKH);
        }
    }
}
