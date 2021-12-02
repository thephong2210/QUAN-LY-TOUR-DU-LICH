using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_nhanvien
    {
        D_nhanvien dNhanVien = new D_nhanvien();

        //Get list nhân viên tùy chỉnh
        public List<nhanvien> GetAllNhanVien()
        {
            return dNhanVien.GetAllNhanVien();
        }

        public List<dynamic> GetListNhanVien()
        {
            return dNhanVien.GetListNhanVien();
        }

        public bool ThemNhanVien(nhanvien objNhanVien)
        {
            return dNhanVien.ThemNhanVien(objNhanVien);
        }

        public List<dynamic> GetListDetailsNhanVien(int maNhanVien)
        {
            return dNhanVien.GetListDetailsNhanVien(maNhanVien);
        }

        public bool SuaNhanVien(nhanvien objNhanVien, int maNhanVien)
        {
            return dNhanVien.SuaNhanVien(objNhanVien, maNhanVien);
        }

        public bool XoaNhanVien(int maNhanVien)
        {
            return dNhanVien.XoaNhanVien(maNhanVien);
        }

        public List<dynamic> TimKiemTenNhanVien(string searchValue)
        {
            return dNhanVien.TimKiemTenNhanVien(searchValue);
        }

    }
}
