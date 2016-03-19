using Microsoft.AspNet.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "+91-XXX-YYY-ZZZZ";
        }

        public string Country()
        {
            return "India";
        }
    }
}