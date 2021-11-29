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

        //Địa điểm đến
        public List<diadiemden> GetListDiaDiemDen()
        {
            return dDiaDiemDen.GetListDiaDiemDen();
        }

        public bool ThemDiaDiemDen(diadiemden objDiaDiemDen)
        {
            return dDiaDiemDen.ThemDiaDiemDen(objDiaDiemDen);
        }

        public bool SuaDiaDiemDen(diadiemden objDiaDiemDen, int maDiaDiemDen)
        {
            return dDiaDiemDen.SuaDiaDiemDen(objDiaDiemDen, maDiaDiemDen);
        }

        public List<diadiemden> TimKiemTenDiaDiemDen(string searchValue)
        {
            return dDiaDiemDen.TimKiemTenDiaDiemDen(searchValue);
        }


        //Địa điểm tham quan
        public bool ThemDiaDiemThamQuan(diadiemthamquan objDiaDiemThamQuan)
        {
            return dDiaDiemDen.ThemDiaDiemThamQuan(objDiaDiemThamQuan);
        }

        public List<diadiemthamquan> GetListDiaDiemThamQuan()
        {
            return dDiaDiemDen.GetListDiaDiemThamQuan();
        }

        public List<diadiemthamquan> GetListDetailsDiaDiemThamQuan(int maDiaDiemDenTemp)
        {
            return dDiaDiemDen.GetListDetailsDiaDiemThamQuan(maDiaDiemDenTemp);
        }

        public bool XoaDiaDiemThamQuan(diadiemthamquan objDiaDiemThamQuan, int maDiaDiem)
        {
            return dDiaDiemDen.XoaDiaDiemThamQuan(objDiaDiemThamQuan, maDiaDiem);
        }

        //Địa điểm đăng ký trong tour
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
