using Microsoft.AspNetCore.Mvc;

namespace Plantvana.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "01090 003 030";
        }
        public string Address()
        {
            return "UK";
        }
    }
}