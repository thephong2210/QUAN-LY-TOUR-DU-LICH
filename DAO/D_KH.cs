using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   
    public class D_KH

    {
        tourdulichEntities tourdulich;

        //Dùng load
        public List<khachhang> GetKhachHang()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getKhachHang = tourdulich.khachhangs;

                return getKhachHang.ToList<khachhang>();

            }

        }

        public bool ThemKhachHang(khachhang objKhachHang)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.khachhangs.Add(objKhachHang);
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

        public bool XoaKhachHang(khachhang objKhachHang, int maSoKhachHang)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    objKhachHang = tourdulich.khachhangs.Where(kh => kh.maSoKhachHang == maSoKhachHang).SingleOrDefault();
                    tourdulich.khachhangs.Remove(objKhachHang);

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

        public bool SuaKhachHang(khachhang objKhachHang, int maSoKhachHang)
        {
            using (tourdulich = new tourdulichEntities())
                try
                {
                    khachhang objOldKhachHang= tourdulich.khachhangs.Where(t => t.maSoKhachHang == maSoKhachHang).SingleOrDefault();
                    objOldKhachHang.hoTenKhachHang = objKhachHang.hoTenKhachHang;
                    objOldKhachHang.soCMND = objKhachHang.soCMND;
                    objOldKhachHang.diaChi = objKhachHang.diaChi;
                    objOldKhachHang.gioiTinh = objKhachHang.gioiTinh;
                    objOldKhachHang.SDT = objKhachHang.SDT;
                    objOldKhachHang.quocTich = objKhachHang.quocTich;
                    tourdulich.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return false;
                }

        }



    }
}
