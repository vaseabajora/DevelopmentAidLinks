﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkExtractor.Models
{
    public class Tender
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Url { get; set; }
        public int EmployeeWorkshiftId { get; set; }
        public EmployeeWorkshift EmployeeWorkshift  { get; set; }

    }
}
