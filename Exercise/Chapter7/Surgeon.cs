using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstJavaChptr_6_11.Chapter7
{
    class Surgeon : Doctor
    {
        public void treatPetient()
        {
            Console.WriteLine("Perform Surgery");
        }
        public void makeIncision()
        {
            Console.WriteLine("make incision");
        }
    }
}
