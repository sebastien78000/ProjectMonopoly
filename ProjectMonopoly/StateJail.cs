using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonopoly
{
    public class StateJail : State
    {
        public StateJail(State state) : this(state.P)
        {
            this.counter = 0;
        }
        public StateJail(Player player)
        {
            this.counter = 0;
            this.p = player;
        }
        public override void Move()
        {
            Dice.Roll();
            counter++;
            StateChangeCheck();
            p.ReRoll = false;
        }

        public void StateChangeCheck()
        {
            if (counter >= 3 || Dice.SameVal)
            {
                p.State = new StateFree(this);
                int pos = p.Position + Dice.Value[0] + Dice.Value[1];
                if (pos > 40)
                {
                    p.Position = pos - 40;
                }
                else
                {
                    p.Position = pos;
                }
            }
        }
    }
}
