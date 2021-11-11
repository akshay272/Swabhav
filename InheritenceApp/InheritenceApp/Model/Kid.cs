using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceApp.Model
{
    class Kid : Man
    {
        public override void Jump()
        {
            Console.WriteLine("kid is Playing");
        }
    }
}
