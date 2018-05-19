using LuisDelValle.Calculator.CalculatorService;
using LuisDelValle.Calculator.CalculatorService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LuisDelValle.Calculator.XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void GetSequences__NumberMultipleFive__SuccessfulResult()
        {
            // Arrange
            int inputNumber = 10;
            var sequenceService = new SequenceService();

            // Act
            SequencesResponse sequencesObject = (SequencesResponse) sequenceService.ProcessNumber(inputNumber);

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, sequencesObject.AllNumbersSequence.ToList());
            Assert.Equal(new List<int> { 1, 3, 5, 7, 9 }, sequencesObject.OddNumbersSequence.ToList());
            Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, sequencesObject.EvenNumbersSequence.ToList());
            Assert.Null(sequencesObject.AllNumbersSecondSequence);
            Assert.Equal('E', sequencesObject.CharacterOutput);
        }

        [Fact]
        public void GetSequences__NumberMultipleThree__SuccessfulResult()
        {
            // Arrange
            int inputNumber = 9;
            var sequenceService = new SequenceService();

            // Act
            SequencesResponse sequencesObject = (SequencesResponse)sequenceService.ProcessNumber(inputNumber);

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, sequencesObject.AllNumbersSequence.ToList());
            Assert.Equal(new List<int> { 1, 3, 5, 7, 9 }, sequencesObject.OddNumbersSequence.ToList());
            Assert.Equal(new List<int> { 2, 4, 6, 8 }, sequencesObject.EvenNumbersSequence.ToList());
            Assert.Null(sequencesObject.AllNumbersSecondSequence);
            Assert.Equal('C', sequencesObject.CharacterOutput);
        }

        [Fact]
        public void GetSequences__NumberMultipleThreeAndMultipleFive__SuccessfulResult()
        {
            // Arrange
            int inputNumber = 15;
            var sequenceService = new SequenceService();

            // Act
            SequencesResponse sequencesObject = (SequencesResponse)sequenceService.ProcessNumber(inputNumber);

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, sequencesObject.AllNumbersSequence.ToList());
            Assert.Equal(new List<int> { 1, 3, 5, 7, 9, 11, 13, 15 }, sequencesObject.OddNumbersSequence.ToList());
            Assert.Equal(new List<int> { 2, 4, 6, 8, 10, 12, 14 }, sequencesObject.EvenNumbersSequence.ToList());
            Assert.Null(sequencesObject.AllNumbersSecondSequence);
            Assert.Equal('Z', sequencesObject.CharacterOutput);
        }

        [Fact]
        public void GetSequences__NumberNotMultipleThreeNorMultipleFive__SuccessfulResult()
        {
            // Arrange
            int inputNumber = 14;
            var sequenceService = new SequenceService();

            // Act
            SequencesResponse sequencesObject = (SequencesResponse)sequenceService.ProcessNumber(inputNumber);

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, sequencesObject.AllNumbersSequence.ToList());
            Assert.Equal(new List<int> { 1, 3, 5, 7, 9, 11, 13 }, sequencesObject.OddNumbersSequence.ToList());
            Assert.Equal(new List<int> { 2, 4, 6, 8, 10, 12, 14 }, sequencesObject.EvenNumbersSequence.ToList());
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, sequencesObject.AllNumbersSecondSequence.ToList());
            Assert.Equal(Char.MinValue, sequencesObject.CharacterOutput);
        }
    }
}
