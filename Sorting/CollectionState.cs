using System;
using System.Collections.Generic;

namespace Sorting
{
    public class CollectionState
    {
        public enum ActionType
        {
            Comparison,
            Assignment,
            Done
        }

        public int[] State;
        public List<int> ActiveItems;
        public ActionType Action;

        /// <summary>
        /// Constructs a collection state from the state of the collection and a list of 
        /// any active items
        /// </summary>
        /// <param name="collectionState">Current state of the collection</param>
        /// <param name="activeItems">
        /// Active items to highlight at this state.
        /// The lists's reference is just copied, so if the algorithm's active items
        /// changes every state, be sure to provide a new list each time
        /// </param>
        public CollectionState(int[] collectionState, List<int> activeItems, ActionType action)
        {
            int len = collectionState.Length;
            State = new int[len];
            Array.Copy(collectionState, State, len);

            ActiveItems = activeItems;
            Action = action;
        }
    }
}