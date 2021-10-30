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
        D_loaihinhdulich dLoaiHinhDuLich = new D_loaihinhdulich();

        public List<loaihinhdulich> GetListLoaiHinhDL()
        {
            return dLoaiHinhDuLich.GetListLoaiHinhDL();
        }


    }
}
