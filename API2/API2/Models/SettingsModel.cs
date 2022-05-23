namespace API2.Models
{
    public class SettingsModel
    {
        public string UrlAPI1 { get; set; }
        public string UrlGitHub { get; set; }

        public SettingsModel()
        {
            WebApplicationBuilder? builder = WebApplication.CreateBuilder();
            WebApplication? app = builder.Build();

            UrlAPI1 = app.Configuration.GetValue<string>("UrlAPI1");
            UrlGitHub = app.Configuration.GetValue<string>("UrlGitHub");
        }
    }
}
