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

        public bool ThemGiaTour(giatour objGiaTour)
        {
            return dGiaTour.ThemGiaTour(objGiaTour);
        }


    }


}
