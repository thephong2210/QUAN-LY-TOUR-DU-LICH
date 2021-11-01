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

        public bool ThemDiaDiemTour(diadiemtour objDiaDiemTour)
        {
            return dDiaDiemDen.ThemDiaDiemTour(objDiaDiemTour);
        }

        public bool XoaDiaDiemTour(diadiemtour objDiaDiemTour, int id)
        {
            return dDiaDiemDen.XoaDiaDiemTour(objDiaDiemTour, id);
        }

        //public bool SuaDiaDiemTour(diadiemtour objDiaDiemTour, int id)
        //{
        //    return dDiaDiemDen.SuaDiaDiemTour(objDiaDiemTour, id);
        //}



    }


}
