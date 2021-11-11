using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccountAutoIDGenerate.Model;
namespace AccountAutoIDGenerate
{
    class Reflector
    {
        
        public void DoReflection(Type ac)
        {
            Type t = Type.GetType(ac.ToString());
            PropertyInfo[] properties = t.GetProperties();
            ConstructorInfo[] constructor = t.GetConstructors();
            MethodInfo[] methods = t.GetMethods();
            MemberInfo[] members = t.GetMembers();
            

            Console.WriteLine("Total Constructors : {0}", constructor.Length);
            for (int i = 0; i < constructor.Length; i++)
            {
                Console.WriteLine(constructor[i]);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Total Properties : {0}", properties.Length);
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine(properties[i]);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Total Methods : {0}", methods.Length);
            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i]);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Totoa Members : {0}", members.Length);
            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine(members[i]);
            }
            Console.WriteLine(" ");

        } 
    }
}
