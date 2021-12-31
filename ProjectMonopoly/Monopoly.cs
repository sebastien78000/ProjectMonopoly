using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonopoly
{
    public class Monopoly
    {
        static Monopoly instance;
        List<Player> participants = new List<Player>();
        Board board;

        // Lock synchronization object
        private static object locker = new object();
        // Constructor (protected)
        protected Monopoly()
        {
            this.board = Board.GetInstance();
            Console.WriteLine("how many players ? Between 2 and 4 please");
            int nbPlayers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nbPlayers; i++)
            {
                Console.WriteLine("Player n°" + i + "\nWhat's your name : ");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("What's your token");
                string token = Console.ReadLine();
                Player player = new Player(name, token);
                participants.Add(player);
            }
        }
        public static Monopoly GetMonopoly()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Monopoly();
                    }
                }
            }
            return instance;
        }

        public string showGame()
        {
            string s = "";
            for (int i = 0; i < participants.Count; i++)
            {
                s += "- " + participants[i].Name + " position:" + participants[i].Position + "\n";
            }
            return s;
        }
        public void Play()
        {
            bool b = true;
            for (int tour = 0; tour <= 5 || b == false; tour++)
            {
                Console.WriteLine("tour nb°" + tour + "\n");
                Console.WriteLine(showGame());
                for (int i = 0; i < participants.Count; i++)
                {
                    Console.WriteLine("\nPlayer n°" + i + " turn !");
                    do
                    {
                        Console.WriteLine("\npress enter to throw the dices -->");
                        Console.ReadKey();
                        participants[i].Play();
                        Console.WriteLine(Dice.Value[0] + " " + Dice.Value[1] + " count:" + participants[i].State.Counter);
                        if (participants[i].ReRoll) Console.WriteLine("continue");
                    }
                    while (participants[i].ReRoll);
                }
                //Console.Clear();
            }
            Console.WriteLine("The end !");
        }
    }
}
