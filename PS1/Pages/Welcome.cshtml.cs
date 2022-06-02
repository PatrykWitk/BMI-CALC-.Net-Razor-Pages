using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMI_CALC.Pages
{
    public class WelcomeModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string firstName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string em { get; set; }

        [BindProperty(SupportsGet = true)]
        public int yo { get; set; }

        [BindProperty(SupportsGet = true)]
        public float height { get; set; }

        [BindProperty(SupportsGet = true)]
        public string sex { get; set; }

        [BindProperty(SupportsGet = true)]
        public float weigh { get; set; }

        [BindProperty(SupportsGet = true)]
        public string unit { get; set; }

        public void OnGet()
        {
        }        
    }
}
