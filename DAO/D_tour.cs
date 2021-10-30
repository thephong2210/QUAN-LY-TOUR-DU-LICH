using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_tour
    {

        tourdulichEntities tourdulich;
        
        public List<dynamic> GetListTour()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListTour = (from tbTour in tourdulich.tours
                                   join tbDiaDiemDen in tourdulich.diadiemdens on tbTour.maDiaDiemDen equals tbDiaDiemDen.maDiaDiemDen
                                   join tbLoaiHinhDuLich in tourdulich.loaihinhduliches on tbTour.maLoaiHinhDuLich equals tbLoaiHinhDuLich.maLoaiHinhDuLich
                                   select new
                                   {
                                       maSoTour = tbTour.maSoTour,
                                       tenGoiTour = tbTour.tenGoiTour,
                                       tenLoaiHinhDuLich = tbLoaiHinhDuLich.tenLoaiHinhDuLich,
                                       tenDiaDiem = tbDiaDiemDen.tenDiaDiemDen,
                                       thoiGianBatDau = tbTour.thoiGianBatDau,
                                       thoiGianKetThuc = tbTour.thoiGianKetThuc
                                   });

                return getListTour.ToList<dynamic>();

            }

        }

        public List<dynamic> GetListDetailsTour(int maSoTour)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsTour = (from tbTour in tourdulich.tours
                                          join tbDiaDiemDen in tourdulich.diadiemdens on tbTour.maDiaDiemDen equals tbDiaDiemDen.maDiaDiemDen
                                          join tbLoaiHinhDuLich in tourdulich.loaihinhduliches on tbTour.maLoaiHinhDuLich equals tbLoaiHinhDuLich.maLoaiHinhDuLich
                                          where tbTour.maSoTour == maSoTour
                                          select new
                                          {
                                              maSoTour = tbTour.maSoTour,
                                              tenGoiTour = tbTour.tenGoiTour,
                                              dacDiem = tbTour.dacDiem,
                                              maGiaTour = tbTour.maGiaTour,
                                              soLuongKhachHang = tbTour.soLuongKhachHang,
                                              tongTien = tbTour.tongTien,
                                              thoiGianBatDau = tbTour.thoiGianBatDau,
                                              thoiGianKetThuc = tbTour.thoiGianKetThuc,
                                              tenLoaiHinhDuLich = tbLoaiHinhDuLich.tenLoaiHinhDuLich,
                                              tenDiaDiem = tbDiaDiemDen.tenDiaDiemDen
                                          });

                return getListDetailsTour.ToList<dynamic>();

            }

        }

        //tạm thời
        public List<giatour> GetGiaTour()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsTour = from tbGiaTour in tourdulich.giatours select tbGiaTour;
                                     
                return getListDetailsTour.ToList<giatour>();

            }

        }


    }
}
