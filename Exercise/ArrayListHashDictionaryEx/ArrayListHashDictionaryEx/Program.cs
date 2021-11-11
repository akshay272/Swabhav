using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayListHashDictionaryEx.Model;


namespace ArrayListHashDictionaryEx
{
    class Program
    {
        static void Main(string[] args)
        {

            CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();

        }

        private static void CaseStudy1()
        {
            ArrayList1 arrayList = new ArrayList1();

            while (true)
            {
                Console.WriteLine("---------------Main Menu-------------");
                Console.WriteLine(" 1 : Create");
                Console.WriteLine(" 2 : Read");
                Console.WriteLine(" 3 : Update ");
                Console.WriteLine(" 4 : Delete ");
                Console.WriteLine("enter a choice : ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("add eleent");
                        int input1 = Convert.ToInt32(Console.ReadLine());
                        arrayList.Add(input1);
                        break;
                        
                    case 2:
                        arrayList.Read();
                        break;

                    case 3:
                        Console.WriteLine(" enter position and element ");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        int input3 = Convert.ToInt32(Console.ReadLine());
                        arrayList.Update(input2, input3);
                        break;

                    case 4:
                        Console.WriteLine("enter index to delete element");
                        int input4 = Convert.ToInt32(Console.ReadLine());
                        arrayList.Delete(input4);
                        break;
                }
            }
        }

        private static void CaseStudy2()
        {
            Dictionary1 dictionary = new Dictionary1();
            Console.WriteLine("Dictionary");
            while (true)
            {
                Console.WriteLine("---------------------------Main Menu--------------------------");
                Console.Write(" 1 : Create \t");
                Console.Write(" 2 : Read \t");
                Console.Write(" 3 : Update \t");
                Console.Write(" 4 : Delete \n");
                Console.WriteLine("enter a choice : ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("add eleent");
                        int keyInput = Convert.ToInt32(Console.ReadLine());
                        int valueInput = Convert.ToInt32(Console.ReadLine());
                        dictionary.Create(keyInput, valueInput);
                        break;

                    case 2:
                        dictionary.Read();
                        break;

                    case 3:
                        Console.WriteLine(" enter position and element ");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        int input3 = Convert.ToInt32(Console.ReadLine());
                        dictionary.Update(input2, input3);
                        break;

                    case 4:
                        Console.WriteLine("enter index to delete element");
                        int input4 = Convert.ToInt32(Console.ReadLine());
                        dictionary.Delete(input4);
                        break;
                }
            }
        }

        private static void CaseStudy3()
        {
            HashSet1 hashSet = new HashSet1();
            Console.WriteLine("HashSet");
            while (true)
            {
                Console.WriteLine("---------------------------Main Menu--------------------------");
                Console.Write(" 1 : Create \t");
                Console.Write(" 2 : Read \t");
                Console.Write(" 3 : Update \t");
                Console.Write(" 4 : Delete \n");
                Console.WriteLine("enter a choice : ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("add value");
                        int input1 = Convert.ToInt32(Console.ReadLine());
                        hashSet.Create(input1);
                        break;

                    case 2:
                        hashSet.Read();
                        break;

                    case 3:
                        Console.WriteLine(" ");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        int input3 = Convert.ToInt32(Console.ReadLine());
                        hashSet.Update(input2, input3);
                        break;

                    case 4:
                        Console.WriteLine("enter value to delete element");
                        int input4 = Convert.ToInt32(Console.ReadLine());
                        hashSet.Delete(input4);
                        break;
                }
            }
        }
    }
}
