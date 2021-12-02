using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   
    public class D_giatour
    {
        tourdulichEntities tourdulich;

        //Dùng load
        public List<giatour> GetGiaTour()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsTour = from tbGiaTour in tourdulich.giatours select tbGiaTour;

                return getListDetailsTour.ToList<giatour>();

            }

        }

        public List<giatour> TimKiemGiaTour(string searchValue)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsTour = tourdulich.giatours.Where(t=>t.dieuKien.Contains(searchValue));

                return getListDetailsTour.ToList<giatour>();

            }

        }


        //Get giá tour qua mã số tour
        public List<giatour> GetGiaTourWithMaTour(int maSoTour)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getList = tourdulich.giatours.Where(t => t.maGiaTour == maSoTour);

                return getList.ToList<giatour>();
            }
              
        }

        public bool ThemGiaTour(giatour objGiaTour)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.giatours.Add(objGiaTour);
                    tourdulich.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return false;
                }


            }

        }

        public bool XoaGiaTour(giatour objGiaTour, int maSoTour)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    objGiaTour = tourdulich.giatours.Where(ddt => ddt.maGiaTour == maSoTour).SingleOrDefault();
                    tourdulich.giatours.Remove(objGiaTour);

                    tourdulich.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return false;
                }

            }
        }



    }
}
