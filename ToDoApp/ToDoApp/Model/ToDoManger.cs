using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    class ToDoManger
    {
        private string FilePath = @"D:\SwabhavTech\C#\Text\todo.txt";
        
        public void Display()
        {
            FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
              
            }
            
            Console.ReadLine();
            fs.Close();
            sr.Close();
        }
        public void AddToList(string str)
        {
            StreamWriter writer = new StreamWriter(FilePath, true);
            writer.WriteLine(str.ToString());
            Console.WriteLine("Task Added");
            Console.WriteLine(" ");
            writer.Close();
        }
        public void Exit()
        {
            FileStream fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Data have been saved Successfully");
            Console.ReadLine();
            Environment.Exit(1);

        }
    }
}
