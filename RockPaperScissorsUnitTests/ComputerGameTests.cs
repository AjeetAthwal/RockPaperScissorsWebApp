using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class ComputerGameTests
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
        /// 0 should be returned when a new game invokes PlayRound() 50 times 
        /// and ResetScores is then invoked and GamesPlayed is called
        /// </summary>
        [TestMethod]
        public void ResetScores_ComputerGame_returnsZeroGamesPlayed()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            ComputerGame computerGame = new ComputerGame();
            int expected = 0;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
            }
            computerGame.ResetScores();
            int actual = computerGame.GamesPlayed;

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
            ComputerGame computerGame = new ComputerGame();
            int expected = 0;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
            }
            computerGame.ResetScores();
            int actual = computerGame.Player1Wins;

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
            ComputerGame computerGame = new ComputerGame();
            int expected = 0;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
            }
            computerGame.ResetScores();
            int actual = computerGame.Player2Wins;

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
            ComputerGame computerGame = new ComputerGame();
            int expected = 0;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
            }
            computerGame.ResetScores();
            int actual = computerGame.Draws;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 50 should be returned when a new
        /// game invokes PlayRound() 50 times and GamesPlayed is called
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returns50GamesPlayed()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            ComputerGame computerGame = new ComputerGame();
            int expected = NUMBEROFROUNDS;

            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
            }
            int actual = computerGame.GamesPlayed;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A number should be returned when a new game with a set seed invokes
        /// PlayRound() 50 times and Player1Wins is called. This
        /// number should match what is returned when RandomRPSChoice invokes
        /// 50 Rounds of 2 Get()'s and computes the result with the same seed 
        /// and counts the number of "P1Wins"
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsPlayer1Wins()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            ComputerGame computerGame = new ComputerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);

            int expected = 0;

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice P1Choice = randomRPSChoice.Get();
                RPSChoice P2Choice = randomRPSChoice.Get();
                if ((RPSP1P2Result)RPSResultExtension.Beats(P1Choice, P2Choice) == RPSP1P2Result.P1WIN)
                {
                    expected++;
                }
            }
            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
            }
            int actual = computerGame.Player1Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A number should be returned when a new game with a set seed invokes
        /// PlayRound() 50 times and Player2Wins is called. This
        /// number should match what is returned when RandomRPSChoice invokes
        /// 50 Rounds of 2 Get()'s and computes the result with the same seed 
        /// and counts the number of "P2Wins"
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsPlayer2Wins()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            ComputerGame computerGame = new ComputerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);

            int expected = 0;

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice P1Choice = randomRPSChoice.Get();
                RPSChoice P2Choice = randomRPSChoice.Get();
                if ((RPSP1P2Result)RPSResultExtension.Beats(P1Choice, P2Choice) == RPSP1P2Result.P2WIN)
                {
                    expected++;
                }
            }
            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
            }
            int actual = computerGame.Player2Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A number should be returned when a new game with a set seed invokes
        /// PlayRound() 50 times and Draws is called. This
        /// number should match what is returned when RandomRPSChoice invokes
        /// 50 Rounds of 2 Get()'s and computes the result with the same seed 
        /// and counts the number of "Draws"
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsDraws()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            ComputerGame computerGame = new ComputerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);

            int expected = 0;

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice P1Choice = randomRPSChoice.Get();
                RPSChoice P2Choice = randomRPSChoice.Get();
                if ((RPSP1P2Result)RPSResultExtension.Beats(P1Choice, P2Choice) == RPSP1P2Result.DRAW)
                {
                    expected++;
                }
            }
            // Act
            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
            }
            int actual = computerGame.Draws;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A list of 50 RPSP1P2Results should be returned when a when a 
        /// game with a set seed invokes PlayRound() 50 times and Player1Choice
        /// and Player2Choice are recorded. These random choices should match 
        /// what is returned when RandomRPSChoice invokes 50 Rounds of 2 
        /// Get()'s and computes the result with the same seed
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsRPSP1P2Results()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            ComputerGame computerGame = new ComputerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);

            List<RPSP1P2Result> expected = new List<RPSP1P2Result>();

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                RPSChoice P1Choice = randomRPSChoice.Get();
                RPSChoice P2Choice = randomRPSChoice.Get();
                expected.Add((RPSP1P2Result)RPSResultExtension.Beats(P1Choice, P2Choice));
            }

            // Act
            List<RPSP1P2Result> actual = new List<RPSP1P2Result>();

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
                actual.Add(computerGame.Result);
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        /// <summary>
        /// A list of 100 random RPSChoices should be returned when a when a 
        /// game with a set seed invokes PlayRound() 50 times and Player1Choice
        /// and Player2Choice are recorded. These random choices should match 
        /// what is returned when RandomRPSChoice invokes Get() 100 times with 
        /// the same set seed
        /// </summary>
        [TestMethod]
        public void PlayRound_50Rounds_returnsRandomRPSChoice()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            ComputerGame computerGame = new ComputerGame(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);

            List<RPSChoice> expected = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFROUNDS * 2; i++)
            {
                expected.Add(randomRPSChoice.Get());
            }

            // Act
            List<RPSChoice> actual = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFROUNDS; i++)
            {
                computerGame.PlayRound();
                actual.Add(computerGame.Player1Choice);
                actual.Add(computerGame.Player2Choice);
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        /// <summary>
        /// An argument exception should be encountered when PlayRound() is 
        /// invoked with one argument. It should only work with no arguments. 
        /// </summary>
        [DataTestMethod]
        [DataRow(RPSChoice.PAPER)]
        [DataRow(RPSChoice.ROCK)]
        [DataRow(RPSChoice.SCISSORS)]
        public void PlayRound_1arg_ThrowsArgumentException(RPSChoice input)
        {
            // Arrange
            ComputerGame computerGame = new ComputerGame();

            // Act
            Action actual = () => computerGame.PlayRound(input);

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
            ComputerGame computerGame = new ComputerGame();

            // Act
            Action actual = () => computerGame.PlayRound(input1, input2);

            // Assert
            Assert.ThrowsException<ArgumentException>(actual);
        }
    }
}
