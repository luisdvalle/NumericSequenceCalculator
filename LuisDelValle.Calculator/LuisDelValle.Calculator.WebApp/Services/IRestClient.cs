using LuisDelValle.Calculator.Abstractions;
using System.Threading.Tasks;

namespace LuisDelValle.Calculator.WebApp.Services
{
    public interface IRestClient
    {
        string Host { get; set; }
        string Path { get; set; }

        Task<Response> GetResponseAsync();
    }
}
