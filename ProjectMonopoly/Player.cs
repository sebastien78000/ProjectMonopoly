using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonopoly
{
    public class Player
    {
        string name;
        int position;
        string token;
        bool reRoll;
        State state;
        int nbLap;

        /// <summary>
        /// Constructor of the player class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="token"></param>
        public Player(string name, string token)
        {
            this.name = name;
            this.token = token;
            this.state = new StateFree(this);
            this.position = 0;
            this.nbLap = 0;
            this.reRoll = true;
        }

        /// <summary>
        /// Property of state
        /// </summary>
        public State State
        {
            get { return state; }
            set { state = value; }
        }
        /// <summary>
        /// Property of token
        /// </summary>
        public string Token
        {
            get { return token; }
        }
        /// <summary>
        /// Property of name
        /// </summary>
        public string Name
        {
            get { return name; }
        }
        /// <summary>
        /// Property of position
        /// </summary>
        public int Position
        {
            get { return position; }
            set
            {
                position = value;
            }
        }
        /// <summary>
        /// Property of nbLap
        /// </summary>
        public int NbLap
        {
            get { return nbLap; }
            set
            {
                nbLap = value;
            }
        }
        /// <summary>
        /// Property of reRoll
        /// </summary>
        public bool ReRoll
        {
            get { return reRoll; }
            set { reRoll = value; }
        }

        /// <summary>
        /// Launch the function Move of state and depending of the state, use the Move function of stateJail or stateFree
        /// </summary>
        public void Play()
        {
            state.Move();
        }
    }
}
