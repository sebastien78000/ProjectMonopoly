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

        /// <summary>
        /// Access property of the variable p (read and write)
        /// </summary>
        public Player P
        {
            get { return p; }
            set { p = value; }
        }
        /// <summary>
        ///  Access property of the variable counter (read and write)
        /// </summary>
        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        /// <summary>
        /// Function to move (mandatory in the two classes stateJail and stateFree)
        /// </summary>
        public abstract void Move();
    }
}
