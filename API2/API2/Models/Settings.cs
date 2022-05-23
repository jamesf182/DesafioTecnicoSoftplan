namespace API2.Models
{
    public class Settings
    {
        public string UrlAPI1 { get; set; }

        public Settings()
        {
            WebApplicationBuilder? builder = WebApplication.CreateBuilder();
            WebApplication? app = builder.Build();

            UrlAPI1 = app.Configuration.GetValue<string>("UrlAPI1");
        }
    }
}
