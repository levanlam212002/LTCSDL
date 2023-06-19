using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public void SuaBenhNhan(Patient p)
        {
            Patient patient = kiemBenhNhan(p.Id);
            patient.Name = p.Name;
            patient.Birthday = p.Birthday;
            patient.phoneNumber = p.phoneNumber;
            patient.email = p.email;
            patient.cccd = p.cccd;
            patient.address = p.address;
            patient.Male = p.Male;
            db.SaveChanges();
        }
        public void XoaBenhNhan(int id)
        {
            db.Patients.Remove(db.Patients.Find(id));
            db.SaveChanges();
        }
        public Patient kiemBenhNhan(int id)
        {
            return db.Patients.Find(id);
        }
        public dynamic LayDLPatient()
        {
            var ds = db.Patients.Select(s =>
            new {
               s.Id,
               s.Name,
               s.Male,
               s.cccd,
               s.Birthday,
               s.email,
               s.address,
               s.phoneNumber
            }).ToList();
            return ds;
        }
      
    }
}
