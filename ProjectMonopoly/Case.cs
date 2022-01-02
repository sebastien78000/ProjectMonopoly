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

        /// <summary>
        /// Constructor of the class Case
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        public Case(string name, int index)
        {
            this.name = name;
            this.index = index;
        }

        /// <summary>
        /// Access property of attribute name (read and write)
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Access property of attribute index (read and write)
        /// </summary>
        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
        }


    }
}
