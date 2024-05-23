using RazorPortfolio.Pages;
using System.Reflection;
using System.Text;

namespace RazorPortfolio.Utils
{
    public static class Render
    {
        public static string RenderTechnologies(Project project)
        {
            if (project.TechStack == null || project.TechStack != null && project.TechStack.Length < 0)
                return string.Empty;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("<h3 class=\"header-technologies\">Technologies&Frameworks used:</h3>");
            stringBuilder.Append("<div class=\"technology-container\">");

            for (int t = 0; t < project.TechStack!.Length; t++)
            {
                stringBuilder.Append(Database.TechnologiesDictionary[project.TechStack[t]]);
            }

            stringBuilder.Append("</div></br>");
            return stringBuilder.ToString();
        }
    }
}
