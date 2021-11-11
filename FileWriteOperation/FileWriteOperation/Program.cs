using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileWriteOperation.model;

namespace FileWriteOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\SwabhavTech\\C#\\Text\\writeOperation.txt";
            FileOperation fw = new FileOperation();

            while (true)
            {
                Console.WriteLine("Enter choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        fw.Write(filePath);
                        Console.WriteLine("writen succesfully");
                        break;
                    case 2:
                        fw.Read(filePath);
                        
                        break;
                }
            }

            Console.ReadKey();



        }
    }
}
