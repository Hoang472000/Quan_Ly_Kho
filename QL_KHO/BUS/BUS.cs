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
        
        //xuat
       
        public static DataTable xuat_ctx(string ma)
        {
            return DAO.xuat_ctx(ma);
        }
       
        public static DataTable xuat_px()
        {
            return DAO.xuat_px();
        }
       
        //sua
        
        public static int sua_ctx(ChiTietXuat a)
        {
            return DAO.sua_CTX(a);
        }
    
        public static int sua_PX(PhieuXuat a)
        {
            return DAO.sua_PX(a);
        }
      
        //xoa
        
        public static int xoa_CTX(ChiTietXuat a)
        {
            return DAO.xoa_CTX(a);
        }
       
        public static int xoa_PX(PhieuXuat a)
        {
            return DAO.xoa_PX(a);
        }
      
        //Thêm
      
        public static int them_ctx(ChiTietXuat a)
        {
            return DAO.them_CTX(a);
        }


        public static int them_px(PhieuXuat a)
        {
            return DAO.them_PX(a);
        }
    }
}
