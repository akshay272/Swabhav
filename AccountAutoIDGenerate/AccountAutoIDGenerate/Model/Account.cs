using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccountAutoIDGenerate.Model
{

    class Account
    {
        private string _name;
        private float _balance;
        private GenderType _genner;
        private string _id;
        private static int _count;

        static Account()
        {
            _count = 1001;
        }
        
        public Account(string name, float balance)
        {
            _name = name;
            _balance = balance;
            _id = "C"+ _count;
            _count += 1;
        }
        public Account(string name,GenderType gender, float Balance)
        {
            _name = name;
            _genner = gender;
            _balance = Balance;
            _id = "C" + _count;
            _count += 1;

        }
        public Account(String name, GenderType gender)
        {
            _name = name;
            _genner = gender;
            _id = "C" + _count;
            _count += 1;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public float Balance
        {
            get
            {
                return _balance;
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
        }
        public GenderType Gender
        {
            get
            {
                return _genner;
            }
        }
        public void Withdraw(float amount)
        {
            _balance -= amount;
            Console.WriteLine("Amount withdraw succefully");
            
        }
        public void Deposite(float amount)
        {
            _balance += amount;
            Console.WriteLine("Amount deposited successfully");
        }

    }
}
