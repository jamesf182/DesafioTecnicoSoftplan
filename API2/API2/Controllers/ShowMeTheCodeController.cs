using API2.Models;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly ShowMeTheCodeModel _showMeTheCodeModel = new();

        /// <summary>
        /// Retorna a url onde encontra-se o código fonte do projeto no GitHub
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetUrlGitHub()
        {
            return _showMeTheCodeModel.RetornaUrlGitHub();
        }
    }
}
