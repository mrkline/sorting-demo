using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sorting.Algorithms
{
    /// <summary>
    /// "Bubbles" high items to the top. An O(n^2) sort.
    /// </summary>
    class Bubblesort : SortingAlgorithm
    {

        public Bubblesort(int[] collectionToSort)
            : base(collectionToSort)
        { }

        public override void Sort()
        {
            List<int> active = null;

            int swapPoint = 0;
            bool swappedThisPass = false;

            while (true)
            {
                ++swapPoint;
                if (swapPoint == collection.Length)
                {
                    swapPoint = 1;
                    if (!swappedThisPass)
                    {
                        SaveState(null, CollectionState.ActionType.Done);
                        return;
                    }
                    else
                    {
                        swappedThisPass = false;
                    }
                }

                active = new List<int>(2);
                active.Add(swapPoint);
                active.Add(swapPoint - 1);

                OnComparison(active);

                if (collection[swapPoint - 1] > collection[swapPoint])
                {
                    OnSwap(active);

                    collection.Swap(swapPoint - 1, swapPoint);

                    swappedThisPass = true;
                }
            }
        }

        public override string Name
        {
            get { return "Bubblesort";  }
        }
    }
}
