using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_LoaiChiPhi
    {
        D_LoaiChiPhi d_LoaiChiPhi = new D_LoaiChiPhi();

        public List<loaichiphi> GetLoaiChiPhi()
        {
            return d_LoaiChiPhi.GetLoaiChiPhi();
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


        public List<loaichiphi> TimKiemTenLoaiChiPhi(string searchValue)
        {
            return d_LoaiChiPhi.TimKiemTenLoaiChiPhi(searchValue);
        }

    }
}
