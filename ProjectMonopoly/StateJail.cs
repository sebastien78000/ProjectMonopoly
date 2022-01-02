using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonopoly
{
    public class StateJail : State
    {
        /// <summary>
        /// constructor of the stateFree class with parameter state
        /// </summary>
        /// <param name="state"></param>
        public StateJail(State state) : this(state.P)
        {
            this.counter = 0;
        }
        /// <summary>
        /// constructor of the stateFree class with parameter player
        /// </summary>
        /// <param name="player"></param>
        public StateJail(Player player)
        {
            this.counter = 0;
            this.p = player;
        }

        /// <summary>
        /// Function that hnadles the calculation of the new position of the player when in jail
        /// Includes launching the dices and check if the value of the dices is the same or the number of turn in prison equal to three
        /// </summary>
        public override void Move()
        {
            Dice.Roll();
            counter++;
            StateChangeCheck();
            p.ReRoll = false;
        }

        /// <summary>
        /// Function that checks if the state of the player needs to be changed
        /// If the number of double is equal to one or the number of turn in prison (counter)
        /// if the state doesn't change the function also calculate the position if the player return to the first case.
        /// </summary>
        public void StateChangeCheck()
        {
            if (counter >= 3 || Dice.SameVal)
            {
                p.State = new StateFree(this);
                int pos = p.Position + Dice.Value[0] + Dice.Value[1];

            }
        }
    }
}
