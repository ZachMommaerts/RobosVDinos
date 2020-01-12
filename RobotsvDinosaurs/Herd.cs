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
        public List<Dinosaur> dinosaurs;
        public Dinosaur dinosaur;

        //constructor

        public Herd()
        {
        dinosaurs = new List<Dinosaur>();

        Dinosaur barney = new Dinosaur("barney", 120, 30, 0, 70, 40);

        dinosaurs.Add(barney);

        Dinosaur reptar = new Dinosaur("reptar", 160, 20, 0, 80, 30);

        dinosaurs.Add(reptar);

        Dinosaur rex = new Dinosaur("rex", 100, 10, 50, 0, 60);

        dinosaurs.Add(rex);
        }

        //member methods

        
        
        
    }
}
