using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonopoly
{
    public class Dice
    {
        static private Random dice = new Random();
        static int[] value = new int[2];

        /// <summary>
        /// Function to change the value of the dices
        /// </summary>
        static public void Roll()
        {
            value[0] = dice.Next(1, 7);
            value[1] = dice.Next(1, 7);
        }

        /// <summary>
        /// Property in read only of attribute value containing the value of the two dices
        /// </summary>
        static public int[] Value { get => value; }

        /// <summary>
        /// Property in read only to get a bool if the two dices are equal
        /// </summary>
        static public bool SameVal { get => Dice.Value[0] == Dice.Value[1]; }

    }
}
