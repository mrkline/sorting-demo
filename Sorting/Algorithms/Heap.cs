using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting.Algorithms
{
    /// <summary>
    /// An O(n*log(n)) sort that works by building the list into a binary heap
    /// then repeatedly removing the root and placing it into the sorted list
    /// </summary>
    class Heap : SortingAlgorithm
    {
        private List<int> active;

        public Heap(int[] collection)
            : base(collection)
        { }

        public override string Name
        {
            get { return "Heapsort"; }
        }

        public override void Sort()
        {
            Heapify();

            int end = collection.Length - 1;
            while (end > 0)
            {
                active = new List<int>(2);
                active.Add(end);
                active.Add(0);
                OnSwap(active);

                collection.Swap(end, 0);
                SiftDown(0, end - 1);
                --end;
            }

            SaveState(null, CollectionState.ActionType.Done);
        }

        /// <summary>
        /// Converts the collection into a heap
        /// </summary>
        private void Heapify()
        {
            int start = collection.Length / 2 - 1;

            while (start >= 0)
            {
                SiftDown(start, collection.Length - 1);
                --start;
            }
        }

        private void SiftDown(int start, int end)
        {
            int root = start;
            
            while (root * 2 + 1 <= end)
            {
                int child = root * 2 + 1;
                int swap = root;

                active = new List<int>(2);
                active.Add(swap);
                active.Add(child);
                OnComparison(active);
                
                if (collection[swap] < collection[child])
                    swap = child;

                active = new List<int>(3);
                active.Add(child + 1);
                active.Add(end);
                active.Add(swap);
                OnComparison(active);

                if (child + 1 <= end && collection[swap] < collection[child + 1])
                    swap = child + 1;

                active = new List<int>(2);
                active.Add(swap);
                active.Add(root);

                if (swap != root)
                {
                    OnSwap(active);

                    collection.Swap(root, swap);
                    root = swap;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
