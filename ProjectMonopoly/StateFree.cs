using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonopoly
{
    public class StateFree : State
    {
        public StateFree(State state) : this(state.P)
        {
            this.counter = 0;
        }
        public StateFree(Player player)
        {
            this.counter = 0;
            this.p = player;
        }

        /// <summary>
        /// Function that hnadles the calculation of the new position of the player
        /// Inclues launching the dices and check if the value of the dices is the same
        /// </summary>
        public override void Move()
        {
            p.ReRoll = false;
            Dice.Roll();
            int potentialPos = p.Position + Dice.Value[0] + Dice.Value[1];
            if (Dice.SameVal)
            {
                counter++;
                p.ReRoll = true;
            }
            else { counter = 0; }
            StateChangeCheck(potentialPos);
        }

        /// <summary>
        /// Function that checks if the state of the player needs to be changed
        /// If the number of double is equal to three or the position equal to 30 (case go to jail)
        /// if the state doesn't change the function also calculate the position if the player return to the first case.
        /// </summary>
        /// <param name="pos"></param>
        public void StateChangeCheck(int pos)
        {
            if (counter >= 3 || pos == 30)
            {
                p.State = new StateJail(this);
                p.Position = 10;
                p.ReRoll = false;
            }
            else
            {
                if (pos > 39)
                {
                    p.Position = pos - 40;
                    p.NbLap++;
                }
                else
                {
                    p.Position = pos;
                }

            }
        }
    }
}
