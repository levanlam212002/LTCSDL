using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospitals.DAO;
using hospitals.Models;

namespace hospitals.Bus
{
    public class Bus_Patient
    {
        DAO_Patient Patient;
        public Bus_Patient()
        {
            Patient = new DAO_Patient();
        }
        public void ThemBenhNhan(Patient p)
        {
            try
            {
                Patient.ThemBenhNhan(p);
                MessageBox.Show("Đăng ký thành công!");
            }
            catch (Exception)
            {

                MessageBox.Show("Them That Bai");
            }
        }
        public void SuaBenhNhan(Patient p)
        {
            Patient.SuaBenhNhan(p);
        }
        public void XoaBenhNhan(int id)
        {
            Patient.XoaBenhNhan(id);
        }
        public void HienThiDSPatientLenDGV(DataGridView dgv)
        {
            dgv.DataSource = Patient.LayDLPatient();
        }
    }
}
