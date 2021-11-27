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
                var getAllDangKy = tourdulich.dangkies;
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
                                   join tbLoaiKhachHang in tourdulich.loaikhachhangs on tbDangKy.maLoaiKhachHang equals tbLoaiKhachHang.maLoaiKhachHang
                                   join tbDoan in tourdulich.doanduliches on tbDangKy.maSoDoan equals tbDoan.maSoDoan
                                   select new
                                   {
                                       id = tbDangKy.id,
                                       maSoKhachHang = tbDangKy.maSoKhachHang,
                                       maTour = tbDangKy.maTour,
                                       maLoaiKhachHang= tbDangKy.maLoaiKhachHang,
                                       ngayDangKy = tbDangKy.ngayDangKy,
                                       maDoan = tbDangKy.ngayDangKy
                                   });

                return getListDangKy.ToList<dynamic>();

            }

           


        }

        public List<dynamic> GetListDetailsDangKy(int id)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsDangKy = (from tbDangKy in tourdulich.dangkies
                                            join tbKhachHang in tourdulich.khachhangs on tbDangKy.maSoKhachHang equals tbKhachHang.maSoKhachHang
                                            join tbTour in tourdulich.tours on tbDangKy.maTour equals tbTour.maSoTour
                                            join tbLoaiKhachHang in tourdulich.loaikhachhangs on tbDangKy.maLoaiKhachHang equals tbLoaiKhachHang.maLoaiKhachHang
                                            join tbDoan in tourdulich.doanduliches on tbDangKy.maSoDoan equals tbDoan.maSoDoan
                                            where tbDangKy.id == id
                                          select new
                                          {
                                              id = tbDangKy.id,
                                              maSoKhachHang = tbDangKy.maSoKhachHang,
                                              maTour = tbDangKy.maTour,
                                              maLoaiKhachHang = tbDangKy.maLoaiKhachHang,
                                              ngayDangKy = tbDangKy.ngayDangKy,
                                              maDoan = tbDangKy.ngayDangKy
                                          });

                return getListDetailsDangKy.ToList<dynamic>();

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
                    objDangKyOld.maLoaiKhachHang = objDangKy.maLoaiKhachHang;
                    objDangKyOld.ngayDangKy = objDangKy.ngayDangKy;
                    objDangKyOld.maSoDoan = objDangKy.maSoDoan;
                    

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
                    dangky objDangKy = new dangky();
                    objDangKy = tourdulich.dangkies.Where(t => t.id == id).SingleOrDefault();
                    tourdulich.dangkies.Remove(objDangKy);

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
