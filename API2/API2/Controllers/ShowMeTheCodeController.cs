using API2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        private SettingsModel settings;

        /// <summary>
        /// Retorna a url onde encontra-se o código fonte do projeto no GitHub
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetUrlGitHub()
        {
            settings = new SettingsModel();

            return settings.UrlGitHub;
        }
    }
}
