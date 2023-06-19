using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitals.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        [Required]
        public string specialize { get; set; }
        [Required]
        public string position { get; set; }
    }
}
