namespace QL_Kho.Gui
{
    partial class UC_HangHoa
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
            this.txtmaCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaHH = new System.Windows.Forms.TextBox();
            this.lbl_mahh = new System.Windows.Forms.Label();
            this.dgvhangHoa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoLuong = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhangHoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(575, 150);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(70, 33);
            this.btnluu.TabIndex = 52;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(483, 151);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 33);
            this.btnxoa.TabIndex = 53;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(575, 111);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(70, 33);
            this.btnsua.TabIndex = 54;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(483, 112);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(70, 33);
            this.btnthem.TabIndex = 55;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmaCC
            // 
            this.txtmaCC.Location = new System.Drawing.Point(304, 119);
            this.txtmaCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtmaCC.Name = "txtmaCC";
            this.txtmaCC.Size = new System.Drawing.Size(138, 20);
            this.txtmaCC.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Mã CC";
            // 
            // txttenHH
            // 
            this.txttenHH.Location = new System.Drawing.Point(71, 151);
            this.txttenHH.Margin = new System.Windows.Forms.Padding(2);
            this.txttenHH.Name = "txttenHH";
            this.txttenHH.Size = new System.Drawing.Size(143, 20);
            this.txttenHH.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tên HH";
            // 
            // txtmaHH
            // 
            this.txtmaHH.Location = new System.Drawing.Point(71, 118);
            this.txtmaHH.Margin = new System.Windows.Forms.Padding(2);
            this.txtmaHH.Name = "txtmaHH";
            this.txtmaHH.Size = new System.Drawing.Size(143, 20);
            this.txtmaHH.TabIndex = 47;
            // 
            // lbl_mahh
            // 
            this.lbl_mahh.AutoSize = true;
            this.lbl_mahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mahh.Location = new System.Drawing.Point(12, 119);
            this.lbl_mahh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mahh.Name = "lbl_mahh";
            this.lbl_mahh.Size = new System.Drawing.Size(55, 16);
            this.lbl_mahh.TabIndex = 46;
            this.lbl_mahh.Text = "Mã HH";
            // 
            // dgvhangHoa
            // 
            this.dgvhangHoa.AllowUserToAddRows = false;
            this.dgvhangHoa.AllowUserToDeleteRows = false;
            this.dgvhangHoa.AllowUserToResizeRows = false;
            this.dgvhangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvhangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvhangHoa.Location = new System.Drawing.Point(0, 197);
            this.dgvhangHoa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvhangHoa.Name = "dgvhangHoa";
            this.dgvhangHoa.RowTemplate.Height = 24;
            this.dgvhangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhangHoa.Size = new System.Drawing.Size(690, 204);
            this.dgvhangHoa.TabIndex = 45;
            this.dgvhangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhangHoa_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 100);
            this.panel1.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(228, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "HÀNG HÓA";
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.Location = new System.Drawing.Point(304, 155);
            this.txtsoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(138, 20);
            this.txtsoLuong.TabIndex = 58;
            this.txtsoLuong.TextChanged += new System.EventHandler(this.txtsoLuong_TextChanged);
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(231, 155);
            this.la.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(69, 16);
            this.la.TabIndex = 57;
            this.la.Text = "Số lượng";
            // 
            // UC_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtsoLuong);
            this.Controls.Add(this.la);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmaCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttenHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaHH);
            this.Controls.Add(this.lbl_mahh);
            this.Controls.Add(this.dgvhangHoa);
            this.Name = "UC_HangHoa";
            this.Size = new System.Drawing.Size(690, 401);
            this.Load += new System.EventHandler(this.HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhangHoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmaCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttenHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaHH;
        private System.Windows.Forms.Label lbl_mahh;
        private System.Windows.Forms.DataGridView dgvhangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoLuong;
        private System.Windows.Forms.Label la;
    }
}
