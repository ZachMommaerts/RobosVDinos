﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvDinosaurs
{
    class Fleet
    {
        // member variables
        public List<Robot> robots;

        Weapon railgun = new Weapon("railguin", 20);

        Weapon sword = new Weapon("sword", 10);

        Weapon laser = new Weapon("laser", 30);


        //constructor
        public Fleet()
        {
            robots = new List<Robot>();
            
            Robot megatron = new Robot("megatron", 120, 30, 0, 70, 40, railgun);

            robots.Add(megatron);

            Robot starscream = new Robot("starscream", 160, 20, 0, 80, 30, sword);

            robots.Add(starscream);

            Robot shockwave = new Robot("shockwave", 100, 10, 0, 90, 60, laser);

            robots.Add(shockwave);
        }

        //member methods


    }
}
