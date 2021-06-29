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
        public static DataTable tk_hh()
        {
            return Dataprovider.GetData("tk_hh");
        }
        public static DataTable tk_xuat()
        {
            return Dataprovider.GetData("tk_xuat");
        }
        public static DataTable tk_nhap()
        {
            return Dataprovider.GetData("tk_nhap");
        }
        //thêm
        public static int them_CTN(ChiTietNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCTN", a.MaCTN),
                new SqlParameter("@maPN", a.MaPN),
                new SqlParameter("@maHH", a.MaHH),
                new SqlParameter("@soLuong", a.SoLuong),
                new SqlParameter("@donGia", a.DonGia),
            };
            return Dataprovider.ExecuteNonQuery("them_CTN", para);
        }
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
        public static int them_HH(HangHoa a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maHH", a.MaHH),
                new SqlParameter("@tenHH", a.TenHH),
                new SqlParameter("@maNCC", a.MaNCC),
                new SqlParameter("@soLuong", a.SoLuong),
            };
            return Dataprovider.ExecuteNonQuery("them_HH", para);
        }
        public static int them_NCC(NCC a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maNCC", a.MaNCC),
                new SqlParameter("@tenNCC", a.TenNCC),
                new SqlParameter("@diaChi", a.DiaChi),
            };
            return Dataprovider.ExecuteNonQuery("them_NCC", para);
        }
        public static int them_PN(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maPN", a.MaPN),
                new SqlParameter("@ngayNhap", a.NgayNhap),
                new SqlParameter("@tongTien", a.TongTien),
            };
            return Dataprovider.ExecuteNonQuery("them_PN", para);
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
        public static int sua_CTN(ChiTietNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCTN", a.MaCTN),
                new SqlParameter("@maPN", a.MaPN),
                new SqlParameter("@maHH", a.MaHH),
                new SqlParameter("@soLuong", a.SoLuong),
                new SqlParameter("@donGia", a.DonGia),

            };
            return Dataprovider.ExecuteNonQuery("sua_CTN", para);
        }
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
        public static int sua_HH(HangHoa a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maHH", a.MaHH),
                new SqlParameter("@tenHH", a.TenHH),
                new SqlParameter("@maNCC", a.MaNCC),
            };
            return Dataprovider.ExecuteNonQuery("sua_HH", para);
        }
        public static int sua_NCC(NCC a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maNCC", a.MaNCC),
                new SqlParameter("@tenNCC", a.TenNCC),
                new SqlParameter("@diaChi", a.DiaChi),
                
            };
            return Dataprovider.ExecuteNonQuery("sua_NCC", para);
        }
        public static int sua_PN(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maPN", a.MaPN),
                new SqlParameter("@ngayNhap", a.NgayNhap),
                new SqlParameter("@tongTien", a.TongTien),
            };
            return Dataprovider.ExecuteNonQuery("sua_PN", para);
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
        public static int xoa_CTN(ChiTietNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCTN", a.MaCTN),


            };
            return Dataprovider.ExecuteNonQuery("xoa_CTN", para);
        }
        public static int xoa_CTX(ChiTietXuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCTX", a.MaCTX),


            };
            return Dataprovider.ExecuteNonQuery("xoa_CTX", para);
        }
        public static int xoa_HH(HangHoa a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maHH", a.MaHH),


            };
            return Dataprovider.ExecuteNonQuery("xoa_HH", para);
        }
        public static int xoa_NCC(NCC a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maNCC", a.MaNCC),


            };
            return Dataprovider.ExecuteNonQuery("xoa_NCC", para);
        }
        public static int xoa_PN(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maPN", a.MaPN),


            };
            return Dataprovider.ExecuteNonQuery("xoa_PN", para);
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
        public static DataTable xuat_pn()
        {
            return Dataprovider.GetData("xuat_PN");
        }
        public static DataTable xuat_ctn(string ma)
        {
            return Dataprovider.GetData("xuat_CTN2" + "'" + ma + "'");
        }
        public static DataTable xuat_px()
        {
            return Dataprovider.GetData("xuat_PX");
        }
        public static DataTable xuat_ctx(string ma)
        {
            return Dataprovider.GetData("xuat_CTX2" + "'" + ma + "'");
        }
        public static DataTable xuat_hh()
        {
            return Dataprovider.GetData("xuat_HH");
        }
        public static DataTable xuat_hh_tk()
        {
            return Dataprovider.GetData("xuat_hh_tk");
        }
        public static DataTable xuat_ncc()
        {
            return Dataprovider.GetData("xuat_NCC");
        }
    }
}
