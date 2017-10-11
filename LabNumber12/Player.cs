using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12
{
    abstract class Player
    {
        protected string name;
        protected string roshambo;
      
        
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }

        public string Roshambo
        {
            set { this.roshambo = value; }
            get { return roshambo; }
        }

        public Player()
        {
            this.name = " ";
        }
        public Player(string playername)
        {
            this.name = playername;
        }

        public abstract string generateRoshambo();


    }
}
