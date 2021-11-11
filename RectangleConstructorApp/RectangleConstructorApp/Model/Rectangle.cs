using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Model
{
    class Rectangle
    {
        private static int _height;
        private static int _width;
        private static string _color = "red";
        private static string _borderColor = "red";

        private const int UPPER_BOUND = 100;
        private const int LOWER_BOUND = 1;

        public Rectangle(int width, int height, string color)
        {
            _width = ValidateDimensions(width);
            _height = ValidateDimensions(height);
            _color = ValidateColor(color);
        }
        public Rectangle(int width, int height, string color, string borderColor)
        {
            _width = ValidateDimensions(width);
            _height = ValidateDimensions(height);
            _color = ValidateColor(color);
            _borderColor = ValidateColor(borderColor);
        }
        private int ValidateDimensions(int dimension)
        {
            if (dimension >= LOWER_BOUND && dimension <= UPPER_BOUND)
            {
                return dimension;
            }
            else if (dimension < LOWER_BOUND)
            {
                Console.WriteLine("out of bond Value set to 1");
                return LOWER_BOUND;
            }
            else
            {
                Console.WriteLine("out of bond value set to 100");
                return UPPER_BOUND;
            }
        }
        private string ValidateColor(string color)
        {
            const string DEFAULT_COLOR = "red";
            string colors = color.ToLower();

            if (colors == "red" || colors == "green" || colors == "blue")
            {
                return colors;
            }
            else
            {
                return DEFAULT_COLOR;
            }
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
        public string GetColor()
        {
            return _color;
        }
        public string GetBorderColor()
        {
            return _borderColor;
        }
        public int CalculateArea()
        {
            return _height * _width;
        }

    }
}
