using DAO;
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


    }
}
