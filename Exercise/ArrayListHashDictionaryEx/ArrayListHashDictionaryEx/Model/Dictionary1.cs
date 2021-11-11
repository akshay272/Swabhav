using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListHashDictionaryEx.Model
{
    class Dictionary1 
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        public void Create(int key, int value)
        {
            dictionary.Add(key, value);
        }

        public void Delete(int key)
        {
            dictionary.Remove(key);
        }

        public void Read()
        {
            foreach(KeyValuePair<int , int> dict in dictionary)
            {
                Console.WriteLine(dict.Key + " " + dict.Value);
            }
            Console.WriteLine(" ");
        }

        public void Update(int key, int value)
        {
            dictionary.Remove(key);
            dictionary.Add(key, value);
        }
    }
}
