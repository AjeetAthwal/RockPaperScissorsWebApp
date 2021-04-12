using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class RPSResultsConversionTests
    {
        [TestMethod]
        public void RPSResultToRPSP1P2ResultCast_WIN_ReturnsP1WIN()
        {
            // Arrange
            RPSResult rpsResult = RPSResult.WIN;
            RPSP1P2Result expected = RPSP1P2Result.P1WIN;

            // Act
            RPSP1P2Result result = (RPSP1P2Result)rpsResult;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RPSResultToRPSP1P2ResultCast_LOSS_ReturnsP2WIN()
        {
            // Arrange
            RPSResult rpsResult = RPSResult.LOSS;
            RPSP1P2Result expected = RPSP1P2Result.P2WIN;

            // Act
            RPSP1P2Result result = (RPSP1P2Result)rpsResult;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RPSResultToRPSP1P2ResultCast_DRAW_ReturnsP1DRAW()
        {
            // Arrange
            RPSResult rpsResult = RPSResult.DRAW;
            RPSP1P2Result expected = RPSP1P2Result.DRAW;

            // Act
            RPSP1P2Result result = (RPSP1P2Result)rpsResult;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
