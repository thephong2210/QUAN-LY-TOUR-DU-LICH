using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class B_loaichiphi
    {
        D_loaichiphi d_LoaiChiPhi = new D_loaichiphi();

        public List<loaichiphi> GetListLoaiChiPhi()
        {
            return d_LoaiChiPhi.GetListLoaiChiPhi();
        }
        

        public bool ThemLoaiChiPhi(loaichiphi objLoai)
        {
            return d_LoaiChiPhi.ThemLoaiChiPhi(objLoai);
        }

        public bool XoaLoaiChiPhi(int maLoai)
        {
            return d_LoaiChiPhi.XoaLoaiChiPhi(maLoai);
        }

        public bool SuaLoaiChiPhi(loaichiphi objLoai,int maLoai)
        {
            return d_LoaiChiPhi.SuaLoaiChiPhi(objLoai, maLoai);
        }

    }
}
