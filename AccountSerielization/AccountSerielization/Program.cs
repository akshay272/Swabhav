using AccountSerielization.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AccountSerielization
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account account = new Account(1000);
            PrintDetails(account);
            Serialization(account);
            account.Deposite(1000);
            Serialization(account);
            Deserialization(account);

            Console.ReadKey();
        }

        private static string FilePath()
        {
            string filePath = "D:\\SwabhavTech\\C#\\Text\\Serial.txt;";
            return filePath;
        }
        
        private static void Deserialization(Account ac)
        {
            string filePath = FilePath();
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Account deSeriealized = (Account)formatter.Deserialize(fs);
            fs.Close();
            Console.WriteLine("Desirialization done");
            PrintDetails(deSeriealized);
        }
        private static void Serialization(Account ac)
        {
            string filePath = FilePath();
            FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, ac);
            fs.Close();
            Console.WriteLine("file Saved Successfully in {0} ",filePath);
            Console.WriteLine("Serializing........");
            PrintDetails(ac);
        }
        private static void PrintDetails(Account ac)
        {
            Console.WriteLine("Account Balance : {0}", ac.Balance);
            Console.WriteLine(" ");
        }
    }
}
