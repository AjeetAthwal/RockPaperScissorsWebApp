using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class ScoreboardTests
    {
        [TestMethod]
        public void AddingP1WinWorks()
        {
            // Arrange
            RandomRPSChoice r = new RandomRPSChoice();
            Computer player1 = new Computer(r);
            Computer player2 = new Computer(r);
            Scoreboard scoreboard = new Scoreboard(player1, player2);
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expectedP1Wins = 1;
            int expectedP2Wins = 0;
            int expectedDraws = 0;
            int expectedgamesPlayed = 1;

            // Act
            scoreboard.update(newRPSresult);

            // Assert
            Assert.AreEqual(expectedP1Wins, scoreboard.Player1Wins);
            Assert.AreEqual(expectedP2Wins, scoreboard.Player2Wins);
            Assert.AreEqual(expectedDraws, scoreboard.Draws);
            Assert.AreEqual(expectedgamesPlayed, scoreboard.GamesPlayed);
        }

        [TestMethod]
        public void AddingP2WinWorks()
        {
            // Arrange
            RandomRPSChoice r = new RandomRPSChoice();
            Computer player1 = new Computer(r);
            Computer player2 = new Computer(r);
            Scoreboard scoreboard = new Scoreboard(player1, player2);
            RPSP1P2Result newRPSresult = RPSP1P2Result.P2WIN;
            int expectedP1Wins = 0;
            int expectedP2Wins = 1;
            int expectedDraws = 0;
            int expectedgamesPlayed = 1;

            // Act
            scoreboard.update(newRPSresult);

            // Assert
            Assert.AreEqual(expectedP1Wins, scoreboard.Player1Wins);
            Assert.AreEqual(expectedP2Wins, scoreboard.Player2Wins);
            Assert.AreEqual(expectedDraws, scoreboard.Draws);
            Assert.AreEqual(expectedgamesPlayed, scoreboard.GamesPlayed);
        }

        [TestMethod]
        public void AddingDrawWorks()
        {
            // Arrange
            RandomRPSChoice r = new RandomRPSChoice();
            Computer player1 = new Computer(r);
            Computer player2 = new Computer(r);
            Scoreboard scoreboard = new Scoreboard(player1, player2);
            RPSP1P2Result newRPSresult = RPSP1P2Result.DRAW;
            int expectedP1Wins = 0;
            int expectedP2Wins = 0;
            int expectedDraws = 1;
            int expectedgamesPlayed = 1;

            // Act
            scoreboard.update(newRPSresult);

            // Assert
            Assert.AreEqual(expectedP1Wins, scoreboard.Player1Wins);
            Assert.AreEqual(expectedP2Wins, scoreboard.Player2Wins);
            Assert.AreEqual(expectedDraws, scoreboard.Draws);
            Assert.AreEqual(expectedgamesPlayed, scoreboard.GamesPlayed);
        }
        [TestMethod]
        public void AddingMultipleResultsWorks()
        {
            // Arrange
            RandomRPSChoice r = new RandomRPSChoice();
            Computer player1 = new Computer(r);
            Computer player2 = new Computer(r);
            Scoreboard scoreboard = new Scoreboard(player1, player2);
            RPSP1P2Result newRPSresult1 = RPSP1P2Result.DRAW;
            RPSP1P2Result newRPSresult2 = RPSP1P2Result.P1WIN;
            RPSP1P2Result newRPSresult3 = RPSP1P2Result.P1WIN;
            RPSP1P2Result newRPSresult4 = RPSP1P2Result.P2WIN;
            int expectedP1Wins = 2;
            int expectedP2Wins = 1;
            int expectedDraws = 1;
            int expectedgamesPlayed = 4;

            // Act
            scoreboard.update(newRPSresult1);
            scoreboard.update(newRPSresult2);
            scoreboard.update(newRPSresult3);
            scoreboard.update(newRPSresult4);

            // Assert
            Assert.AreEqual(expectedP1Wins, scoreboard.Player1Wins);
            Assert.AreEqual(expectedP2Wins, scoreboard.Player2Wins);
            Assert.AreEqual(expectedDraws, scoreboard.Draws);
            Assert.AreEqual(expectedgamesPlayed, scoreboard.GamesPlayed);
        }
    }
}
