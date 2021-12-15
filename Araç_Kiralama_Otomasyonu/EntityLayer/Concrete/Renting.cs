using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Renting
    {
        [Key]
        public int RentingId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }
        [Required]
        public Decimal FirstKm { get; set; }
        [Required]
        public Decimal LastKm { get; set; }
        [Required]
        public decimal Payment { get; set; }
        [Required]
        public int Score { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required]
        public int UserId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }
    }
}
