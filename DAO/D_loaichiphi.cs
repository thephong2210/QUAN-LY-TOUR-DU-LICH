using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_loaichiphi
    {
        tourdulichEntities tourdulich;

        //Dùng load combobox 
        public List<loaichiphi> GetListLoaiChiPhi()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getList = tourdulich.loaichiphis.Where(t => t.trangThai == 1);
                                       
                return getList.ToList<loaichiphi>();

            }

        }
        
        public bool ThemLoaiChiPhi(loaichiphi objName)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.loaichiphis.Add(objName);
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
                    loaichiphi objLoai = tourdulich.loaichiphis.Where(t => t.maLoaiChiPhi == maLoai).SingleOrDefault();
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

        public bool SuaLoaiChiPhi(loaichiphi objLoai, int maLoai)
        {

            using (tourdulich = new tourdulichEntities())

            {
                try
                {
                    loaichiphi objOldLoai = tourdulich.loaichiphis.Where(t => t.maLoaiChiPhi == maLoai).SingleOrDefault();

                    objOldLoai.tenLoaiChiPhi = objLoai.tenLoaiChiPhi;
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
