using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp.Model
{
    class Rectangle
    {
        private int _height;
        private int _width;
        private ColorType _borerColor;
        private int LOWER_BOUND = 1;
        private int UPPER_BOUND = 100;

        public Rectangle()
        {
            Console.WriteLine("New Rectangle is created..........!");
            _borerColor = ColorType.red;
        }
       
        private int Validation(int value)
        {
            if (value < LOWER_BOUND)
            {
                Console.WriteLine("{0} value out of Lower Bound set to 1", value);
                return LOWER_BOUND;
            }
            else if (value > UPPER_BOUND)
            {
                Console.WriteLine("{0} value out of Upper Bound set to 100", value);
                return UPPER_BOUND;
            }
            else
            {
                return value;
            }
        }
        public int Height
        {
            set
            {
                _height = Validation(value);
            }
            get
            {
                return _height;
            }
        }
        public int Width
        {
            set
            {
                _width = Validation(value);
            }
            get
            {
                return _width;
            }
        }
        public ColorType BorderColor
        {
            set
            {
                _borerColor = value;
            }
            get
            {
                return _borerColor;
            }
        }
        

        public int CalculateArea()
        {
            return _height * _width;
        }
    }
}
