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
                var getListTenLHDL = tourdulich.loaihinhduliches;
                                       
                return getListTenLHDL.ToList<loaihinhdulich>();

            }

        }
        public List<dynamic> GetListDetailsLoaiHinhDuLich(int maLoaiHinhDuLich)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsLoaiHinhDuLich = (from tbLoaiHinhDuLich in tourdulich.loaihinhduliches
                                                   where tbLoaiHinhDuLich.maLoaiHinhDuLich == maLoaiHinhDuLich
                                                   select new
                                                   {
                                                       maLoaiHinhDulich = tbLoaiHinhDuLich.maLoaiHinhDuLich,
                                                       tenLoaiHinhDuLich = tbLoaiHinhDuLich.tenLoaiHinhDuLich

                                                   });

                return getListDetailsLoaiHinhDuLich.ToList<dynamic>();
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

        public bool XoaLoaiHinhDuLich(loaihinhdulich objLoaiHinhDuLich,int maLoaiHinhDuLich)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    objLoaiHinhDuLich = tourdulich.loaihinhduliches.Where(t => t.maLoaiHinhDuLich == maLoaiHinhDuLich).SingleOrDefault();
                     tourdulich.loaihinhduliches.Remove(objLoaiHinhDuLich);
                    
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
