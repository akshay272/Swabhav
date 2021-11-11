using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListHashDictionaryEx.Model
{
    class ArrayList1 
    {
        ArrayList arrayList = new ArrayList();
        
        public void Add(int aList)
        {
            arrayList.Add(aList);
        }

        public void Delete(int index)
        {
            arrayList.RemoveAt(index -1);
        }

        public void Read()
        {
            foreach(int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }

        public void Update( int index, int value)
        {
            arrayList.RemoveAt(index - 1);
            arrayList.Insert(index - 1, value);
        }
    }
}
