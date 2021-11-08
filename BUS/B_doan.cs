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

        public List<dynamic> GetListDoan()
        {
            return dDoan.GetListDoan();
        }

        //public list<dynamic> getlistdetailsdoan(int masodoan)
        //{
        //    return ddoan.getlistdetailsdoan(masodoan);
        //}

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

