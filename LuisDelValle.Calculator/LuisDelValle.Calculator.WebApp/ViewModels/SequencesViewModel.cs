using LuisDelValle.Calculator.CalculatorService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuisDelValle.Calculator.WebApp.ViewModels
{
    public class SequencesViewModel
    {
        [Required]
        public int InputNumber { get; set; }
        public SequencesResponse Sequences { get; set; }
    }
}
