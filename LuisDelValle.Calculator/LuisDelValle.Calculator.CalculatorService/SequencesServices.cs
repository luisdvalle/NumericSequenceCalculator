using LuisDelValle.Calculator.Abstractions;
using LuisDelValle.Calculator.CalculatorService.Abstractions;
using LuisDelValle.Calculator.CalculatorService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuisDelValle.Calculator.CalculatorService
{
    public class SequenceService : INumberService
    {
        public Response ProcessNumber(int inputNumber)
        {
            var result = new SequencesResponse()
            {
                AllNumbersSequence = new List<int>(),
                OddNumbersSequence = new List<int>(),
                EvenNumbersSequence = new List<int>(),
                AllNumbersSecondSequence = null,
                CharacterOutput = Char.MinValue
            };

            // Generate sequences: all numbers, odd numbers and even numbers.
            for (int i = 1; i <= inputNumber; i++)
            {
                result.AllNumbersSequence.Add(i);

                if (i % 2 == 0)
                {
                    result.EvenNumbersSequence.Add(i);
                }
                else
                {
                    result.OddNumbersSequence.Add(i);
                }
            }

            // Set CharacterOutput.
            if (inputNumber % 3 == 0 && inputNumber % 5 == 0)
            {
                result.CharacterOutput = 'Z';
            }
            else if (inputNumber % 3 == 0)
            {
                result.CharacterOutput = 'C';
            }
            else if (inputNumber % 5 == 0)
            {
                result.CharacterOutput = 'E';
            }
            else
            {
                result.AllNumbersSecondSequence = result.AllNumbersSequence;
            }

            return result;
        }
    }
}
