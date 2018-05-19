using LuisDelValle.Calculator.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuisDelValle.Calculator.CalculatorService.Models
{
    public class SequencesResponse : Response
    {
        public IList<int> AllNumbersSequence { get; set; }
        public IList<int> OddNumbersSequence { get; set; }
        public IList<int> EvenNumbersSequence { get; set; }
        public IList<int> AllNumbersSecondSequence { get; set; }
        public char CharacterOutput { get; set; }

    }
}
