using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectMonopoly;

namespace UnitTestProjectMonopoly
{
    [TestClass]
    public class UnitTestStateFree
    {
        /// <summary>
        /// This test aims to check that the players goes to jail when 
        /// played thrice in a row
        /// </summary>
        [TestMethod]
        public void Test_InJail_When_Played3times_InARow()
        {
            //Arrange
            Player p1 = new Player("player1", "car");
            StateFree current = new StateFree(p1);
            //Act
            current.Counter = 3;
            current.StateChangeCheck(p1.Position);
            //Assert
            Assert.AreEqual(p1.Position, 10);
        }

        /// <summary>
        /// this test aims to check that a player
        /// goes to jail when landing on "go to jail
        /// </summary>
        [TestMethod]
        public void Test_InJail_When_On_GoToJail_Case()
        {
            //Arrange
            Player p1 = new Player("player1", "car");
            StateFree current = new StateFree(p1);
            //Act
            p1.Position = 30;
            current.StateChangeCheck(p1.Position);
            //Assert
            Assert.AreEqual(p1.Position, 10);
        }

        /// <summary>
        /// This test aims to check that 
        /// the state of the player isn't changed when should not.
        /// </summary>
        [TestMethod]
        public void Test_State_Not_Updated_At_Every_Move()
        {
            // Arrange
            Player p1 = new Player("first player", "hat");
            StateFree free = new StateFree(p1);
            // Act
            p1.Play();

            // Assert
            Assert.IsInstanceOfType(p1.State, free.GetType());
        }

        /// <summary>
        /// This test aims to check that the state of a player 
        /// changes from Free to Jail when he lands on "Go to jail"
        /// </summary>
        [TestMethod]
        public void Test_State_Updated()
        {
            // Arrange
            Player p1 = new Player("first player", "hat");
            StateFree free = new StateFree(p1);
            StateJail jail = new StateJail(p1);
            // Act
            p1.Position = 30;
            free.StateChangeCheck(p1.Position);

            // Assert
            Assert.IsInstanceOfType(p1.State, jail.GetType());
        }
    }
}
