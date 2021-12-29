using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonopoly
{
    public abstract class State
    {
        protected int counter;
        protected Player p;

        public Player P
        {
            get { return p; }
            set { p = value; }
        }
        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        public abstract void Move();
    }
}
