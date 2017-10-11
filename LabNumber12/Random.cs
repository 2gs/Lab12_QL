using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    class RandomPlayer: Player
    {
        public override string generateRoshambo()
        {
            

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int num =  rnd.Next(1, 4);
   
            if(num == 1)
            {
              return ("Rock");
            }
            else if(num == 2)
            {
               return ("Paper");
            }
            else 
            {
                return ("Siccors");
            }
       
        }
    }
}
