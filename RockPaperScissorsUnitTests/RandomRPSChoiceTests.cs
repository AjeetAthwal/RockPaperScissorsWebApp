using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissorsUnitTests
{
    [TestClass]
    public class RandomRPSChoiceTests
    {
        private static int GetSeed()
        {
            Random r1 = new Random();
            int seed = r1.Next();
            return seed;
        }

        [TestMethod]
        public void Get_SingleGet_ReturnsSameRPSChoice()
        {
            // Assign
            int seed = GetSeed();
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);
            Random r = new Random(seed);
            RPSChoice expected = (RPSChoice)r.Next(0, Enum.GetValues(typeof(RPSChoice)).Length);

            // Act
            RPSChoice actual = randomRPSChoice.Get();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_HundredGets_ReturnsSameRPSChoice()
        {
            // Assign
            int NUMBEROFGETS = 100;
            int seed = GetSeed();
            RandomRPSChoice randomRPSChoice = new RandomRPSChoice(seed);
            Random r = new Random(seed);
            List<RPSChoice> expected = new List<RPSChoice>();

            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                expected.Add((RPSChoice)r.Next(0, Enum.GetValues(typeof(RPSChoice)).Length));
            }

            // Act
            List<RPSChoice> actual = new List<RPSChoice>();
            for (int i = 0; i < NUMBEROFGETS; i++)
            {
                actual.Add(randomRPSChoice.Get());
            }

            // Assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
