using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospitals.Models;

namespace PhongKham.DAO
{
    public class DAO_ExaminationCard
    {
        hospitalDbContext db;
        public DAO_ExaminationCard()
        {
            db = new hospitalDbContext();
        }
        public void ThemPhieu(ExaminationCard p)
        {
            db.ExaminationCards.Add(p);
            db.SaveChanges();
        }
        public int KiemPhieuVuaTao()
        {
            List<ExaminationCard> e = db.ExaminationCards.ToList();
            int i = e.Count;
            return e[i - 1].Id;
        }
        public List<ExaminationCard> LayCard(int id)
        {
           List<ExaminationCard> c = db.ExaminationCards.Where(s => s.PatientId == id).ToList();
           return c;
        }
        public ExaminationCard LayCardById(int id)
        {
            return db.ExaminationCards.Where(s => s.Id == id).FirstOrDefault();
            
        }
    }
}
