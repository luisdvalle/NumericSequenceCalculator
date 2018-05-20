using System.Threading.Tasks;
using LuisDelValle.Calculator.CalculatorService.Models;
using LuisDelValle.Calculator.WebApp.Services;
using LuisDelValle.Calculator.WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuisDelValle.Calculator.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IRestClient _restClient;

        public HomeController(IRestClient restClient)
        {
            _restClient = restClient;
            _restClient.Host = "http://localhost:5001/";
            _restClient.Path = "api/sequences?number=";
        }

        [HttpGet]
        public IActionResult Index()
        {
            SequencesViewModel vm = new SequencesViewModel();

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Index(SequencesViewModel vm)
        {
            if (vm.InputNumber < 1)
            {
                ModelState.AddModelError("", "Input number can't be less than 1");

                return View(vm);
            }

            if (ModelState.IsValid)
            {
                _restClient.Path = _restClient.Path + vm.InputNumber;
                SequencesResponse sequences = await _restClient.GetResponseAsync() as SequencesResponse;

                vm.Sequences = sequences;
            }

            return View(vm);
        }
    }
}
