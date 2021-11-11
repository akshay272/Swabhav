using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceApp.Model;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man x = new Man();
            Boy y = new Boy();

            AtThePartyHall(x);
            AtThePartyHall(y);
            //AtTheCinemaHall(x);
            AtTheCinemaHall(y);
            Console.ReadKey();
        }

        private static void AtThePartyHall(IManeer obj)
        {
            Console.WriteLine("At the party");
            obj.Wish();
            obj.Depart();
            
        }
        private static void AtTheCinemaHall(IEmotion obj)
        {
            Console.WriteLine("At the Cinema Hall");
            obj.Cry();
            obj.Lough();
        }

        
    }
}
