using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovableApp.Model;

namespace MovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movables = new IMovable[3];
            movables[0] = new Car();
            movables[1] = new Truck();
            movables[2] = new Bike();
            
            StartRace(movables);
            Console.ReadKey();
            
        }

        private static void StartRace(IMovable[] movables)
        {
            foreach(IMovable moves in movables)
            {
                moves.Move();
            }
        }
    }
}
