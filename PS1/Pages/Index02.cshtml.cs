using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BMI_CALC.Models;

namespace BMI_CALC
{
    public class Index02Model : PageModel
    {
        [BindProperty]
        public Person person { get; set; }

        public IActionResult OnPost(Person person)
        {

                return RedirectToPage("Welcome", person);
        }

    }
}