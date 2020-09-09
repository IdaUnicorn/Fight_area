using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_area
{
    class Harry
    {
        /// class variables
        public double hitpoints;// properties
        public double attack;
        public double defence;
  
        //laver constructors 
        public Harry(double Hitpoints, double Attack, double Defence)
        { 
            hitpoints = Hitpoints;
            attack = Attack;
            defence = Defence;
        }
        public int Hitpoints { get; set; }
        public string Attack { get; set; }
        public string Defence { get; set; }

    }

}
