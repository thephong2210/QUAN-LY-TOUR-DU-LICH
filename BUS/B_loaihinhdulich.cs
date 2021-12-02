using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class B_loaihinhdulich
    {
        D_loaihinhdulich d_LoaiHinhDuLich = new D_loaihinhdulich();

        public List<loaihinhdulich> GetListLoaiHinhDL()
        {
            return d_LoaiHinhDuLich.GetListLoaiHinhDL();
        }
        public List<loaihinhdulich> TimKiemTenLoaiHinhDuLich(string searchValue)
        {
            return d_LoaiHinhDuLich.TimKiemTenLoaiHinhDuLich(searchValue);
        }



        public bool ThemLoaiHinhDuLich(loaihinhdulich objLoaiHinhDuLich)
        {
            return d_LoaiHinhDuLich.ThemLoaiHinhDuLich(objLoaiHinhDuLich);
        }

        public bool XoaLoaiHinhDuLich(int maLoaiHinhDuLich)
        {
            return d_LoaiHinhDuLich.XoaLoaiHinhDuLich(maLoaiHinhDuLich);
        }

        public bool SuaLoaiHinhDuLich(loaihinhdulich objLoaiHinhDuLich,int maLoaiHinhDuLich)
        {
            return d_LoaiHinhDuLich.SuaLoaiHinhDuLich(objLoaiHinhDuLich, maLoaiHinhDuLich);
        }

    }
}
