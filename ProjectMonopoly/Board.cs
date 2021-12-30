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

        public static Board GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Board();
            }
            return _instance;
        }

        public List<Case> BoardList
        {
            get { return this.boardList; }
            set { this.boardList = value; }
        }
    }
}
