using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class ScoreboardTests
    {
        private Scoreboard CreateEmptyScoreboard()
        {
            RandomRPSChoice r = new RandomRPSChoice();
            Computer player1 = new Computer(r);
            Computer player2 = new Computer(r);
            return new Scoreboard(player1, player2);
        }

        [TestMethod]
        public void update_P1WIN_ReturnsScoreboardWithOneWinForPlayerOne()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expectedP1Wins = 1;

            // Act
            actualScoreboard.update(newRPSresult);
            int actualP1Wins = actualScoreboard.Player1Wins;

            // Assert
            Assert.AreEqual(expectedP1Wins, actualP1Wins);
        }

        [TestMethod]
        public void update_P1WIN_ReturnsScoreboardWithNoWinForPlayerTwo()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expectedP2Wins = 0;

            // Act
            actualScoreboard.update(newRPSresult);
            int actualP2Wins = actualScoreboard.Player2Wins;

            // Assert
            Assert.AreEqual(expectedP2Wins, actualP2Wins) ;
        }

        [TestMethod]
        public void update_P1WIN_ReturnsScoreboardWithNoDraw()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expectedDraws = 0;

            // Act
            actualScoreboard.update(newRPSresult);
            int actualDraws = actualScoreboard.Draws;

            // Assert
            Assert.AreEqual(expectedDraws, actualDraws);
        }

        [TestMethod]
        public void update_P1WIN_ReturnsScoreboardWithOneGamePlayed()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expectedGamesPlayed = 1;

            // Act
            actualScoreboard.update(newRPSresult);
            int actualGamesPlayed = actualScoreboard.GamesPlayed;

            // Assert
            Assert.AreEqual(expectedGamesPlayed, actualGamesPlayed);
        }

        [TestMethod]
        public void AddingP2WinWorks()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
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
            Scoreboard scoreboard = CreateEmptyScoreboard();
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
            Scoreboard scoreboard = CreateEmptyScoreboard();
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

        [TestMethod]
        public void ResetScoresWorks()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult1 = RPSP1P2Result.DRAW;
            RPSP1P2Result newRPSresult2 = RPSP1P2Result.P1WIN;
            RPSP1P2Result newRPSresult3 = RPSP1P2Result.P1WIN;
            RPSP1P2Result newRPSresult4 = RPSP1P2Result.P2WIN;
            int expectedP1Wins = 0;
            int expectedP2Wins = 0;
            int expectedDraws = 0;
            int expectedgamesPlayed = 0;

            // Act
            scoreboard.update(newRPSresult1);
            scoreboard.update(newRPSresult2);
            scoreboard.update(newRPSresult3);
            scoreboard.update(newRPSresult4);
            scoreboard.reset();

            // Assert
            Assert.AreEqual(expectedP1Wins, scoreboard.Player1Wins);
            Assert.AreEqual(expectedP2Wins, scoreboard.Player2Wins);
            Assert.AreEqual(expectedDraws, scoreboard.Draws);
            Assert.AreEqual(expectedgamesPlayed, scoreboard.GamesPlayed);
        }
    }
}
