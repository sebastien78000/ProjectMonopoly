using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonopoly
{
    public sealed class Board
    {
        List<Case> boardList = new List<Case>();

        /// <summary>
        /// Constructor of the class Board, can only be called once
        /// Create a list of 40 cases
        /// </summary>
        private Board()
        {
            for (int i = 0; i < 40; i++)
            {
                nameCase recup = (nameCase)i;
                string temp = recup.ToString();
                Case cases = new Case(temp, i);
                boardList.Add(cases);
            }

        }
        private static Board _instance;

        /// <summary>
        /// Function that checks the existence of an object Board
        /// </summary>
        /// <returns></returns>
        public static Board GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Board();
            }
            return _instance;
        }

        /// <summary>
        /// Property of the attribute boardList (read only)
        /// </summary>
        public List<Case> BoardList
        {
            get { return this.boardList; }
        }
    }
}
