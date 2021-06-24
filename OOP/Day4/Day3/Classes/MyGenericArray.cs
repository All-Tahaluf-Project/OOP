using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Classes
{
    class MyGenericArray<T>
    {
        private T[] MyArrary;

        public MyGenericArray(int size)
        {
            MyArrary = new T[size];
        }

        public T GetItem(int index)
        {
            return MyArrary[index];
        }

        public void SetItem(int index,T Value)
        {
            MyArrary[index] = Value;
        }
    }
}
