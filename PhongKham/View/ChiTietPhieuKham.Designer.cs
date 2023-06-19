namespace PhongKham.View
{
    partial class ChiTietPhieuKham
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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lbIdBS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgLichSu = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 9);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(156, 47);
            this.btnQuayLai.TabIndex = 24;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lbIdBS
            // 
            this.lbIdBS.AutoSize = true;
            this.lbIdBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdBS.Location = new System.Drawing.Point(75, 425);
            this.lbIdBS.Name = "lbIdBS";
            this.lbIdBS.Size = new System.Drawing.Size(0, 26);
            this.lbIdBS.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(323, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 47);
            this.label2.TabIndex = 20;
            this.label2.Text = "LỊCH SỬ BỆNH NHÂN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(256, -335);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 47);
            this.label1.TabIndex = 18;
            this.label1.Text = "ĐĂNG KÝ KHÁM BỆNH";
            // 
            // dtgLichSu
            // 
            this.dtgLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLichSu.Location = new System.Drawing.Point(12, 184);
            this.dtgLichSu.Name = "dtgLichSu";
            this.dtgLichSu.RowHeadersWidth = 51;
            this.dtgLichSu.RowTemplate.Height = 24;
            this.dtgLichSu.Size = new System.Drawing.Size(972, 333);
            this.dtgLichSu.TabIndex = 25;
            this.dtgLichSu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Chon);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã Bệnh Nhân:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(277, 91);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(27, 29);
            this.lbId.TabIndex = 26;
            this.lbId.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên Bệnh Nhân:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(695, 91);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(150, 29);
            this.lbTen.TabIndex = 26;
            this.lbTen.Text = "Lê Văn Lâm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Lịch sử khám bệnh:";
            // 
            // ChiTietPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 529);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgLichSu);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lbIdBS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietPhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietPhieuKham";
            this.Load += new System.EventHandler(this.ChiTietPhieuKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lbIdBS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgLichSu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label7;
    }
}