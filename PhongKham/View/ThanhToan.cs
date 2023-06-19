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
using hospitals.Models;
using PhongKham.Bus;

namespace PhongKham.View
{
    public partial class ThanhToan : Form
    {
        Bus_Bill bus_bill;
        Bus_ExaminationCard exam;
       
        public ThanhToan()
        {
            InitializeComponent();
            bus_bill = new Bus_Bill();
            exam = new Bus_ExaminationCard();
        }

        private void đăngKýKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            this.Hide();
            dk.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
        }
        void HienThiDLLenDG()
        {
            dgvBill.DataSource = null;
            bus_bill.HienThiDSPatientLenDGV(dgvBill);
            dgvBill.Columns[0].Width = (int)(dgvBill.Width * 0.2);
            dgvBill.Columns[1].Width = (int)(dgvBill.Width * 0.5);
            dgvBill.Columns[2].Width = (int)(dgvBill.Width * 0.3);
           
        }
        void HienThiDLLenDGSearch()
        {
            dgvBill.DataSource = null;
            bus_bill.LayBillByIdPaitent(dgvBill,int.Parse(txtMaBenhNhan.Text));
            dgvBill.Columns[0].Width = (int)(dgvBill.Width * 0.2);
            dgvBill.Columns[1].Width = (int)(dgvBill.Width * 0.5);
            dgvBill.Columns[2].Width = (int)(dgvBill.Width * 0.3);

        }
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            HienThiDLLenDG();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDLLenDGSearch();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                bus_bill.ThanhToanHD(int.Parse(txtMaBenhNhan.Text),DateTime.Now);
                HienThiDLLenDG();
                MessageBox.Show("Thanh Toán Thành Công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thanh Toán Thất Bại");
            }
           
        }

        private void Chon(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                txtMaBenhNhan.Text = dgvBill.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            HienThiDLLenDG();
        }

        private void ChiTietHoaDon(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietToaThuoc f = new ChiTietToaThuoc();
            ExaminationCard ex = exam.layCardById(int.Parse(dgvBill.Rows[e.RowIndex].Cells[2].Value.ToString()));
            f.IdBn = ex.PatientId.ToString();
            f.tenBn = ex.Patient.Name;
            f.idPhieu = ex.Id.ToString();
            f.IdBs = null;
            f.tienKham = ex.ExaminationFee.ToString();
            this.Hide();
            f.ShowDialog();
        }
    }
}
