using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [StringLength(20, MinimumLength = 2)]
        public string Model { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string Brand { get; set; }
        public int CompanyId { get; set; }
        [StringLength(15, MinimumLength = 3)]
        public string Color { get; set; }
        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string FuelType { get; set; }
        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string GearType { get; set; }
        [Required]
        public int MinDrivingLicenseAge { get; set; }
        [Required]
        public int MinAge { get; set; }
        [Required]
        public int Seats { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string CarCategory { get; set; }
        [Required]
        public Decimal InstantKm { get; set; }
        [Required]
        public decimal RentalFee { get; set; }
        [Required]
        public bool RentalStatus { get; set; }
        public virtual Company Company { get; set; }
        public ICollection<Renting> Rentings { get; set; }
    }
}
