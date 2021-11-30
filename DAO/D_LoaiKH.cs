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
                var getListLoaiKH = tourdulich.loaikhachhangs.Where(t => t.trangThai == 1);
                return getListLoaiKH.ToList<loaikhachhang>();
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

        public bool XoaLoaiKH(int maLoaiKH)
        {
            using (tourdulich= new tourdulichEntities())
                try
                {
                    loaikhachhang objLoaiKH = tourdulich.loaikhachhangs.Where(t => t.maLoaiKhachHang == maLoaiKH).SingleOrDefault();
                    objLoaiKH.trangThai = 0;


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
                    objOldLoaiKH.trangThai = objLoaiKH.trangThai;

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
