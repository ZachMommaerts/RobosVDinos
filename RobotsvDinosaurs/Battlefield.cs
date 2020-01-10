using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvDinosaurs
{
    class Battlefield
    {
        // member variables
        Herd herd;
        Fleet fleet;
        int min;
        int max;

        // constructor

        public Battlefield()
        {
            herd = new Herd();

            fleet = new Fleet();
        }

        // member methods
        public int RandomGenerator(int min, int max)
        {
            Random rng = new Random();
            int numberone = rng.Next();
            return numberone;
        }
    }
}
