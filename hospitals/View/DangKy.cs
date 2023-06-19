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

namespace BTL
{
    public partial class DangKy : Form
    {
        Bus_Patient bus_Patient;
        public DangKy()
        {
            InitializeComponent();
            bus_Patient = new Bus_Patient();    
        }

    

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Name = txtName.Text;
            if (cbNam.Checked)
                p.Sex = true;
            else
                p.Sex = false;
            p.Birthday = dtBirthday.Value;
            p.email = txtEmail.Text;
            p.cccd = float.Parse(txtCccd.Text);
            p.phoneNumber = txtSdt.Text;
            bus_Patient.ThemBenhNhan(p);
        }
    }
}
