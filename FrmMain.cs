using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using QL_Kho.Gui;

namespace QL_Kho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_HangHoa a = new UC_HangHoa();
            a.Dock = DockStyle.Fill;
            panel2.Controls.Add(a);
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_NhapHang a = new UC_NhapHang();
            a.Dock = DockStyle.Fill;
            panel2.Controls.Add(a);
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_XuatHang a = new UC_XuatHang();
            a.Dock = DockStyle.Fill;
            panel2.Controls.Add(a);
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UC_NCC a = new UC_NCC();
            a.Dock = DockStyle.Fill;
            panel2.Controls.Add(a);
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UC_TimKiem a = new UC_TimKiem();
            a.Dock = DockStyle.Fill;
            panel2.Controls.Add(a);
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            UC_ThongKe a = new UC_ThongKe();
            a.Dock = DockStyle.Fill;
            panel2.Controls.Add(a);
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file:///C:/Users/Admin/Desktop/TTNhom_))/Help/abc.html");

        }
    }
}
