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
                energy -= 10;
                Console.WriteLine($"{type} attacks {robot.name} for {attackPower}");
            }
            if (energy <= 0)
            {
                robot.health -= 0;
                Console.WriteLine($"{type} tried to attack {robot.name} but is out of power");
                energy += 20;
            }
            if (health <= 0)
            {
                return;
            }
            else
            {
                robot.health -= 0;
                Console.WriteLine($"{type} missed their attack on {robot.name}");
            }
        }
        public int RandomGenerator(int min, int max)
        {
            Random rng = new Random();
            int random = rng.Next();
            return random;
        }
    }
        
    
}
