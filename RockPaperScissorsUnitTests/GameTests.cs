using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class GameTests
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


        [TestMethod]
        public void PlayRound_50Rounds_returnsRandomRPSChoice()
        {
            // Arrange
            int NUMBEROFROUNDS = 50;
            int seed = CreateSeed();
            Game game = new Game(GameState.COMPUTERVSCOMPUTER, seed);
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
                game.playRound(0,0);
                actual.Add(game.Player1Choice);
                actual.Add(game.Player2Choice);
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
