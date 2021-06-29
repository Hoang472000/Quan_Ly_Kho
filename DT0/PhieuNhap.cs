using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Kho.DT0
{
    class PhieuNhap
    {
        private string maPN;
        private DateTime ngayNhap;
        private float tongTien;

        public string MaPN
        {
            get
            {
                return maPN;
            }

            set
            {
                maPN = value;
            }
        }
        public DateTime NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }
        public float TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }
    }
}
