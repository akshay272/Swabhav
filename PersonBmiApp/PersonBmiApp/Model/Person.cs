using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBmiApp.Model
{
    class Person
    {
        string _name;
        float _height;
        float _weight;
        int _age;
        string _gender;
        float _bmi;

        public Person(string name, string gender, float hieght,float weight, int age)
        {
            _name = name;
            _gender = gender;
            _height = hieght * 0.0254f;
            _weight = weight;
            _age = age;
        }
        public void Workout()
        {
            _weight = _weight - (5 * _weight / 100);
            Console.WriteLine("Workout Finished : ");
            Console.WriteLine("wieght decreased by 5%");
        }
        public void eat()
        {
            _weight = _weight + (10 * _weight / 100);
            _height = _height + (2 * _height / 100);
            Console.WriteLine("You have eaten : ");
            Console.WriteLine("height increased by 2%");
            Console.WriteLine("wieght increased by 10%");
        }
        public string GetName()
        {
            return _name;
        }
        public string GetGender()
        {
            return _gender;
        }
        public float GetHieght()
        {
            return _height;
        }
        public float GetWeight()
        {
            return _weight;
        }
        public int GetAge()
        {
            return _age;
        }
        public float GetBmi()
        {
            _bmi = _weight / (_height * _height);
            return _bmi;
        }
    }
}
