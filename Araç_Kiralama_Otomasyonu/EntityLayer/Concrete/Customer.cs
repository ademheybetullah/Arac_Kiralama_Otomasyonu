using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Surname { get; set; }
        [StringLength(200, MinimumLength = 2)]
        [Required]
        public string Password { get; set; }
        [StringLength(200, MinimumLength = 2)]
        [Required]
        public string Salt { get; set; }
        [StringLength(10, MinimumLength = 10)]
        [Required]
        public string PhoneNo { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string Email { get; set; }
        [StringLength(500, MinimumLength = 2)]
        [Required]
        public string Address { get; set; }
        public List<Renting> Rentings { get; set; }
        public List<Reservation> Reservations { get; set; }

    }
}
