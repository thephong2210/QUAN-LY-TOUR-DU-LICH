using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class D_doan
    {
        tourdulichEntities tourdulich = new tourdulichEntities();
        public List<doandulich> GetAllDoan()
        {
            {
                var getAllTour = tourdulich.doanduliches;
                return getAllTour.ToList<doandulich>();
            }
        }
        public List<dynamic> GetListDoan()
        {

            {
                var getListDoan = (from tbDoan in tourdulich.doanduliches
                                   join tbTour in tourdulich.tours on tbDoan.maSoTour equals tbTour.maSoTour
                                   select new
                                   {
                                       Mã = tbDoan.maSoDoan,
                                       TênGọiĐoàn = tbDoan.tenGoiDoan,
                                       TênGọiTour = tbTour.tenGoiTour,
                                       thoiGianKhoiHanh = tbDoan.thoiGianKhoiHanh,
                                       thoiGianKetThuc = tbDoan.thoiGianKetThuc,
                                       Chi_tiết = tbDoan.chiTiet
                                   });

                return getListDoan.ToList<dynamic>();

            }

        }
        public List<dynamic> GetKhachHangOfDoan(int maDoan)
        {

            {
                var getKHDoan = (from tbDangKy in tourdulich.dangkies
                                 where tbDangKy.maSoDoan == maDoan
                                 join tbKH in tourdulich.khachhangs on tbDangKy.maSoKhachHang equals tbKH.maSoKhachHang
                                 join tbDoan in tourdulich.doanduliches on tbDangKy.maSoDoan equals tbDoan.maSoDoan



                                 select new
                                 {
                                     id = tbKH.maSoKhachHang,
                                     ten = tbKH.hoTenKhachHang



                                 });

                return getKHDoan.ToList<dynamic>();

            }


        }
        public List<dynamic> GetNhanVienOfDoan(int maDoan)
        {

            {
                var getNVDoan = (from tbThamGia in tourdulich.thamgiadoans
                                 where tbThamGia.maSoDoan == maDoan
                                 join tbNV in tourdulich.nhanviens on tbThamGia.maNhanVien equals tbNV.maNhanVien
                                 join tbDoan in tourdulich.doanduliches on tbThamGia.maSoDoan equals tbDoan.maSoDoan
                                 select new
                                 {
                                     id = tbNV.maNhanVien,
                                     ten = tbNV.tenNhanVien

                                 });

                return getNVDoan.ToList<dynamic>();

            }


        }
        public bool ThemDoan(doandulich objDoan)
        {
            {
                try
                {
                    tourdulich.doanduliches.Add(objDoan);
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

        public bool SuaDoan(doandulich objDoan, int maSoDoan)
        {
            {
                try
                {
                    doandulich objDoanOld = tourdulich.doanduliches.Where(t => t.maSoDoan == maSoDoan).SingleOrDefault();
                    objDoanOld.tenGoiDoan = objDoan.tenGoiDoan;
                    objDoanOld.thoiGianKhoiHanh = objDoan.thoiGianKhoiHanh;
                    objDoanOld.thoiGianKetThuc = objDoan.thoiGianKetThuc;
                    objDoanOld.chiTiet = objDoan.chiTiet;
                    objDoanOld.maSoTour = objDoan.maSoTour;


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

        public bool XoaDoan(int maSoDoan)
        {

            {
                try
                {
                    doandulich objDoan = new doandulich();
                    objDoan = tourdulich.doanduliches.Where(t => t.maSoDoan == maSoDoan).SingleOrDefault();
                    tourdulich.doanduliches.Remove(objDoan);

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
