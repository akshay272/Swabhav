using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceApp.Model
{
    class Infant : Man
    {
        public override void Jump()
        {
            Console.WriteLine("infant jumping");
            base.Jump();
        }
    }
}
