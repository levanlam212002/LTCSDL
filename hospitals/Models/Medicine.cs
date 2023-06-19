using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitals.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Unit { get; set; }
        public float Price { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime Expiry { get; set; }
    }
}
