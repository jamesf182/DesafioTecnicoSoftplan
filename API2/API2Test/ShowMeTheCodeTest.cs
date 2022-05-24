using API2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API2Test
{
    public class ShowMeTheCodeTest
    {
        private ShowMeTheCodeController? _showMeTheCodeController;

        [Fact]
        public void ShowMeTheCode_QuandoChamado_RetornaString()
        {
            _showMeTheCodeController = new ShowMeTheCodeController();
                        
            // Act            
            string urlGitHub = _showMeTheCodeController.GetUrlGitHub();

            // Assert
            Assert.IsType<string>(urlGitHub);
        }
    }
}
