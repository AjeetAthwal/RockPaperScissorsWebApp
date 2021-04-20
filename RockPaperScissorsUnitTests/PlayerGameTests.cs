using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class PlayerGameTests
    {
        /// <summary>
        /// Helper function that generates a random seed
        /// </summary>
        private static int CreateSeed()
        {
            Random r1 = new Random();
            int seed = r1.Next();
            return seed;
        }

        /// <summary>
        /// ROCK should be returned when PlayRound() is 
        /// invoked with argument ROCK and Player1Choice is called
        /// </summary>
        [TestMethod]
        public void PlayRound_ROCK_ReturnsROCK()
        {
            // Arrange
            PlayerGame playerGame = new PlayerGame();
            RPSChoice input = RPSChoice.ROCK;
            RPSChoice expected = RPSChoice.ROCK;

            // Act
            playerGame.PlayRound(input);
            RPSChoice actual = playerGame.Player1Choice;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// PAPER should be returned when PlayRound() is 
        /// invoked with argument PAPER and Player1Choice is called
        /// </summary>
        [TestMethod]
        public void PlayRound_PAPER_ReturnsPAPER()
        {
            // Arrange
            PlayerGame playerGame = new PlayerGame();
            RPSChoice input = RPSChoice.PAPER;
            RPSChoice expected = RPSChoice.PAPER;

            // Act
            playerGame.PlayRound(input);
            RPSChoice actual = playerGame.Player1Choice;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// SCISSORS should be returned when PlayRound() is 
        /// invoked with argument SCISSORS and Player1Choice is called
        /// </summary>
        [TestMethod]
        public void PlayRound_SCISSORS_ReturnsSCISSORS()
        {
            // Arrange
            PlayerGame playerGame = new PlayerGame();
            RPSChoice input = RPSChoice.SCISSORS;
            RPSChoice expected = RPSChoice.SCISSORS;

            // Act
            playerGame.PlayRound(input);
            RPSChoice actual = playerGame.Player1Choice;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// An argument exception should be encountered when PlayRound() is 
        /// invoked with two arguments. It should only work with no arguments. 
        /// </summary>
        [TestMethod]
        public void PlayRound_0args_ThrowsArgumentException()
        {
            // Arrange
            PlayerGame playerGame = new PlayerGame();

            // Act
            Action actual = () => playerGame.PlayRound();

            // Assert
            Assert.ThrowsException<ArgumentException>(actual);
        }

        /// <summary>
        /// An argument exception should be encountered when PlayRound() is 
        /// invoked with two arguments. It should only work with no arguments. 
        /// </summary>
        [DataTestMethod]
        [DataRow(RPSChoice.PAPER, RPSChoice.PAPER)]
        [DataRow(RPSChoice.PAPER, RPSChoice.ROCK)]
        [DataRow(RPSChoice.PAPER, RPSChoice.SCISSORS)]
        [DataRow(RPSChoice.ROCK, RPSChoice.PAPER)]
        [DataRow(RPSChoice.ROCK, RPSChoice.ROCK)]
        [DataRow(RPSChoice.ROCK, RPSChoice.SCISSORS)]
        [DataRow(RPSChoice.SCISSORS, RPSChoice.PAPER)]
        [DataRow(RPSChoice.SCISSORS, RPSChoice.ROCK)]
        [DataRow(RPSChoice.SCISSORS, RPSChoice.SCISSORS)]
        public void PlayRound_2args_ThrowsArgumentException(RPSChoice input1, RPSChoice input2)
        {
            // Arrange
            PlayerGame playerGame = new PlayerGame();

            // Act
            Action actual = () => playerGame.PlayRound(input1, input2);

            // Assert
            Assert.ThrowsException<ArgumentException>(actual);
        }

        /// <summary>
        /// A list of 50 random RPSChoices should be returned when a when a 
        /// game with a set seed invokes PlayRound() 50 times and Player2Choice
        /// is recorded. These random choices should match 
        /// what is returned when RandomRPSChoice invokes Get() 50 times with 
        /// the same set seed
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsRandomRPSChoice()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            PlayerGame playerGame = new PlayerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);

            List<RPSChoice> expected = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                expected.Add(randomRPSChoice.Get());
            }

            // Act
            List<RPSChoice> actual = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
                actual.Add(playerGame.Player2Choice);
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        /// <summary>
        /// A list of 50 RPSP1P2Results should be returned when a
        /// game with a set seed invokes PlayRound() 50 times and Beats
        /// is recorded. These random choices should match 
        /// what is returned when RandomRPSChoice invokes Get() 50 times with 
        /// the same set seed
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsRPSP1P2Results()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            PlayerGame playerGame = new PlayerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);

            List<RPSP1P2Result> expected = new List<RPSP1P2Result>();

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice P1Choice = (RPSChoice)i;
                RPSChoice P2Choice = randomRPSChoice.Get();
                expected.Add((RPSP1P2Result)RPSResultExtension.Beats(P1Choice, P2Choice));
            }

            // Act
            List<RPSP1P2Result> actual = new List<RPSP1P2Result>();

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
                actual.Add(playerGame.Result);
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        /// <summary>
        /// A number should be returned when a new game with a set seed invokes
        /// PlayRound() 50 times and Player1Wins
        /// is recorded. These random choices should match 
        /// what is returned when RandomRPSChoice invokes Get() 50 times with 
        /// the same set seed.
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsPlayer1Wins()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            PlayerGame playerGame = new PlayerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);
            int expected = 0;

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice P1Choice = (RPSChoice)i;
                RPSChoice P2Choice = randomRPSChoice.Get();
                if ((RPSP1P2Result)RPSResultExtension.Beats(P1Choice, P2Choice) == RPSP1P2Result.P1WIN)
                {
                    expected++;
                }
            }

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
            }
            int actual = playerGame.Player1Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A number should be returned when a new game with a set seed invokes
        /// PlayRound() 50 times and Player2Wins
        /// is recorded. These random choices should match 
        /// what is returned when RandomRPSChoice invokes Get() 50 times with 
        /// the same set seed.
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsPlayer2Wins()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            PlayerGame playerGame = new PlayerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);
            int expected = 0;

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice P1Choice = (RPSChoice)i;
                RPSChoice P2Choice = randomRPSChoice.Get();
                if ((RPSP1P2Result)RPSResultExtension.Beats(P1Choice, P2Choice) == RPSP1P2Result.P2WIN)
                {
                    expected++;
                }
            }

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
            }
            int actual = playerGame.Player2Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A number should be returned when a new game with a set seed invokes
        /// PlayRound() 50 times and Player2Wins
        /// is recorded. These random choices should match 
        /// what is returned when RandomRPSChoice invokes Get() 50 times with 
        /// the same set seed.
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsDraws()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            PlayerGame playerGame = new PlayerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);
            int expected = 0;

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice P1Choice = (RPSChoice)i;
                RPSChoice P2Choice = randomRPSChoice.Get();
                if ((RPSP1P2Result)RPSResultExtension.Beats(P1Choice, P2Choice) == RPSP1P2Result.DRAW)
                {
                    expected++;
                }
            }

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
            }
            int actual = playerGame.Draws;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 50 should be returned when a new game invokes
        /// PlayRound() 50 times and GamesPlayed is recorded. These random choices should match 
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returns50GamesPlayed()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            PlayerGame playerGame = new PlayerGame();
            int expected = 50;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
            }
            int actual = playerGame.GamesPlayed;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when a new game invokes PlayRound() 50 times 
        /// and ResetScores is then invoked and GamesPlayed is called
        /// </summary>
        [TestMethod]
        public void ResetScores_PlayerGame_returnsZeroGamesPlayed()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            PlayerGame playerGame = new PlayerGame();
            int expected = 0;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
            }
            playerGame.ResetScores();
            int actual = playerGame.GamesPlayed;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when a new game invokes PlayRound() 50 times 
        /// and ResetScores is then invoked and Player1Wins is called
        /// </summary>
        [TestMethod]
        public void ResetScores_ComputerGame_returnsZeroPlayer1Wins()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            PlayerGame playerGame = new PlayerGame();
            int expected = 0;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
            }
            playerGame.ResetScores();
            int actual = playerGame.Player1Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when a new game invokes PlayRound() 50 times 
        /// and ResetScores is then invoked and Player2Wins is called
        /// </summary>
        [TestMethod]
        public void ResetScores_ComputerGame_returnsZeroPlayer2Wins()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            PlayerGame playerGame = new PlayerGame();
            int expected = 0;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
            }
            playerGame.ResetScores();
            int actual = playerGame.Player2Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when a new game invokes PlayRound() 50 times 
        /// and ResetScores is then invoked and Draws is called
        /// </summary>
        [TestMethod]
        public void ResetScores_ComputerGame_returnsZeroDraws()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            PlayerGame playerGame = new PlayerGame();
            int expected = 0;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice input = (RPSChoice)i;
                playerGame.PlayRound(input);
            }
            playerGame.ResetScores();
            int actual = playerGame.Draws;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
