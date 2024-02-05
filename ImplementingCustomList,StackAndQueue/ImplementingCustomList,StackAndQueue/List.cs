using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingCustomList_StackAndQueue
{
    public class List
    {
        private const int InitialCapacity = 2;
        private int[] items;
        public List()
        {
            this.items = new int[InitialCapacity];
        }
        public int Count { get; private set; }

        public void Add(int item)
        {
            if (this.items.Length == this.Count)
            {
                this.Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (i == index)
                {

                }
            }

            return;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < this.items.Length; i++)
            {
                if (this.items[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            int temp = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = temp;
        }


        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                int currentNum = this.items[i];
                action(currentNum);
            }
        }
    }
}
