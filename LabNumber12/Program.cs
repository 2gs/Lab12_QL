using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanPlayer humanPlayer = new HumanPlayer();
            RockPlayer rockPlayer = new RockPlayer();
            //    RandomPlayer randomPlayer = new RandomPlayer();

            string name = " ";
            string answer = " ";
            string choice = " ";
            bool keep = true;
            while (keep)
            {
                Console.WriteLine("Welcome to the Rock, Paper,Scissors");
                Console.WriteLine("Enter in your name");
                name = Console.ReadLine();
                Console.WriteLine(name + "wants to play my game, step up then!!!");


                Console.WriteLine("Who do you want to play against TheJets or TheSharks (j/s)");
                answer = Console.ReadLine();
                if (answer == "j")
                {
                    Console.WriteLine("Your are playing Thejets");
                }
                else if (answer == "s")
                {
                    Console.WriteLine("Your are playing TheSharks");

                }

                int tie, win, lose;
                tie = win = lose = 0;

                string p1 = humanPlayer.generateRoshambo();
                string p2 = rockPlayer.generateRoshambo();

                if (p1 == p2)
                {
                    Console.WriteLine("There was a Tie");
                    tie++;

                }
                else if (p1 != p2)
                {
                    Console.WriteLine("You lost my friend, get ya reps up!!");
                    lose++;
                }
                else
                {
                    Console.WriteLine(name + "You won my friend, true champ or did you get lucky?");
                    win++;

                }

                Console.WriteLine("Do you want play again? y or n");
                choice = Console.ReadLine();
                if (choice == "Y")
                {
                    keep = true;
                }
                else if (choice == "N")
                {
                    Console.WriteLine("You have quitted" + " " + name);
                    Console.WriteLine("The score was" + " " + "# of wins:" + win + " " + "# of losses:" + lose + " " + "# of ties" + tie);
                    keep = false;
                }


            }
        }
    }
}
