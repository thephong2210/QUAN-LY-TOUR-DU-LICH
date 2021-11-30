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

        //Địa điểm đến
        public List<diadiemden> GetListDiaDiemDen()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDiaDiemDen = tourdulich.diadiemdens.Where(t => t.trangThai == 1);

                return getListDiaDiemDen.ToList<diadiemden>();
            }

        }

        public bool ThemDiaDiemDen(diadiemden objDiaDiemDen)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.diadiemdens.Add(objDiaDiemDen);
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

        public bool SuaDiaDiemDen(diadiemden objDiaDiemDen, int maDiaDiemDen)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    diadiemden objOld = tourdulich.diadiemdens.Where(t => t.maDiaDiemDen == maDiaDiemDen).SingleOrDefault();
                    objOld.tenDiaDiemDen = objDiaDiemDen.tenDiaDiemDen;
                    objOld.trangThai = objDiaDiemDen.trangThai;

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

        public List<diadiemden> TimKiemTenDiaDiemDen(string searchValue)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDiaDiemDen = tourdulich.diadiemdens.Where(t => t.tenDiaDiemDen.Contains(searchValue)).Where(t => t.trangThai == 1);

                return getListDiaDiemDen.ToList<diadiemden>();
            }

        }

        //Địa điểm tham quan
        public List<diadiemthamquan> GetListDiaDiemThamQuan()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListTenDDThamQuan = tourdulich.diadiemthamquans;

                return getListTenDDThamQuan.ToList<diadiemthamquan>();

            }

        }

        public List<diadiemthamquan> GetListDetailsDiaDiemThamQuan(int maDiaDiemDenTemp)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsDDD = tourdulich.diadiemthamquans.Where(maDiaDiemDen => maDiaDiemDen.maDiaDiemDen == maDiaDiemDenTemp);

                return getListDetailsDDD.ToList<diadiemthamquan>();

            }

        }

        public bool ThemDiaDiemThamQuan(diadiemthamquan objDiaDiemThamQuan)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.diadiemthamquans.Add(objDiaDiemThamQuan);
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

        public bool XoaDiaDiemThamQuan(diadiemthamquan objDiaDiemThamQuan, int maDiaDiem)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    objDiaDiemThamQuan = tourdulich.diadiemthamquans.Where(ddt => ddt.maDiaDiem == maDiaDiem).SingleOrDefault();
                    tourdulich.diadiemthamquans.Remove(objDiaDiemThamQuan);

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


        //Địa điểm đã đăng ký trong tour
        public List<diadiemtour> GetListDiaDiemTour()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDiaDiemTour = tourdulich.diadiemtours;

                return getListDiaDiemTour.ToList<diadiemtour>();

            }

        }

        public bool ThemDiaDiemTour(diadiemtour objDiaDiemTour)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.diadiemtours.Add(objDiaDiemTour);
                    tourdulich.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return false;
                }
                
            }
        }

        public bool XoaDiaDiemTour(diadiemtour objDiaDiemTour, int id)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    objDiaDiemTour = tourdulich.diadiemtours.Where(ddt => ddt.id == id).SingleOrDefault();
                    tourdulich.diadiemtours.Remove(objDiaDiemTour);

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

        //public bool SuaDiaDiemTour(diadiemtour objDiaDiemTour, int id)
        //{
        //    using (tourdulich = new tourdulichEntities())
        //    {
        //        try
        //        {
        //            diadiemtour objDiaDiemTourOld = tourdulich.diadiemtours.Where(ddt => ddt.id == id).SingleOrDefault();
        //            objDiaDiemTourOld.maTour = objDiaDiemTour.maTour;
        //            objDiaDiemTourOld.tenDiaDiemThamQuan = objDiaDiemTour.tenDiaDiemThamQuan;

        //            tourdulich.SaveChanges();
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            System.Diagnostics.Debug.WriteLine(ex);
        //            return false;
        //        }

        //    }
        //}




    }
}
