using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QL_Kho
{
    public partial class FrmLogin : Form
    {
        Dataprovider con = new Dataprovider();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ckcHienpw_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcHienpw.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
        private void txtacc_TextChanged(object sender, EventArgs e)
        {
            txtacc.Text = "";
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.Text = "";
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if ((txtacc.Text == "") || (txtpass.Text == ""))
            {
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LANLAN\SQLEXPRESS;Initial Catalog=Quan_Ly_Kho;Integrated Security=True");
                con.Open();
                string s = "select count(*) from TaiKhoan where acc='" + txtacc.Text + "'and pass='" + txtpass.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(s, con);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form1 a = new Form1();
                    a.Show();
                    con.Close();
                }
                else
                {
                    // MessageBox.Show("loi");
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản");
                }
            }
        }
    }
}
