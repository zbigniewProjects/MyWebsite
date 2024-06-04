using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPortfolio.Pages.Projects
{
    public class twitterModel : PageModel
    {
        [BindProperty]
        public Database.Project Project { get; set; } = Database.Projects[0];
    }
}
