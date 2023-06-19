using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.Models;

namespace PhongKham.DAO
{
    public class DAO_Prescription
    {
        hospitalDbContext db;
        public DAO_Prescription()
        {
            db = new hospitalDbContext();
        }
        public void ThemPrescription(Prescription p)
        {
            db.Prescriptions.Add(p);
            db.SaveChanges();
        }
        public int KiemPhieuPreVuaTao()
        {
            List<Prescription> e = db.Prescriptions.ToList();
            int i = e.Count;
            return e[i - 1].Id;
        }

        public Prescription LayPrescription(int id)
        {
            Prescription p = db.Prescriptions.Where(s => s.ExaminationCardId == id).FirstOrDefault();
            return p;
        }
    }
}
