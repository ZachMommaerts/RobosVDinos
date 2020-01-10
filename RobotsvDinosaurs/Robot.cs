using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvDinosaurs
{
    class Robot
    {
        // member variables

        public string name;
        public int health;
        public int pwrlvl;
        public Weapon weapon;
        public int attackPower;
        public int evadechance;
        public int hitchance;
        public int speed;

        // constructor

        public Robot(string name, int health, int attackPower, int evadechance, int hitchance, int speed, Weapon weapon)
        {
            this.pwrlvl = 100;
            this.name = name;
            this.health = health;
            this.attackPower = attackPower;
            this.evadechance = evadechance;
            this.hitchance = hitchance;
            this.speed = speed;
            this.weapon = weapon;

        }
        // member methods

        public void RoboAttack(Dinosaur dinosaur)
        {
            if (dinosaur.evadechance < hitchance)
            {
                dinosaur.health -= attackPower;
            }
        }
    }
}
