using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL;
using hospitals.Models;
using PhongKham.Bus;

namespace PhongKham.View
{
    public partial class Admin : Form
    {
        Bus_Doctor admin_bus;
       
        public Admin()
        {
            InitializeComponent();
            admin_bus = new Bus_Doctor();
        }
        void hienDS()
        {
            dgvAdmin.DataSource = null;
            admin_bus.hienDS(dgvAdmin);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dgvAdmin.Columns[0].Width = (int)(dgvAdmin.Width * 0.05);
            dgvAdmin.Columns[1].Width = (int)(dgvAdmin.Width * 0.3);
            dgvAdmin.Columns[2].Width = (int)(dgvAdmin.Width * 0.15);
            dgvAdmin.Columns[3].Width = (int)(dgvAdmin.Width * 0.2);
            dgvAdmin.Columns[4].Width = (int)(dgvAdmin.Width * 0.1);
            dgvAdmin.Columns[5].Width = (int)(dgvAdmin.Width * 0.1);
            dgvAdmin.Columns[6].Width = (int)(dgvAdmin.Width * 0.1);
            hienDS();
            txtId.Enabled = false;
        }

        private void dtgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAdmin.Rows.Count)
            {
                txtId.Enabled = false;
                txtId.Text = dgvAdmin.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvAdmin.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtChucVu.Text = dgvAdmin.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtChuyenNganh.Text = dgvAdmin.Rows[e.RowIndex].Cells[3].Value.ToString();
                Birthday.Value = DateTime.Parse(dgvAdmin.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtUserName.Text = dgvAdmin.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPassWord.Text = dgvAdmin.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            Doctor d = new Doctor();
            d.Name = txtName.Text;
            d.position = txtChucVu.Text;
            d.userName = txtUserName.Text;
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtPassWord.Text);
            byte[] has = new MD5CryptoServiceProvider().ComputeHash(temp);
            string pass = has.ToString();
            d.password = pass;
            d.specialize = txtChuyenNganh.Text;
            d.Birthday = DateTime.Parse(Birthday.Value.ToString());
            if (admin_bus.themNV(d))
            {
                MessageBox.Show("Thêm thành công!");
                admin_bus.hienDS(dgvAdmin);
                Reload();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Id = int.Parse(txtId.Text);

            if (admin_bus.xoaNV(d))
            {
                MessageBox.Show("Xóa thành công!");
                admin_bus.hienDS(dgvAdmin);
                Reload();
            }
            else
            {
                MessageBox.Show("Delete Fail");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Id = int.Parse(txtId.Text);
            d.Name = txtName.Text;
            d.position = txtChucVu.Text;
            d.userName = txtUserName.Text;
            d.password = txtPassWord.Text;
            d.specialize = txtChuyenNganh.Text;
            d.Birthday = DateTime.Parse(Birthday.Value.ToString());
            if (admin_bus.suaNV(d))
            {
                MessageBox.Show("Sửa thành công!");
                admin_bus.hienDS(dgvAdmin);
                Reload();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void menuThemThuoc_Click(object sender, EventArgs e)
        {
            //Drug t = new Drug();
            //this.Hide();
            //t.ShowDialog();
        }

        private void Admin_Load_1(object sender, EventArgs e)
        {
            hienDS();
            txtId.Enabled = false;
        }

        private void menuSigout_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
        }

        private void menuThemThuoc_Click_1(object sender, EventArgs e)
        {
            Thuoc f = new Thuoc();
            this.Hide();
            f.ShowDialog();
        }
        private void Reload()
        {
            txtChucVu.Text = "";
            txtChuyenNganh.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            txtPassWord.Text = "";
            txtUserName.Text = "";
            Birthday.Value = DateTime.Now;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void menuReport_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            this.Hide();
            f.ShowDialog();
        }
    }
}
