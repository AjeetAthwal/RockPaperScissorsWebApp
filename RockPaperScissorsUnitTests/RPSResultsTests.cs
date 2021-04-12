using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class RPSResultsTests
    {
        [TestMethod]
        public void Beats_RockVsScissors_ReturnsWin()
        {
            // Arrange
            RPSChoice choice1 = RPSChoice.ROCK;
            RPSChoice choice2 = RPSChoice.SCISSORS;
            RPSResult expected = RPSResult.WIN;

            // Act
            RPSResult result = RPSResultExtension.Beats(choice1, choice2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Beats_ScissorsVsRock_ReturnsWin()
        {
            // Arrange
            RPSChoice choice1 = RPSChoice.SCISSORS;
            RPSChoice choice2 = RPSChoice.PAPER;
            RPSResult expected = RPSResult.WIN;

            // Act
            RPSResult result = RPSResultExtension.Beats(choice1, choice2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Beats_PaperVsRock_ReturnsWin()
        {
            // Arrange
            RPSChoice choice1 = RPSChoice.PAPER;
            RPSChoice choice2 = RPSChoice.ROCK;
            RPSResult expected = RPSResult.WIN;

            // Act
            RPSResult result = RPSResultExtension.Beats(choice1, choice2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Beats_ScissorsVsRock_ReturnsLoss()
        {
            // Arrange
            RPSChoice choice1 = RPSChoice.SCISSORS;
            RPSChoice choice2 = RPSChoice.ROCK;
            RPSResult expected = RPSResult.LOSS;

            // Act
            RPSResult result = RPSResultExtension.Beats(choice1, choice2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Beats_PaperVsScissors_ReturnsLoss()
        {
            // Arrange
            RPSChoice choice1 = RPSChoice.PAPER;
            RPSChoice choice2 = RPSChoice.SCISSORS;
            RPSResult expected = RPSResult.LOSS;

            // Act
            RPSResult result = RPSResultExtension.Beats(choice1, choice2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Beats_RockVsPaper_ReturnsLoss()
        {
            // Arrange
            RPSChoice choice1 = RPSChoice.ROCK;
            RPSChoice choice2 = RPSChoice.PAPER;
            RPSResult expected = RPSResult.LOSS;

            // Act
            RPSResult result = RPSResultExtension.Beats(choice1, choice2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Beats_RockVsRock_ReturnsDraw()
        {
            // Arrange
            RPSChoice choice1 = RPSChoice.ROCK;
            RPSChoice choice2 = RPSChoice.ROCK;
            RPSResult expected = RPSResult.DRAW;

            // Act
            RPSResult result = RPSResultExtension.Beats(choice1, choice2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Beats_PaperVsPaper_ReturnsDraw()
        {
            // Arrange
            RPSChoice choice1 = RPSChoice.PAPER;
            RPSChoice choice2 = RPSChoice.PAPER;
            RPSResult expected = RPSResult.DRAW;

            // Act
            RPSResult result = RPSResultExtension.Beats(choice1, choice2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Beats_ScissorsVsScissors_ReturnsDraw()
        {
            // Arrange
            RPSChoice choice1 = RPSChoice.SCISSORS;
            RPSChoice choice2 = RPSChoice.SCISSORS;
            RPSResult expected = RPSResult.DRAW;

            // Act
            RPSResult result = RPSResultExtension.Beats(choice1, choice2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
