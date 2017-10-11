using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
     class HumanPlayer: Player
    {


        public override string generateRoshambo()
        {
            string play = " ";
            Console.WriteLine("Enter in rock, paper, or siccors");

            play = Console.ReadLine();
            return play;
        }
       
    }
}
