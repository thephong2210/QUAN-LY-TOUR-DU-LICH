using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_dangkynhanvien
    {
        D_dangkynhanvien d_dangkynhanvien = new D_dangkynhanvien();

        public List<thamgiadoan> GetAllDangKy()
        {
            return d_dangkynhanvien.GetAllDangKy();
        }

        public List<dynamic> TimKiemTheoTenNV(string searchValue)
        {
            return d_dangkynhanvien.TimKiemTheoTenNV(searchValue);
        }

        public List<dynamic> GetListDangKy()
        {
            return d_dangkynhanvien.GetListDangKy();
        }

        public List<dynamic> GetListDetailsDangKy(int id)
        {
            return d_dangkynhanvien.GetListDetailsDangKy(id);
        }

        public bool ThemDangKy(thamgiadoan objDangKy)
        {
            return d_dangkynhanvien.ThemDangKy(objDangKy);
        }

        public bool XoaDangKy(int id)
        {
            return d_dangkynhanvien.XoaDangKy(id);
        }

    }
}
