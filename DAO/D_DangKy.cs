using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_DangKy
    {
        tourdulichEntities tourdulich;
        public List<dangky> GetAllDangKy()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getAllDangKy = tourdulich.dangkies.Where(t => t.trangThai == 1);
                return getAllDangKy.ToList<dangky>();
            }
        }

        
        //Load on datagridview
        public List<dynamic> GetListDangKy()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDangKy = (from tbDangKy in tourdulich.dangkies
                                   join tbKhachHang in tourdulich.khachhangs on tbDangKy.maSoKhachHang equals tbKhachHang.maSoKhachHang
                                   join tbTour in tourdulich.tours on tbDangKy.maTour equals tbTour.maSoTour
                                   join tbDoan in tourdulich.doanduliches on tbDangKy.maSoDoan equals tbDoan.maSoDoan
                                   where tbDangKy.trangThai == 1
                                   select new
                                   {
                                       id = tbDangKy.id,
                                       tenKhachHang = tbKhachHang.hoTenKhachHang,
                                       tenGoiTour = tbTour.tenGoiTour,
                                       ngayDangKy = tbDangKy.ngayDangKy,
                                       tenGoiDoan = tbDoan.tenGoiDoan
                                   });

                return getListDangKy.ToList<dynamic>();

            }

        }

        public List<dynamic> TimKiemTheoTenKH(string searchValue)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDangKy = (from tbDangKy in tourdulich.dangkies
                                     join tbKhachHang in tourdulich.khachhangs on tbDangKy.maSoKhachHang equals tbKhachHang.maSoKhachHang
                                     join tbTour in tourdulich.tours on tbDangKy.maTour equals tbTour.maSoTour
                                     join tbDoan in tourdulich.doanduliches on tbDangKy.maSoDoan equals tbDoan.maSoDoan
                                     where tbDangKy.trangThai == 1
                                     select new
                                     {
                                         id = tbDangKy.id,
                                         tenKhachHang = tbKhachHang.hoTenKhachHang,
                                         tenGoiTour = tbTour.tenGoiTour,
                                         ngayDangKy = tbDangKy.ngayDangKy,
                                         tenGoiDoan = tbDoan.tenGoiDoan
                                     }).Where(t=>t.tenKhachHang.Contains(searchValue));

                return getListDangKy.ToList<dynamic>();

            }

        }

        public List<dynamic> GetListDetailsDangKy(int id)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDangKy = (from tbDangKy in tourdulich.dangkies
                                     join tbKhachHang in tourdulich.khachhangs on tbDangKy.maSoKhachHang equals tbKhachHang.maSoKhachHang
                                     join tbTour in tourdulich.tours on tbDangKy.maTour equals tbTour.maSoTour
                                     join tbDoan in tourdulich.doanduliches on tbDangKy.maSoDoan equals tbDoan.maSoDoan
                                     where tbDangKy.id == id
                                     select new
                                     {
                                         id = tbDangKy.id,
                                         tenKhachHang = tbKhachHang.hoTenKhachHang,
                                         tenGoiTour = tbTour.tenGoiTour,
                                         ngayDangKy = tbDangKy.ngayDangKy,
                                         tenGoiDoan = tbDoan.tenGoiDoan,
                                         giaTourDangKy = tbDangKy.giaTourDangKy
                                     });

                return getListDangKy.ToList<dynamic>();

            }

        }

        public bool ThemDangKy(dangky objDangKy)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.dangkies.Add(objDangKy);
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

        public bool SuaDangKy(dangky objDangKy, int id)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    dangky objDangKyOld = tourdulich.dangkies.Where(t => t.id == id).SingleOrDefault();
                    objDangKyOld.maSoKhachHang = objDangKy.maSoKhachHang;
                    objDangKyOld.maTour = objDangKy.maTour;
                    objDangKyOld.ngayDangKy = objDangKy.ngayDangKy;
                    objDangKyOld.maSoDoan = objDangKy.maSoDoan;
                    objDangKyOld.soLuongKhachHang = objDangKy.soLuongKhachHang;
                    objDangKyOld.giaTourDangKy = objDangKy.giaTourDangKy;
                    objDangKyOld.trangThai = objDangKy.trangThai;

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


        public bool XoaDangKy(int id)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    dangky objDangKyOld = tourdulich.dangkies.Where(t => t.id == id).SingleOrDefault();
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


        //thống kê
        public List<dynamic> TopTourDangKyNhieu(int topNumber)
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbDangKy in tourdulich.dangkies
                                     from tbTour in tourdulich.tours
                                     where tbDangKy.trangThai == 1 && tbDangKy.maTour == tbTour.maSoTour
                                     group tbDangKy by new
                                     {
                                         maTour = tbDangKy.maTour,
                                         tenTour = tbTour.tenGoiTour
                                     } into g
                                     select new
                                     {
                                         maTour = g.Key.maTour,
                                         tenTour = g.Key.tenTour,
                                         TotalDangKy = g.Count()
                                     }).OrderByDescending(t => t.TotalDangKy).Take(topNumber);

                return getListDangKy.ToList<dynamic>();

            }
        }

        public List<dynamic> GetSoLuongDoan()
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbTour in tourdulich.tours
                                     from tbDoan in tourdulich.doanduliches
                                     where tbDoan.trangThai == 1 && tbTour.maSoTour == tbDoan.maSoTour
                                     group tbDoan by new
                                     {
                                         maTour = tbDoan.maSoTour
                                     } into g
                                     select new
                                     {
                                         maTour = g.Key.maTour,
                                         TotalDoan = g.Count()
                                     });

                return getListDangKy.ToList<dynamic>();

            }
        }


        public List<dynamic> GetDoanhSoDangKyAllTour(int numberLimit)
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbDangKy in tourdulich.dangkies
                                     from tbTour in tourdulich.tours
                                     where tbDangKy.trangThai == 1 && tbDangKy.maTour == tbTour.maSoTour
                                     group tbDangKy by new
                                     {
                                         maSoTour = tbDangKy.maTour,
                                         tenTour = tbTour.tenGoiTour
                                     } into g
                                     select new
                                     {
                                         maSoTour = g.Key.maSoTour,
                                         tenTour = g.Key.tenTour,
                                         totalGiaVe = g.Sum(t => t.giaTourDangKy)
                                     }).OrderByDescending(t => t.totalGiaVe).Take(numberLimit);

                return getListDangKy.ToList<dynamic>();

            }
        }

        public List<DoanhSoDangKyAllTour> GetDoanhSoDangKyAllTour()
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbDangKy in tourdulich.dangkies
                                     from tbTour in tourdulich.tours
                                     where tbDangKy.trangThai == 1 && tbDangKy.maTour == tbTour.maSoTour
                                     group tbDangKy by new
                                     {
                                         maSoTour = tbDangKy.maTour,
                                         tenTour = tbTour.tenGoiTour
                                     } into g
                                     select new DoanhSoDangKyAllTour
                                     {
                                         maSoTour = g.Key.maSoTour,
                                         tenTour = g.Key.tenTour,
                                         totalGiaVe = (double)g.Sum(t => t.giaTourDangKy)
                                     }).OrderByDescending(t => t.totalGiaVe);

                return getListDangKy.ToList<DoanhSoDangKyAllTour>();

            }
        }


        //get chi phi all tour
        public List<ChiPhiAllDoanModel> GetChiPhiAllDoan()
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbChiPhi in tourdulich.chiphis
                                     from tbDoan in tourdulich.doanduliches
                                     where tbChiPhi.trangThai == 1 && tbChiPhi.maSoDoan == tbDoan.maSoDoan
                                     group tbChiPhi by new
                                     {
                                         maSoDoan = tbChiPhi.maSoDoan,
                                         maSoTour = tbDoan.maSoTour
                                     } into g
                                     select new ChiPhiAllDoanModel
                                     {
                                         maSoDoan = g.Key.maSoDoan,
                                         maSoTour = g.Key.maSoTour,
                                         totalChiPhi = g.Sum(t => t.tongChiPhi)
                                     }).OrderByDescending(t => t.totalChiPhi).GroupBy(t => t.maSoTour)
                                                .Select(t => new ChiPhiAllDoanModel
                                                {
                                                    maSoDoan = t.FirstOrDefault().maSoDoan,
                                                    maSoTour = t.FirstOrDefault().maSoTour,
                                                    totalChiPhi = t.Sum(c => c.totalChiPhi)
                                                }); ;

                return getListDangKy.ToList<ChiPhiAllDoanModel>();

            }
        }

        public List<ChiPhiAllDoanModel> GetChiPhiOneTour(int maSoTour)
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbChiPhi in tourdulich.chiphis
                                     from tbDoan in tourdulich.doanduliches
                                     where tbChiPhi.trangThai == 1 && tbChiPhi.maSoDoan == tbDoan.maSoDoan && tbDoan.maSoTour == maSoTour
                                     group tbChiPhi by new
                                     {
                                         maSoDoan = tbChiPhi.maSoDoan,
                                         maSoTour = tbDoan.maSoTour
                                     } into g
                                     select new ChiPhiAllDoanModel
                                     {
                                         maSoDoan = g.Key.maSoDoan,
                                         maSoTour = g.Key.maSoTour,
                                         totalChiPhi = g.Sum(t => t.tongChiPhi)
                                     }).OrderByDescending(t => t.totalChiPhi).GroupBy(t => t.maSoTour)
                                                .Select(t => new ChiPhiAllDoanModel
                                                {
                                                    maSoDoan = t.FirstOrDefault().maSoDoan,
                                                    maSoTour = t.FirstOrDefault().maSoTour,
                                                    totalChiPhi = t.Sum(c => c.totalChiPhi)
                                                }); ;

                return getListDangKy.ToList<ChiPhiAllDoanModel>();

            }
        }

        public List<ChiPhiAllDoanModel> GetChiPhiAllDoan_Doan()
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbChiPhi in tourdulich.chiphis
                                     from tbDoan in tourdulich.doanduliches
                                     where tbChiPhi.trangThai == 1 && tbChiPhi.maSoDoan == tbDoan.maSoDoan
                                     group tbChiPhi by new
                                     {
                                         maSoDoan = tbChiPhi.maSoDoan,
                                         maSoTour = tbDoan.maSoTour
                                     } into g
                                     select new ChiPhiAllDoanModel
                                     {
                                         maSoDoan = g.Key.maSoDoan,
                                         maSoTour = g.Key.maSoTour,
                                         totalChiPhi = g.Sum(t => t.tongChiPhi)
                                     }).OrderByDescending(t => t.totalChiPhi);

                return getListDangKy.ToList<ChiPhiAllDoanModel>();

            }
        }

        public List<ChiPhiAllDoanModel> GetChiPhiOneDoan_Doan(int maSoDoan)
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbChiPhi in tourdulich.chiphis
                                     from tbDoan in tourdulich.doanduliches
                                     where tbChiPhi.trangThai == 1 && tbChiPhi.maSoDoan == tbDoan.maSoDoan && tbChiPhi.maSoDoan == maSoDoan
                                     group tbChiPhi by new
                                     {
                                         maSoDoan = tbChiPhi.maSoDoan,
                                         maSoTour = tbDoan.maSoTour
                                     } into g
                                     select new ChiPhiAllDoanModel
                                     {
                                         maSoDoan = g.Key.maSoDoan,
                                         maSoTour = g.Key.maSoTour,
                                         totalChiPhi = g.Sum(t => t.tongChiPhi)
                                     }).OrderByDescending(t => t.totalChiPhi);

                return getListDangKy.ToList<ChiPhiAllDoanModel>();

            }
        }

        public List<DoanhSoDangKyAllDoan> GetDoanhSoDangKyAllDoan()
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbDangKy in tourdulich.dangkies
                                     from tbDoan in tourdulich.doanduliches
                                     where tbDangKy.trangThai == 1 && tbDangKy.maSoDoan == tbDoan.maSoDoan
                                     group tbDangKy by new
                                     {
                                         maSoDoan = tbDangKy.maSoDoan,
                                         tenDoan = tbDoan.tenGoiDoan
                                     } into g
                                     select new DoanhSoDangKyAllDoan
                                     {
                                         maSoDoan = g.Key.maSoDoan,
                                         tenDoan = g.Key.tenDoan,
                                         totalGiaVe = (double)g.Sum(t => t.giaTourDangKy)
                                     }).OrderByDescending(t => t.totalGiaVe);

                return getListDangKy.ToList<DoanhSoDangKyAllDoan>();

            }
        }

        public List<DoanhSoDangKyAllDoan> GetDoanhSoDangKyOneDoan(int maSoDoan)
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbDangKy in tourdulich.dangkies
                                     from tbDoan in tourdulich.doanduliches
                                     where tbDangKy.trangThai == 1 && tbDangKy.maSoDoan == tbDoan.maSoDoan && tbDangKy.maSoDoan == maSoDoan
                                     group tbDangKy by new
                                     {
                                         maSoDoan = tbDangKy.maSoDoan,
                                         tenDoan = tbDoan.tenGoiDoan
                                     } into g
                                     select new DoanhSoDangKyAllDoan
                                     {
                                         maSoDoan = g.Key.maSoDoan,
                                         tenDoan = g.Key.tenDoan,
                                         totalGiaVe = (double)g.Sum(t => t.giaTourDangKy)
                                     }).OrderByDescending(t => t.totalGiaVe);

                return getListDangKy.ToList<DoanhSoDangKyAllDoan>();

            }
        }


        public List<dynamic> GetSoLanDiTourNhanVien(int numberLimit)
        {
            using (tourdulich = new tourdulichEntities())
            {

                var getListDangKy = (from tbThamGiaDoan in tourdulich.thamgiadoans
                                     from tbNhanVien in tourdulich.nhanviens
                                     where tbThamGiaDoan.trangThai == 1 && tbThamGiaDoan.maNhanVien == tbNhanVien.maNhanVien
                                     group tbThamGiaDoan by new
                                     {
                                         maNhanVien = tbThamGiaDoan.maNhanVien,
                                         tenNhanVien = tbNhanVien.tenNhanVien
                                     } into g
                                     select new
                                     {
                                         maNhanVien = g.Key.maNhanVien,
                                         tenNhanVien = g.Key.tenNhanVien,
                                         soLanDiTour = g.Count()
                                     }).OrderByDescending(t => t.soLanDiTour).Take(numberLimit);

                return getListDangKy.ToList<dynamic>();

            }
        }


        public List<dynamic> GetDoanhSoMoiThangCuaNam(int yearValue)
        {
            using (tourdulich = new tourdulichEntities())
            {
                
                var getListDangKy = (from tbDangKy in tourdulich.dangkies
                                     where tbDangKy.trangThai == 1
                                     group tbDangKy by new
                                     {
                                         Year = yearValue,
                                         Month = tbDangKy.ngayDangKy.Month
                                     } into g
                                     select new
                                     {
                                        MonthAndYear = g.Key.Year + "-" + g.Key.Month,
                                        Total = g.Sum(t=>t.giaTourDangKy)
                                     });

                return getListDangKy.ToList<dynamic>();

            }
        }

        public List<chiphi> GetAllChiPhi()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getAllChiPhi = tourdulich.chiphis.Where(t => t.trangThai == 1);
                return getAllChiPhi.ToList<chiphi>();
            }
        }

        
    }
}
