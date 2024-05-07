using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPortfolio.Pages
{
    public class ProjectsModel : PageModel
    {
        [BindProperty]
        public List<Project> Projects { get; set; } = new List<Project>();

        public ProjectsModel() 
        {
            Projects.Add(new Project
            {
                Name = "EasyCommunicator",
                ImageUrl = "img/preview_easycom.png",
                Description = "EasyCommunicator is client-server communication app that utilizes tcp protocol to " +
                "enable http-like communication but in both ways. Server can issue request to client and vice versa.",
                PageUrl = "/projects/easycommunicator"
            });
            Projects.Add(new Project
            {
                Name = "EasyUploader",
                ImageUrl = "img/preview_easyUploader.png",
                Description = "EasyUploader is application that automates process of deploying server build of Unity3D game to dedicated server. It allows " +
                "user to build game and upload it to server in one click, and run it with specified launch comands in second.",
                PageUrl = "/projects/easyuploader"

            });
        }
    }

    public struct Project 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string PageUrl { get; set; }
    }
}
