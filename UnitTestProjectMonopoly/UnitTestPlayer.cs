using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectMonopoly;

namespace UnitTestProjectMonopoly
{
    [TestClass]
    public class UnitTestPlayer
    {
        [TestMethod]
        public void Test_Position_Updated()
        {
            // Arrange
            Player p1 = new Player("first player", "hat");

            // Act
            p1.Play();

            // Assert
            Assert.AreNotEqual(0, p1.Position);
        }

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
