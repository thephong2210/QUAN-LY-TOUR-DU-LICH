using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_LoaiChiPhi
    {
        tourdulichEntities tourdulich;

        public List<loaichiphi> GetLoaiChiPhi()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListLoai = tourdulich.loaichiphis.Where(t => t.trangThai == 1);
                return getListLoai.ToList<loaichiphi>();
            }    
        }

        public List<loaichiphi> TimKiemTenLoaiChiPhi(string searchValue)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListLoai = tourdulich.loaichiphis.Where(t => t.trangThai == 1).Where(t=>t.tenLoaiChiPhi.Contains(searchValue));
                return getListLoai.ToList<loaichiphi>();
            }
        }


        public bool ThemLoaiChiPhi(loaichiphi objLoai)
        {
            using (tourdulich = new tourdulichEntities())
                try
                {
                    tourdulich.loaichiphis.Add(objLoai);
                    tourdulich.SaveChanges();
                    return true;

                }catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }

        }

        public bool XoaLoaiChiPhi(int maLoai)
        {
            using (tourdulich= new tourdulichEntities())
                try
                {
                    loaichiphi objLoai = tourdulich.loaichiphis.Where(t => t.maLoaiChiPhi == maLoai).SingleOrDefault();
                    objLoai.trangThai = 0;


                    tourdulich.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }
        }

        public bool SuaLoaiChiPhi(loaichiphi objLoai,int maLoai)
        {
            using (tourdulich = new tourdulichEntities())
                try
                {
                    loaichiphi objOldLoai = tourdulich.loaichiphis.Where(t => t.maLoaiChiPhi == maLoai).SingleOrDefault();
                    objOldLoai.tenLoaiChiPhi = objLoai.tenLoaiChiPhi;
                    objOldLoai.trangThai = objLoai.trangThai;

                    tourdulich.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }
            
        }
    }
}
