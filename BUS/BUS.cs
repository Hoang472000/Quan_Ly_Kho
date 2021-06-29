using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_Kho.DT0;
using QL_Kho.Data;
using System.Data;

namespace QL_Kho.BUS
{
    class BUS
    {
        //Thống kê
        public static DataTable tk_hh()
        {
            return DAO.tk_hh();
        }
        public static DataTable tk_nhap()
        {
            return DAO.tk_nhap();
        }
        public static DataTable tk_xuat()
        {
            return DAO.tk_xuat();
        }
        //xuat
        public static DataTable xuat_ctn(string ma)
        {
            return DAO.xuat_ctn(ma);
        }
        public static DataTable xuat_ctx(string ma)
        {
            return DAO.xuat_ctx(ma);
        }
        public static DataTable xuat_pn()
        {
            return DAO.xuat_pn();
        }
        public static DataTable xuat_px()
        {
            return DAO.xuat_px();
        }
        public static DataTable xuat_hh()
        {
            return DAO.xuat_hh();
        }
        public static DataTable xuat_hh_tk()
        {
            return DAO.xuat_hh_tk();
        }
        public static DataTable xuat_ncc()
        {
            return DAO.xuat_ncc();
        }
        //sua
        public static int sua_ctn(ChiTietNhap a)
        {
            return DAO.sua_CTN(a);
        }
        public static int sua_ctx(ChiTietXuat a)
        {
            return DAO.sua_CTX(a);
        }
        public static int sua_PN(PhieuNhap a)
        {
            return DAO.sua_PN(a);
        }
        public static int sua_PX(PhieuXuat a)
        {
            return DAO.sua_PX(a);
        }
        public static int sua_HH(HangHoa a)
        {
            return DAO.sua_HH(a);
        }
        public static int sua_NCC(NCC a)
        {
            return DAO.sua_NCC(a);
        }
        //xoa
        public static int xoa_CTN(ChiTietNhap a)
        {
            return DAO.xoa_CTN(a);
        }
        public static int xoa_CTX(ChiTietXuat a)
        {
            return DAO.xoa_CTX(a);
        }
        public static int xoa_PN(PhieuNhap a)
        {
            return DAO.xoa_PN(a);
        }
        public static int xoa_PX(PhieuXuat a)
        {
            return DAO.xoa_PX(a);
        }
        public static int xoa_HH(HangHoa a)
        {
            return DAO.xoa_HH(a);
        }
        public static int xoa_NCC(NCC a)
        {
            return DAO.xoa_NCC(a);
        }
        //Thêm
        public static int them_ctn(ChiTietNhap a)
        {
            return DAO.them_CTN(a);
        }
        public static int them_ctx(ChiTietXuat a)
        {
            return DAO.them_CTX(a);
        }
        public static int them_pn(PhieuNhap a)
        {
            return DAO.them_PN(a);
        }
        public static int them_px(PhieuXuat a)
        {
            return DAO.them_PX(a);
        }
        public static int them_hh(HangHoa a)
        {
            return DAO.them_HH(a);
        }
        public static int them_ncc(NCC a)
        {
            return DAO.them_NCC(a);
        }

    }
}
