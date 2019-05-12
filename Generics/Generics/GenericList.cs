using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericList<T> where T : IComparable<T>
    {
        T[] array;
        private int index = 0;
        public GenericList(int size)
        {
            array = new T[size];
        }

        public void Add(T value)
        {
            if (array.Length == index)
            {
                throw new Exception("Array is full");
            }
            array[index] = value;
            index++;
        }

        public T GetByIndex(int index)
        {
            if (index < 0 || index > array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return array[index];
        }

        public void RemoveByIndex(int index)
        {
            if (index < 0 || index > array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            T[] array2 = new T[array.Length - index - 1];

            Array.Copy(array, index + 1, array2, 0, array2.Length);
            array2.CopyTo(array, index);
            array[array.Length - 1] = default(T);
        }

        public void InsertByIndex(int index, T value)
        {
           
            if (index < 0 || index > array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (!array[array.Length - 1].Equals(default(T)))
            {
                throw new Exception("Array is full");
            }

            T[] array2 = new T[array.Length - index - 1];

            if (index != default(int))
            {
                Array.Copy(array, index, array2, 0, array2.Length);
                array[index] = value;
                array2.CopyTo(array, index + 1);
            }
            else
            {
                array[index] = value;
            }           
        }

        public void Clear()
        {
            array = new T[array.Length];
        }

        public int GetFirstIndexByValue(T value)
        {
            return Array.IndexOf(array, value);
        }


        public int GetLastIndexByValue(T value)
        {
            return Array.LastIndexOf(array, value);           
        }

        public void Resize()
        {          
            if (!array[array.Length - 1].Equals(default(T)))
            {
                Array.Resize(ref array, array.Length * 2);
            }
        }

        public T Max()
        {
            T max = array[0];
            foreach (var value in array)
            {
                if (value.CompareTo(max) >= 0)
                {
                    max = value;
                }
            }

            return max;
        }


        public T Min()
        {
            T min = array[0];
            foreach (var value in array)
            {
                if (value.CompareTo(min) <= 0)
                {
                    min = value;
                }
            }

            return min;
        }

    }
}
