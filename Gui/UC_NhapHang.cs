using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Kho.BUS;
using QL_Kho.DT0;

namespace QL_Kho.Gui
{
    public partial class UC_NhapHang : UserControl
    {
        bool them1, sua1,them2 ,sua2 ;
        public UC_NhapHang()
        {
            InitializeComponent();
        }
        DataTable a = new DataTable();
        private void load()
        {
            DataTable a = new DataTable();
            a = BUS.BUS.xuat_pn();
            dgvphieuNhap.DataSource = a;
        }
        
        private void dgvphieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma_PN.Text = dgvphieuNhap.CurrentRow.Cells[0].Value.ToString();
            txttongTien.Text = dgvphieuNhap.CurrentRow.Cells[2].Value.ToString();
            datePK.Text = dgvphieuNhap.CurrentRow.Cells[1].Value.ToString();
            txtma_PN.Enabled = false;
            datePK.Enabled = false;

            dgvCTN.DataSource = BUS.BUS.xuat_ctn(txtma_PN.Text);
        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            load();
            txttongTien.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtma_PN.Enabled = true;
            datePK.Enabled = true;
            txtma_PN.Clear();
            txttongTien.Clear();
            them1 = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            datePK.Enabled = true;
            sua1 = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            PhieuNhap a = new PhieuNhap();
            a.MaPN = txtma_PN.Text.Trim();

            if (BUS.BUS.xoa_PN(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvphieuNhap.DataSource = BUS.BUS.xuat_pn();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them1)
            {
                PhieuNhap a = new PhieuNhap();
                a.MaPN = txtma_PN.Text.Trim();
                a.NgayNhap = datePK.Value;
                a.TongTien = 0;
                if (BUS.BUS.them_pn(a) != 0)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvphieuNhap.DataSource = BUS.BUS.xuat_pn();
                }
                them1 = false;
            }
            else if (sua1)
            {
                PhieuNhap a = new PhieuNhap();
                a.MaPN = txtma_PN.Text.Trim();
                a.NgayNhap = datePK.Value;
                a.TongTien = 0;
                if (BUS.BUS.sua_PN(a) != 0)
                {
                    MessageBox.Show("Sua thanh cong");
                    dgvphieuNhap.DataSource = BUS.BUS.xuat_pn();
                }
                sua1 = false;
            }
    }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            txtmaCTN.Enabled = true;
            txtmaHH.Enabled = true;
            txtdonGia.Enabled = true;
            txt_soLuong.Enabled = true;
            them2 = true;
            txtmaCTN.Clear();
            txtmaHH.Clear();
            txtdonGia.Clear();
            txt_soLuong.Clear();
        }

        private void btnsua2_Click(object sender, EventArgs e)
        {

            txtmaHH.Enabled = true;
            txtdonGia.Enabled = true;
            txt_soLuong.Enabled = true;
            sua2 = true;

        }

        private void btnxoa2_Click(object sender, EventArgs e)
        {
            ChiTietNhap a = new ChiTietNhap();

            a.MaCTN = txtmaCTN.Text.Trim();

            if (BUS.BUS.xoa_CTN(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvCTN.DataSource = BUS.BUS.xuat_ctn(txtma_PN.Text);
            }
            dgvphieuNhap.DataSource = BUS.BUS.xuat_pn();
        }

        private void btnluu2_Click(object sender, EventArgs e)
        {

            if (them2)
            {
                ChiTietNhap a = new ChiTietNhap();
                a.MaPN = txtma_PN.Text.Trim();
                a.MaCTN = txtmaCTN.Text.Trim();
                a.MaHH = txtmaHH.Text.Trim();
                a.DonGia = float.Parse(txtdonGia.Text);
                a.SoLuong = int.Parse(txt_soLuong.Text);
                if (BUS.BUS.them_ctn(a) != 0)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvCTN.DataSource = BUS.BUS.xuat_ctn(txtma_PN.Text);
                }
                them2 = false;
                dgvphieuNhap.DataSource = BUS.BUS.xuat_pn();
            }
            else if (sua2)
            {
                ChiTietNhap a = new ChiTietNhap();
                a.MaPN = txtma_PN.Text.Trim();
                a.MaCTN = txtmaCTN.Text.Trim();
                a.MaHH = txtmaHH.Text.Trim();
                a.DonGia = float.Parse(txtdonGia.Text);
                a.SoLuong = int.Parse(txt_soLuong.Text);
                if (BUS.BUS.sua_ctn(a) != 0)
                {
                    MessageBox.Show("sua thanh cong");
                    dgvCTN.DataSource = BUS.BUS.xuat_ctn(txtma_PN.Text);
                }
                sua2 = false;
                dgvphieuNhap.DataSource = BUS.BUS.xuat_pn();
            }
        }

        private void dgvCTN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaCTN.Text = dgvCTN.CurrentRow.Cells[0].Value.ToString();
            txtmaHH.Text = dgvCTN.CurrentRow.Cells[1].Value.ToString();
            txtdonGia.Text = dgvCTN.CurrentRow.Cells[3].Value.ToString();
            txt_soLuong.Text = dgvCTN.CurrentRow.Cells[2].Value.ToString();
            txtmaCTN.Enabled = false;
            txtmaHH.Enabled = false;
            txtdonGia.Enabled = false;
            txt_soLuong.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
