using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPortfolio.Pages.Projects
{
    public class dnuploaderModel : PageModel
    {
        [BindProperty]
        public Database.Project Project { get; set; } = Database.Projects[2];
        public void OnGet()
        {
        }
    }
}
