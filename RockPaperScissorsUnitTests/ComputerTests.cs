using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;

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
        public void GetRPSChoice_1000Rocks_returnsRandomRPSChoice()
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();
            RPSChoice input = RPSChoice.ROCK;

            // Act
            RPSChoice actual = computer.GetRPSChoice(input);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetRPSChoice_1000Paper_returnsRandomRPSChoice()
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();
            RPSChoice input = RPSChoice.PAPER;

            // Act
            RPSChoice actual = computer.GetRPSChoice(input);

            // Assert
            Assert.Fail();
        }


        [TestMethod]
        public void GetRPSChoice_1000Scissors_returnsRandomRPSChoice()
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();
            RPSChoice input = RPSChoice.SCISSORS;
            RPSChoice expected = RPSChoice.SCISSORS;

            // Act
            RPSChoice actual = computer.GetRPSChoice(input);

            // Assert
            Assert.Fail();
        }
    }
}
