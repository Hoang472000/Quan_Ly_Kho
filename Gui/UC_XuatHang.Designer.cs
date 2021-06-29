namespace QL_Kho.Gui
{
    partial class UC_XuatHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCTX = new System.Windows.Forms.DataGridView();
            this.dgvphieuXuat = new System.Windows.Forms.DataGridView();
            this.txttongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdonGia = new System.Windows.Forms.TextBox();
            this.txtmaCTX = new System.Windows.Forms.TextBox();
            this.DG = new System.Windows.Forms.Label();
            this.MCTN = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.datePK = new System.Windows.Forms.DateTimePicker();
            this.txtma_PX = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txtsoLuong = new System.Windows.Forms.Label();
            this.txtngayLap = new System.Windows.Forms.Label();
            this.txtmaPX = new System.Windows.Forms.Label();
            this.btnthem2 = new System.Windows.Forms.Button();
            this.btnsua2 = new System.Windows.Forms.Button();
            this.btnxoa2 = new System.Windows.Forms.Button();
            this.btnluu2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 71);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(258, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "XUẤT HÀNG";
            // 
            // dgvCTX
            // 
            this.dgvCTX.AllowUserToAddRows = false;
            this.dgvCTX.AllowUserToDeleteRows = false;
            this.dgvCTX.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTX.Location = new System.Drawing.Point(348, 256);
            this.dgvCTX.Name = "dgvCTX";
            this.dgvCTX.Size = new System.Drawing.Size(339, 142);
            this.dgvCTX.TabIndex = 83;
            this.dgvCTX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTX_CellContentClick);
            // 
            // dgvphieuXuat
            // 
            this.dgvphieuXuat.AllowUserToAddRows = false;
            this.dgvphieuXuat.AllowUserToDeleteRows = false;
            this.dgvphieuXuat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvphieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieuXuat.Location = new System.Drawing.Point(3, 256);
            this.dgvphieuXuat.Name = "dgvphieuXuat";
            this.dgvphieuXuat.Size = new System.Drawing.Size(344, 142);
            this.dgvphieuXuat.TabIndex = 82;
            this.dgvphieuXuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieuXuat_CellContentClick);
            // 
            // txttongTien
            // 
            this.txttongTien.Location = new System.Drawing.Point(133, 160);
            this.txttongTien.Multiline = true;
            this.txttongTien.Name = "txttongTien";
            this.txttongTien.Size = new System.Drawing.Size(130, 20);
            this.txttongTien.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 80;
            this.label3.Text = "Tổng Tiền";
            // 
            // txtmaHH
            // 
            this.txtmaHH.Location = new System.Drawing.Point(470, 122);
            this.txtmaHH.Multiline = true;
            this.txtmaHH.Name = "txtmaHH";
            this.txtmaHH.Size = new System.Drawing.Size(102, 20);
            this.txtmaHH.TabIndex = 79;
            this.txtmaHH.TextChanged += new System.EventHandler(this.txtmaHH_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 78;
            this.label2.Text = "Mã Hàng Hóa";
            // 
            // txtdonGia
            // 
            this.txtdonGia.Location = new System.Drawing.Point(470, 163);
            this.txtdonGia.Multiline = true;
            this.txtdonGia.Name = "txtdonGia";
            this.txtdonGia.Size = new System.Drawing.Size(102, 20);
            this.txtdonGia.TabIndex = 76;
            this.txtdonGia.TextChanged += new System.EventHandler(this.txtdonGia_TextChanged);
            // 
            // txtmaCTX
            // 
            this.txtmaCTX.Location = new System.Drawing.Point(470, 83);
            this.txtmaCTX.Multiline = true;
            this.txtmaCTX.Name = "txtmaCTX";
            this.txtmaCTX.Size = new System.Drawing.Size(102, 22);
            this.txtmaCTX.TabIndex = 77;
            this.txtmaCTX.TextChanged += new System.EventHandler(this.txtmaCTX_TextChanged);
            // 
            // DG
            // 
            this.DG.AutoSize = true;
            this.DG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG.Location = new System.Drawing.Point(374, 167);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(50, 14);
            this.DG.TabIndex = 74;
            this.DG.Text = "Đơn Giá";
            // 
            // MCTN
            // 
            this.MCTN.AutoSize = true;
            this.MCTN.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCTN.Location = new System.Drawing.Point(363, 87);
            this.MCTN.Name = "MCTN";
            this.MCTN.Size = new System.Drawing.Size(95, 14);
            this.MCTN.TabIndex = 75;
            this.MCTN.Text = "Mã Chi Tiết Xuất";
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnluu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(249, 195);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(70, 36);
            this.btnluu.TabIndex = 70;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(173, 195);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 36);
            this.btnxoa.TabIndex = 71;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(97, 195);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(70, 36);
            this.btnsua.TabIndex = 72;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnthem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(23, 195);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(68, 36);
            this.btnthem.TabIndex = 73;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // datePK
            // 
            this.datePK.Location = new System.Drawing.Point(133, 119);
            this.datePK.Name = "datePK";
            this.datePK.Size = new System.Drawing.Size(132, 20);
            this.datePK.TabIndex = 69;
            // 
            // txtma_PX
            // 
            this.txtma_PX.Location = new System.Drawing.Point(131, 80);
            this.txtma_PX.Multiline = true;
            this.txtma_PX.Name = "txtma_PX";
            this.txtma_PX.Size = new System.Drawing.Size(132, 20);
            this.txtma_PX.TabIndex = 68;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(470, 207);
            this.txt_soLuong.Multiline = true;
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(102, 20);
            this.txt_soLuong.TabIndex = 67;
            this.txt_soLuong.TextChanged += new System.EventHandler(this.txt_soLuong_TextChanged);
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.AutoSize = true;
            this.txtsoLuong.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoLuong.Location = new System.Drawing.Point(374, 215);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(61, 14);
            this.txtsoLuong.TabIndex = 66;
            this.txtsoLuong.Text = "Số Lượng";
            // 
            // txtngayLap
            // 
            this.txtngayLap.AutoSize = true;
            this.txtngayLap.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngayLap.Location = new System.Drawing.Point(32, 126);
            this.txtngayLap.Name = "txtngayLap";
            this.txtngayLap.Size = new System.Drawing.Size(60, 14);
            this.txtngayLap.TabIndex = 64;
            this.txtngayLap.Text = "Ngày Xuất";
            // 
            // txtmaPX
            // 
            this.txtmaPX.AutoSize = true;
            this.txtmaPX.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaPX.Location = new System.Drawing.Point(20, 86);
            this.txtmaPX.Name = "txtmaPX";
            this.txtmaPX.Size = new System.Drawing.Size(84, 14);
            this.txtmaPX.TabIndex = 65;
            this.txtmaPX.Text = "Mã Phiếu Xuất";
            // 
            // btnthem2
            // 
            this.btnthem2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnthem2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem2.Location = new System.Drawing.Point(591, 87);
            this.btnthem2.Name = "btnthem2";
            this.btnthem2.Size = new System.Drawing.Size(68, 36);
            this.btnthem2.TabIndex = 84;
            this.btnthem2.Text = "Thêm2";
            this.btnthem2.UseVisualStyleBackColor = false;
            this.btnthem2.Click += new System.EventHandler(this.btnthem2_Click);
            // 
            // btnsua2
            // 
            this.btnsua2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsua2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua2.Location = new System.Drawing.Point(591, 126);
            this.btnsua2.Name = "btnsua2";
            this.btnsua2.Size = new System.Drawing.Size(68, 36);
            this.btnsua2.TabIndex = 85;
            this.btnsua2.Text = "Sửa2";
            this.btnsua2.UseVisualStyleBackColor = false;
            this.btnsua2.Click += new System.EventHandler(this.btnsua2_Click);
            // 
            // btnxoa2
            // 
            this.btnxoa2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxoa2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa2.Location = new System.Drawing.Point(591, 161);
            this.btnxoa2.Name = "btnxoa2";
            this.btnxoa2.Size = new System.Drawing.Size(68, 36);
            this.btnxoa2.TabIndex = 86;
            this.btnxoa2.Text = "Xóa2";
            this.btnxoa2.UseVisualStyleBackColor = false;
            this.btnxoa2.Click += new System.EventHandler(this.btnxoa2_Click);
            // 
            // btnluu2
            // 
            this.btnluu2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnluu2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu2.Location = new System.Drawing.Point(591, 196);
            this.btnluu2.Name = "btnluu2";
            this.btnluu2.Size = new System.Drawing.Size(68, 36);
            this.btnluu2.TabIndex = 87;
            this.btnluu2.Text = "Lưu2";
            this.btnluu2.UseVisualStyleBackColor = false;
            this.btnluu2.Click += new System.EventHandler(this.btnluu2_Click);
            // 
            // UC_XuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnluu2);
            this.Controls.Add(this.btnxoa2);
            this.Controls.Add(this.btnsua2);
            this.Controls.Add(this.btnthem2);
            this.Controls.Add(this.dgvCTX);
            this.Controls.Add(this.dgvphieuXuat);
            this.Controls.Add(this.txttongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdonGia);
            this.Controls.Add(this.txtmaCTX);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.MCTN);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.datePK);
            this.Controls.Add(this.txtma_PX);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txtsoLuong);
            this.Controls.Add(this.txtngayLap);
            this.Controls.Add(this.txtmaPX);
            this.Controls.Add(this.panel1);
            this.Name = "UC_XuatHang";
            this.Size = new System.Drawing.Size(690, 401);
            this.Load += new System.EventHandler(this.UC_XuatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCTX;
        private System.Windows.Forms.DataGridView dgvphieuXuat;
        private System.Windows.Forms.TextBox txttongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdonGia;
        private System.Windows.Forms.TextBox txtmaCTX;
        private System.Windows.Forms.Label DG;
        private System.Windows.Forms.Label MCTN;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker datePK;
        private System.Windows.Forms.TextBox txtma_PX;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label txtsoLuong;
        private System.Windows.Forms.Label txtngayLap;
        private System.Windows.Forms.Label txtmaPX;
        private System.Windows.Forms.Button btnthem2;
        private System.Windows.Forms.Button btnsua2;
        private System.Windows.Forms.Button btnxoa2;
        private System.Windows.Forms.Button btnluu2;
    }
}
