using System.Threading.Tasks;

namespace API.Services
{
    public class FooService
    {
        public async Task<string> AsyncIo()
        {
            await Task.Delay(1200);
            
            return "Let's just pretend I was loaded from a database or something";
        }
    }
}