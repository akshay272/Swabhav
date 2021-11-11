using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstJavaChptr_6_11.Chapter7
{
    class FamilyDoctor:Doctor
    {
        Boolean _makeHouseCall;
        public void GiveAdvice()
        {
            Console.WriteLine("inside Family Doctor class");
            Console.WriteLine("Give HomeSpun Advice :");
        }
    }
}
