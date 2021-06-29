using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Kho.DT0
{
    class HangHoa
    {
        private string maHH;
        private string tenHH;
        private string maNCC;
        private int soLuong;
        
        public string MaHH
        {
            get
            {
                return maHH;
            }
            set
            {
                maHH = value;
            }
        }
        public string TenHH
        {
            get
            {
                return tenHH;
            }
            set
            {
                tenHH = value;
            }
        }
        public string MaNCC
        {
            get
            {
                return maNCC;
            }
            set
            {
                maNCC = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return soLuong;
            }
            set
            {
                soLuong = value;
            }
        }
    }
}
