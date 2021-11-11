using System;
using System.Collections;
using HeadFirstJavaChptr_6_11.Chapter7;
using HeadFirstJavaChptr_6_11.Chapter8;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstJavaChptr_6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Chapter6();
            Chapter7();
            Chapter8();
            Console.ReadKey();
        }

        private static void Chapter8()
        {
            Console.WriteLine("Polymorphism>>>>>>");
            Polymorphism poly = new Polymorphism();
            poly.Print(45);
            poly.Print(75.65f);
            poly.Print(452442.655954663);
            poly.Print('A');
            poly.Print(true);
            poly.Print("Hello my name is Akshay ");
            Console.WriteLine(" ");
            
        }

        private static void Chapter7()
        {
            // inheritence
            Console.WriteLine("Inheritence>>>>");
            Doctor doctor = new Doctor();
            doctor.treatPetient();
            Surgeon surgeon = new Surgeon();
            surgeon.makeIncision();
            surgeon.treatPetient();
            FamilyDoctor fdoctor = new FamilyDoctor();
            fdoctor.GiveAdvice();
            fdoctor.treatPetient();
            Console.WriteLine(" ");

        }

        private static void Chapter6()
        {
            //Arraylist
            ArrayList aList = new ArrayList();
            aList.Add(95);
            aList.Add(15);
            aList.Add(85);
            aList.Add(12);
            aList.RemoveAt(1);

            aList.Sort();
            
            Console.WriteLine("Count : {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);
            Console.WriteLine("is read-only : {0}", aList.IsReadOnly);
            Console.WriteLine("is Fixed-Size : {0}", aList.IsFixedSize);

            foreach(int element in aList)
            {
                Console.WriteLine("{0}",element);
            }
            Console.WriteLine(" ");
            
        }
    }
}
