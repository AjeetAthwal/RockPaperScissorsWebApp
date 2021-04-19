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
