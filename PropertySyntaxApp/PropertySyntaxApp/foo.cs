using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySyntaxApp
{
    class foo
    {
        private int _bar;
        private int _random;
        public foo()
        {
            Random rd = new Random();
            _random = rd.Next(0, 2);
        }
        

        public int Bar
        {
            get 
            {
                return _bar;
            }
            set 
            {
                if (value > 0)
                {
                    _bar = value;
                }
                else
                {
                    _bar = 0;
                }
            }
        }
        public float Random
        {
            get
            {
                return _random;
            }
        }

    }
    
}
