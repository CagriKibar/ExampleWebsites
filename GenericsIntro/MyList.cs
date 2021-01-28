using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //type'dan gelir, istenilen hersey yazılabilir. Kullanımı genelde bu şekilde.
    {

        T[] items;
        public MyList()//constructor.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];

            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
        
    }
}
