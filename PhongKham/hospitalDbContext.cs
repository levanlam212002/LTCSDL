using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace hospitals.Models
{
    public class hospitalDbContext :DbContext
    {
        public hospitalDbContext(): base("name=strConnection") {}
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<ExaminationCard> ExaminationCards { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<PrescriptionDetails> PrescriptionDetails { get; set; }


    }
}
