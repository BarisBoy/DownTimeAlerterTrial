using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DowntimeAlert.Schedule.Web.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public ActionResult<object> Index()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetName().Version.ToString();
            var buildDate = System.IO.File.GetCreationTime(Assembly.GetExecutingAssembly().Location);

            return new
            {
                Service = "Hangfire Callback Service",
                Version = version,
                BuildDate = buildDate
            };
        }
    }
}
