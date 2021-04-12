using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class ComputerTests
    {
        private Computer CreateComputerWithNoWins()
        {
            RandomRPSChoice r = new RandomRPSChoice();
            return new Computer(r);
        }

        private Computer CreateComputerWithSetSeed(int seed)
        {
            RandomRPSChoice r = new RandomRPSChoice(seed);
            return new Computer(r);
        }

        private static int CreateSeed()
        {
            Random r1 = new Random();
            int seed = r1.Next();
            return seed;
        }

        private Computer CreateComputerWithWins()
        {
            Computer computer = CreateComputerWithNoWins();
            computer.AddWin();
            return computer;
        }

        [TestMethod]
        public void Wins_ComputerWithNoWins_returnsZeroWins()
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();
            int expected = 0;

            // Act
            int actual = computer.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddWin_ComputerWithNoWins_returnsOneWin()
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();
            int expected = 1;

            // Act
            computer.AddWin();
            int actual = computer.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Wins_ComputerWithWins_returnsMoreThanZeroWins()
        {
            // Arrange
            Computer computer = CreateComputerWithWins();
            int expectedGreaterThan = 0;

            // Act
            int actual = computer.Wins;

            // Assert
            Assert.IsTrue(actual > expectedGreaterThan);
        }

        [TestMethod]
        public void ResetWins_ComputerWithNoWins_returnsZeroWins()
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();
            int expected = 0;

            // Act
            computer.ResetWins();
            int actual = computer.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ResetWins_ComputerWithWins_returnsZeroWins()
        {
            // Arrange
            Computer computer = CreateComputerWithWins();
            int expected = 0;

            // Act
            computer.ResetWins();
            int actual = computer.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetRPSChoice_100Rocks_returnsRandomRPSChoice()
        {
            // Arrange
            int NUMBEROFGETS = 100;
            int seed = CreateSeed();
            Computer computer = CreateComputerWithSetSeed(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);
            RPSChoice input = RPSChoice.ROCK;
            List<RPSChoice> expected = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                expected.Add(randomRPSChoice.Get());
            }

            // Act
            List<RPSChoice> actual = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                actual.Add(computer.GetRPSChoice(input));
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void GetRPSChoice_1000Paper_returnsRandomRPSChoice()
        {
            // Arrange
            int NUMBEROFGETS = 100;
            int seed = CreateSeed();
            Computer computer = CreateComputerWithSetSeed(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);
            RPSChoice input = RPSChoice.PAPER;
            List<RPSChoice> expected = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                expected.Add(randomRPSChoice.Get());
            }

            // Act
            List<RPSChoice> actual = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                actual.Add(computer.GetRPSChoice(input));
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void GetRPSChoice_1000Scissors_returnsRandomRPSChoice()
        {
            // Arrange
            int NUMBEROFGETS = 100;
            int seed = CreateSeed();
            Computer computer = CreateComputerWithSetSeed(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);
            RPSChoice input = RPSChoice.SCISSORS;
            List<RPSChoice> expected = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                expected.Add(randomRPSChoice.Get());
            }

            // Act
            List<RPSChoice> actual = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                actual.Add(computer.GetRPSChoice(input));
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
