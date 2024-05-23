using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPortfolio.Pages.Projects
{
    public class dncommunicatorModel : PageModel
    {
        [BindProperty]
        public Project Project { get; set; } = Database.Projects[1];
        public void OnGet()
        {
        }
    }
}
