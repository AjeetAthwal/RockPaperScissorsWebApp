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

        private Scoreboard CreateNonEmptyScoreboard()
        {
            Scoreboard scoreboard = CreateEmptyScoreboard();
            scoreboard.Update(RPSP1P2Result.DRAW);
            return scoreboard;
        }

        [TestMethod]
        public void CreateEmptyScoreboard__ReturnsScoreboardWithNoGamePlayed()
        {
            // Arrange
            int expectedGamesPlayed = 0;

            // Act
            Scoreboard actualScoreboard = CreateEmptyScoreboard();

            // Assert
            Assert.AreEqual(expectedGamesPlayed, actualScoreboard.GamesPlayed);
        }

        [TestMethod]
        public void CreateNonEmptyScoreboard__ReturnsScoreboardWithMoreThanNoGamePlayed()
        {
            // Arrange
            int expectedGamesPlayedGreaterThan = 0;

            // Act
            Scoreboard actualScoreboard = CreateNonEmptyScoreboard();

            // Assert
            Assert.IsTrue(actualScoreboard.GamesPlayed > expectedGamesPlayedGreaterThan);
        }

        [TestMethod]
        public void Update_P1WIN_ReturnsScoreboardWithOneWinForPlayerOne()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expectedP1Wins = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualP1Wins = actualScoreboard.Player1Wins;

            // Assert
            Assert.AreEqual(expectedP1Wins, actualP1Wins);
        }

        [TestMethod]
        public void Update_P1WIN_ReturnsScoreboardWithNoWinForPlayerTwo()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expectedP2Wins = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualP2Wins = actualScoreboard.Player2Wins;

            // Assert
            Assert.AreEqual(expectedP2Wins, actualP2Wins) ;
        }

        [TestMethod]
        public void Update_P1WIN_ReturnsScoreboardWithNoDraw()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expectedDraws = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualDraws = actualScoreboard.Draws;

            // Assert
            Assert.AreEqual(expectedDraws, actualDraws);
        }

        [TestMethod]
        public void Update_P1WIN_ReturnsScoreboardWithOneGamePlayed()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expectedGamesPlayed = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualGamesPlayed = actualScoreboard.GamesPlayed;

            // Assert
            Assert.AreEqual(expectedGamesPlayed, actualGamesPlayed);
        }

        [TestMethod]
        public void Update_P2WIN_ReturnsScoreboardWithNoWinForPlayerOne()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P2WIN;
            int expectedP1Wins = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualP1Wins = actualScoreboard.Player1Wins;

            // Assert
            Assert.AreEqual(expectedP1Wins, actualP1Wins);
        }

        [TestMethod]
        public void Update_P2WIN_ReturnsScoreboardWithOneWinForPlayerTwo()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P2WIN;
            int expectedP2Wins = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualP2Wins = actualScoreboard.Player2Wins;

            // Assert
            Assert.AreEqual(expectedP2Wins, actualP2Wins);
        }

        [TestMethod]
        public void Update_P2WIN_ReturnsScoreboardWithNoDraw()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P2WIN;
            int expectedDraws = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualDraws = actualScoreboard.Draws;

            // Assert
            Assert.AreEqual(expectedDraws, actualDraws);
        }

        [TestMethod]
        public void Update_P2WIN_ReturnsScoreboardWithOneGamePlayed()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P2WIN;
            int expectedGamesPlayed = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualGamesPlayed = actualScoreboard.GamesPlayed;

            // Assert
            Assert.AreEqual(expectedGamesPlayed, actualGamesPlayed);
        }

        [TestMethod]
        public void Update_DRAW_ReturnsScoreboardWithNoWinForPlayerOne()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.DRAW;
            int expectedP1Wins = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualP1Wins = actualScoreboard.Player1Wins;

            // Assert
            Assert.AreEqual(expectedP1Wins, actualP1Wins);
        }

        [TestMethod]
        public void Update_DRAW_ReturnsScoreboardWithNoWinForPlayerTwo()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.DRAW;
            int expectedP2Wins = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualP2Wins = actualScoreboard.Player2Wins;

            // Assert
            Assert.AreEqual(expectedP2Wins, actualP2Wins);
        }

        [TestMethod]
        public void Update_DRAW_ReturnsScoreboardWithOneDraw()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.DRAW;
            int expectedDraws = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualDraws = actualScoreboard.Draws;

            // Assert
            Assert.AreEqual(expectedDraws, actualDraws);
        }

        [TestMethod]
        public void Update_DRAW_ReturnsScoreboardWithOneGamePlayed()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.DRAW;
            int expectedGamesPlayed = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actualGamesPlayed = actualScoreboard.GamesPlayed;

            // Assert
            Assert.AreEqual(expectedGamesPlayed, actualGamesPlayed);
        }

        [TestMethod]
        public void Reset_EmptyScoreboard_ReturnsScoreboardWithNoGamePlayed()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
            int expectedGamesPlayed = 0;

            // Act
            scoreboard.Reset();

            // Assert
            Assert.AreEqual(expectedGamesPlayed, scoreboard.GamesPlayed);
        }

        [TestMethod]
        public void Reset_EmptyScoreboard_ReturnsScoreboardWithNoDraw()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
            int expectedDraws = 0;

            // Act
            scoreboard.Reset();

            // Assert
            Assert.AreEqual(expectedDraws, scoreboard.Draws);
        }

        [TestMethod]
        public void Reset_EmptyScoreboard_ReturnsScoreboardWithNoWinForPlayerOne()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
            int expectedP1Wins = 0;

            // Act
            scoreboard.Reset();

            // Assert
            Assert.AreEqual(expectedP1Wins, scoreboard.Player1Wins);
        }

        [TestMethod]
        public void Reset_EmptyScoreboard_ReturnsScoreboardWithNoWinForPlayerTwo()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
            int expectedP2Wins = 0;

            // Act
            scoreboard.Reset();

            // Assert
            Assert.AreEqual(expectedP2Wins, scoreboard.Player2Wins);
        }

        [TestMethod]
        public void Reset_NonEmptyScoreboard_ReturnsScoreboardWithNoGamePlayed()
        {
            // Arrange
            Scoreboard scoreboard = CreateNonEmptyScoreboard();
            int expectedGamesPlayed = 0;

            // Act
            scoreboard.Reset();

            // Assert
            Assert.AreEqual(expectedGamesPlayed, scoreboard.GamesPlayed);
        }

        [TestMethod]
        public void Reset_NonEmptyScoreboard_ReturnsScoreboardWithNoDraw()
        {
            // Arrange
            Scoreboard scoreboard = CreateNonEmptyScoreboard();
            int expectedDraws = 0;

            // Act
            scoreboard.Reset();

            // Assert
            Assert.AreEqual(expectedDraws, scoreboard.Draws);
        }

        [TestMethod]
        public void Reset_NonEmptyScoreboard_ReturnsScoreboardWithNoWinForPlayerOne()
        {
            // Arrange
            Scoreboard scoreboard = CreateNonEmptyScoreboard();
            int expectedP1Wins = 0;

            // Act
            scoreboard.Reset();

            // Assert
            Assert.AreEqual(expectedP1Wins, scoreboard.Player1Wins);
        }

        [TestMethod]
        public void Reset_NonEmptyScoreboard_ReturnsScoreboardWithNoWinForPlayerTwo()
        {
            // Arrange
            Scoreboard scoreboard = CreateNonEmptyScoreboard();
            int expectedP2Wins = 0;

            // Act
            scoreboard.Reset();

            // Assert
            Assert.AreEqual(expectedP2Wins, scoreboard.Player2Wins);
        }
    }
}
