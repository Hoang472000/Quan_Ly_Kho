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
    public partial class UC_HangHoa : UserControl
    {
        bool them, sua;
        public UC_HangHoa()
        {
            InitializeComponent();
        }
        DataTable a = new DataTable();

        private void xuat()
        {
            dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            xuat();
        }
        private void dgvhangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaHH.Text = dgvhangHoa.CurrentRow.Cells[0].Value.ToString();
            txttenHH.Text = dgvhangHoa.CurrentRow.Cells[1].Value.ToString();
            txtmaCC.Text = dgvhangHoa.CurrentRow.Cells[2].Value.ToString();
            txtsoLuong.Text = dgvhangHoa.CurrentRow.Cells[3].Value.ToString();
            txtmaCC.Enabled = false;
            txttenHH.Enabled = false;
            txtmaHH.Enabled = false;
            txtsoLuong.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txtmaCC.Enabled = true;
            txttenHH.Enabled = true;
            txtmaHH.Enabled = true;
            txtsoLuong.Enabled = true;
            sua = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            HangHoa a = new HangHoa();
            a.MaHH = txtmaHH.Text.Trim();
            if (BUS.BUS.xoa_HH(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                HangHoa a = new HangHoa();
                a.MaHH = txtmaHH.Text.Trim();
                a.MaNCC = txtmaCC.Text.Trim();
                a.TenHH = txttenHH.Text.Trim();
                a.SoLuong = int.Parse(txtsoLuong.Text);
                    if (BUS.BUS.them_hh(a) != 0)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
                }
                them = false;
            }
            else if (sua)
            {
                HangHoa a = new HangHoa();
                a.MaHH = txtmaHH.Text.Trim();
                a.MaNCC = txtmaCC.Text.Trim();
                a.TenHH = txttenHH.Text.Trim();
                a.SoLuong = int.Parse(txtsoLuong.Text);
                if (BUS.BUS.sua_HH(a) != 0)
                {
                    MessageBox.Show("Sua thanh cong");
                    dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
                }
                sua = false;
            }
        }

        private void txtsoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmaHH.Enabled = true;
            txtmaCC.Enabled = true;
            txtsoLuong.Enabled = true;
            txttenHH.Enabled = true;
     
            txttenHH.Clear();
            txtsoLuong.Clear();
            txtmaCC.Clear();
            txtmaHH.Clear();
            them = true;
        }
    }
}
