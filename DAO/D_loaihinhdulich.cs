using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_loaihinhdulich
    {
        tourdulichEntities tourdulich;

        //Dùng load combobox 
        public List<loaihinhdulich> GetListLoaiHinhDL()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListTenLHDL = tourdulich.loaihinhduliches.Where(t => t.trangThai == 1);
                                       
                return getListTenLHDL.ToList<loaihinhdulich>();

            }

        }

        public List<loaihinhdulich> TimKiemTenLoaiHinhDuLich(string searchValue)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListTenLHDL = tourdulich.loaihinhduliches.Where(t => t.trangThai == 1).Where(t=>t.tenLoaiHinhDuLich.Contains(searchValue));

                return getListTenLHDL.ToList<loaihinhdulich>();

            }

        }

        public bool ThemLoaiHinhDuLich(loaihinhdulich objLoaiHinhDuLich)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.loaihinhduliches.Add(objLoaiHinhDuLich);
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

        public bool XoaLoaiHinhDuLich(int maLoaiHinhDuLich)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                     loaihinhdulich objLoaiHinhDuLich = tourdulich.loaihinhduliches.Where(t => t.maLoaiHinhDuLich == maLoaiHinhDuLich).SingleOrDefault();
                     objLoaiHinhDuLich.trangThai = 0;
                    
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
        public bool SuaLoaiHinhDuLich(loaihinhdulich objLoaiHinhDuLich, int maLoaiHinhDuLich)
        {
            
            using (tourdulich = new tourdulichEntities())
                
            {
                try
                {
                    loaihinhdulich objOldLoaiHinhDuLich = tourdulich.loaihinhduliches.Where(t => t.maLoaiHinhDuLich == maLoaiHinhDuLich).SingleOrDefault();
                    
                    objOldLoaiHinhDuLich.tenLoaiHinhDuLich = objLoaiHinhDuLich.tenLoaiHinhDuLich;
                    objOldLoaiHinhDuLich.trangThai = objLoaiHinhDuLich.trangThai;

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
