using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Sorting.Algorithms
{
    /// <summary>
    /// Abstract base for sorting algorithms. The algorithm 
    /// </summary>
    public abstract class SortingAlgorithm
    {
        public Queue<CollectionState> States { get; set; }

        /// <summary>
        /// Comparisons the algorithm has made. Implementations should
        /// increment it as appropriate in their Sort method
        /// </summary>
        public ulong Comparisons { get; protected set; }

        public ulong Assignments { get; protected set; }

        public int CollectionSize { get { return collection.Length; } }

        protected int[] collection;

        public SortingAlgorithm(int[] collectionToSort)
        {
            Comparisons = 0;

            collection = new int[collectionToSort.Length];
            Array.Copy(collectionToSort, collection, collection.Length);
            States = new Queue<CollectionState>();
        }

        /// <summary>
        /// Gets the name of the sorting algorithm to display in the window
        /// </summary>
        public abstract String Name { get; }

        /// <summary>
        /// Saves the sorting state and increments the comparison counter
        /// </summary>
        public void OnComparison(List<int> activeItems)
        {
            ++Comparisons;
            SaveState(activeItems, CollectionState.ActionType.Comparison);
        }

        public void OnSwap(List<int> activeItems)
        {
            Assignments += 3;
            SaveState(activeItems, CollectionState.ActionType.Assignment);
        }

        /// <summary>
        /// Invalidates the current graphics and blocks for them to be finished redrawing
        /// </summary>
        public void SaveState(List<int> activeItems, CollectionState.ActionType action)
        {
            States.Enqueue(new CollectionState(collection, activeItems, action));
        }

        /// <summary>
        /// Sort the collection, saving a state at every step the algorithm wishes to display
        /// </summary>
        public abstract void Sort();
    }
}
