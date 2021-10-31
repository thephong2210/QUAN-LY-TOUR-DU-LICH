using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   
    public class D_diadiemden
    {
        tourdulichEntities tourdulich;

        //Dùng load combobox 
        public List<diadiemden> GetListDiaDiemDen()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDiaDiemDen = tourdulich.diadiemdens;

                return getListDiaDiemDen.ToList<diadiemden>();
            }

        }

        public List<diadiemthamquan> GetListDiaDiemThamQuan()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListTenDDThamQuan = tourdulich.diadiemthamquans;

                return getListTenDDThamQuan.ToList<diadiemthamquan>();

            }

        }

        public List<diadiemtour> GetListDiaDiemTour()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDiaDiemTour = tourdulich.diadiemtours;

                return getListDiaDiemTour.ToList<diadiemtour>();

            }

        }




    }
}
