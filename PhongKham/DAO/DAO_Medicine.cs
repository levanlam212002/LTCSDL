using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.Models;
using PhongKham.View;

namespace PhongKham.DAO
{
    public class DAO_Medicine
    {
        hospitalDbContext db;
        public DAO_Medicine()
        {
            db = new hospitalDbContext();
        }
        public dynamic LayDLMedicine()
        {
            var ds = db.Medicines.Select(s =>
            new {
                s.Id,
                s.Name
            }).ToList();
            return ds;
        }
        public Medicine LayDLMedicineById(int id)
        {
            Medicine ds = db.Medicines.Where(s => s.Id == id).FirstOrDefault();
            return ds;
        }
        public dynamic layDS()
        {
            var ds = db.Medicines.Select(t => new
            {
                t.Id,
                t.Name,
                t.Unit,
                t.AddedDate,
                t.Expiry,
                t.Price
            }).ToList();
            return ds;
        }
        public void ThemThuoc(Medicine t)
        {
            db.Medicines.Add(t);
            db.SaveChanges();

        }
        public bool kiemTra(Medicine t)
        {
            Medicine th = db.Medicines.Find(t.Id);
            if (t != null)
            {

                return true;
            }
            else
                return false;
        }
        public void Sua(Medicine t)
        {
            Medicine th = db.Medicines.Find(t.Id);
            th.Name = t.Name;
            th.Unit = t.Unit;
            th.Price = t.Price;
            th.Expiry = t.Expiry;
            th.AddedDate = t.AddedDate;
            db.SaveChanges();
        }
        public void Xoa(Medicine t)
        {
            Medicine th = db.Medicines.Find(t.Id);
            db.Medicines.Remove(th);
            db.SaveChanges();
        }
        public void themThuoc(Medicine t)
        {
            db.Medicines.Add(t);
            db.SaveChanges();
        }
    }
}
