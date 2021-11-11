using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Model
{
    class Student
    {
        private int _rollNumber;
        private string _name;
        private string _location;

        public Student(int rollNumber, string name, string location)
        {
            _rollNumber = rollNumber;
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
            return _rollNumber;
        }
        public override bool Equals(object obj)
        {
            Student student = (Student)obj;
            if(this._rollNumber == student._rollNumber)
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
