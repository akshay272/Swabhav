using System;
using PolymorphismApp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismApp;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Polymorphism1();
            Inheritence();
            Console.ReadKey();
        }

        private static void Inheritence()
        {
            Console.WriteLine("Doctor -->>");
            Doctor doctor = new Doctor();
            doctor.treatPetient();
            Console.WriteLine("Surgeon-->>");
            Surgeon surgeon = new Surgeon();
            surgeon.makeIncision();
            surgeon.treatPetient();
            Console.WriteLine("Family Doctor-->>");
            FamilyDoctor fDoctor = new FamilyDoctor();
            fDoctor.treatPetient();
            fDoctor.GiveAdvice();
        }

        private static void Polymorphism1()
        {
            Polymorphism poly = new Polymorphism();
            poly.Print(55);
            poly.Print(675.554f);
            poly.Print(454525.684558);
            poly.Print(true);
            poly.Print("Hello Iam Akshay");
            poly.Print('A');
            
        }
    }
}
