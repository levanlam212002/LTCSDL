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
    public class Bus_PrescriptionDetail
    {
        DAO_PrescriptionDetail pred;
        public Bus_PrescriptionDetail()
        {
            pred = new DAO_PrescriptionDetail();
        }
        public void ThemPrescriptionDetails(PrescriptionDetails p)
        {
            try
            {
                pred.ThemPrescriptionDetail(p);
            }
            catch (Exception)
            {

                MessageBox.Show("That Bai");
            }
        }
        public List<PrescriptionDetails> LayPrescriptionDetails(int id)
        {
            return pred.LayPrescriptionDetails(id);
        }

    }
}
