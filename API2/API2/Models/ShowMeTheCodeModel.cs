namespace API2.Models
{
    public class ShowMeTheCodeModel
    {
        private readonly SettingsModel settings = new();

        public string RetornaUrlGitHub()
        {
            return settings.UrlGitHub;
        }
    }
}
