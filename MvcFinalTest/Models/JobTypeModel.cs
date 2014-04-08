using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFinalTest.Models
{
    public class JobTypeModel
    {
        
        public int JobTypeId { get; set; }

        [Required(ErrorMessage="Name is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        public decimal RatePerHour { get; set; }
    }
}