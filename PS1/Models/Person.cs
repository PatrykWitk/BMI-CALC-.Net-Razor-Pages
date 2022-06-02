using System.ComponentModel.DataAnnotations;

namespace BMI_CALC.Models
{
    public class Person
    {
        [Display(Name = "Imie:")]
        [StringLength(15, ErrorMessage = "Zbyt dlugie.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Zle znaki.")]
        [Required(ErrorMessage = "Pole obowiazkowe")]
        public string FirstName { get; set; }

        [Display(Name = "Wiek:")]
        [Range(1, 120)]
        public int yo { get; set; }

        [Display(Name = "Wzrost:")]

        [Required(ErrorMessage = "Pole obowiazkowe.")]
        public float height { get; set; } 

        [Display(Name = "Waga:")]
        [Required(ErrorMessage = "Pole obowiazkowe.")]
        public float weigh { get; set; } 

        [Display(Name = "Miara:")]
        [Required(ErrorMessage = "Pole obowiazkowe")]
        public string unit { get; set; }

  
    }

}
