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

        static public void Roll()
        {
            value[0] = dice.Next(1, 7);
            value[1] = dice.Next(1, 7);
        }

        static public int[] Value { get => value; }
        static public bool SameVal { get => Dice.Value[0] == Dice.Value[1]; }

    }
}
