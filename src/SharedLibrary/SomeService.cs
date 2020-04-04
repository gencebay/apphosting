using System.Threading.Tasks;

namespace SharedLibrary
{
    public class SomeService
    {
        public Task InvokeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
