using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_queue
{
    public class MyStack<T> : IEnumerable
    {
        private T[] items;
        public int Count { get; private set; }
        public int Capacity { get; private set; }
        private int lastIndex;

        public MyStack()
        {
            Capacity = 4;
            items = new T[Capacity];
            Count = 0;
            lastIndex = -1;
        }

        public MyStack(int capacity)
        {
            if (capacity >= 0)
            {
                Capacity = capacity;
                items = new T[Capacity];
                Count = 0;
                lastIndex = -1;
            }
            else
            {
                throw new InvalidOperationException("Capacity cannot be less than 0");
            }
        }

        public void Push(T item)
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref items, Capacity);
            }

            lastIndex++;
            items[lastIndex] = item;
            Count++;
        }

        public T Peek()
        {
            if (lastIndex == -1)
            {
                throw new InvalidOperationException("Empty");
            }

            return items[lastIndex];
        }

        public T Pop()
        {
            if (lastIndex == -1)
            {
                throw new InvalidOperationException("Empty list");
            }

            T removedElement = items[lastIndex];
            lastIndex--;
            Count--;

            if (Count < Capacity / 4)
            {
                Capacity /= 2;
                Array.Resize(ref items, Capacity);
            }
            return removedElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = lastIndex; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
