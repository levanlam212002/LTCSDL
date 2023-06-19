using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.Models;

namespace hospitals.DAO
{
    public class DAO_Patient
    {
        hospitalDbContext db;
        public DAO_Patient()
        {
            db = new hospitalDbContext();
        }
        public void ThemBenhNhan(Patient p)
        {
            db.Patients.Add(p);
            db.SaveChanges();
        }
    }
}
