using System.Threading.Tasks;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("test")]
    public class TestController : Controller
    {
        private readonly BarService barService;
        private readonly FunctionalService functionalService;

        public TestController(BarService barService, FunctionalService functionalService)
        {
            this.barService = barService;
            this.functionalService = functionalService;
        }
        
        [HttpGet]
        public async Task<string> LoadSomeData()
        {
            return await barService.LoadSomeData();
        }

        [HttpGet("add")]
        public int Add()
        {
            return functionalService.AddSomeNumbers(15, 20);
        }
    }
}