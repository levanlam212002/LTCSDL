using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospitals.Bus;
using hospitals.Models;
using PhongKham.Bus;
using PhongKham.View;

namespace BTL
{
    public partial class PhieuKham : Form
    {
        public string IdBn;
        public string tenBn;
        public string IdBS;
        DataTable dtToaThuoc;
        Bus_Medicine bus_Medicine;
        Bus_ExaminationCard Bus_ExaminationCard;
        Bus_Prescription Bus_Prescription;
        Bus_PrescriptionDetail Bus_PrescriptionDetail;
        Bus_Bill Bus_Bill;
        public PhieuKham()
        {   
            InitializeComponent();
            bus_Medicine = new Bus_Medicine();
            Bus_ExaminationCard = new Bus_ExaminationCard();
            Bus_Prescription = new Bus_Prescription();
            Bus_PrescriptionDetail = new Bus_PrescriptionDetail();
            Bus_Bill = new Bus_Bill();
        }


        private void BacSi_Load(object sender, EventArgs e)
        {
            lbName.Text = tenBn;
            lbId.Text = IdBn;
            lbIdBS.Text = IdBS;
            bus_Medicine.HienThiDSPatientLenCBB(cbThuoc);
            dtToaThuoc = new DataTable();
            dtToaThuoc.Columns.Add("MedicineId");
            dtToaThuoc.Columns.Add("MedicineName");
            dtToaThuoc.Columns.Add("Quantity");
            dtToaThuoc.Columns.Add("Unit");
            dtToaThuoc.Columns.Add("Price");
            dgvtoa.DataSource = dtToaThuoc;
            dgvtoa.Columns[0].Width = (int)(dgvtoa.Width * 0.1);
            dgvtoa.Columns[1].Width = (int)(dgvtoa.Width * 0.3);
            dgvtoa.Columns[2].Width = (int)(dgvtoa.Width * 0.1);
            dgvtoa.Columns[3].Width = (int)(dgvtoa.Width * 0.2);
            dgvtoa.Columns[4].Width = (int)(dgvtoa.Width * 0.2);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BacSi f = new BacSi();
            this.Hide();
            f.id = IdBS;
            f.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ExaminationCard ex = new ExaminationCard();
            ex.Diagnostic = txtTrieuChung.Text;
            ex.Forecast = txtDuDoan.Text;
            ex.PatientId = Int32.Parse(lbId.Text);
            ex.DoctorId = Int32.Parse(lbIdBS.Text);
            ex.ExaminationFee = float.Parse(nbTienKham.Text);
            Bus_ExaminationCard.ThemExaminationCard(ex);
            Prescription pre = new Prescription();
            pre.Name = txtTenToa.Text;
            pre.ExaminationCardId = Bus_ExaminationCard.KiemPhieuVuaTao();
            Bus_Prescription.ThemExaminationCard(pre);
            foreach(DataRow item in dtToaThuoc.Rows)
            {
                PrescriptionDetails pd = new PrescriptionDetails();
                pd.PrescriptionId = Bus_Prescription.KiemPreVuaTao();
                pd.MedicineId = int.Parse(item[0].ToString());
                pd.Quantity = int.Parse(item[2].ToString());
                Bus_PrescriptionDetail.ThemPrescriptionDetails(pd);
            }
            Bill b = new Bill();
            b.Total = TinhBill();
            b.ExaminationCardId = Bus_ExaminationCard.KiemPhieuVuaTao();
            b.Status = false;
            Bus_Bill.ThemBill(b);
            BacSi f = new BacSi();
            this.Hide();
            f.id = IdBS;
            f.ShowDialog();
        }
        private float TinhBill()
        {
            float total = 0;
            total = float.Parse(nbTienKham.Text);
            if (radCo.Checked)
            {
                foreach (DataRow item in dtToaThuoc.Rows)
                {
                    total += float.Parse(item[2].ToString()) * float.Parse(item[4].ToString());
                }
            }
            return total;
        }

        private void btnThemThuoc_Click_1(object sender, EventArgs e)
        {
            DataRow r = dtToaThuoc.NewRow();
            Medicine m = bus_Medicine.LayMedicine(Int32.Parse(cbThuoc.SelectedValue.ToString()));
            r[0] = m.Id;
            r[1] = m.Name;
            r[2] = Convert.ToInt32(nbSoLuong.Value);
            r[3] = m.Unit;
            r[4] = m.Price;
            dtToaThuoc.Rows.Add(r);
        }
    }
}
