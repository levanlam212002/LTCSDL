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
    public partial class Thuoc : Form
    {
        Bus_Medicine thuoc_bus;
        public Thuoc()
        {
            InitializeComponent();
            thuoc_bus = new Bus_Medicine();
        }

        void hienDS()
        {
            dgvThuoc.DataSource = null;
            thuoc_bus.HienDs(dgvThuoc);
        }
        private void thuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvThuoc.Rows.Count)
            {
                txtId.Enabled = false;
                txtId.Text = dgvThuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvThuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUnit.Text = dgvThuoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                add.Value = DateTime.Parse(dgvThuoc.Rows[e.RowIndex].Cells[3].Value.ToString());
                exp.Value = DateTime.Parse(dgvThuoc.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtPrice.Text = dgvThuoc.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Medicine t = new Medicine();
            t.Id = int.Parse(txtId.Text);
            t.Name = txtName.Text;
            t.Unit = txtUnit.Text;
            t.Expiry = DateTime.Parse(exp.Value.ToString());
            t.AddedDate = DateTime.Parse(add.Value.ToString());
            t.Price = float.Parse(txtPrice.Text.ToString());
            //Goi su kien sua cua Bus
            if (thuoc_bus.SuaThuoc(t))
            {
                MessageBox.Show("Sửa thành công!");
                thuoc_bus.HienDs(dgvThuoc);
                Reload();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Medicine t = new Medicine();
            t.Id = int.Parse(txtId.Text);

            if (thuoc_bus.XoaThuoc(t))
            {
                MessageBox.Show("Xóa Thành Công!");
                thuoc_bus.HienDs(dgvThuoc);
                Reload();
            }
            else
            {
                MessageBox.Show("Delete Fail");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           Medicine t = new Medicine();
            t.Name = txtName.Text;
            t.Unit = txtUnit.Text;
            t.Expiry = DateTime.Parse(exp.Value.ToString());
            t.AddedDate = DateTime.Parse(add.Value.ToString());
            t.Price = float.Parse(txtPrice.Text.ToString());

            if (thuoc_bus.themThuoc(t))
            {
                MessageBox.Show("Thêm Thành Công!");
                thuoc_bus.HienDs(dgvThuoc);
                Reload();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.ShowDialog();
        }

        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            hienDS();
            dgvThuoc.Columns[0].Width = (int)(dgvThuoc.Width * 0.1);
            dgvThuoc.Columns[1].Width = (int)(dgvThuoc.Width * 0.2);
            dgvThuoc.Columns[2].Width = (int)(dgvThuoc.Width * 0.1);
            dgvThuoc.Columns[3].Width = (int)(dgvThuoc.Width * 0.2);
            dgvThuoc.Columns[4].Width = (int)(dgvThuoc.Width * 0.2);
            dgvThuoc.Columns[5].Width = (int)(dgvThuoc.Width * 0.2);
        }
        private void Reload()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtUnit.Text = "";
            add.Value = DateTime.Now;
            exp.Value = DateTime.Now;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
