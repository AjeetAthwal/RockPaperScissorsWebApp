using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class RPSResultsTests
    {
        [TestMethod]
        public void RockBeatsScissors()
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
        public void ScissorsBeatsPaper()
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
        public void PaperBeatsRock()
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
        public void ScissorsLossesToRock()
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
        public void PaperLossesToScissors()
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
        public void RockLossesToPaper()
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
        public void RockDrawWorks()
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
        public void PaperDrawWorks()
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
        public void ScissorsDrawWorks()
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
