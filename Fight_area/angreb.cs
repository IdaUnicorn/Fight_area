using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_area
{
    class Mikkel
    {
        /// class variables
        private double hitpoints;
        private double attack;
        private double defence;

        //laver constructors 
        public Mikkel(double Hitpoints, double Attack, double Defence)
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
