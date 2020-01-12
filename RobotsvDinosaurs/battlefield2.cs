using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvDinosaurs
{
    class battlefield2C
    {
        // member variables
        Herd herd;
        Fleet fleet;
        Dinosaur userdino;
        Robot userrobo;
        Robot enemyrobo;
        int turncounter;
        string userside;
        string dinoside;
        string roboside;

        // constructor

        public battlefield2C()
        {
            herd = new Herd();
            fleet = new Fleet();


        }

        // member methods
        public void ChooseYourSide()
        {
            while (userside != "Dinosaurs" && userside != "Decepticons")
            {
                Console.WriteLine("Choose your side: Dinosaurs or Decepticons");
                userside = Console.ReadLine();
                switch (userside)
                {
                    case "Dinosaurs":
                        Console.WriteLine("You have chosen to join the Dinosaurs!");
                        break;
                    case "Decepticons":
                        Console.WriteLine("You have chosen to join the Decepticons!");
                        break;
                    default:
                        Console.WriteLine("You did not select a valid option. Please choose again");
                        break;
                }
            }
            
        }
        public void PickYourFighter()
        {
            ChooseYourSide();

            if (userside == "Dinosaurs")
            {
                while (dinoside != "Barney" && dinoside != "Reptar" && dinoside != "Rex")
                {
                    Console.WriteLine("Choose to play as Barney, Reptar, or Rex");
                    dinoside = Console.ReadLine();
                    switch (dinoside)
                    {
                        case "Barney":
                            Console.WriteLine("You have selected Barney as your fighter!");
                            userdino = herd.dinosaurs[0];
                            break;
                        case "Reptar":
                            Console.WriteLine("You have selected Reptar as your fighter!");
                            userdino = herd.dinosaurs[1];
                            break;
                        case "Rex":
                            Console.WriteLine("You have selected Rex as your fighter!");
                            userdino = herd.dinosaurs[2];
                            break;
                        default:
                            Console.WriteLine("You did not select a valid option. Please choose again");
                            break;
                    }
                }
            }
            if (userside == "Decepticons")
            {
                while (roboside != "Megatron" && roboside != "Starscream" && roboside != "Shockwave")
                {
                    Console.WriteLine("Choose to play as Megatron, Starscream, or Shockwave");
                    roboside = Console.ReadLine();
                    switch (roboside)
                    {
                        case "Megatron":
                            Console.WriteLine("You have selected Megatron as your fighter!");
                            userrobo = fleet.robots[0];
                            break;
                        case "Starscream":
                            Console.WriteLine("You have selected Starscream as your fighter!");
                            userrobo = fleet.robots[1];
                            break;
                        case "Shockwave":
                            Console.WriteLine("You have selected Shockwave as your fighter!");
                            userrobo = fleet.robots[2];
                            break;
                        default:
                            Console.WriteLine("You did not select a valid option. Please choose again");
                            break;
                    }
                }

            }
        }
        public void TakeTurn()
        {
            if(userdino.speed >= fleet.robots[0])
            {
                userdino.DinoAttack(fleet.robots[0])
            }
            turncounter = 0;
        }

    }
}
