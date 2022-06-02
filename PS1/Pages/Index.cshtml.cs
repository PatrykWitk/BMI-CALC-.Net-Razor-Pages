using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BMI_CALC.Models;

namespace BMI_CALC
{
    public class IndexModel : PageModel
    {

        public IActionResult OnPost()
        {
                return RedirectToPage("Index02");
        }

    }
}