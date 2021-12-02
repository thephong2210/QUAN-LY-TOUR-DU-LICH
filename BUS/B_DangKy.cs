using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_DangKy
    {
        D_DangKy d_dangky = new D_DangKy();

        public List<dangky> GetAllDangKy()
        {
            return d_dangky.GetAllDangKy();
        }

        public List<dynamic> TimKiemTheoTenKH(string searchValue)
        {
            return d_dangky.TimKiemTheoTenKH(searchValue);
        }

        public List<dynamic> GetListDangKy()
        {
            return d_dangky.GetListDangKy();
        }

        public List<dynamic> GetListDetailsDangKy(int id)
        {
            return d_dangky.GetListDetailsDangKy(id);
        }

        public bool ThemDangKy(dangky objDangKy)
        {
            return d_dangky.ThemDangKy(objDangKy);
        }

        public bool SuaDangKy(dangky objDangKy, int id)
        {
            return d_dangky.SuaDangKy(objDangKy, id);
        }

        public bool XoaDangKy(int id)
        {
            return d_dangky.XoaDangKy(id);
        }

    }
}
