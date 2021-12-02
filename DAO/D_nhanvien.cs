using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_nhanvien
    {
        tourdulichEntities tourdulich;

        public List<nhanvien> GetAllNhanVien()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getAllNhanVien = tourdulich.nhanviens.Where(t => t.trangThai == 1);
                return getAllNhanVien.ToList<nhanvien>();
            }
        }
        //Load dataGridView
        public List<dynamic> GetListNhanVien()
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListNhanVien = (from tbNhanVien in tourdulich.nhanviens
                                       where tbNhanVien.trangThai == 1
                                   select new
                                   {
                                       maNhanVien = tbNhanVien.maNhanVien,
                                       tenNhanVien = tbNhanVien.tenNhanVien,
                                       nhiemVu = tbNhanVien.nhiemVu
                                   });

                return getListNhanVien.ToList<dynamic>();

            }

        }

        public List<dynamic> TimKiemTenNhanVien(string searchValue)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListNhanVien = (from tbNhanVien in tourdulich.nhanviens
                                       where tbNhanVien.trangThai == 1
                                       select new
                                       {
                                           maNhanVien = tbNhanVien.maNhanVien,
                                           tenNhanVien = tbNhanVien.tenNhanVien,
                                           nhiemVu = tbNhanVien.nhiemVu
                                       }).Where(t=>t.tenNhanVien.Contains(searchValue));

                return getListNhanVien.ToList<dynamic>();

            }

        }

        public List<dynamic> GetListDetailsNhanVien(int maNhanVien)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsNhanVien = (from tbNhanVien in tourdulich.nhanviens
                                          where tbNhanVien.maNhanVien == maNhanVien
                                          select new
                                          {
                                              maNhanVien = tbNhanVien.maNhanVien,
                                              tenNhanVien = tbNhanVien.tenNhanVien,
                                              nhiemVu = tbNhanVien.nhiemVu
                                          });

                return getListDetailsNhanVien.ToList<dynamic>();
            }
        }
        public List<dynamic> TimKiemNhanVien(int maNhanVien)
        {
            using (tourdulich = new tourdulichEntities())
            {
                var getListDetailsNhanVien = (from tbNhanVien in tourdulich.nhanviens
                                              where tbNhanVien.maNhanVien == maNhanVien
                                              where tbNhanVien.trangThai == 1
                                              select new
                                              {
                                                  maNhanVien = tbNhanVien.maNhanVien,
                                                  tenNhanVien = tbNhanVien.tenNhanVien,
                                                  nhiemVu = tbNhanVien.nhiemVu
                                              });

                return getListDetailsNhanVien.ToList<dynamic>();
            }
        }

        public bool ThemNhanVien(nhanvien objNhanVien)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    tourdulich.nhanviens.Add(objNhanVien);
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

        public bool XoaNhanVien(int maNhanVien)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {
                    nhanvien objNhanVien = tourdulich.nhanviens.Where(t => t.maNhanVien == maNhanVien).SingleOrDefault();    // ??
                    objNhanVien.trangThai = 0;

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

        public bool SuaNhanVien(nhanvien objNhanVien, int maNhanVien)
        {
            using (tourdulich = new tourdulichEntities())
            {
                try
                {                  
                    nhanvien objNhanVienOld = tourdulich.nhanviens.Where(t => t.maNhanVien == maNhanVien).SingleOrDefault();
                    objNhanVienOld.tenNhanVien = objNhanVien.tenNhanVien;
                    objNhanVienOld.nhiemVu = objNhanVien.nhiemVu;
                    objNhanVienOld.trangThai = objNhanVien.trangThai;

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
