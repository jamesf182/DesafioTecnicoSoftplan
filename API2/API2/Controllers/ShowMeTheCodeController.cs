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
        /// Show me the code
        /// </summary>
        /// <returns>Retorna a url onde encontra-se o código fonte no GitHub</returns>
        [HttpGet]
        public string GetUrlGitHub()
        {
            settings = new SettingsModel();

            return settings.UrlGitHub;
        }
    }
}
