using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospitals.Models;
using PhongKham.Bus;

namespace PhongKham.View
{
   
    public partial class ChiTietToaThuoc : Form
    {
        public String tenBn;
        public String IdBn;
        public String IdBs;
        public String idPhieu;
        public String tienKham;
        DataTable dtToa;
        Bus_Prescription pre;
        Bus_PrescriptionDetail pd;
        public ChiTietToaThuoc()
        {
            InitializeComponent();
            pre = new Bus_Prescription(); 
            pd = new Bus_PrescriptionDetail();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (IdBs != null)
            {
                ChiTietPhieuKham f = new ChiTietPhieuKham();
                f.IdBs = IdBs;
                f.IdBn = IdBn;
                f.tenBn = tenBn;
                this.Hide();
                f.ShowDialog();
            }else
            {
                ThanhToan f = new ThanhToan();
                this.Hide();
                f.ShowDialog();
            }    
        }

        private void ChiTietToaThuoc_Load(object sender, EventArgs e)
        {
            lbTen.Text = tenBn;
            lbId.Text = IdBn;
            HienThi();
        }
        private void HienThi()
        {
            dtToa = new DataTable();
            dtToa.Columns.Add("Mã");
            dtToa.Columns.Add("Tên thuốc");
            dtToa.Columns.Add("Số lượng");
            dtToa.Columns.Add("Đơn vị");
            dtToa.Columns.Add("Giá tiền");
            dtToa.Columns.Add("Tổng tiền");
            dtgToa.DataSource = dtToa;
            dtgToa.Columns[0].Width = (int)(dtgToa.Width * 0.1);
            dtgToa.Columns[1].Width = (int)(dtgToa.Width * 0.4);
            dtgToa.Columns[2].Width = (int)(dtgToa.Width * 0.1);
            dtgToa.Columns[3].Width = (int)(dtgToa.Width * 0.2);
            dtgToa.Columns[3].Width = (int)(dtgToa.Width * 0.2);
            dtgToa.Columns[3].Width = (int)(dtgToa.Width * 0.2);
            Prescription p =  pre.LayPre(int.Parse(idPhieu));
                lbTenToa.Text = p.Name;
            lbTienKham.Text = tienKham; 
                foreach (PrescriptionDetails i in pd.LayPrescriptionDetails(p.Id))
                {
                    DataRow s = dtToa.NewRow();
                    s[0] = i.Medicine.Id;
                    s[1] = i.Medicine.Name;
                    s[2] = i.Quantity;
                    s[3] = i.Medicine.Unit;
                    s[4] = i.Medicine.Price;
                    s[5] = i.Medicine.Price * i.Quantity;
                    dtToa.Rows.Add(s);
                }
        }
    }
}
