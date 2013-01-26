using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sorting.Algorithms
{
    /// <summary>
    /// Takes an item at a time and inserts it into the sorted portion of the list.
    /// An O(n^2) sort, but usually faster than Bubblesort.
    /// </summary>
    class Insertion : SortingAlgorithm
    {
        public Insertion(int[] collectionToSort)
            : base(collectionToSort)
        { }

        public override string Name
        {
            get { return "Insertion Sort"; }
        }

        public override void Sort()
        {
            List<int> active = null;

            for (int i = 1; i < collection.Length; ++i)
            {
                int currValue = collection[i];
                int j = i - 1;
                bool done = false;
                do
                {
                    active = new List<int>(2);
                    active.Add(i);
                    active.Add(j);

                    OnComparison(active);

                    if (collection[j] > currValue)
                    {
                        active = new List<int>(2);
                        active.Add(j);
                        active.Add(j + 1);
                        ++Assignments;
                        SaveState(active, CollectionState.ActionType.Assignment);

                        collection[j + 1] = collection[j];
                        --j;

                        if (j < 0)
                            done = true;
                    }
                    else
                    {
                        done = true;
                    }
                } while (!done);

                active = new List<int>(2);
                active.Add(currValue);
                active.Add(j + 1);
                ++Assignments;
                SaveState(active, CollectionState.ActionType.Assignment);

                collection[j + 1] = currValue;
            }

            SaveState(null, CollectionState.ActionType.Done);
        }
    }
}
