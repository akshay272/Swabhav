using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Surgeon : Doctor
    {
        public interface Checkup
        {

        }
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
