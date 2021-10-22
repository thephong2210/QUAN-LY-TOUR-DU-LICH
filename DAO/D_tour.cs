using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class D_tour
    {
        DataConnection connect = new DataConnection();

       public DataTable GetListTour()
        {
            connect.OpenConnect();
            DataTable dataTable = new DataTable();
            string querySql = "SELECT maSoTour, tenGoiTour, tenLoaiHinhDuLich, tenDiaDiem, thoiGianBatDau, thoiGianKetThuc " +
                            "FROM tour T, diadiemthamquan DD,loaihinhdulich LH " +
                            "WHERE T.maDiaDiem = DD.maDiaDiem AND LH.maLoaiHinhDuLich = T.maLoaiHinhDuLich ";

            SqlCommand command = new SqlCommand(querySql, connect.conn );

            dataTable.Load(command.ExecuteReader());

            connect.CloseConnect();

            return dataTable;

        }

        //Hiển thị chi tiết tour
        public DataTable GetListDetailsTour(int maSoTour)
        {
            connect.OpenConnect();
            DataTable dataTable = new DataTable();
            string querySql = "SELECT tenGoiTour, dacDiem, tenLoaiHinhDuLich, tenDiaDiem, maGiaTour, soLuongKhachHang, tongTien, thoiGianBatDau, thoiGianKetThuc " +
                            "FROM tour T, diadiemthamquan DD,loaihinhdulich LH " +
                            "WHERE T.maDiaDiem = DD.maDiaDiem AND LH.maLoaiHinhDuLich = T.maLoaiHinhDuLich AND maSoTour=" + maSoTour;

            SqlCommand command = new SqlCommand(querySql, connect.conn);

            dataTable.Load(command.ExecuteReader());

            connect.CloseConnect();

            return dataTable;

        }

        public void ThemTour(DTO_tour DTOtour)
        {
            connect.OpenConnect();
            
            string querySql = "INSERT INTO tour VALUES(@tenGoiTour, @dacDiem, @maDiaDiem, " +
                               "@maGiaTour, @maLoaiHinhDuLich, @soLuongKhachHang," +
                                "@tongTien, @thoiGianBatDau, @thoiGianKetThuc)";

            SqlCommand command = new SqlCommand(querySql, connect.conn);

            command.Parameters.Add(new SqlParameter("@tenGoiTour", DTOtour.TenGoiTour ));
            command.Parameters.Add(new SqlParameter("@dacDiem", DTOtour.DacDiem));
            command.Parameters.Add(new SqlParameter("@maDiaDiem", DTOtour.MaDiaDiem));
            command.Parameters.Add(new SqlParameter("@maGiaTour", DTOtour.MaGiaTour));
            command.Parameters.Add(new SqlParameter("@maLoaiHinhDuLich", DTOtour.MaLoaiHinhDuLich));
            command.Parameters.Add(new SqlParameter("@soLuongKhachHang", DTOtour.SoLuongKhachHang));
            command.Parameters.Add(new SqlParameter("@tongTien", DTOtour.TongTien));
            command.Parameters.Add(new SqlParameter("@thoiGianBatDau", DTOtour.ThoiGianBatDau));
            command.Parameters.Add(new SqlParameter("@thoiGianKetThuc", DTOtour.ThoiGianKetThuc));

            command.ExecuteNonQuery();

            connect.CloseConnect();
        }

        //ghi tạm ở DAO tour
        public DataSet GetListDiaDiem()
        {
            connect.OpenConnect();
            DataSet dataSet = new DataSet();
            string querySql = "SELECT tenDiaDiem FROM diadiemthamquan";

            SqlCommand command = new SqlCommand(querySql, connect.conn);

            SqlDataAdapter adapterData = new SqlDataAdapter();

            adapterData.SelectCommand = command;
            adapterData.Fill(dataSet);

            connect.CloseConnect();

            return dataSet;
        }

        //tam thoi
        public DataTable GetMaDiaDiem(string tenDiaDiem)
        {
            connect.OpenConnect();
            DataTable dataSet = new DataTable();
            string querySql = "SELECT maDiaDiem FROM diadiemthamquan WHERE tendiaDiem = N'" + tenDiaDiem + "'";

       
            System.Diagnostics.Debug.WriteLine(querySql); //viet ra console de test

            SqlCommand command = new SqlCommand(querySql, connect.conn);

            SqlDataAdapter adapterData = new SqlDataAdapter();

            adapterData.SelectCommand = command;
            adapterData.Fill(dataSet);

            connect.CloseConnect();

            return dataSet;
        }

        public DataSet GetListLoaiHinhDuLich()
        {
            connect.OpenConnect();
            DataSet dataSet = new DataSet();
            string querySql = "SELECT tenLoaiHinhDuLich FROM loaihinhdulich";

            SqlCommand command = new SqlCommand(querySql, connect.conn);

            SqlDataAdapter adapterData = new SqlDataAdapter();

            adapterData.SelectCommand = command;
            adapterData.Fill(dataSet);

            connect.CloseConnect();

            return dataSet;
        }

        //tam thoi
        public DataTable GetMaLoaiHinhDuLich(string tenLoaiHinhDuLich)
        {
            connect.OpenConnect();
            DataTable dataSet = new DataTable();
            string querySql = "SELECT maLoaiHinhDuLich FROM loaihinhdulich WHERE tenLoaiHinhDuLich = N'" + tenLoaiHinhDuLich + "'";


            System.Diagnostics.Debug.WriteLine(querySql); //viet ra console de test

            SqlCommand command = new SqlCommand(querySql, connect.conn);

            SqlDataAdapter adapterData = new SqlDataAdapter();

            adapterData.SelectCommand = command;
            adapterData.Fill(dataSet);

            connect.CloseConnect();

            return dataSet;
        }




    }
}
