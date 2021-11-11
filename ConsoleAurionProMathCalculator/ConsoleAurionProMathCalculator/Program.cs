using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AurionProMathCalculator;


namespace ConsoleAurionProMathCalculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            Model model = new Model();
            CaseStudy1(model);
            CaseStudy2(model);
            CaseStudy3(model);
            
            Console.ReadKey();
        }

        private static void CaseStudy3(Model model)
        {
            int limit = 50;
            int[] primeArray = model.GeneratePrimeNo(limit);
            Console.WriteLine("prime NO till {0}", limit);
            
            foreach (int i in primeArray)
            {
                if(i == 0)
                {
                    break;
                }
                else
                {
                    Console.Write(i + " ");
                }
                
            }
            Console.WriteLine(" ");
        }

        private static void CaseStudy1(Model model)
        {
            if (model.CheckPrimeNo(23) == true)
            {
                Console.WriteLine("The number is prime ");
            }
            else
            {
                Console.WriteLine("The number is not Prime");
            }
            Console.WriteLine(" ");
        }

        
        private static void CaseStudy2(Model model)
        {
            int limit = 75;
            int[] evenArray = model.GenerateEvenNo(limit);
            Console.WriteLine("Even NO till {0}", limit);
            foreach(int i in evenArray)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine(" ");
        }
    }
}
