using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.Models;

namespace PhongKham.DAO
{
    public class DAO_PrescriptionDetail
    {
        hospitalDbContext db;
        public DAO_PrescriptionDetail()
        {
            db = new hospitalDbContext();
        }
        public void ThemPrescriptionDetail(PrescriptionDetails p)
        {
            db.PrescriptionDetails.Add(p);
            db.SaveChanges();
        }
        public List<PrescriptionDetails> LayPrescriptionDetails(int id)
        {
            return db.PrescriptionDetails.Where(p => p.PrescriptionId == id).ToList();
        }
    }
}
