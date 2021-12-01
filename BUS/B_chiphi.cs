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
        D_chiphi d_LoaiChiPhi = new D_chiphi();

        public List<chiphi> GetListLoaiChiPhi()
        {
            return d_LoaiChiPhi.GetListLoaiChiPhi();
        }
        

        public bool ThemLoaiChiPhi(chiphi objLoai)
        {
            return d_LoaiChiPhi.ThemLoaiChiPhi(objLoai);
        }

        public bool XoaLoaiChiPhi(int maLoai)
        {
            return d_LoaiChiPhi.XoaLoaiChiPhi(maLoai);
        }

        public bool SuaLoaiChiPhi(chiphi objLoai,int maLoai)
        {
            return d_LoaiChiPhi.SuaLoaiChiPhi(objLoai, maLoai);
        }

    }
}
