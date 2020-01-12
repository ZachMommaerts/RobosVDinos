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
        public void DoBattle()
        {
            while (herd.dinosaurs[0].health > 0 || herd.dinosaurs[1].health > 0 || herd.dinosaurs[2].health > 0 || fleet.robots[0].health > 0 || fleet.robots[1].health > 0 || fleet.robots[2].health > 0)
            {
                if(herd.dinosaurs[0].speed > fleet.robots[0].speed)
                {
                    herd.dinosaurs[0].DinoAttack(fleet.robots[0]);
                }
                else
                {
                    fleet.robots[0].RoboAttack(herd.dinosaurs[0]);
                }
                herd.dinosaurs[0].DinoAttack(fleet.robots[0]);

                fleet.robots[0].RoboAttack(herd.dinosaurs[0]);
                if (fleet.robots[0].health <= 0)
                {
                    herd.dinosaurs[0].DinoAttack(fleet.robots[1]);
                    Console.WriteLine($"{fleet.robots[0].name} has powered down!");
                }
                if (herd.dinosaurs[0].health <= 0)
                {
                    fleet.robots[0].RoboAttack(herd.dinosaurs[1]);
                    Console.WriteLine($"{herd.dinosaurs[0].type} has died!");
                }
                herd.dinosaurs[1].DinoAttack(fleet.robots[1]);

                fleet.robots[1].RoboAttack(herd.dinosaurs[1]);
                if (fleet.robots[0].health <= 0)
                {
                    herd.dinosaurs[1].DinoAttack(fleet.robots[2]);
                    Console.WriteLine($"{fleet.robots[1].name} has powered down!");
                }
                if (herd.dinosaurs[1].health <= 0)
                {
                    fleet.robots[1].RoboAttack(herd.dinosaurs[2]);
                    Console.WriteLine($"{herd.dinosaurs[1].type} has died!");
                }
                herd.dinosaurs[2].DinoAttack(fleet.robots[2]);

                fleet.robots[2].RoboAttack(herd.dinosaurs[2]);
                if (fleet.robots[0].health <= 0)
                {
                    herd.dinosaurs[2].DinoAttack(fleet.robots[0]);
                    Console.WriteLine($"{fleet.robots[2].name} has powered down!");
                }
                if (herd.dinosaurs[2].health <= 0)
                {
                    fleet.robots[2].RoboAttack(herd.dinosaurs[0]);
                    Console.WriteLine($"{herd.dinosaurs[2].type} has died!");
                }

            }
            if (herd.dinosaurs[0].health > 0 || herd.dinosaurs[1].health > 0 || herd.dinosaurs[2].health > 0)
            {
                Console.WriteLine("Dinosaurs are victorious!!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Decepticons are victorious!!!");
                Console.ReadLine();
            }

        }


    }
}
