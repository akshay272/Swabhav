using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriteOperation.model
{
    class FileOperation
    {
       public void Write(String filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
        } 
        public void Read(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);

            Console.WriteLine("Content of the File");

            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
        }
        public void Append(string filePath)
        {

        }
        
    }
}
