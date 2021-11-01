using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_loaihinhdulich
    {
        tourdulichEntities tourdulich;

        //Dùng load combobox 
        public List<loaihinhdulich> GetListLoaiHinhDL()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListTenLHDL = tourdulich.loaihinhduliches;
                                       
                return getListTenLHDL.ToList<loaihinhdulich>();

            }

        }

    }
}
