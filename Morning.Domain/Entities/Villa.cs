using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning.Domain.Entities
{
    public class Villa
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }
        [Display(Name = "Price per night")]
        [Range(10, 1000,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public double? Price { get; set; }
        public int Sqft { get; set; }
        [Range(1, 10,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Occupancy { get; set; }
        [Display(Name ="Image Url")]
        public string? ImageUrl {  get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
