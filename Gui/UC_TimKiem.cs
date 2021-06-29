using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Kho.Gui
{
    public partial class UC_TimKiem : UserControl
    {
        DataTable dt;
        public UC_TimKiem()
        {
            InitializeComponent();
        }
        private void xuat()
        { dt= BUS.BUS.tk_hh();
            dgv_tknv.DataSource = dt;
        }

        private void UC_TimKiem_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void txt_tennv_TextChanged(object sender, EventArgs e)
        {
            string st = string.Format("[Tên Hàng Hóa] like '%{0}%'", txt_tennv.Text);
            dt.DefaultView.RowFilter = st;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string st = string.Format("[Nhà Cung Cấp] like '%{0}%'", textBox1.Text);
            dt.DefaultView.RowFilter = st;
        }

        private void txt_tennv_Click(object sender, EventArgs e)
        {
            txt_tennv.Text = "";

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void dgv_tknv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
