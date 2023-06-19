using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using hospitals.Models;
using PhongKham.Bus;

namespace PhongKham.View
{
    public partial class ChiTietPhieuKham : Form
    {
        public String tenBn;
        public String IdBn;
        public String IdBs;
        DataTable dtLS;
        Bus_ExaminationCard exam;
        public ChiTietPhieuKham()
        {
            InitializeComponent();
            exam = new Bus_ExaminationCard();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            BacSi f = new BacSi();
            f.id = IdBs;
            this.Hide();
            f.ShowDialog();
        }

        private void ChiTietPhieuKham_Load(object sender, EventArgs e)
        {
            lbTen.Text = tenBn;
            lbId.Text = IdBn;
            HienThi();
        }
        private void HienThi()
        {
            dtLS = new DataTable();
            dtLS.Columns.Add("Mã");
            dtLS.Columns.Add("Triệu chứng");
            dtLS.Columns.Add("Dự đoán");
            dtLS.Columns.Add("Mã bác sĩ");
            dtLS.Columns.Add("Tiền Khám");
            dtgLichSu.DataSource = dtLS;
            dtgLichSu.Columns[0].Width = (int)(dtgLichSu.Width * 0.1);
            dtgLichSu.Columns[1].Width = (int)(dtgLichSu.Width * 0.4);
            dtgLichSu.Columns[2].Width = (int)(dtgLichSu.Width * 0.4);
            dtgLichSu.Columns[3].Width = (int)(dtgLichSu.Width * 0.1);
            dtgLichSu.Columns[4].Width = (int)(dtgLichSu.Width * 0.2);
            foreach (ExaminationCard i in exam.layCard(int.Parse(IdBn)))
            {
                DataRow s = dtLS.NewRow();
                s[0] = i.Id;
                s[1] = i.Diagnostic;
                s[2] = i.Forecast;
                s[3] = i.DoctorId;
                s[4] = i.ExaminationFee;
                dtLS.Rows.Add(s);
            }
        }

        private void Chon(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietToaThuoc f = new ChiTietToaThuoc();
            f.IdBn = IdBn;
            f.tenBn = tenBn;
            f.tienKham = dtgLichSu.Rows[e.RowIndex].Cells[4].Value.ToString(); 
            f.idPhieu = dtgLichSu.Rows[e.RowIndex].Cells[0].Value.ToString();
            f.IdBs = IdBs;
            this.Hide();
            f.ShowDialog();
        }
    }
}
