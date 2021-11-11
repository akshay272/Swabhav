using CustomAttributeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAnnotation(typeof(Foo));
            Console.ReadKey();
        }
        public static void GetAnnotation(Type t)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().Where(T => t.GetCustomAttributes<NeedToRefactor>().Count() > 0);


            var methods = t.GetMethods().Where(m => m.GetCustomAttributes<NeedToRefactor>().Count() > 0);

            Console.WriteLine("Number of Methods annoted: {0}", methods.Count());
            foreach (var m in methods)
            {
                Console.WriteLine(m.ReturnType.Name + " " + m.Name);
            }
            Console.ReadLine();
        }
    }
}
