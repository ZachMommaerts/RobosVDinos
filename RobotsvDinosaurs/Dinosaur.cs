using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvDinosaurs
{
    class Dinosaur
    {
        // member variables

        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public int evadechance;
        public int hitchance;
        public int speed;

        // constructor
        public Dinosaur(string type, int health, int attackPower, int evadechance, int hitchance, int speed)
        {
            energy = 100;
            this.type = type;
            this.health = health;
            this.attackPower = attackPower;
            this.evadechance = evadechance;
            this.hitchance = hitchance;
            this.speed = speed;

        }

        // member methods

        public void DinoAttack(Robot robot)
        {
            if (robot.evadechance < hitchance)
            {
                robot.health -= attackPower;
            }
        }
    }
}
