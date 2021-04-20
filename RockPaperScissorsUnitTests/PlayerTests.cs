using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class PlayerTests
    {
        /// <summary>
        /// Helper function that generates a player with no wins. Tested using Wins_PlayerWithNoWins_returnsZeroWins
        /// </summary>
        private Player CreatePlayerWithNoWins()
        {
            return new Player();
        }

        /// <summary>
        /// Helper function that generates a player with wins. Tested using Wins_PlayerWithWins_returnsMoreThanZeroWins
        /// </summary>
        private Player CreatePlayerWithWins()
        {
            Player player = new Player();
            player.AddWin();
            return player;
        }

        /// <summary>
        /// Zero should be returned when a player with no wins has its property Wins called
        /// </summary>
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

        /// <summary>
        /// One should be returned when a player with no wins invokes AddWin() and its property Wins called
        /// </summary>
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

        /// <summary>
        /// A number greater than 0 should be returned when a player with wins has its property Wins called
        /// </summary>
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

        /// <summary>
        /// A number greater than 0 should be returned when a player with wins has its property Wins called
        /// </summary>
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

        /// <summary>
        /// 0 should be returned when a player with wins invokes ResetWins() and its property Wins called
        /// </summary>
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

        /// <summary>
        /// ROCK should be returned when a player with invokes GetRPSChoice() and with argument ROCK
        /// </summary>
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

        /// <summary>
        /// PAPER should be returned when a player with invokes GetRPSChoice() and with argument PAPER
        /// </summary>
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

        /// <summary>
        /// SCISSORS should be returned when a player with invokes GetRPSChoice() and with argument SCISSORS
        /// </summary>
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

        /// <summary>
        /// An argument exception should be encountered when GetRPSChoice() is 
        /// invoked with two arguments. It should only work with no arguments. 
        /// </summary>
        [TestMethod]
        public void GetRPSChoice_0args_ThrowsArgumentException()
        {
            // Arrange
            Player player = CreatePlayerWithNoWins();

            // Act
            Action actual = () => player.GetRPSChoice();

            // Assert
            Assert.ThrowsException<ArgumentException>(actual);
        }
    }
}
