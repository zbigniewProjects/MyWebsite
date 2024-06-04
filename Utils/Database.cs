using RazorPortfolio.Pages;

namespace RazorPortfolio
{
    public static class Database
    {
        public struct Project
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public string PageUrl { get; set; }

            public ProjectType[] ProjectType { get; set; }
            public Technologies[] TechStack { get; set; }
        }

        public static Dictionary<Technologies, string> TechnologiesDictionary = new Dictionary<Technologies, string>() {
            { Technologies.dotNet, "<div class=\"technology tech-net\">.NET</div>" },
            { Technologies.csharp, "<div class=\"technology tech-net\">C#</div>"},
            { Technologies.aspNet, "<div class=\"technology tech-net\">ASP.Net</div>"},
            { Technologies.aspNetIdentity, "<div class=\"technology tech-MVC\">ASP.Net.Identity</div>"},
            { Technologies.html, "<div class=\"technology tech-html\">HTML</div>"},
            { Technologies.css, "<div class=\"technology tech-css\">CSS</div>"},
            { Technologies.mvc, "<div class=\"technology tech-MVC\">ASP.Net.MVC</div>"},
            { Technologies.entityFramework, "<div class=\"technology tech-ef\">Entity Framework</div>"},
            { Technologies.mediatr, "<div class=\"technology tech-mediatr\">MediatR</div>"},
            { Technologies.postgresql, "<div class=\"technology tech-postgres\">PostgreSQL</div>"},
            { Technologies.mssql, "<div class=\"technology tech-mssql\">MSSQL</div>"},
            { Technologies.javascript, "<div class=\"technology tech-js\">JavaScript</div>"},
            { Technologies.tcpip, "<div class=\"technology tech-tcpip\">TCP/IP</div>"},
            { Technologies.ajax, "<div class=\"technology tech-tcpip\">AJAX</div>"},
            { Technologies.unity3d, "<div class=\"technology tech-unity\">Unity3D</div>"},
        };

        public static Dictionary<ProjectType, string> ProjectTypes = new Dictionary<ProjectType, string>()
        {
            {ProjectType.WebAPI, "ASP.NET Core WebAPI" },
            {ProjectType.MVC, "ASP.NET Core MVC" },
            {ProjectType.UnityClient, "Unity3D client"},
            {ProjectType.ConsoleApplication, "Console application"},
            {ProjectType.ReactFrontend, "React frontend"},
            {ProjectType.UnityGame, "Unity3D game"},
            {ProjectType.ClassLibrary, "Class Library"},
        };

        public static List<Project> Projects { get; internal set; } = new List<Project>() {
             new Project{
                 Name = "Xwitter",
                 ProjectType = [ ProjectType.MVC ],
                 ImageUrl = "img/preview_xwitter.jpg",
                 Description = "In short - Twitter clone web app.<br><br> Users can create account, post posts, and others can comment them. Each post and user have their unique urls" +
                 "<br> You can check out Xwitter <a href=\"https://xwitter.zbigniew.dev\" target=\"_blank\"> here </a>",
                 PageUrl = "/projects/xwitter",
                 TechStack = [
                    Technologies.aspNet,
                    Technologies.csharp,
                    Technologies.mvc,
                    Technologies.aspNetIdentity,
                    Technologies.entityFramework,
                    Technologies.mediatr,
                    Technologies.postgresql,
                    Technologies.html,
                    Technologies.css,
                    Technologies.javascript,
                    Technologies.ajax,
                ]
             },
            new Project
            {
                Name = "EasyCommunicator",
                ProjectType = [ ProjectType.ClassLibrary ],
                ImageUrl = "img/preview_easycom.png",
                Description = "EasyCommunicator is client-server communication app that utilizes tcp protocol to " +
                "enable http-like communication but in both ways. Server can issue request to client and vice versa.",
                PageUrl = "/projects/easycommunicator",
                TechStack = [
                    Technologies.dotNet,
                    Technologies.csharp,
                    Technologies.tcpip
                ]

            },
            new Project
            {
                Name = "EasyUploader",
                ProjectType = [ ProjectType.WebAPI, ProjectType.UnityClient ],
                ImageUrl = "img/preview_easyUploader.png",
                Description = "EasyUploader is application that automates process of deploying server build of Unity3D game to dedicated server. It allows " +
                "user to build game and upload it to server in one click, and run it with specified launch comands in second.",
                PageUrl = "/projects/easyuploader",
                TechStack = [
                    Technologies.csharp,
                    Technologies.unity3d
                ]
            }
        };
    }
    public enum Technologies
    {
        csharp,
        dotNet,
        aspNet,
        aspNetIdentity,
        mvc,
        html,
        css,
        entityFramework,
        mediatr,
        postgresql,
        mssql,
        javascript,
        tcpip,
        ajax,
        unity3d,
        dapper,
    }
    public enum ProjectType 
    {
        ConsoleApplication,
        MVC,
        WebAPI,
        ClassLibrary,
        ReactFrontend,
        UnityClient,
        UnityGame,
    }
}
