using GoodDogTestDrive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodDogTestDrive
{
    class GoodDogTest
    {
        static void Main(string[] args)
        {
            GoodDog one = new GoodDog();
            one.SetSize(10);
            GoodDog two = new GoodDog();
            two.SetSize(50);
            Console.WriteLine("Dog one : " + one.GetSize());
            Console.WriteLine("Dog two : " + two.GetSize());
            one.Bark();
            two.Bark();
            Console.ReadKey();
        }
    }
}
