using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_Kho.DT0;

namespace QL_Kho.Data
{
    class DAO
    {

        //thống kê
       
        
        public static int them_CTX(ChiTietXuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCTX", a.MaCTX),
                new SqlParameter("@maPX", a.MaPX),
                new SqlParameter("@maHH", a.MaHH),
                new SqlParameter("@soLuong", a.SoLuong),
                new SqlParameter("@donGia", a.DonGia),
            };
            return Dataprovider.ExecuteNonQuery("them_CTX", para);
        }
      
        public static int them_PX(PhieuXuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maPX", a.MaPX),
                new SqlParameter("@ngayXuat", a.NgayXuat),
                new SqlParameter("@tongTien", a.TongTien),
            };
            return Dataprovider.ExecuteNonQuery("them_PX", para);
        }
        //sua
        
        public static int sua_CTX(ChiTietXuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCTX", a.MaCTX),
                new SqlParameter("@maPX", a.MaPX),
                new SqlParameter("@maHH", a.MaHH),
                new SqlParameter("@soLuong", a.SoLuong),
                new SqlParameter("@donGia", a.DonGia),

            };
            return Dataprovider.ExecuteNonQuery("sua_CTX", para);
        }
      
        public static int sua_PX(PhieuXuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maPX", a.MaPX),
                new SqlParameter("@ngayXuat", a.NgayXuat),
                new SqlParameter("@tongTien", a.TongTien),
            };
            return Dataprovider.ExecuteNonQuery("sua_PX", para);
        }
        //xóa
       
        public static int xoa_CTX(ChiTietXuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCTX", a.MaCTX),


            };
            return Dataprovider.ExecuteNonQuery("xoa_CTX", para);
        }
        
        public static int xoa_PX(PhieuXuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maPX", a.MaPX),


            };
            return Dataprovider.ExecuteNonQuery("xoa_PX", para);
        }
        //xuat
       
        public static DataTable xuat_px()
        {
            return Dataprovider.GetData("xuat_PX");
        }
        public static DataTable xuat_ctx(string ma)
        {
            return Dataprovider.GetData("xuat_CTX2" + "'" + ma + "'");
        }
       
        
       
    }
}
