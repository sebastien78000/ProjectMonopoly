using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectMonopoly;

namespace UnitTestProjectMonopoly
{
    [TestClass]
    public class UnitTestStateFree
    {
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
