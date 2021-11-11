using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Model;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoApp();
        }

        private static void ToDoApp()
        {
            ToDoManger toDoManger = new ToDoManger();
            while (true)
            {
                Console.WriteLine("Enter y to Go inside Menu and n for Exit");
                int yesNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    if (yesNo == 'y')
                    {
                        Console.WriteLine("1:Display 2:Add 3:Exit");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                toDoManger.Display();
                                break;
                            case 2:
                                Console.WriteLine("Enter the task");
                                string task = Convert.ToString(Console.ReadLine());
                                toDoManger.AddToList(task);
                                //Serialization(todo.GetArray());
                                break;
                            case 3:

                                toDoManger.Exit();
                                break;
                        }

                    }
                    else if (yesNo == 'n')
                    {
                        toDoManger.Exit();
                    }


                }
            }
        }

        
    }
}
 