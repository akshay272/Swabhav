using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int height;
        private int width;
        private int LOWER_BOUND = 1;
        private int UPPER_BOUND = 100;

        public void SetHeight(int pHeight)
        {
            height = Validation(pHeight);
            
        }
        public void SetWidth(int pWidth)
        {
            width = Validation(pWidth);
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetWidth()
        {
            return width;
        }

        private int Validation(int value)
        {
            if(value< LOWER_BOUND )
            {
                Console.WriteLine("{0} value out of Lower Bound set to 1", value);
                return LOWER_BOUND ;
            }
            else if (value > UPPER_BOUND)
            {
                Console.WriteLine("{0} value out of Upper Bound set to 100",value );
                return UPPER_BOUND;
            }
            else
            {
                return value;
            }
        }

        public int CalculateArea()
        {
            return width*height;
        }

    }
}
