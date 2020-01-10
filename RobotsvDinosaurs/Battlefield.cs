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

            while (herd.dinosaurs[0].health > 0 || herd.dinosaurs[1].health > 0 || herd.dinosaurs[2].health > 0 || fleet.robots[0].health > 0 || fleet.robots[1].health > 0 || fleet.robots[2].health > 0)
            {
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
                    Console.WriteLine($"{herd.dinosaurs[0]} has died!");
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
                    Console.WriteLine($"{herd.dinosaurs[1]} has died!");
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
                    Console.WriteLine($"{herd.dinosaurs[2]} has died!");
                }

            }
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
