using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectMonopoly;

namespace UnitTestProjectMonopoly
{
    [TestClass]
    public class UnitTestStateJail
    {

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
    }
}
