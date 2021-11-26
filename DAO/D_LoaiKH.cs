using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_LoaiKH
    {
        tourdulichEntities tourdulich;

        public List<loaikhachhang> GetLoaikhachhangs()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListLoaiKH = tourdulich.loaikhachhangs;
                return getListLoaiKH.ToList<loaikhachhang>();
            }    
        }

        public List<dynamic> GetListDetailsLoaiKhachHang(int maLoaiKhachHang)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsLoaiKhachHang = (from tbLoaiKhachHang in tourdulich.loaikhachhangs
                                               where tbLoaiKhachHang.maLoaiKhachHang == maLoaiKhachHang
                                               select new
                                               {
                                                   maLoaiKhachHang = tbLoaiKhachHang.maLoaiKhachHang,
                                                   tenLoaiKhachHang = tbLoaiKhachHang.tenLoaiKhachHang
                                                  
                                               });

                return getListDetailsLoaiKhachHang.ToList<dynamic>();
            }
        }

        public List<dynamic> GetListLoaiKhachHang()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListLoaiKhachHang = (from tbLoaiKhachHang in tourdulich.loaikhachhangs
                                       select new
                                       {
                                           maLoaiKhachHang = tbLoaiKhachHang.maLoaiKhachHang,
                                           tenLoaiKhachHang = tbLoaiKhachHang.tenLoaiKhachHang
                                           
                                       });

                return getListLoaiKhachHang.ToList<dynamic>();

            }

        }


        public bool ThemLoaiKH(loaikhachhang objLoaiKH)
        {
            using (tourdulich = new tourdulichEntities())
                try
                {
                    tourdulich.loaikhachhangs.Add(objLoaiKH);
                    tourdulich.SaveChanges();
                    return true;

                }catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }

        }

        public bool XoaLoaiKH(loaikhachhang objLoaiKH, int maLoaiKH)
        {
            using (tourdulich= new tourdulichEntities())
                try
                {
                    objLoaiKH = tourdulich.loaikhachhangs.Where(t => t.maLoaiKhachHang == maLoaiKH).SingleOrDefault();
                    tourdulich.loaikhachhangs.Remove(objLoaiKH);
                    
                    tourdulich.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }
        }

        public bool SuaLoaiKH(loaikhachhang objLoaiKH,int maLoaiKH)
        {
            using (tourdulich = new tourdulichEntities())
                try
                {
                    loaikhachhang objOldLoaiKH = tourdulich.loaikhachhangs.Where(t => t.maLoaiKhachHang == maLoaiKH).SingleOrDefault();
                    objOldLoaiKH.tenLoaiKhachHang = objLoaiKH.tenLoaiKhachHang;
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
