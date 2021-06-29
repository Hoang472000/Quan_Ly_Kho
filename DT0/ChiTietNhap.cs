using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Kho.DT0
{
    class ChiTietNhap
    {
        private string maCTN;
        private string maPN;
        private string maHH;
        private int soLuong;
        private float donGia;

        public string MaCTN
        {
            get
            {
                return maCTN;
            }

            set
            {
                maCTN = value;
            }
        }
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
        public float DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }
    }
}
