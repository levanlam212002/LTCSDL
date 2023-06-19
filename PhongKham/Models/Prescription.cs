using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitals.Models
{
    public class Prescription
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int ExaminationCardId { get; set; }
        public virtual ExaminationCard ExaminationCard { get; set; }

    }
}
