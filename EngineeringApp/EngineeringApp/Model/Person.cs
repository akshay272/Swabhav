using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringApp.Model
{
    abstract class Person
    {
        private int _id;
        private string _address;
        private string _dateOfBirth;

        public Person(int id, string address, string dateofbirth)
        {
            this._id = id;
            this._address = address;
            this._dateOfBirth = dateofbirth;
        }

        public Person(int id, string address, string dateOfBirth, double basicsalary) : this(id, address, dateOfBirth)
        {
            Basicsalary = basicsalary;
        }
        public int id
        {
            get
            {
                return _id;
            }
        }
        public string address
        {
            get
            {
                return _address;
            }
        }
        public string dateofbirth
        {
            get
            {
                return _dateOfBirth;
            }
        }

        public double Basicsalary { get; }
        public abstract string ExtraThings();


    }
}
