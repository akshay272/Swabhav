using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventryGuitarApp.Model;
using InventryGuitarApp.Model.Enum;
namespace InventryGuitarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventry inventry = new Inventry();
            initializeInventry(inventry);
            //PrintGuitarDetails(inventry);

            Guitar whatErinLikes = new Guitar("", 0, Builder.ANY, "model2", GType.ELECTRIC, Wood.ALDER,Wood.ALDER);

            List<Guitar> guitar = inventry.Search(whatErinLikes);

            if(guitar != null)
            {
                PrintDetails(guitar);
            }
            else
            {
                Console.WriteLine("Sorry Erin, We have nothing for you");
            }

            Console.ReadKey();
        }

        private static void PrintDetails(List<Guitar> guitarList)
        {
            Console.WriteLine("==============================Match Guitars==================================");
            Console.WriteLine("Erin, you might like this \n");
            foreach (Guitar guitar in guitarList)
            {
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(guitar.GetBuilder + " " + guitar.GetModel + " " + guitar.GetType + " guitar :");
                Console.WriteLine(guitar.GetBackWood + " back and sides");
                Console.WriteLine(guitar.GetTopWood + " top.");
                Console.WriteLine("You can hae it for only $" + guitar.GetPrice + "! \n");
            }
            
        }

        private static void PrintGuitarDetails(Inventry inventry1)
        {
            Guitar guitar = inventry1.GetGuitar("S001");
            Console.WriteLine("searched element of seriel id {0}",guitar.GetSerielNumber);
            

            Console.WriteLine(guitar.GetSerielNumber);
            Console.WriteLine(guitar.GetModel);
            Console.WriteLine(guitar.GetType);
            Console.WriteLine(guitar.GetTopWood);
            Console.WriteLine(guitar.GetBackWood);
            Console.WriteLine(guitar.GetPrice);

        }

        private static void initializeInventry(Inventry inventry)
        {
            inventry.AddGuitar("S001", 2500, Builder.OLSON, "model1", GType.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.COCBOLO);
            inventry.AddGuitar("S004", 2500, Builder.MARTIN, "model2", GType.ACOUSTIC, Wood.BRAZILIAN_ROSEWOOD, Wood.COCBOLO);
            inventry.AddGuitar("S002", 3000, Builder.FENDER, "model2", GType.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventry.AddGuitar("S003", 2600, Builder.FENDER, "model3", GType.ELECTRIC, Wood.ALDER, Wood.ALDER);
        }
    }
}
