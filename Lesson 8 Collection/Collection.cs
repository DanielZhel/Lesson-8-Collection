using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Collection
{
    internal class Collection<T>
    {
        private T[] array;
        private int size = 0;
        private int i = 0;

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public Collection()
        {
            this.array = new T[size];
            
        }
        protected int Size
        {
            get { return size; }
        }

        public void Add(T value)
        {
            Array.Resize(ref this.array, array.Length+1);
            size = array.Length;
            array[i] = value;
            i++;
            
        }
        
        public T GetValue(int index)
        {
            return array[index];
        }

        public void Remove(int index)
        {
            array[index] = default;
        }

        public int GetLength()
        {
            return size;
        }

    }

    internal class MyCollection : Collection<int>
    {
       public static MyCollection operator +(MyCollection firstColl, MyCollection secondColl)
        {
            MyCollection result = new MyCollection();

            if (firstColl.GetLength() != secondColl.GetLength())
            {
                Console.WriteLine("Different length's");
            }
            
            for (int i = 0 ; i < firstColl.GetLength(); i++)
            {
                result.Add(firstColl[i] + secondColl[i]);
            }
            return result;
        }

        public static bool operator ==(MyCollection firstColl, MyCollection secondColl)
        {
            if (firstColl.GetLength() != secondColl.GetLength())
            {
                Console.WriteLine("Different length's");
            }

            for (int i = 0; i < firstColl.GetLength(); i++)
            {
                if (firstColl[i] != secondColl[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(MyCollection firstColl, MyCollection secondColl)
        {
            if (firstColl.GetLength() != secondColl.GetLength())
            {
                Console.WriteLine("Different length's");
            }

            for (int i = 0; i < firstColl.GetLength(); i++)
            {
                if (firstColl[i] != secondColl[i])
                {
                    return true;
                }
            }

            return false;
        }

    }
    
}
