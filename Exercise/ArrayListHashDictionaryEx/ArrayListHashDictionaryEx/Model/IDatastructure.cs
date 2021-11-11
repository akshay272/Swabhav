using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListHashDictionaryEx
{
    interface IDatastructure
    {
        void Create(object[] aList);
        void Read();
        void Update(object value, int index);
        void Delete(int index);

    }
}
