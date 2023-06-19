using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.Models;
using PhongKham.Bus;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhongKham.DAO
{
    public class DAO_Bill
    {
        hospitalDbContext db;
        public DAO_Bill()
        {
            db = new hospitalDbContext();
        }
        public dynamic LayDLBill()
        {
            var ds = db.Bills.Select(s =>
            new
            {
                s.Id,
                s.Total,
                s.ExaminationCardId,
                s.Status
            }).Where(o => o.Status == false).ToList();
            return ds;
        }
        public List<Bill> LayBill(int id)
        {
            return db.Bills.Where(o => o.ExaminationCard.PatientId == id).ToList();
        }
        public List<Bill> LayBills(int Nam, int s1, int s2, int s3)
        {
            return db.Bills.Where(t => t.PayDate.Year == Nam && (t.PayDate.Month == s1 || t.PayDate.Month == s2 || t.PayDate.Month == s3)).ToList();
        }
        public void ThanhToan(int id, DateTime d)
        {
            List<Bill> bills = db.Bills.ToList();
            Bill b = bills.Find(o => o.Id == id);
            b.Status = true;
            b.PayDate = d;
            db.SaveChanges();
        }
        public void ThemBill(Bill b)
        {
            db.Bills.Add(b);
            db.SaveChanges();
        }
    }
}
