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
