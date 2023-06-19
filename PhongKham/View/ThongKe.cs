using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospitals.Models;
using PhongKham.Bus;

namespace PhongKham.View
{
    public partial class ThongKe : Form
    {
        Bus_Bill bill;
        DataTable dt = new DataTable();
        public ThongKe()
        {
            InitializeComponent();
            bill = new Bus_Bill();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            this.Hide();
            f.ShowDialog();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            cbbQuy.Items.Add("Quý 1(Tháng 1-2-3)");
            cbbQuy.Items.Add("Quý 2(Tháng 4-5-6)");
            cbbQuy.Items.Add("Quý 3(Tháng 7-8-9)");
            cbbQuy.Items.Add("Quý 4(Tháng 10-11-12)");
            dt.Columns.Add("Mã");
            dt.Columns.Add("Ngày Thanh Toán");
            dt.Columns.Add("Tổng tiền");
            dtgThongKe.DataSource = dt;
            dtgThongKe.Columns[0].Width = (int)(dtgThongKe.Width * 0.1);
            dtgThongKe.Columns[1].Width = (int)(dtgThongKe.Width * 0.4);
            dtgThongKe.Columns[2].Width = (int)(dtgThongKe.Width * 0.4);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Bill i in bill.LayBill(int.Parse(txtNam.Text), cbbQuy.SelectedIndex))
                {
                    DataRow r = dt.NewRow();
                    r[0] = i.Id;
                    r[1] = i.PayDate;
                    r[2] = i.Total;
                    dt.Rows.Add(r);
                }
                
            }
            catch 
            { 
                MessageBox.Show("Bạn đã nhập sai định dạng năm!");
            }
        }
    }
}
