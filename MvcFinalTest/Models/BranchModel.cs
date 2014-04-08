using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcFinalTest.Models
{    
    public class BranchModel
    {
        [Required(ErrorMessage="Id is mandatory")]
        public int BranchId { get; set; }

        [StringLength(50, ErrorMessage = "Name cannot more than 50 characters")]
        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is mandatory")]
        [StringLength(100,ErrorMessage="Address cannot more than 100 characters")]
        public string Address { get; set; }

        [DisplayName("Zip Code")]
        [Required(ErrorMessage="Zip Code is mandatory")]
        [Range(10000, 99999, ErrorMessage = "Please enter valid Number and length must be 5 characters long")]
        public string ZipCode { get; set; }
    }
}