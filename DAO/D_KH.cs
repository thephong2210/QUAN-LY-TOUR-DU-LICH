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
                var getKhachHang = tourdulich.khachhangs.Where(t => t.trangThai == 1);

                return getKhachHang.ToList<khachhang>();

            }

        }

        public List<khachhang> TimKiemTenKhachHang(string searchValue)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getKhachHang = tourdulich.khachhangs.Where(t => t.trangThai == 1).Where(t=>t.hoTenKhachHang.Contains(searchValue));

                return getKhachHang.ToList<khachhang>();

            }

        }

        public List<dynamic> GetListKhachHang()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListKhachHang = (from tbKhachHang in tourdulich.khachhangs
                                        where tbKhachHang.trangThai == 1
                                       select new
                                       {
                                           maSoKhachHang = tbKhachHang.maSoKhachHang,
                                           hoTenKhachHang = tbKhachHang.hoTenKhachHang,
                                           soCMND = tbKhachHang.soCMND,
                                           diaChi = tbKhachHang.diaChi,
                                           gioiTinh = tbKhachHang.gioiTinh,
                                           SDT= tbKhachHang.SDT,
                                           quocTich = tbKhachHang.quocTich
                                       });

                return getListKhachHang.ToList<dynamic>();

            }

        }

        public List<dynamic> GetListDetailsKhachHang(int maSoKhachHang)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsKhachHang = (from tbKhachHang in tourdulich.khachhangs
                                              where tbKhachHang.maSoKhachHang == maSoKhachHang
                                              select new
                                              {
                                                  maSoKhachHang = tbKhachHang.maSoKhachHang,
                                                  hoTenKhachHang = tbKhachHang.hoTenKhachHang,
                                                  soCMND = tbKhachHang.soCMND,
                                                  diaChi = tbKhachHang.diaChi,
                                                  gioiTinh = tbKhachHang.gioiTinh,
                                                  SDT = tbKhachHang.SDT,
                                                  quocTich = tbKhachHang.quocTich
                                              });

                return getListDetailsKhachHang.ToList<dynamic>();
            }
        }


        public List<khachhang> GetListDetailsKhachHang2(int maSoKhachHang)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getKhachHang = tourdulich.khachhangs.Where(t => t.trangThai == 1).Where(t=>t.maSoKhachHang == maSoKhachHang);

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

        public bool XoaKhachHang(int maSoKhachHang)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    khachhang objKhachHang = tourdulich.khachhangs.Where(kh => kh.maSoKhachHang == maSoKhachHang).SingleOrDefault();
                    objKhachHang.trangThai = 0;

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
                    objOldKhachHang.trangThai = objKhachHang.trangThai;

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
