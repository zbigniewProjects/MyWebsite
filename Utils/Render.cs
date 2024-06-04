using RazorPortfolio.Pages;
using System.Reflection;
using System.Text;

namespace RazorPortfolio.Utils
{
    public static class Render
    {
        public static string RenderTechnologies(Technologies[] techStack, bool renderDefaultHeader = true)
        {
            if (techStack == null || techStack != null && techStack.Length < 0)
                return string.Empty;

            StringBuilder stringBuilder = new StringBuilder();

            if(renderDefaultHeader)
                stringBuilder.Append("<h3 class=\"header-technologies\">Technologies&Frameworks used:</h3>");

            stringBuilder.Append("<div class=\"technology-container\">");

            for (int t = 0; t < techStack!.Length; t++)
            {
                stringBuilder.Append(Database.TechnologiesDictionary[techStack[t]]);
            }

            stringBuilder.Append("</div></br>");
            return stringBuilder.ToString();
        }

        public static string RenderProjectsTypesStack(ProjectType[] projectTypes) 
        {
            if (projectTypes.Length == 1) 
            {
                return $"<div class=\"projectTypeHeader\">{Database.ProjectTypes[projectTypes[0]]}</div>";
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < projectTypes.Length; i++)
            {
                stringBuilder.Append($"<div class=\"projectTypeHeader\">{Database.ProjectTypes[projectTypes[i]]}</div>");

                if ((i+1) < projectTypes.Length)
                    stringBuilder.Append(" + ");
            }

            return stringBuilder.ToString();
        }
    }
}
