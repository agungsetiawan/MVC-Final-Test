using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcFinalTest.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }


        [DisplayName("First Name")]
        [Required(ErrorMessage="Firstname is mandaroty")]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Alphabet only")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is mandaroty")]
        [DisplayName("Last Name")]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Alphabet only")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is mandaroty")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            ErrorMessage="Email must be valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Addres is mandaroty")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Branch Id is mandaroty")]
        [DisplayName("Branch")]
        public int BranchId { get; set; }

        [Required(ErrorMessage = "Job Type Id is mandaroty")]
        [DisplayName("Job Type")]
        public int JobTypeId { get; set; }

        [Required(ErrorMessage = "Branch is mandaroty")]
        public string Branch { get; set; }

        [Required(ErrorMessage = "Jobtype is mandaroty")]
        public string JobType { get; set; }
    }
}