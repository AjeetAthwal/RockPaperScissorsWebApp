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
        /// <summary>
        /// Helper function that generates a random seed
        /// </summary>
        private static int GetSeed()
        {
            Random r1 = new Random();
            int seed = r1.Next();
            return seed;
        }

        /// <summary>
        /// A random RSPChoice should be returned when RandomRPSChoice with a 
        /// set seed invokes Get(). This random choice should match what is 
        /// returned when, with the same set seed, an RPSChoice is generated
        /// using Random.Next()
        /// </summary>
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

        /// <summary>
        /// A list of 100 random RSPChoices should be returned when 
        /// RandomRPSChoice with a set seed invokes Get() 100 times. This 
        /// list of random choicea should match what is returned when, with the
        /// same set seed, an RPSChoice is generated using Random.Next() 100 
        /// times
        /// </summary>
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
