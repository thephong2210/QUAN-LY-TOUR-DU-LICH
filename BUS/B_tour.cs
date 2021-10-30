using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_tour
    {
        D_tour dTour = new D_tour();

        //Get list tour tùy chỉnh
        public List<dynamic> GetListTour()
        {
            return dTour.GetListTour();
        }

        public List<dynamic> GetListDetailsTour(int maSoTour)
        {
            return dTour.GetListDetailsTour(maSoTour);
        }


    }
}
