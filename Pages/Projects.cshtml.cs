using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static RazorPortfolio.Database;

namespace RazorPortfolio.Pages
{
   
    public class ProjectsModel : PageModel
    {
        [BindProperty]
        public List<Project> Projects { get; set; } = Database.Projects;

    }
}
