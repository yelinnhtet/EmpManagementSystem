using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public String Frist_Name { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public String Last_Name { get; set; }

     
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_of_Birth { get; set; }
    }
}
