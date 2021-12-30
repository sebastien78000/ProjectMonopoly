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

        public Player(string name, string token)
        {
            this.name = name;
            this.token = token;
            this.state = new StateFree(this);
            this.position = 0;
            this.nbLap = 0;
            this.reRoll = true;
        }
        public State State
        {
            get { return state; }
            set { state = value; }
        }
        public string Token
        {
            get { return token; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Position
        {
            get { return position; }
            set
            {
                position = value;
            }
        }
        public int NbLap
        {
            get { return nbLap; }
            set
            {
                nbLap = value;
            }
        }

        public bool ReRoll
        {
            get { return reRoll; }
            set { reRoll = value; }
        }

        public void Play()
        {
            state.Move();
        }
    }
}
