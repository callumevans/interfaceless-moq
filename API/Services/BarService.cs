using System.Threading.Tasks;

namespace API.Services
{
    public class BarService
    {
        private readonly FooService fooService;

        public BarService(FooService fooService)
        {
            this.fooService = fooService;
        }
        
        public Task<string> LoadSomeData()
        {
            return fooService.AsyncIo();
        }
    }
}