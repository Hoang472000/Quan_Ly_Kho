namespace QL_Kho.Gui
{
    partial class UC_NhapHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.datePK = new System.Windows.Forms.DateTimePicker();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txtsoLuong = new System.Windows.Forms.Label();
            this.txtngayLap = new System.Windows.Forms.Label();
            this.txtmaPN = new System.Windows.Forms.Label();
            this.txtma_PN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdonGia = new System.Windows.Forms.TextBox();
            this.txtmaCTN = new System.Windows.Forms.TextBox();
            this.DG = new System.Windows.Forms.Label();
            this.MCTN = new System.Windows.Forms.Label();
            this.txtmaHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvphieuNhap = new System.Windows.Forms.DataGridView();
            this.dgvCTN = new System.Windows.Forms.DataGridView();
            this.btnthem2 = new System.Windows.Forms.Button();
            this.btnsua2 = new System.Windows.Forms.Button();
            this.btnxoa2 = new System.Windows.Forms.Button();
            this.btnluu2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(241, 214);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(70, 36);
            this.btnluu.TabIndex = 39;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(165, 214);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 36);
            this.btnxoa.TabIndex = 40;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(89, 214);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(70, 36);
            this.btnsua.TabIndex = 41;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(15, 214);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(68, 36);
            this.btnthem.TabIndex = 42;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // datePK
            // 
            this.datePK.Location = new System.Drawing.Point(150, 129);
            this.datePK.Name = "datePK";
            this.datePK.Size = new System.Drawing.Size(132, 20);
            this.datePK.TabIndex = 37;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(485, 223);
            this.txt_soLuong.Multiline = true;
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(106, 20);
            this.txt_soLuong.TabIndex = 35;
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.AutoSize = true;
            this.txtsoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoLuong.Location = new System.Drawing.Point(351, 223);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(61, 13);
            this.txtsoLuong.TabIndex = 32;
            this.txtsoLuong.Text = "Số Lượng";
            // 
            // txtngayLap
            // 
            this.txtngayLap.AutoSize = true;
            this.txtngayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngayLap.Location = new System.Drawing.Point(30, 135);
            this.txtngayLap.Name = "txtngayLap";
            this.txtngayLap.Size = new System.Drawing.Size(70, 13);
            this.txtngayLap.TabIndex = 30;
            this.txtngayLap.Text = "Ngày Nhập";
            // 
            // txtmaPN
            // 
            this.txtmaPN.AutoSize = true;
            this.txtmaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaPN.Location = new System.Drawing.Point(30, 86);
            this.txtmaPN.Name = "txtmaPN";
            this.txtmaPN.Size = new System.Drawing.Size(94, 13);
            this.txtmaPN.TabIndex = 31;
            this.txtmaPN.Text = "Mã Phiếu Nhâp";
            // 
            // txtma_PN
            // 
            this.txtma_PN.Location = new System.Drawing.Point(150, 83);
            this.txtma_PN.Multiline = true;
            this.txtma_PN.Name = "txtma_PN";
            this.txtma_PN.Size = new System.Drawing.Size(132, 20);
            this.txtma_PN.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 72);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(264, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtdonGia
            // 
            this.txtdonGia.Location = new System.Drawing.Point(485, 179);
            this.txtdonGia.Multiline = true;
            this.txtdonGia.Name = "txtdonGia";
            this.txtdonGia.Size = new System.Drawing.Size(106, 20);
            this.txtdonGia.TabIndex = 55;
            // 
            // txtmaCTN
            // 
            this.txtmaCTN.Location = new System.Drawing.Point(485, 83);
            this.txtmaCTN.Multiline = true;
            this.txtmaCTN.Name = "txtmaCTN";
            this.txtmaCTN.Size = new System.Drawing.Size(106, 22);
            this.txtmaCTN.TabIndex = 56;
            // 
            // DG
            // 
            this.DG.AutoSize = true;
            this.DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG.Location = new System.Drawing.Point(351, 182);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(53, 13);
            this.DG.TabIndex = 50;
            this.DG.Text = "Đơn Giá";
            // 
            // MCTN
            // 
            this.MCTN.AutoSize = true;
            this.MCTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCTN.Location = new System.Drawing.Point(351, 90);
            this.MCTN.Name = "MCTN";
            this.MCTN.Size = new System.Drawing.Size(106, 13);
            this.MCTN.TabIndex = 52;
            this.MCTN.Text = "Mã Chi Tiết Nhập";
            // 
            // txtmaHH
            // 
            this.txtmaHH.Location = new System.Drawing.Point(485, 135);
            this.txtmaHH.Multiline = true;
            this.txtmaHH.Name = "txtmaHH";
            this.txtmaHH.Size = new System.Drawing.Size(106, 20);
            this.txtmaHH.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mã Hàng Hóa";
            // 
            // txttongTien
            // 
            this.txttongTien.Location = new System.Drawing.Point(150, 179);
            this.txttongTien.Multiline = true;
            this.txttongTien.Name = "txttongTien";
            this.txttongTien.Size = new System.Drawing.Size(130, 20);
            this.txttongTien.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Tổng Tiền";
            // 
            // dgvphieuNhap
            // 
            this.dgvphieuNhap.AllowUserToAddRows = false;
            this.dgvphieuNhap.AllowUserToDeleteRows = false;
            this.dgvphieuNhap.AllowUserToResizeRows = false;
            this.dgvphieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphieuNhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvphieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieuNhap.Location = new System.Drawing.Point(3, 268);
            this.dgvphieuNhap.Name = "dgvphieuNhap";
            this.dgvphieuNhap.ReadOnly = true;
            this.dgvphieuNhap.Size = new System.Drawing.Size(336, 131);
            this.dgvphieuNhap.TabIndex = 63;
            this.dgvphieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieuNhap_CellContentClick);
            // 
            // dgvCTN
            // 
            this.dgvCTN.AllowUserToAddRows = false;
            this.dgvCTN.AllowUserToDeleteRows = false;
            this.dgvCTN.AllowUserToResizeRows = false;
            this.dgvCTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTN.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTN.Location = new System.Drawing.Point(339, 268);
            this.dgvCTN.Name = "dgvCTN";
            this.dgvCTN.ReadOnly = true;
            this.dgvCTN.Size = new System.Drawing.Size(347, 131);
            this.dgvCTN.TabIndex = 63;
            this.dgvCTN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTN_CellContentClick);
            // 
            // btnthem2
            // 
            this.btnthem2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnthem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem2.Location = new System.Drawing.Point(618, 78);
            this.btnthem2.Name = "btnthem2";
            this.btnthem2.Size = new System.Drawing.Size(68, 36);
            this.btnthem2.TabIndex = 64;
            this.btnthem2.Text = "Thêm2";
            this.btnthem2.UseVisualStyleBackColor = false;
            this.btnthem2.Click += new System.EventHandler(this.btnthem2_Click);
            // 
            // btnsua2
            // 
            this.btnsua2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua2.Location = new System.Drawing.Point(618, 123);
            this.btnsua2.Name = "btnsua2";
            this.btnsua2.Size = new System.Drawing.Size(67, 36);
            this.btnsua2.TabIndex = 65;
            this.btnsua2.Text = "Sửa2";
            this.btnsua2.UseVisualStyleBackColor = false;
            this.btnsua2.Click += new System.EventHandler(this.btnsua2_Click);
            // 
            // btnxoa2
            // 
            this.btnxoa2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxoa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa2.Location = new System.Drawing.Point(618, 170);
            this.btnxoa2.Name = "btnxoa2";
            this.btnxoa2.Size = new System.Drawing.Size(67, 36);
            this.btnxoa2.TabIndex = 66;
            this.btnxoa2.Text = "Xóa2";
            this.btnxoa2.UseVisualStyleBackColor = false;
            this.btnxoa2.Click += new System.EventHandler(this.btnxoa2_Click);
            // 
            // btnluu2
            // 
            this.btnluu2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnluu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu2.Location = new System.Drawing.Point(618, 218);
            this.btnluu2.Name = "btnluu2";
            this.btnluu2.Size = new System.Drawing.Size(67, 36);
            this.btnluu2.TabIndex = 67;
            this.btnluu2.Text = "Lưu2";
            this.btnluu2.UseVisualStyleBackColor = false;
            this.btnluu2.Click += new System.EventHandler(this.btnluu2_Click);
            // 
            // UC_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnluu2);
            this.Controls.Add(this.btnxoa2);
            this.Controls.Add(this.btnsua2);
            this.Controls.Add(this.btnthem2);
            this.Controls.Add(this.dgvCTN);
            this.Controls.Add(this.dgvphieuNhap);
            this.Controls.Add(this.txttongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdonGia);
            this.Controls.Add(this.txtmaCTN);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.MCTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.datePK);
            this.Controls.Add(this.txtma_PN);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txtsoLuong);
            this.Controls.Add(this.txtngayLap);
            this.Controls.Add(this.txtmaPN);
            this.Name = "UC_NhapHang";
            this.Size = new System.Drawing.Size(690, 402);
            this.Load += new System.EventHandler(this.UC_NhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker datePK;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label txtsoLuong;
        private System.Windows.Forms.Label txtngayLap;
        private System.Windows.Forms.Label txtmaPN;
        private System.Windows.Forms.TextBox txtma_PN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdonGia;
        private System.Windows.Forms.TextBox txtmaCTN;
        private System.Windows.Forms.Label DG;
        private System.Windows.Forms.Label MCTN;
        private System.Windows.Forms.TextBox txtmaHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvphieuNhap;
        private System.Windows.Forms.DataGridView dgvCTN;
        private System.Windows.Forms.Button btnthem2;
        private System.Windows.Forms.Button btnsua2;
        private System.Windows.Forms.Button btnxoa2;
        private System.Windows.Forms.Button btnluu2;
    }
}
