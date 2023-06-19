using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitals.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Sex {get; set;}
        public DateTime Birthday { get; set; }
        [Required]
        public string email { get; set; }
        public float cccd { get; set;}
        [Required]
        public string phoneNumber { get; set; }

    }
}
