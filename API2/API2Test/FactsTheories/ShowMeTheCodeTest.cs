using API2.Controllers;
using API2.Models;

namespace API2Test.Tests
{
    public class ShowMeTheCodeTest
    {
        private readonly ShowMeTheCodeModel _showMeTheCodeModel = new();

        [Fact]
        public void ShowMeTheCode_QuandoChamado_RetornaString()
        {
            // Act            
            string urlGitHub = _showMeTheCodeModel.RetornaUrlGitHub();

            // Assert
            Assert.IsType<string>(urlGitHub);
        }
    }
}
