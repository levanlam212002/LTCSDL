namespace BTL
{
    partial class PhieuKham
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radCo = new System.Windows.Forms.RadioButton();
            this.radKhong = new System.Windows.Forms.RadioButton();
            this.lbIdBS = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvtoa = new System.Windows.Forms.DataGridView();
            this.cbThuoc = new System.Windows.Forms.ComboBox();
            this.nbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.txtTenToa = new System.Windows.Forms.TextBox();
            this.txtDuDoan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nbTienKham = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(972, 785);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(194, 48);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Lưu Phiếu Khám";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Green;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(731, 785);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(169, 48);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 730);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tiền khám:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(568, 734);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mua thuốc của bệnh viện:";
            // 
            // radCo
            // 
            this.radCo.AutoSize = true;
            this.radCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCo.Location = new System.Drawing.Point(873, 731);
            this.radCo.Name = "radCo";
            this.radCo.Size = new System.Drawing.Size(65, 33);
            this.radCo.TabIndex = 17;
            this.radCo.TabStop = true;
            this.radCo.Text = "Có";
            this.radCo.UseVisualStyleBackColor = true;
            // 
            // radKhong
            // 
            this.radKhong.AutoSize = true;
            this.radKhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKhong.Location = new System.Drawing.Point(972, 731);
            this.radKhong.Name = "radKhong";
            this.radKhong.Size = new System.Drawing.Size(104, 33);
            this.radKhong.TabIndex = 17;
            this.radKhong.TabStop = true;
            this.radKhong.Text = "Không";
            this.radKhong.UseVisualStyleBackColor = true;
            // 
            // lbIdBS
            // 
            this.lbIdBS.AutoSize = true;
            this.lbIdBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdBS.Location = new System.Drawing.Point(1134, 75);
            this.lbIdBS.Name = "lbIdBS";
            this.lbIdBS.Size = new System.Drawing.Size(0, 29);
            this.lbIdBS.TabIndex = 23;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(608, 77);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 29);
            this.lbName.TabIndex = 24;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(249, 78);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 29);
            this.lbId.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.dgvtoa);
            this.groupBox1.Controls.Add(this.cbThuoc);
            this.groupBox1.Controls.Add(this.nbSoLuong);
            this.groupBox1.Controls.Add(this.btnThemThuoc);
            this.groupBox1.Controls.Add(this.txtTenToa);
            this.groupBox1.Controls.Add(this.txtDuDoan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTrieuChung);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1207, 576);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lâp phiếu khám";
            // 
            // dgvtoa
            // 
            this.dgvtoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtoa.Location = new System.Drawing.Point(170, 255);
            this.dgvtoa.Name = "dgvtoa";
            this.dgvtoa.RowHeadersWidth = 51;
            this.dgvtoa.RowTemplate.Height = 24;
            this.dgvtoa.Size = new System.Drawing.Size(829, 238);
            this.dgvtoa.TabIndex = 23;
            // 
            // cbThuoc
            // 
            this.cbThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThuoc.FormattingEnabled = true;
            this.cbThuoc.Location = new System.Drawing.Point(272, 525);
            this.cbThuoc.Name = "cbThuoc";
            this.cbThuoc.Size = new System.Drawing.Size(234, 34);
            this.cbThuoc.TabIndex = 22;
            // 
            // nbSoLuong
            // 
            this.nbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbSoLuong.Location = new System.Drawing.Point(672, 526);
            this.nbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.Size = new System.Drawing.Size(88, 32);
            this.nbSoLuong.TabIndex = 21;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.Green;
            this.btnThemThuoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThemThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemThuoc.Location = new System.Drawing.Point(818, 518);
            this.btnThemThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(162, 46);
            this.btnThemThuoc.TabIndex = 14;
            this.btnThemThuoc.Text = "Thêm Thuốc";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click_1);
            // 
            // txtTenToa
            // 
            this.txtTenToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenToa.Location = new System.Drawing.Point(435, 187);
            this.txtTenToa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenToa.Multiline = true;
            this.txtTenToa.Name = "txtTenToa";
            this.txtTenToa.Size = new System.Drawing.Size(564, 42);
            this.txtTenToa.TabIndex = 19;
            // 
            // txtDuDoan
            // 
            this.txtDuDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuDoan.Location = new System.Drawing.Point(435, 109);
            this.txtDuDoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuDoan.Multiline = true;
            this.txtDuDoan.Name = "txtDuDoan";
            this.txtDuDoan.Size = new System.Drawing.Size(564, 42);
            this.txtDuDoan.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 524);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 527);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thuốc:";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrieuChung.Location = new System.Drawing.Point(435, 22);
            this.txtTrieuChung.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(564, 42);
            this.txtTrieuChung.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(165, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tên Toa Thuốc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dự đoán loại bệnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Triệu chứng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "MÃ BỆNH NHÂN:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(997, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 28);
            this.label13.TabIndex = 20;
            this.label13.Text = "MÃ BÁC SĨ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "TÊN BỆNH NHÂN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(431, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "LẬP PHIẾU KHÁM BỆNH";
            // 
            // nbTienKham
            // 
            this.nbTienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbTienKham.Location = new System.Drawing.Point(262, 727);
            this.nbTienKham.Name = "nbTienKham";
            this.nbTienKham.Size = new System.Drawing.Size(199, 32);
            this.nbTienKham.TabIndex = 26;
            // 
            // PhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 854);
            this.Controls.Add(this.nbTienKham);
            this.Controls.Add(this.lbIdBS);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radKhong);
            this.Controls.Add(this.radCo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnHuy);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BacSi";
            this.Load += new System.EventHandler(this.BacSi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radCo;
        private System.Windows.Forms.RadioButton radKhong;
        private System.Windows.Forms.Label lbIdBS;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvtoa;
        private System.Windows.Forms.ComboBox cbThuoc;
        private System.Windows.Forms.NumericUpDown nbSoLuong;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.TextBox txtTenToa;
        private System.Windows.Forms.TextBox txtDuDoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nbTienKham;
    }
}