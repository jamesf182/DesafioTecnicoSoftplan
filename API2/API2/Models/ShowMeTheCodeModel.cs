namespace API2.Models
{
    public class ShowMeTheCodeModel
    {
        private readonly SettingsModel settings = new();

        /// <summary>
        /// Retorna o diretório do projeto no GitHub
        /// </summary>
        /// <returns>Retorna o diretório do projeto no GitHub</returns>
        public string RetornaUrlGitHub()
        {
            return settings.UrlGitHub;
        }
    }
}
