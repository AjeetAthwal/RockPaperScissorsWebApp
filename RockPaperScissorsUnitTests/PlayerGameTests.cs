using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class PlayerGameTests
    {
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
