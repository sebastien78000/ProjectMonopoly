using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectMonopoly;

namespace UnitTestProjectMonopoly
{
    
    [TestClass]
    public class UnitTestPlayer
    {
        /// <summary>
        /// This test aims to check that when a player call Play()
        /// His position should be updated and equals to the sum of the dices
        /// Here we start at position 0.
        /// </summary>
        [TestMethod]
        public void Test_Position_Updated()
        {

            // Arrange
            Player p1 = new Player("first player", "hat");
            p1.Position = 0;
            int expectedPosition = 0;
            // Act
            p1.Play();
            expectedPosition = Dice.Value[0] + Dice.Value[1];
            // Assert
            Assert.AreEqual(expectedPosition, p1.Position);
        }

        /// <summary>
        /// This test aims to check that the Number of lap is not 
        /// updated everytime a player moves
        /// </summary>
        [TestMethod]
        public void Test_NbLap_Isnot_Changed_At_Every_Move()
        {
            // Arrange
            Player p1 = new Player("first player", "hat");

            // Act
            p1.Play();

            // Assert
            Assert.AreEqual(0, p1.NbLap);
        }

        /// <summary>
        /// This test Aims to check that the position
        /// of a player goes back to the beginning when
        /// it is the end of a lap
        /// </summary>
        [TestMethod]
        public void Test_PositionUpdated_When_EndOfLap()
        {
            //Arrange
            Player p1 = new Player("player1", "car");
            StateFree current = new StateFree(p1);
            //Act
            p1.Position = 43;
            current.StateChangeCheck(p1.Position);
            //Assert
            Assert.AreEqual(p1.Position, 3);
        }

        /// <summary>
        /// This test aims to check that when a player completes 1 lap
        /// his NbLap attribute increments
        /// </summary>
        [TestMethod]
        public void Test_NbLap_Updated_When_EndOfLap()
        {
            //Arrange
            Player p1 = new Player("player1", "car");
            StateFree current = new StateFree(p1);
            //Act
            p1.Position = 43;
            current.StateChangeCheck(p1.Position);
            //Assert
            Assert.AreEqual(p1.NbLap, 1);
        }
    }
}
