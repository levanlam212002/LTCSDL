﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitals.Models
{
    public class ExaminationCard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Diagnostic { get; set; }
        [Required]
        public string Forecast { get; set; }
        [Required]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        [Required]
        public int DoctorId { get; set; }
        [Required]
        public float ExaminationFee { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}
