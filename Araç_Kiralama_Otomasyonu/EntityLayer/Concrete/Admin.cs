using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [StringLength(50, MinimumLength = 4)]
        [Required]
        public string Email { get; set; }
        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string Password { get; set; }
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Surname { get; set; }
    }
}
