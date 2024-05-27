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
    }
}
