using System;
using System.ComponentModel.DataAnnotations;

namespace TestSolution.Model
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name= "Customer Name")]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(15)]
        [Display(Name = "Contact No.")]
        public string ContactNo { get; set; }

    }
}
