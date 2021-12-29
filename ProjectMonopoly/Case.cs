using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonopoly
{
    public class Case
    {
        string name;
        int index;

        public Case(string name, int index)
        {
            this.name = name;
            this.index = index;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
        }


    }
}
