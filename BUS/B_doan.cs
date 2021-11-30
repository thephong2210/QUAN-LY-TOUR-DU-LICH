using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class B_doan
    {

        D_doan dDoan = new D_doan();

        //Get list Doan tùy chỉnh
        public List<doandulich> GetAllDoan()
        {
            return dDoan.GetAllDoan();
        }

        public List<doandulich> GetListDoanWithMaTour(int maSoTour)
        {
            return dDoan.GetListDoanWithMaTour(maSoTour);
        }
        
        public bool ThemSoLuongKhachHangDoan(doandulich objDoan, int maSoDoan)
        {
            return dDoan.ThemSoLuongKhachHangDoan(objDoan, maSoDoan);
        }

        public bool GiamSoLuongKhachHangDoan(int soLuongKhachHang, int maSoDoan)
        {
            return dDoan.GiamSoLuongKhachHangDoan(soLuongKhachHang, maSoDoan);
        }

        public List<dynamic> GetListDoan()
        {
            return dDoan.GetListDoan();
        }


        public bool ThemDoan(doandulich objDoan)
        {
            return dDoan.ThemDoan(objDoan);
        }

        public bool SuaDoan(doandulich objDoan, int maSoDoan)
        {
            return dDoan.SuaDoan(objDoan, maSoDoan);
        }

        public bool XoaDoan(int maSoDoan)
        {
            return dDoan.XoaDoan(maSoDoan);
        }


    }
}

