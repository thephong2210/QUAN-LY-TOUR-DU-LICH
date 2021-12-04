using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class B_chiphi
    {
        D_chiphi d_ChiPhi = new D_chiphi();

        public List<chiphi> GetListLoaiChiPhi()
        {
            return d_ChiPhi.GetListChiPhi();
        }
        

        public bool ThemLoaiChiPhi(chiphi objLoai)
        {
            return d_ChiPhi.ThemChiPhi(objLoai);
        }

        public bool XoaLoaiChiPhi(int maLoai)
        {
            return d_ChiPhi.XoaChiPhi(maLoai);
        }

        public bool SuaLoaiChiPhi(chiphi objLoai,int maLoai)
        {
            return d_ChiPhi.SuaChiPhi(objLoai, maLoai);
        }

    }
}
