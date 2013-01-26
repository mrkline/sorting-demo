using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting.Algorithms
{
    /// <summary>
    /// An O(n*log(n)) sort which works by picking a pivot point and partitioning
    /// items to the correct side of the pivot, then repeating recursively
    /// </summary>
    class Quick : SortingAlgorithm
    {
        private List<int> active;
        private Random rand;

        public Quick(int[] collectionToSort)
            : base(collectionToSort)
        {
            rand = new Random();
        }

        public override string Name
        {
            get { return "Quicksort"; }
        }

        public override void Sort()
        {
            QuicksortRecursor(0, collection.Length - 1);
            SaveState(null, CollectionState.ActionType.Done);
        }

        /// <summary>
        /// Recursively quicksorts collection, or a subset of it
        /// </summary>
        /// <param name="left">Leftmost index to quicksort</param>
        /// <param name="right">Rightmost index to quicksort</param>
        private void QuicksortRecursor(int left, int right)
        {
            int size = right - left + 1;

            if (size <= 3) // manual sort if small
            {
                ManualSort(left, right);
            }
            else
            {
                SetupMedianPivot(left, right);
                int PivotIndex = Partition(left, right);
                QuicksortRecursor(left, PivotIndex - 1);
                QuicksortRecursor(PivotIndex + 1, right);
            }
        }

        /// <summary>
        /// Picks a random pivot. Uses less comparisons than picking a median pivot.
        /// </summary>
        /// <param name="left">Left index of selection</param>
        /// <param name="right">Right index of selection</param>
        private void SetupRandomPivot(int left, int right)
        {
            int pivotIndex = rand.Next(left, right);
            collection.Swap(pivotIndex, right);
        }

        /// <summary>
        /// Picks a pivot as the median of the left, middle and right values
        /// </summary>
        /// <param name="left">Left index of the set</param>
        /// <param name="right">Right index of the set</param>
        private void SetupMedianPivot(int left, int right)
        {
            int center = (left + right) / 2;

            active = new List<int>(2);
            active.Add(left);
            active.Add(center);
            OnComparison(active);

            // order left & center
            if (collection[left] > collection[center])
            {
                OnSwap(active);
                collection.Swap(left, center);
            }

            active = new List<int>(2);
            active.Add(left);
            active.Add(right);
            OnComparison(active);

            // order left & right
            if (collection[left] > collection[right])
            {
                OnSwap(active);
                collection.Swap(left, right);
            }

            active = new List<int>(2);
            active.Add(left);
            active.Add(right);
            OnComparison(active);

            // order center & right
            if (collection[center] > collection[right])
            {
                OnSwap(active);
                collection.Swap(center, right);
            }

            active = new List<int>(2);
            active.Add(center);
            active.Add(right);
            OnSwap(active);

            collection.Swap(center, right); // put pivot on right
        }

        /// <summary>
        /// Places all values less than pivot to its left and all values greater to its right.
        /// Assumes the pivot starts at collection[right]
        /// </summary>
        /// <param name="left">Left index of selection to pivot</param>
        /// <param name="right">Right index of section to pivot. Assumed to contain the pivot</param>
        /// <returns></returns>
        public int Partition(int left, int right)
        {
            int currLeft = left - 1;
            int currRight = right;
            int pivot = collection[right];

            while (true)
            {
                // Find the next item on the left that is larger than the pivot
                do
                {
                    ++currLeft;
                    active = new List<int>(2);
                    active.Add(currLeft);
                    active.Add(right);
                    OnComparison(active);
                } while (collection[currLeft] < pivot) ;
                
                // Find the next item on the right that is smaller than the pivot
                do
                {
                    --currRight;
                    active = new List<int>(2);
                    active.Add(currRight);
                    active.Add(right);
                    OnComparison(active);
                } while (collection[currRight] > pivot) ;

                if (currLeft >= currRight) // if pointers cross, the partition is done
                {
                    break;
                }
                else
                {
                    active = new List<int>(2);
                    active.Add(currLeft);
                    active.Add(currRight);
                    OnSwap(active);

                    collection.Swap(currLeft, currRight); // Not crossed, so swap elements
                }
            }

            active = new List<int>(2);
            active.Add(currLeft);
            active.Add(right);
            OnSwap(active);

            collection.Swap(currLeft, right); // restore pivot
            return currLeft; // return pivot index
        }

        /// <summary>
        /// Used to manually sort sets 3 or smaller
        /// </summary>
        /// <param name="left">Left index of set</param>
        /// <param name="right">Right index of set</param>
        private void ManualSort(int left, int right)
        {
            int size = right - left + 1;
            if (size <= 1)
                return; // no sort necessary

            if (size == 2)
            { // 2-sort left and right
                active = new List<int>(2);
                active.Add(left);
                active.Add(right);
                OnComparison(active);

                if (collection[left] > collection[right])
                {
                    active = new List<int>(2);
                    active.Add(left);
                    active.Add(right);
                    OnSwap(active);

                    collection.Swap(left, right);
                }
                return;
            }
            else // size is 3
            { // 3-sort left, center, & right
                active = new List<int>(2);
                active.Add(left);
                active.Add(right - 1);
                OnComparison(active);

                if (collection[left] > collection[right - 1])
                {
                    active = new List<int>(2);
                    active.Add(left);
                    active.Add(right - 1);
                    OnSwap(active);

                    collection.Swap(left, right - 1); // left, center
                }

                active = new List<int>(2);
                active.Add(left);
                active.Add(right);
                OnComparison(active);

                if (collection[left] > collection[right])
                {
                    active = new List<int>(2);
                    active.Add(left);
                    active.Add(right);
                    OnSwap(active);

                    collection.Swap(left, right); // left, right
                }

                active = new List<int>(2);
                active.Add(right - 1);
                active.Add(right);
                OnComparison(active);

                if (collection[right - 1] > collection[right])
                {
                    active = new List<int>(2);
                    active.Add(right - 1);
                    active.Add(right);
                    OnSwap(active);

                    collection.Swap(right - 1, right); // center, right
                }
            }
        }
    }
}
