using LuisDelValle.Calculator.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuisDelValle.Calculator.CalculatorService.Abstractions
{
    public interface INumberService
    {
        Response ProcessNumber(int inputNumber);
    }
}
