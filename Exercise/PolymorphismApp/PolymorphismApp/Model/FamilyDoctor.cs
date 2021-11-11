using System;
using PolymorphismApp.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class FamilyDoctor:Doctor
    {
        public interface Check
        {

        }
        Boolean _makeHouseCall;
        public void GiveAdvice()
        {
            Console.WriteLine("inside Family Doctor class");
            Console.WriteLine("Give HomeSpun Advice :");
        }
    }
}
