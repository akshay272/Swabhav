using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceApp.Model
{
    class Man
    {
        public virtual void Jump()
        {
            Console.WriteLine("jumping");
        }
        public void Read()
        {
            Console.WriteLine("Man is reading ");
        }
        public void Play()
        {
            Console.WriteLine("Man is Playing ");
        }
        public void Walk()
        {
            Console.WriteLine("Man is Walking ");
        }
    }
}
