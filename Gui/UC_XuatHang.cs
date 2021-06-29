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
    public partial class UC_XuatHang : UserControl
    {
        bool them1, sua1, them2, sua2;
        public UC_XuatHang()
        {
            InitializeComponent();
        }
        DataTable a = new DataTable();
        private void load()
        {
            DataTable a = new DataTable();
            a = BUS.BUS.xuat_px();
            dgvphieuXuat.DataSource = a;
        }
        private void UC_XuatHang_Load(object sender, EventArgs e)
        {
            load();
            txttongTien.Enabled = false;
        }

        private void dgvphieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma_PX.Text = dgvphieuXuat.CurrentRow.Cells[0].Value.ToString();
            txttongTien.Text = dgvphieuXuat.CurrentRow.Cells[2].Value.ToString();
            datePK.Text = dgvphieuXuat.CurrentRow.Cells[1].Value.ToString();
            txtma_PX.Enabled = false;
            datePK.Enabled = false;
        
            dgvCTX.DataSource =BUS.BUS.xuat_ctx(txtma_PX.Text);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            datePK.Enabled = true;
            sua1 = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            PhieuXuat a = new PhieuXuat();
            a.MaPX = txtma_PX.Text.Trim();
            
            if (BUS.BUS.xoa_PX(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
            }
        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            txtmaCTX.Enabled = true;
            txtmaHH.Enabled = true;
            txtdonGia.Enabled = true;
            txt_soLuong.Enabled = true;
            them2 = true;
            txtmaCTX.Clear();
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

        private void btnluu2_Click(object sender, EventArgs e)
        {
            if (them2)
            {
                ChiTietXuat a = new ChiTietXuat();
                a.MaPX = txtma_PX.Text.Trim();
                a.MaCTX = txtmaCTX.Text.Trim();
                a.MaHH = txtmaHH.Text.Trim();
                a.DonGia = float.Parse(txtdonGia.Text);
                a.SoLuong = int.Parse(txt_soLuong.Text);
                if (BUS.BUS.them_ctx(a) != 0)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvCTX.DataSource = BUS.BUS.xuat_ctx(txtma_PX.Text);
                }
                them2 = false;
                dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
            }
            else if (sua2)
            {
                ChiTietXuat a = new ChiTietXuat();
                a.MaPX = txtma_PX.Text.Trim();
                a.MaCTX = txtmaCTX.Text.Trim();
                a.MaHH = txtmaHH.Text.Trim();
                a.DonGia = float.Parse(txtdonGia.Text);
                a.SoLuong = int.Parse(txt_soLuong.Text);
                if (BUS.BUS.sua_ctx(a) != 0)
                {
                    MessageBox.Show("sua thanh cong");
                    dgvCTX.DataSource = BUS.BUS.xuat_ctx(txtma_PX.Text);
                }
                sua2 = false;
                dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
            }
        }

        private void btnxoa2_Click(object sender, EventArgs e)
        {
            ChiTietXuat a = new ChiTietXuat();
           
            a.MaCTX = txtmaCTX.Text.Trim();
        
            if (BUS.BUS.xoa_CTX(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvCTX.DataSource = BUS.BUS.xuat_ctx(txtma_PX.Text);
            }
            dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
        }

        private void txtmaCTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmaHH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCTX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaCTX.Text = dgvCTX.CurrentRow.Cells[0].Value.ToString();
            txtmaHH.Text = dgvCTX.CurrentRow.Cells[1].Value.ToString();
            txtdonGia.Text = dgvCTX.CurrentRow.Cells[3].Value.ToString();
            txt_soLuong.Text = dgvCTX.CurrentRow.Cells[2].Value.ToString();
            txtmaCTX.Enabled = false;
            txtmaHH.Enabled = false;
            txtdonGia.Enabled = false;
            txt_soLuong.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtma_PX.Enabled = true;
            datePK.Enabled = true;
            txtma_PX.Clear();
            txttongTien.Clear();
            them1 = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them1)
            {
                PhieuXuat a = new PhieuXuat();
                a.MaPX = txtma_PX.Text.Trim();
                a.NgayXuat = datePK.Value;
                a.TongTien = 0;
                if (BUS.BUS.them_px(a) != 0)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
                }
                them1 = false;
            }
            else if (sua1)
            {
                PhieuXuat a = new PhieuXuat();
                a.MaPX = txtma_PX.Text.Trim();
                a.NgayXuat = datePK.Value;
                a.TongTien = 0;
                if (BUS.BUS.sua_PX(a) != 0)
                {
                    MessageBox.Show("sua thanh cong");
                    dgvphieuXuat.DataSource = BUS.BUS.xuat_px();
                }
                sua1 = false;
            }

        }
    }
}
