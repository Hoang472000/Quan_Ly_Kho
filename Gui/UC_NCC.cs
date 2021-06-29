using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Kho.DT0;
using QL_Kho.BUS;

namespace QL_Kho.Gui
{
    public partial class UC_NCC : UserControl
    {
        bool them, sua;
        public UC_NCC()
        {
            InitializeComponent();
        }
        DataTable a = new DataTable();

        private void xuat()
        {
            dgvNCC.DataSource = BUS.BUS.xuat_ncc();
        }
        private void NCC_Load(object sender, EventArgs e)
        {
            xuat();
        }
        private void dgvnhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txt_tenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            txt_diaChi.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
            txt_maNCC.Enabled = false;
            txt_tenNCC.Enabled = false;
            txt_diaChi.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txt_maNCC.Enabled = true;
            txt_tenNCC.Enabled = true;
            txt_diaChi.Enabled = true;
            sua = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NCC a = new NCC();
            a.MaNCC = txt_maNCC.Text.Trim();

            if (BUS.BUS.xoa_NCC(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvNCC.DataSource = BUS.BUS.xuat_ncc();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                NCC a = new NCC();
                a.MaNCC = txt_maNCC.Text.Trim();
                a.TenNCC = txt_tenNCC.Text.Trim();
                a.DiaChi = txt_diaChi.Text.Trim();
                if (BUS.BUS.them_ncc(a) != 0)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvNCC.DataSource = BUS.BUS.xuat_ncc();
                }
                them = false;
            }
            else if (sua)
            {
                NCC a = new NCC();
                a.MaNCC = txt_maNCC.Text.Trim();
                a.TenNCC = txt_tenNCC.Text.Trim();
                a.DiaChi = txt_diaChi.Text.Trim();
                if (BUS.BUS.sua_NCC(a) != 0)
                {
                    MessageBox.Show("Sua thanh cong");
                    dgvNCC.DataSource = BUS.BUS.xuat_ncc();
                }
                sua = false;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txt_maNCC.Enabled = true;
            txt_tenNCC.Enabled = true;
            txt_diaChi.Enabled = true;
            txt_maNCC.Clear();
            txt_tenNCC.Clear();
            txt_diaChi.Clear();
            them = true;
        }
    }
}
