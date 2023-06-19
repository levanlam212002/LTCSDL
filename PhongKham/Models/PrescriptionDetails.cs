using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitals.Models
{
    public class PrescriptionDetails
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        [Required]
        public int PrescriptionId { get; set; }
        public virtual Prescription Prescription { get; set; }
        [Required]
        public int MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }
    }
}
