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
using PhongKham.View;

namespace BTL
{
    public partial class DangKy : Form
    {
        Bus_Patient bus_Patient;
        private int id;
        public DangKy()
        {
            InitializeComponent();
            bus_Patient = new Bus_Patient();    
        }

    

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Name = txtName.Text;
            if (rdNam.Checked)
                p.Male = true;
            else
                p.Male = false;
            p.Birthday = dtBirthday.Value;
            p.email = txtEmail.Text;
            p.cccd = float.Parse(txtCccd.Text);
            p.address = txtAddress.Text;
            p.phoneNumber = txtSdt.Text;
            bus_Patient.ThemBenhNhan(p);
            Reload();
            HienThiDLLenDG();
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
            DGVBenhNhan.Columns[7].Width = (int)(DGVBenhNhan.Width * 0.2);
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            HienThiDLLenDG();
        }

        private void thanhToánHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan();
            this.Hide();
            tt.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Id = id;
            p.Name = txtName.Text;
            p.email = txtEmail.Text;
            p.address = txtAddress.Text;
            p.cccd = float.Parse(txtCccd.Text);
            p.phoneNumber = txtSdt.Text;
            p.Birthday = dtBirthday.Value;
            if (rdNam.Checked)
                p.Male = true;
            else
                p.Male = false;
            bus_Patient.SuaBenhNhan(p);
            MessageBox.Show("Sửa thành công");
            Reload();
            HienThiDLLenDG();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bus_Patient.XoaBenhNhan(id);
            MessageBox.Show("Xóa thành công!");
            Reload();
            HienThiDLLenDG();
        }

        private void Chon(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Int32.Parse(DGVBenhNhan.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = DGVBenhNhan.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (bool.Parse(DGVBenhNhan.Rows[e.RowIndex].Cells[2].Value.ToString()))
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                dtBirthday.Value = DateTime.Parse(DGVBenhNhan.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtEmail.Text = DGVBenhNhan.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCccd.Text = DGVBenhNhan.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSdt.Text = DGVBenhNhan.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtAddress.Text = DGVBenhNhan.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
        }
        private void Reload()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtCccd.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
            dtBirthday.Value = DateTime.Now;
            rdNam.Checked = false;
            rdNu.Checked = false;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
