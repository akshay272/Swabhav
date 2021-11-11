using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionaryApp.Model
{
    class Student
    {
        private int _rollNumber;
        private int _standard;
        private string _name;
        private string _location;

        public Student(int rollNumber, int standard, string name, string location)
        {
            _rollNumber = rollNumber;
            _standard = standard;
            _name = name;
            _location = location;
        }
        public int GetRollNumber
        {
            get
            {
                return _rollNumber;
            }
        }
        public string GetName
        {
            get { return _name; }
        }
        public string GetLocation
        {
            get { return _location; }
        }
        public override int GetHashCode()
        {
            string str = Convert.ToString(_rollNumber) + Convert.ToString(_standard);
            return int.Parse(str);
        }
        
        public override bool Equals(object obj)
        {
            Student student = (Student)obj;
            if (this._rollNumber == student._rollNumber && this._standard == student._standard)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
