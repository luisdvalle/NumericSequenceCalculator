using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuisDelValle.Calculator.CalculatorService.Abstractions;
using LuisDelValle.Calculator.CalculatorService.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuisDelValle.Calculator.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SequencesController : Controller
    {
        private INumberService _sequencesService;

        public SequencesController(INumberService sequencesService)
        {
            _sequencesService = sequencesService;
        }

        [HttpGet]
        public SequencesResponse Get(int number)
        {
            return (SequencesResponse) _sequencesService.ProcessNumber(number);
        }
    }
}
