using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace dynform.Controllers
{
    [Route("api/[controller]")]
    [Produces("text/plain")]
    [ApiController]
    public class ValuesController : Controller
    {
        // GET api/values/config1
        [HttpGet("config1")]
        public ActionResult<string> DajConfig1()
        {
            var file = System.IO.File.ReadAllText("./tabulka.json");
            return file;
        }

        // GET api/values/config2
        [HttpGet("config2")]
        public ActionResult<string> DajConfig2()
        {
            var file = System.IO.File.ReadAllText("./formular.json");
            return file;
        }

        // GET api/values/data
        [HttpGet("data")]
        public ActionResult<string> DajData()
        {
            return "[[{\"id\":\"meno\",\"hodnota\":\"Jaro\"},{\"id\":\"priezvisko\",\"hodnota\":\"Juriasdf\"}]]";
        }
    }
}
