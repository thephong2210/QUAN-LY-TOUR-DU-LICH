using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class B_giatour
    {
        D_giatour dGiaTour = new D_giatour();

        public List<giatour> GetGiaTour()
        {
            return dGiaTour.GetGiaTour();
        }

        public List<giatour> TimKiemGiaTour(string searchValue)
        {
            return dGiaTour.TimKiemGiaTour(searchValue);
        }

        public List<giatour> GetGiaTourWithMaTour(int maSoTour)
        {
            return dGiaTour.GetGiaTourWithMaTour(maSoTour);
        }

        public bool ThemGiaTour(giatour objGiaTour)
        {
            return dGiaTour.ThemGiaTour(objGiaTour);
        }

        public bool XoaGiaTour(giatour objGiaTour, int maSoTour)
        {
            return dGiaTour.XoaGiaTour(objGiaTour, maSoTour);
        }

    }


}
