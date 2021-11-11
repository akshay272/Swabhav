using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayListHashDictionaryEx.Model
{
    class HashSet1
    {
        HashSet<int> hashset = new HashSet<int>();
        public void Create(int value)
        {
            hashset.Add(value);
        }

        public void Delete(int value)
        {
            if (hashset.Contains(value))
            {
                hashset.Remove(value);
            }
            else
            {
                Console.WriteLine("{0} not found", value);
            }
        }

        public void Read()
        {
            foreach (int value in hashset)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine(" ");
        }

        public void Update(int value1, int value2)
        {
            if (hashset.Contains(value1))
            {
                hashset.Remove(value1);
                hashset.Add(value2);
            }
            else
            {
                Console.WriteLine("{0} value not found ", value1);
            }
            
            
        }
    }
}
