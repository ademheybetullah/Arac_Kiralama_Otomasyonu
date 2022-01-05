using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string City { get; set; }
        [StringLength(500, MinimumLength = 2)]
        [Required]
        public string Address { get; set; }
        [Required]
        public int CarCount { get; set; }
        public Decimal CompanyScore { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Car> Cars { get; set; }
        public List<Renting> Rentings { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
