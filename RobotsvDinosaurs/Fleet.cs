using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvDinosaurs
{
    class Fleet
    {
        // member variables
        List<Robot> robots;

        //constructor
        Weapon railguin = new Weapon("railguin", 20);

        Weapon sword = new Weapon("sword", 10);

        Weapon laser = new Weapon("laser", 30);

        Robot megatron = new Robot("megatron", 120, 30, 40, 70, 40);

        Robot starscream = new Robot("starscream", 160, 20, 30, 80, 30);

        Robot shockwave = new Robot("shockwave", 100, 10, 50, 90, 60);

        //member methods
        public Fleet(List<Robot> robots)
        {
            foreach (Robot robot in robots)
            {
                Console.WriteLine($"{robot.name}");
            }
        }


    }
}
