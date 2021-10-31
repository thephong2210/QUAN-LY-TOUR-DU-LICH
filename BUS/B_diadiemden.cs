using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class B_diadiemden
    {
        D_diadiemden dDiaDiemDen = new D_diadiemden();

        public List<diadiemden> GetListDiaDiemDen()
        {
            return dDiaDiemDen.GetListDiaDiemDen();
        }

        public List<diadiemthamquan> GetListDiaDiemThamQuan()
        {
            return dDiaDiemDen.GetListDiaDiemThamQuan();
        }

        public List<diadiemtour> GetListDiaDiemTour()
        {
            return dDiaDiemDen.GetListDiaDiemTour();
        }

    }


}
