using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.Models;
using PhongKham.DAO;
using System.Windows.Forms;

namespace PhongKham.Bus
{
    public class Bus_Prescription
    {
        DAO_Prescription pre ;
        public Bus_Prescription()
        {
           pre = new DAO_Prescription();
        }
        public void ThemExaminationCard(Prescription p)
        {
            try
            {
                pre.ThemPrescription(p);
            }
            catch (Exception)
            {

                MessageBox.Show("That Bai");
            }
        }
        public int KiemPreVuaTao()
        {
            return pre.KiemPhieuPreVuaTao();
        }
        public Prescription LayPre(int id)
        {
            return pre.LayPrescription(id);
        }
    }
}
