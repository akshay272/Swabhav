using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Doctor
    {
        public interface checkUp
        {

        }

        Boolean _workshopAtHospital;
        public void treatPetient()
        {
            Console.WriteLine("inside Doctor class");
            Console.WriteLine("Perform a checkup : ");
        }
    }
    
}
