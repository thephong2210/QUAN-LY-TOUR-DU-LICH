using System;

namespace DTO
{
  
    public class DTO_tour
    {
        private string tenGoiTour;
        private string dacDiem;
        private int maDiaDiem;
        private int maGiaTour;
        private int maLoaiHinhDuLich;
        private int soLuongKhachHang;
        private double tongTien;
        private string thoiGianBatDau;
        private string thoiGianKetThuc;
      

        public string TenGoiTour { get => tenGoiTour; set => tenGoiTour = value; }
        public string DacDiem { get => dacDiem; set => dacDiem = value; }
        public int MaDiaDiem { get => maDiaDiem; set => maDiaDiem = value; }
        public int MaGiaTour { get => maGiaTour; set => maGiaTour = value; }
        public int MaLoaiHinhDuLich { get => maLoaiHinhDuLich; set => maLoaiHinhDuLich = value; }
        public int SoLuongKhachHang { get => soLuongKhachHang; set => soLuongKhachHang = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public string ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public string ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }

        public DTO_tour(string tenGoiTour, string dacDiem, int maDiaDiem, int maGiaTour, int maLoaiHinhDuLich, int soLuongKhachHang, double tongTien, string thoiGianBatDau, string thoiGianKetThuc)
        {
            this.TenGoiTour = tenGoiTour;
            this.DacDiem = dacDiem;
            this.MaDiaDiem = maDiaDiem;
            this.MaGiaTour = maGiaTour;
            this.MaLoaiHinhDuLich = maLoaiHinhDuLich;
            this.SoLuongKhachHang = soLuongKhachHang;
            this.TongTien = tongTien;
            this.ThoiGianBatDau = thoiGianBatDau;
            this.ThoiGianKetThuc = thoiGianKetThuc;
        }

        
    }
}
