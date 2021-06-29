using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Kho.DT0
{
    class ChiTietXuat
    {
        private string maCTX;
        private string maPX;
        private string maHH;
        private int soLuong;
        private float donGia;

        public string MaCTX
        {
            get
            {
                return maCTX;
            }

            set
            {
                maCTX = value;
            }
        }
        public string MaPX
        {
            get
            {
                return maPX;
            }

            set
            {
                maPX = value;
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
