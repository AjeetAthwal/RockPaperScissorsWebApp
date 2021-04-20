using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class ComputerTests
    {
        /// <summary>
        /// Helper function that generates a computer with no wins. Tested using Wins_ComputerWithNoWins_returnsZeroWins
        /// </summary>
        private Computer CreateComputerWithNoWins()
        {
            RandomRPSChoice r = new RandomRPSChoice();
            return new Computer(r);
        }

        /// <summary>
        /// Helper function that generates a computer with no wins and a set seed. Tested using Wins_ComputerWithNoWinsAndSetSeed_returnsZeroWins
        /// </summary>
        private Computer CreateComputerWithNoWinsAndSetSeed(int seed)
        {
            RandomRPSChoice r = new RandomRPSChoice(seed);
            return new Computer(r);
        }

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
        /// Helper function that generates a computer with wins. Tested using Wins_ComputerWithWins_returnsMoreThanZeroWins
        /// </summary>
        private Computer CreateComputerWithWins()
        {
            Computer computer = CreateComputerWithNoWins();
            computer.AddWin();
            return computer;
        }

        /// <summary>
        /// Zero should be returned when a computer with no wins has its property Wins called
        /// </summary>
        [TestMethod]
        public void Wins_ComputerWithNoWins_returnsZeroWins()
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();
            int expected = 0;

            // Act
            int actual = computer.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Zero should be returned when a player with no wins has its property Wins called
        /// </summary>
        [TestMethod]
        public void Wins_ComputerWithNoWinsAndSetSeed_returnsZeroWins()
        {
            // Arrange
            int seed = CreateSeed();
            Computer computer = CreateComputerWithNoWinsAndSetSeed(seed);
            int expected = 0;

            // Act
            int actual = computer.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// One should be returned when a computer with no wins invokes AddWin() and its property Wins called
        /// </summary>
        [TestMethod]
        public void AddWin_ComputerWithNoWins_returnsOneWin()
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();
            int expected = 1;

            // Act
            computer.AddWin();
            int actual = computer.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A number greater than 0 should be returned when a computer with wins has its property Wins called
        /// </summary>
        [TestMethod]
        public void Wins_ComputerWithWins_returnsMoreThanZeroWins()
        {
            // Arrange
            Computer computer = CreateComputerWithWins();
            int expectedGreaterThan = 0;

            // Act
            int actual = computer.Wins;

            // Assert
            Assert.IsTrue(actual > expectedGreaterThan);
        }

        /// <summary>
        /// 0 should be returned when a computer with no wins invokes ResetWins() and its property Wins called
        /// </summary>
        [TestMethod]
        public void ResetWins_ComputerWithNoWins_returnsZeroWins()
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();
            int expected = 0;

            // Act
            computer.ResetWins();
            int actual = computer.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 0 should be returned when a computer with wins invokes ResetWins() and its property Wins called
        /// </summary>
        [TestMethod]
        public void ResetWins_ComputerWithWins_returnsZeroWins()
        {
            // Arrange
            Computer computer = CreateComputerWithWins();
            int expected = 0;

            // Act
            computer.ResetWins();
            int actual = computer.Wins;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A list of 100 random RSPChoices should be returned when a computer 
        /// with no wins and a set seed invokes GetRPSChoice() 100 times. These
        /// random choices should match what is returned when RandomRPSChoice
        /// invokes Get() 100 times with the same set seed
        /// </summary>
        [TestMethod]
        public void GetRPSChoice_100Rounds_returnsRandomRPSChoice()
        {
            // Arrange
            int NUMBEROFGETS = 100;
            int seed = CreateSeed();
            Computer computer = CreateComputerWithNoWinsAndSetSeed(seed);
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);

            List<RPSChoice> expected = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                expected.Add(randomRPSChoice.Get());
            }

            // Act
            List<RPSChoice> actual = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                actual.Add(computer.GetRPSChoice());
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        /// <summary>
        /// An argument exception should be encountered when GetRPSChoice() is 
        /// invoked with one argument. It should only work with no arguments. 
        /// </summary>
        [DataTestMethod]
        [DataRow(RPSChoice.PAPER)]
        [DataRow(RPSChoice.ROCK)]
        [DataRow(RPSChoice.SCISSORS)]
        public void GetRPSChoice_1arg_ThrowsArgumentException(RPSChoice input)
        {
            // Arrange
            Computer computer = CreateComputerWithNoWins();

            // Act
            Action actual = () => computer.GetRPSChoice(input);

            // Assert
            Assert.ThrowsException<ArgumentException>(actual);
        }
    }
}
