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
                var getAllTour = tourdulich.doanduliches.Where(t => t.trangThai == 1);
                return getAllTour.ToList<doandulich>();
            }
        }

        public List<doandulich> GetOneDoan(int maSoDoan)
        {
            {
                var getAllTour = tourdulich.doanduliches.Where(t => t.trangThai == 1).Where(t=>t.maSoDoan == maSoDoan);
                return getAllTour.ToList<doandulich>();
            }
        }

        public List<dynamic> GetOneDoan2(int maSoDoan)
        {

            {
                var getListDoan = (from tbDoan in tourdulich.doanduliches
                                   join tbTour in tourdulich.tours on tbDoan.maSoTour equals tbTour.maSoTour
                                   where tbDoan.trangThai == 1 && tbDoan.maSoDoan == maSoDoan
                                   select new
                                   {
                                       ID = tbDoan.maSoDoan,
                                       TenDoan = tbDoan.tenGoiDoan,
                                       TenTour = tbTour.tenGoiTour,
                                       thoiGianKhoiHanh = tbDoan.thoiGianKhoiHanh,
                                       thoiGianKetThuc = tbDoan.thoiGianKetThuc,
                                       chitiet = tbDoan.chiTiet

                                   });

                return getListDoan.ToList<dynamic>();

            }

        }
        public List<dynamic> GetListDoan()
        {

            {
                var getListDoan = (from tbDoan in tourdulich.doanduliches
                                   join tbTour in tourdulich.tours on tbDoan.maSoTour equals tbTour.maSoTour
                                   where tbDoan.trangThai == 1
                                   select new
                                   {
                                       ID = tbDoan.maSoDoan,
                                       TenDoan = tbDoan.tenGoiDoan,
                                       TenTour = tbTour.tenGoiTour,
                                       thoiGianKhoiHanh = tbDoan.thoiGianKhoiHanh,
                                       thoiGianKetThuc = tbDoan.thoiGianKetThuc,
                                       chitiet = tbDoan.chiTiet

                                   });

                return getListDoan.ToList<dynamic>();

            }

        }

        public List<dynamic> TimKiemTenDoan(string searchValue)
        {

            {
                var getListDoan = (from tbDoan in tourdulich.doanduliches
                                   join tbTour in tourdulich.tours on tbDoan.maSoTour equals tbTour.maSoTour
                                   where tbDoan.trangThai == 1
                                   select new
                                   {
                                       ID = tbDoan.maSoDoan,
                                       TenDoan = tbDoan.tenGoiDoan,
                                       TenTour = tbTour.tenGoiTour,
                                       thoiGianKhoiHanh = tbDoan.thoiGianKhoiHanh,
                                       thoiGianKetThuc = tbDoan.thoiGianKetThuc,
                                       chitiet = tbDoan.chiTiet

                                   }).Where(t=>t.TenDoan.Contains(searchValue));

                return getListDoan.ToList<dynamic>();

            }

        }

        //Get list đoàn qua mã số tour
        public List<doandulich> GetListDoanWithMaTour(int maSoTour)
        {
            try{
                var getList = tourdulich.doanduliches.Where(t => t.maSoTour == maSoTour).Where(t => t.trangThai == 1);

                return getList.ToList();

            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return null;
            }
        }


        //Get list đoàn qua mã số đoàn
        public List<dynamic> GetDoan(int ma)
        {

            {
                var getListDoan = (from tbDoan in tourdulich.doanduliches
                                   join tbTour in tourdulich.tours on tbDoan.maSoTour equals tbTour.maSoTour
                                   where (tbDoan.maSoDoan == ma) && (tbDoan.trangThai == 1)
                                   select new
                                   {
                                       TenDoan = tbDoan.tenGoiDoan,
                                       TenTour = tbTour.tenGoiTour,
                                       thoiGianKhoiHanh = tbDoan.thoiGianKhoiHanh,
                                       thoiGianKetThuc = tbDoan.thoiGianKetThuc,
                                       chitiet = tbDoan.chiTiet,
                                       soLuongKhachHang = tbDoan.soLuongKhachHang,
                                       soLuongNhanVien = tbDoan.SoLuongNhanVien,
                                       maSoDoan = tbDoan.maSoDoan

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
                                 where tbDangKy.trangThai == 1


                                 select new
                                 {
                                     id = tbDangKy.id,
                                     ten = tbKH.hoTenKhachHang,
                                     gia = tbDangKy.giaTourDangKy
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
                                 where tbThamGia.trangThai == 1
                                 select new
                                 {
                                     id = tbThamGia.maThamGia,
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
                    objDoanOld.trangThai = objDoan.trangThai;

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

        public bool ThemSoLuongKhachHangDoan(doandulich objDoan, int maSoDoan)
        {
            {
                try
                {
                    doandulich objDoanOld = tourdulich.doanduliches.Where(t => t.maSoDoan == maSoDoan).SingleOrDefault();
                    objDoanOld.soLuongKhachHang += objDoan.soLuongKhachHang;
                    
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

        public bool ThemSoLuongNhanVienDoan(doandulich objDoan, int maSoDoan)
        {
            {
                try
                {
                    doandulich objDoanOld = tourdulich.doanduliches.Where(t => t.maSoDoan == maSoDoan).SingleOrDefault();
                    objDoanOld.SoLuongNhanVien += objDoan.SoLuongNhanVien;

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

        public bool GiamSoLuongKhachHangDoan(doandulich objDoan, int maSoDoan)
        {
            {
                try
                {
                    doandulich objDoanOld = tourdulich.doanduliches.Where(t => t.maSoDoan == maSoDoan).SingleOrDefault();
                    objDoanOld.soLuongKhachHang -= objDoan.soLuongKhachHang;

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

        public bool GiamSoLuongNhanVienDoan(doandulich objDoan, int maSoDoan)
        {
            {
                try
                {
                    doandulich objDoanOld = tourdulich.doanduliches.Where(t => t.maSoDoan == maSoDoan).SingleOrDefault();
                    objDoanOld.SoLuongNhanVien -= objDoan.SoLuongNhanVien;

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
                    doandulich objDoan = tourdulich.doanduliches.Where(t => t.maSoDoan == maSoDoan).SingleOrDefault();
                    objDoan.trangThai = 0;

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
