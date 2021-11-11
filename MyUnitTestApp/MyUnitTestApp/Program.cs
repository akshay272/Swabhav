using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MyUnitTestApp.Model;

namespace MyUnitTestApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyUntiTestClass>().Count() > 0);

            foreach(var T in types)
            {
                Console.WriteLine(T.Name);
                var methods = T.GetMethods().Where(m => m.GetCustomAttributes<MyUnitTestMethod>().Count() > 0);
                object obj = Activator.CreateInstance(T);
                Console.WriteLine("Number of Methods annoted: {0}", methods.Count());
                foreach (var method in methods)
                {
                    var v = method.Invoke(obj, null);
                    if (v.Equals(true))
                    {
                        Console.WriteLine(method.Name +" "+ "---> Passed");
                    }
                    else
                    {
                        Console.WriteLine(method.Name +" "+ "---> Failed");
                    }
                }
                Console.WriteLine(" ");
                
            }
            
            Console.ReadKey();
        }

        
    }
}
