namespace PhongKham.View
{
    partial class BacSi
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
            this.DGVBenhNhan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.lbIdBS = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBenhNhan
            // 
            this.DGVBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBenhNhan.Location = new System.Drawing.Point(12, 90);
            this.DGVBenhNhan.Name = "DGVBenhNhan";
            this.DGVBenhNhan.RowHeadersWidth = 51;
            this.DGVBenhNhan.RowTemplate.Height = 24;
            this.DGVBenhNhan.Size = new System.Drawing.Size(1105, 300);
            this.DGVBenhNhan.TabIndex = 13;
            this.DGVBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chon);
            this.DGVBenhNhan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChiTiet);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(332, -335);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "ĐĂNG KÝ KHÁM BỆNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(334, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 47);
            this.label2.TabIndex = 14;
            this.label2.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(438, 413);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(248, 48);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Lập phiếu khám";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(24, 425);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(111, 26);
            this.lb.TabIndex = 16;
            this.lb.Text = "Mã bác sĩ:";
            // 
            // lbIdBS
            // 
            this.lbIdBS.AutoSize = true;
            this.lbIdBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdBS.Location = new System.Drawing.Point(151, 425);
            this.lbIdBS.Name = "lbIdBS";
            this.lbIdBS.Size = new System.Drawing.Size(0, 26);
            this.lbIdBS.TabIndex = 16;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(946, 9);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(156, 47);
            this.btnDangXuat.TabIndex = 17;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // BacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 476);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lbIdBS);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVBenhNhan);
            this.Controls.Add(this.label1);
            this.Name = "BacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BacSi";
            this.Load += new System.EventHandler(this.BacSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVBenhNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbIdBS;
        private System.Windows.Forms.Button btnDangXuat;
    }
}