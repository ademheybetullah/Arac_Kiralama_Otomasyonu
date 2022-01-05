using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string Surname { get; set; }
        [StringLength(200, MinimumLength = 2)]
        [Required]
        public string Password { get; set; }
        [Required]
        public string Salt { get; set; }
        [StringLength(10, MinimumLength = 10)]
        [Required]
        public string PhoneNo { get; set; }
        public int CompanyId { get; set; }
        [StringLength(500, MinimumLength = 2)]
        [Required]
        public string Address { get; set; }
        [StringLength(10, MinimumLength = 2)]
        [Required]
        public string Status { get; set; }
        [StringLength(50, MinimumLength = 4)]
        [Required]
        public string Email { get; set; }
        public Company Company { get; set; }
    }
}
