using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_area
{
    public class Program
    {


        static void Main(string[] args)
        {
            double Harry_hitpoints = 120; // hitpoints, attack, defence for Harry.
            double Harry_attack = 2; 
            double Harry_defence = 5;
            
            double Mikkel_hitpoints = 40; // hitpoints, attack, defence for Mikkel.
            double Mikkel_attack = 9;
            double Mikkel_defence = 9;

            while (Harry_hitpoints > 0 && Mikkel_hitpoints > 0)
            {
                Console.WriteLine("Harrys hitpoints before attack are " + Harry_hitpoints + ".");
                Console.WriteLine("Mikkels hitpoints before attack are " + Mikkel_hitpoints + ".");

                Harry_hitpoints = Harry_hitpoints - (Harry_defence - Mikkel_attack);
                Mikkel_hitpoints = Mikkel_hitpoints - (Mikkel_defence - Harry_attack);

                Console.WriteLine("After the attack the hit points are: Harry: " + Harry_hitpoints + " and Mikkel: " + Mikkel_hitpoints + ".");
                Console.WriteLine();

            }
            if (Mikkel_hitpoints <= 0)
            {
                Console.WriteLine("Kong Fu Harry won and Minimusen Mikkel lost");
                Console.WriteLine("Harrys hitpoints are " + Harry_hitpoints);
                Console.WriteLine("Mikkels hitpoints are " + Mikkel_hitpoints);
                Console.ReadKey();
            }

            else if (Harry_hitpoints <= 0)
            {
                Console.WriteLine("Minimusen Mikkel won and Kong Fu HArry lost");
                Console.WriteLine("Harrys hitpoints are " + Harry_hitpoints);
                Console.WriteLine("Mikkels hitpoints are " + Mikkel_hitpoints);
                Console.ReadKey();
            }
            else;
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }

            List<string> WinnerRange = new List<string>(WinnerOfKvartfinale);
            if (Harry_hitpoints > Mikkel_hitpoints)
            {
                Harry_hitpoints = WinnerOfKvartfinale; 
            }
            else (Mikkel_hitpoints > Harry_hitpoints)
            {
                Mikkel_hitpoints = WinnerOfKvartfinale;
            }

            //min ide er at vinderen af første runde får navnet WinnerOfKvartfinale, denne kæmper så videre imod næste modstander
            //vinderen af denne kamp kommer til at hedde WinnerOfSemifinale, denne kæmper så mod næste modstander indtil der er fundet en vinder.
        }




    }
}

