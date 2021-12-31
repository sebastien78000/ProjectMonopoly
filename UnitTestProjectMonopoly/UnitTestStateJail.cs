using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectMonopoly;

namespace UnitTestProjectMonopoly
{
    [TestClass]
    public class UnitTestStateJail
    {
        /// <summary>
        /// This test aims to check that 
        /// the position of a player is updated when he
        /// has waited for the third time
        /// </summary>
        [TestMethod]
        public void Test_UpdatedPosition_When_OutOfJail()
        {
            //Arrange
            Player p1 = new Player("player1", "car");
            StateJail current = new StateJail(p1);
            //Act
            current.Counter = 3;
            p1.Position = 10;
            Dice.Roll();
            current.StateChangeCheck();
            //Assert
            Assert.AreNotEqual(p1.Position, 10);
        }

        /// <summary>
        /// This state aims to check that the state of a player
        /// changes from Jail to Free when he waited 3 turns in jail
        /// </summary>
        [TestMethod]
        public void Test_State_Updated_When_In_Jail()
        {
            // Arrange
            Player p1 = new Player("first player", "hat");
            StateFree free = new StateFree(p1);
            StateJail jail = new StateJail(p1);
            // Act
            p1.State = jail;
            p1.Position = 10;
            jail.Counter = 3;
            jail.StateChangeCheck();

            // Assert
            Assert.IsInstanceOfType(p1.State, free.GetType());
        }
    }
}
