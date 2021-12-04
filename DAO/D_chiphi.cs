using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_chiphi
    {
        tourdulichEntities tourdulich;

        //Dùng load combobox 
        public List<chiphi> GetListChiPhi() //get all
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getList = tourdulich.chiphis.Where(t => t.trangThai == 1);
                                       
                return getList.ToList<chiphi>();

            }

        }

        public List<chiphi> GetListChiPhiVoiMa(int maChiPhi) 
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getList = tourdulich.chiphis.Where(t => t.trangThai == 1).Where(t=>t.maChiPhi == maChiPhi);

                return getList.ToList<chiphi>();

            }

        }

        public List<chiphi> GetListChiPhiWithMaDoan(int maSoDoan) //get list ứng với mã đoàn
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getList = tourdulich.chiphis.Where(t => t.trangThai == 1).Where(t => t.maSoDoan == maSoDoan);
               
                return getList.ToList<chiphi>();

            }

        }

        public List<dynamic> GetListChiPhiMaDoanOnView(int maSoDoan) //get list ứng với mã đoàn
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getList = (from tbChiPhi in tourdulich.chiphis
                               where (tbChiPhi.trangThai == 1) && (tbChiPhi.maSoDoan == maSoDoan)
                               select new
                               {
                                   maChiPhi = tbChiPhi.maChiPhi,
                                   tenChiPhi = tbChiPhi.tenChiPhi,
                                   tongChiPhi = tbChiPhi.tongChiPhi
                               });
                return getList.ToList<dynamic>();

            }

        }

        public bool ThemChiPhi(chiphi objName)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.chiphis.Add(objName);
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

        public bool XoaChiPhi(int maLoai)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    chiphi objLoai = tourdulich.chiphis.Where(t => t.maChiPhi == maLoai).SingleOrDefault();
                    objLoai.trangThai = 0;
                    
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

        public bool SuaChiPhi(chiphi objLoai, int maLoai)
        {

            using (tourdulich = new tourdulichEntities())

            {
                try
                {
                    chiphi objOldLoai = tourdulich.chiphis.Where(t => t.maChiPhi == maLoai).SingleOrDefault();

                    //objOldLoai.tenChiPhi = objLoai.tenChiPhi;
                    //objOldLoai.maSoDoan = objLoai.maSoDoan;
                    objOldLoai.tongChiPhi = objLoai.tongChiPhi;
                    //objOldLoai.trangThai = objLoai.trangThai;

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
