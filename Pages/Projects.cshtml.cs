using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPortfolio.Pages
{
   
    public class ProjectsModel : PageModel
    {
        [BindProperty]
        public List<Project> Projects { get; set; } = Database.Projects;

    }

    public struct Project 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string PageUrl { get; set; }

        public Technologies[] TechStack { get; set; }
    }
}
