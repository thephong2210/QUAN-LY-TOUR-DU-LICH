using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_dangkynhanvien
    {
        tourdulichEntities tourdulich;
        public List<thamgiadoan> GetAllDangKy()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getAllDangKy = tourdulich.thamgiadoans.Where(t=>t.trangThai == 1);
                return getAllDangKy.ToList<thamgiadoan>();
            }
        }

        
        //Load on datagridview
        public List<dynamic> GetListDangKy()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDangKy = (from tbThamGiaDoan in tourdulich.thamgiadoans
                                   join tbNhanVien in tourdulich.nhanviens on tbThamGiaDoan.maNhanVien equals tbNhanVien.maNhanVien
                                   join tbDoan in tourdulich.doanduliches on tbThamGiaDoan.maSoDoan equals tbDoan.maSoDoan
                                   where tbThamGiaDoan.trangThai == 1
                                   select new
                                   {
                                       maThamGia = tbThamGiaDoan.maThamGia,
                                       tenNhanVien = tbNhanVien.tenNhanVien,
                                       tenDoan = tbDoan.tenGoiDoan,
                                       thoiGianBatDau = tbThamGiaDoan.thoiGianBatDau,
                                       thoiGianKetThuc = tbThamGiaDoan.thoiGianKetThuc
                                   });

                return getListDangKy.ToList<dynamic>();

            }

        }

        public List<dynamic> TimKiemTheoTenNV(string searchValue)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDangKy = (from tbThamGiaDoan in tourdulich.thamgiadoans
                                     join tbNhanVien in tourdulich.nhanviens on tbThamGiaDoan.maNhanVien equals tbNhanVien.maNhanVien
                                     join tbDoan in tourdulich.doanduliches on tbThamGiaDoan.maSoDoan equals tbDoan.maSoDoan
                                     where tbThamGiaDoan.trangThai == 1
                                     select new
                                     {
                                         maThamGia = tbThamGiaDoan.maThamGia,
                                         tenNhanVien = tbNhanVien.tenNhanVien,
                                         tenDoan = tbDoan.tenGoiDoan,
                                         thoiGianBatDau = tbThamGiaDoan.thoiGianBatDau,
                                         thoiGianKetThuc = tbThamGiaDoan.thoiGianKetThuc
                                     }).Where(t=>t.tenNhanVien.Contains(searchValue));

                return getListDangKy.ToList<dynamic>();

            }

        }

        public List<dynamic> GetListDetailsDangKy(int maThamGia)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDangKy = (from tbThamGiaDoan in tourdulich.thamgiadoans
                                     join tbNhanVien in tourdulich.nhanviens on tbThamGiaDoan.maNhanVien equals tbNhanVien.maNhanVien
                                     join tbDoan in tourdulich.doanduliches on tbThamGiaDoan.maSoDoan equals tbDoan.maSoDoan
                                     where tbThamGiaDoan.maThamGia == maThamGia
                                     select new
                                     {
                                         maThamGia = tbThamGiaDoan.maThamGia,
                                         tenNhanVien = tbNhanVien.tenNhanVien,
                                         tenDoan = tbDoan.tenGoiDoan,
                                         thoiGianBatDau = tbThamGiaDoan.thoiGianBatDau,
                                         thoiGianKetThuc = tbThamGiaDoan.thoiGianKetThuc
                                     });

                return getListDangKy.ToList<dynamic>();

            }

        }

        public bool ThemDangKy(thamgiadoan objDangKy)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.thamgiadoans.Add(objDangKy);
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


        public bool XoaDangKy(int maThamGia)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    thamgiadoan objDangKyOld = tourdulich.thamgiadoans.Where(t => t.maThamGia == maThamGia).SingleOrDefault();
                    objDangKyOld.trangThai = 0;

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
