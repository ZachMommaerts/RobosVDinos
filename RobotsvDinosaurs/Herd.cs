using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvDinosaurs
{
    class Herd
    {
        // member variables
        List<Dinosaur> dinosaurs;

        //constructor
        Dinosaur barney = new Dinosaur("barney", 120, 30, 40, 70, 40);

        Dinosaur reptar = new Dinosaur("reptar", 160, 20, 30, 80, 30);

        Dinosaur rex = new Dinosaur("rex", 100, 10, 50, 90, 60);

        //member methods

        public Herd(List<Dinosaur> dinosaurs)
        {    
            foreach (Dinosaur dinosaur in dinosaurs)
            {
                Console.WriteLine($"{dinosaur.type}");
            }
        }

        
        
        
    }
}
