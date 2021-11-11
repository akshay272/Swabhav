using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodDogTestDrive.Model
{
    class GoodDog
    {
        private int size;
        public int GetSize()
        {
            return size;
        }
        public void SetSize(int s)
        {
            size = s;
        }
        public void Bark()
        {
            if(size > 60)
            {
                Console.WriteLine("Woof! Woof!");
            }
            else if (size > 14)
            {
                Console.WriteLine("Ruff! Ruff!");
            }
            else
            {
                Console.WriteLine("Yip! Yip!");
            }
        }
    }
}
