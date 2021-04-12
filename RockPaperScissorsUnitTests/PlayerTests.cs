using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class PlayerTests
    {
        private Player CreatePlayerWithNoWins()
        {
            return new Player();
        }

        private Player CreatePlayerWithWins()
        {
            Player player = new Player();
            player.AddWin();
            return player;
        }

        [TestMethod]
        public void Wins_PlayerWithNoWins_returnsZeroWins()
        {
            // Arrange
            Player player = CreatePlayerWithNoWins();
            int expected = 0;

            // Act
            int actual = player.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddWin_PlayerWithNoWins_returnsOneWin()
        {
            // Arrange
            Player player = CreatePlayerWithNoWins();
            int expected = 1;

            // Act
            player.AddWin();
            int actual = player.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Wins_PlayerWithWins_returnsMoreThanZeroWins()
        {
            // Arrange
            Player player = CreatePlayerWithWins();
            int expectedGreaterThan = 0;

            // Act
            int actual = player.Wins;

            // Assert
            Assert.IsTrue(actual > expectedGreaterThan);
        }

        [TestMethod]
        public void ResetWins_PlayerWithNoWins_returnsZeroWins()
        {
            // Arrange
            Player player = CreatePlayerWithNoWins();
            int expected = 0;

            // Act
            player.ResetWins();
            int actual = player.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ResetWins_PlayerWithWins_returnsZeroWins()
        {
            // Arrange
            Player player = CreatePlayerWithWins();
            int expected = 0;

            // Act
            player.ResetWins();
            int actual = player.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetRPSChoice_Rock_returnsRock()
        {
            // Arrange
            Player player = CreatePlayerWithNoWins();
            RPSChoice input = RPSChoice.ROCK;
            RPSChoice expected = RPSChoice.ROCK;

            // Act
            RPSChoice actual = player.GetRPSChoice(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetRPSChoice_Paper_returnsPaper()
        {
            // Arrange
            Player player = CreatePlayerWithNoWins();
            RPSChoice input = RPSChoice.PAPER;
            RPSChoice expected = RPSChoice.PAPER;

            // Act
            RPSChoice actual = player.GetRPSChoice(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetRPSChoice_Scissors_returnsScissors()
        {
            // Arrange
            Player player = CreatePlayerWithNoWins();
            RPSChoice input = RPSChoice.SCISSORS;
            RPSChoice expected = RPSChoice.SCISSORS;

            // Act
            RPSChoice actual = player.GetRPSChoice(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
