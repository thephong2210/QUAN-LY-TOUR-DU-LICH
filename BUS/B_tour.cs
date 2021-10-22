using DAO;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class B_tour
    {
        D_tour dao_Tour = new D_tour();

        public DataTable GetListTour()
        {
            return dao_Tour.GetListTour();
        }

        public void ThemTour(DTO_tour DTOtour)
        {
            dao_Tour.ThemTour(DTOtour);
        }

        //ghi tạm
        public DataSet GetListDiaDiem()
        {
            return dao_Tour.GetListDiaDiem();
        }

        public DataTable GetMaDiaDiem(String tenDiaDiem)
        {
            return dao_Tour.GetMaDiaDiem(tenDiaDiem);
        }

        public DataSet GetListLoaiHinhDuLich()
        {
            return dao_Tour.GetListLoaiHinhDuLich();
        }

        public DataTable GetMaLoaiHinhDuLich(string tenLoaiHinhDuLich)
        {
            return dao_Tour.GetMaLoaiHinhDuLich(tenLoaiHinhDuLich);
        }



    }
}
