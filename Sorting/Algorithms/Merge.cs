using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sorting.Algorithms
{
    /// <summary>
    /// An O(n*log(n)) sort that works by splitting the list
    /// into smaller and smaller lists, then merging them together.
    /// </summary>
    class Merge : SortingAlgorithm
    {
        private List<int> active;

        public Merge(int[] collectionToSort)
            : base(collectionToSort)
        { }

        public override string Name
        {
            get { return "Merge Sort"; }
        }

        public override void Sort()
        {
            SortRecursor(0, collection.Length);
            SaveState(null, CollectionState.ActionType.Done);
        }

        /// <summary>
        /// Recursively sorts a set of values 
        /// </summary>
        /// <param name="startIndex">Starting index of the set to sort</param>
        /// <param name="length">Length of the set to sort</param>
        private void SortRecursor(int startIndex, int length)
        {
            if (length < 2)
                return;

            int splitPoint = length / 2;

            SortRecursor(startIndex, splitPoint);
            SortRecursor(startIndex + splitPoint, length - splitPoint);
            MergeSection(startIndex, length);
        }

        /// <summary>
        /// Merges a section of the collection.
        /// </summary>
        /// <param name="startIndex">Start of the list to merge, inclusive</param>
        /// <param name="length">Length of the list to merge, inclusive</param>
        private void MergeSection(int startIndex, int length)
        {
            // If we're down to two items, compare and swap as needed
            if (length == 2)
            {
                int second = startIndex + 1;

                active = new List<int>(2);
                active.Add(startIndex);
                active.Add(second);

                OnComparison(active);

                if (collection[startIndex] > collection[second])
                {
                    OnSwap(active);
                    collection.Swap(startIndex, second);
                }
            }
            else
            {
                int splitPoint = length / 2; // First index of the right (exclusing startIndex offset)

                int currLeft = startIndex;
                int currRight = splitPoint + startIndex;
                int remainingLeft = splitPoint;
                int remainingRight = length - splitPoint;

                int sortedIndex = 0;
                int[] sorted = new int[length];

                while (remainingLeft > 0 || remainingRight > 0)
                {
                    active = new List<int>(2);

                    if (remainingLeft > 0 && remainingRight > 0)
                    {
                        active.Add(currLeft);
                        active.Add(currRight);

                        if (collection[currLeft] < collection[currRight])
                        {
                            sorted[sortedIndex] = collection[currLeft];
                            ++currLeft;
                            --remainingLeft;
                        }
                        else
                        {
                            sorted[sortedIndex] = collection[currRight];
                            ++currRight;
                            --remainingRight;
                        }
                    }
                    else if (remainingLeft > 0)
                    {
                        active.Add(currLeft);

                        sorted[sortedIndex] = collection[currLeft];
                        ++currLeft;
                        --remainingLeft;
                    }
                    else if (remainingRight > 0)
                    {
                        active.Add(currRight);

                        sorted[sortedIndex] = collection[currRight];
                        ++currRight;
                        --remainingRight;
                    }

                    ++sortedIndex;

                    OnComparison(active);
                }

                active = new List<int>(length);
                for (int c = 0; c < length; ++c)
                    active.Add(c + startIndex);

                Assignments += (ulong)length;
                SaveState(active, CollectionState.ActionType.Assignment);

                Array.Copy(sorted, 0, collection, startIndex, length);
            }
        }
    }
}
