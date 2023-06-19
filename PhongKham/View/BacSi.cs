using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL;
using hospitals.Bus;

namespace PhongKham.View
{
    public partial class BacSi : Form
    {
        Bus_Patient bus_Patient;
        Label lbId = new Label();
        Label lbTen = new Label();
        public String id;
        public BacSi()
        {
            InitializeComponent();
            bus_Patient = new Bus_Patient();
        }
        void HienThiDLLenDG()
        {
            DGVBenhNhan.DataSource = null;
            bus_Patient.HienThiDSPatientLenDGV(DGVBenhNhan);
            DGVBenhNhan.Columns[0].Width = (int)(DGVBenhNhan.Width * 0.05);
            DGVBenhNhan.Columns[1].Width = (int)(DGVBenhNhan.Width * 0.2);
            DGVBenhNhan.Columns[2].Width = (int)(DGVBenhNhan.Width * 0.07);
            DGVBenhNhan.Columns[3].Width = (int)(DGVBenhNhan.Width * 0.2);
            DGVBenhNhan.Columns[4].Width = (int)(DGVBenhNhan.Width * 0.2);
            DGVBenhNhan.Columns[5].Width = (int)(DGVBenhNhan.Width * 0.2);
            DGVBenhNhan.Columns[6].Width = (int)(DGVBenhNhan.Width * 0.2);
        }
        private void BacSi_Load(object sender, EventArgs e)
        {
            HienThiDLLenDG();
            lbIdBS.Text = id;
        }

       

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            PhieuKham p = new PhieuKham();
            p.IdBn = lbId.Text;
            p.tenBn = lbTen.Text;
            p.IdBS = id;
            this.Hide();
            p.ShowDialog();
        }

        private void chon(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                lbId.Text = DGVBenhNhan.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbTen.Text = DGVBenhNhan.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap(); 
            this.Hide();
            f.ShowDialog();
        }

        private void ChiTiet(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietPhieuKham f = new ChiTietPhieuKham();
            f.IdBn = DGVBenhNhan.Rows[e.RowIndex].Cells[0].Value.ToString();
            f.tenBn = DGVBenhNhan.Rows[e.RowIndex].Cells[1].Value.ToString();
            f.IdBs = id;
            this.Hide();
            f.ShowDialog();
        }
    }
}
