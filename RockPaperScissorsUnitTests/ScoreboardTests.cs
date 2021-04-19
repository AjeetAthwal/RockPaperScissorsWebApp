using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class ScoreboardTests
    {
        /// <summary>
        /// Helper function that generates a Scoreboard with no wins. Tested using GamesPlayed_CreateEmptyScoreboard_ReturnsScoreboardWithNoGamePlayed
        /// </summary>
        private Scoreboard CreateEmptyScoreboard()
        {
            RandomRPSChoice r = new RandomRPSChoice();
            Computer player1 = new Computer(r);
            Computer player2 = new Computer(r);
            return new Scoreboard(player1, player2);
        }

        /// <summary>
        /// Helper function that generates a Scoreboard with wins. Tested using GamesPlayed_CreateNonEmptyScoreboard_ReturnsScoreboardWithMoreThanNoGamePlayed
        /// </summary>
        private Scoreboard CreateNonEmptyScoreboard()
        {
            Scoreboard scoreboard = CreateEmptyScoreboard();
            scoreboard.Update(RPSP1P2Result.DRAW);
            return scoreboard;
        }

        /// <summary>
        /// Zero should be returned when a scoreboard with no games played has its property GamesPlayed called
        /// </summary>
        [TestMethod]
        public void GamesPlayed_CreateEmptyScoreboard_ReturnsScoreboardWithNoGamePlayed()
        {
            // Arrange
            int expected = 0;

            // Act
            Scoreboard actual = CreateEmptyScoreboard();

            // Assert
            Assert.AreEqual(expected, actual.GamesPlayed);
        }

        /// <summary>
        /// A number greater than 0 should be returned when a non empty scoreboard has its property GamesPlayed called
        /// </summary>
        [TestMethod]
        public void GamesPlayed_CreateNonEmptyScoreboard_ReturnsScoreboardWithMoreThanNoGamePlayed()
        {
            // Arrange
            int expectedGreaterThan = 0;

            // Act
            Scoreboard actual = CreateNonEmptyScoreboard();

            // Assert
            Assert.IsTrue(actual.GamesPlayed > expectedGreaterThan);
        }

        /// <summary>
        /// 1 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument P1WIN andd its property 
        /// Player1Wins is called
        /// </summary>
        [TestMethod]
        public void Update_P1WIN_ReturnsScoreboardWithOneWinForPlayerOne()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int excpected = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.Player1Wins;

            // Assert
            Assert.AreEqual(excpected, actual);
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument P1WIN andd its property 
        /// Player2Wins is called
        /// </summary>
        [TestMethod]
        public void Update_P1WIN_ReturnsScoreboardWithNoWinForPlayerTwo()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expected = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.Player2Wins;

            // Assert
            Assert.AreEqual(expected, actual) ;
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument P1WIN andd its property 
        /// Draws is called
        /// </summary>
        [TestMethod]
        public void Update_P1WIN_ReturnsScoreboardWithNoDraw()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expected = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.Draws;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 1 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument P1WIN andd its property 
        /// GamesPlayed is called
        /// </summary>
        [TestMethod]
        public void Update_P1WIN_ReturnsScoreboardWithOneGamePlayed()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P1WIN;
            int expected = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.GamesPlayed;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument P2WIN andd its property 
        /// Player1Wins is called
        /// </summary>
        [TestMethod]
        public void Update_P2WIN_ReturnsScoreboardWithNoWinForPlayerOne()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P2WIN;
            int expected = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.Player1Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 1 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument P2WIN andd its property 
        /// Player2Wins is called
        /// </summary>
        [TestMethod]
        public void Update_P2WIN_ReturnsScoreboardWithOneWinForPlayerTwo()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P2WIN;
            int expected = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.Player2Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument P2WIN andd its property 
        /// Draws is called
        /// </summary>
        [TestMethod]
        public void Update_P2WIN_ReturnsScoreboardWithNoDraw()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P2WIN;
            int expected = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.Draws;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 1 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument P2WIN andd its property 
        /// GamesPlayed is called
        /// </summary>
        [TestMethod]
        public void Update_P2WIN_ReturnsScoreboardWithOneGamePlayed()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.P2WIN;
            int expected = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.GamesPlayed;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument DRAW andd its property 
        /// Player1Wins is called
        /// </summary>
        [TestMethod]
        public void Update_DRAW_ReturnsScoreboardWithNoWinForPlayerOne()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.DRAW;
            int expected = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.Player1Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument DRAW and its property 
        /// Player2Wins is called
        /// </summary>
        [TestMethod]
        public void Update_DRAW_ReturnsScoreboardWithNoWinForPlayerTwo()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.DRAW;
            int expected = 0;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.Player2Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 1 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument DRAW and its property 
        /// Draws is called
        /// </summary>
        [TestMethod]
        public void Update_DRAW_ReturnsScoreboardWithOneDraw()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.DRAW;
            int expected = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.Draws;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 1 should be returned when an empty Scoreboard is created and 
        /// Update() is invoked with argument DRAW and its property 
        /// GamesPlayed is called
        /// </summary>
        [TestMethod]
        public void Update_DRAW_ReturnsScoreboardWithOneGamePlayed()
        {
            // Arrange
            Scoreboard actualScoreboard = CreateEmptyScoreboard();
            RPSP1P2Result newRPSresult = RPSP1P2Result.DRAW;
            int expected = 1;

            // Act
            actualScoreboard.Update(newRPSresult);
            int actual = actualScoreboard.GamesPlayed;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Reset() is invoked and its property GamesPlayed is called
        /// </summary>
        [TestMethod]
        public void Reset_EmptyScoreboard_ReturnsScoreboardWithNoGamePlayed()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
            int expected = 0;

            // Act
            scoreboard.Reset();
            int actual = scoreboard.GamesPlayed;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Reset() is invoked and its property Draws is called
        /// </summary>
        [TestMethod]
        public void Reset_EmptyScoreboard_ReturnsScoreboardWithNoDraw()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
            int expected = 0;

            // Act
            scoreboard.Reset();
            int actual = scoreboard.Draws;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Reset() is invoked and its property Player1Wins is called
        /// </summary>
        [TestMethod]
        public void Reset_EmptyScoreboard_ReturnsScoreboardWithNoWinForPlayerOne()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
            int expected = 0;

            // Act
            scoreboard.Reset();
            int actual = scoreboard.Player1Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when an empty Scoreboard is created and 
        /// Reset() is invoked and its property Player2Wins is called
        /// </summary>
        [TestMethod]
        public void Reset_EmptyScoreboard_ReturnsScoreboardWithNoWinForPlayerTwo()
        {
            // Arrange
            Scoreboard scoreboard = CreateEmptyScoreboard();
            int expected = 0;

            // Act
            scoreboard.Reset();
            int actual = scoreboard.Player2Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when a non empty Scoreboard is created and 
        /// Reset() is invoked and its property GamesPlayed is called
        /// </summary>
        [TestMethod]
        public void Reset_NonEmptyScoreboard_ReturnsScoreboardWithNoGamePlayed()
        {
            // Arrange
            Scoreboard scoreboard = CreateNonEmptyScoreboard();
            int expected = 0;

            // Act
            scoreboard.Reset();
            int actual = scoreboard.GamesPlayed;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when a non empty Scoreboard is created and 
        /// Reset() is invoked and its property Draws is called
        /// </summary>
        [TestMethod]
        public void Reset_NonEmptyScoreboard_ReturnsScoreboardWithNoDraw()
        {
            // Arrange
            Scoreboard scoreboard = CreateNonEmptyScoreboard();
            int expected = 0;

            // Act
            scoreboard.Reset();
            int actual = scoreboard.Draws;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when a non empty Scoreboard is created and 
        /// Reset() is invoked and its property Player1Wins is called
        /// </summary>
        [TestMethod]
        public void Reset_NonEmptyScoreboard_ReturnsScoreboardWithNoWinForPlayerOne()
        {
            // Arrange
            Scoreboard scoreboard = CreateNonEmptyScoreboard();
            int expected = 0;

            // Act
            scoreboard.Reset();
            int actual = scoreboard.Player1Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when a non empty Scoreboard is created and 
        /// Reset() is invoked and its property Player2Wins is called
        /// </summary>
        [TestMethod]
        public void Reset_NonEmptyScoreboard_ReturnsScoreboardWithNoWinForPlayerTwo()
        {
            // Arrange
            Scoreboard scoreboard = CreateNonEmptyScoreboard();
            int expected = 0;

            // Act
            scoreboard.Reset();
            int actual = scoreboard.Player2Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
