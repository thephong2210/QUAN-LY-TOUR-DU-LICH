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
        public List<chiphi> GetListLoaiChiPhi()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getList = tourdulich.chiphis.Where(t => t.trangThai == 1);
                                       
                return getList.ToList<chiphi>();

            }

        }

        public List<chiphi> GetListLoaiChiPhiWithMaDoan(int maSoDoan)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getList = tourdulich.chiphis.Where(t => t.trangThai == 1).Where(t => t.maSoDoan == maSoDoan);

                return getList.ToList<chiphi>();

            }

        }

        public bool ThemLoaiChiPhi(chiphi objName)
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

        public bool XoaLoaiChiPhi(int maLoai)
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

        public bool SuaLoaiChiPhi(chiphi objLoai, int maLoai)
        {

            using (tourdulich = new tourdulichEntities())

            {
                try
                {
                    chiphi objOldLoai = tourdulich.chiphis.Where(t => t.maChiPhi == maLoai).SingleOrDefault();

                    objOldLoai.tenChiPhi = objLoai.tenChiPhi;
                    objOldLoai.maSoDoan = objLoai.maSoDoan;
                    objOldLoai.tongChiPhi = objLoai.tongChiPhi;
                    objOldLoai.trangThai = objLoai.trangThai;

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
