using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
                while (true)
                {
                    Console.WriteLine("***** Welocome in Number Guesser ****");
                    Random rd = new Random();
                    int randomNumber = rd.Next(1, 101);
                
                    int tries = 0;
                    while (true)
                    {
                        Console.WriteLine("Enter a number between 1 and 100(0 to quit):");
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input == 0)
                            return;
                        else if (input < randomNumber)
                        {
                            Console.WriteLine("Too Low..try again!");
                            ++tries;
                            Console.WriteLine("Toatal tries : " + tries);
                            continue;
                        }
                        else if (input > randomNumber)
                        {
                            Console.WriteLine("Too High...try again!");
                            ++tries;
                            Console.WriteLine("Toatal tries : " + tries);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("You Guessed Right {0}!",
                                               randomNumber);
                            Console.WriteLine("It took you {0} {1}.\n", (tries +1),
                                               tries == 1 ? "try" : "tries");
                            Console.WriteLine("*******");
                            Console.WriteLine("Do you want play again (y/n)? :");
                            tries = 0;
                            char decision = Convert.ToChar(Console.ReadLine());
                            if(decision == 'y')
                            {
                                continue;
                            }
                            if(decision == 'n')
                            {                                
                                return;
                            }
                        }
                    }
                }


        }
  
    }
}
