using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringApp.Model
{
    class Student : Person
    {
        private int _id;
        private string _address;
        private string _dateOfBirth;
        private string _branch;

        public Student(int id, string address, string dateOfBirth, string branch) : base(id, address, dateOfBirth)
        {
            this._id = id;
            this._address = address;
            this._dateOfBirth = dateOfBirth;
            this._branch = branch;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
        }
        public string dateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
        }
        public string branch
        {
            get
            {
                return _branch;
            }
        }
        public override string ExtraThings()
        {
            Console.WriteLine("Branch: " + branch);
            return string.Empty;
        }
    }
}
