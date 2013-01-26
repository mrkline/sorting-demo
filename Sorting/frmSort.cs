using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sorting.Algorithms;
using System.Threading;

namespace Sorting
{
    public partial class frmSort : Form
    {
        private SortingAlgorithm algo;
        private Queue<CollectionState> stateList;
            
        public frmSort(SortingAlgorithm algorithm, int iterationPauseLen)
        {
            InitializeComponent();            
            algo = algorithm;
            Text = algo.Name;
            crCollection.InactiveColor = Color.Black;
            crCollection.ComparisonColor = Color.Red;
            crCollection.AssignmentColor = Color.Blue;
            tmrDelay.Interval = iterationPauseLen;

            bwAlgoRunner.RunWorkerAsync();
        }

        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            // Iterate through our states and draw them
            CollectionState curr = stateList.Dequeue();
            crCollection.CurrentState = curr;
            crCollection.Invalidate();

            // We're done replaying
            if (stateList.Count == 0)
            {
                tmrDelay.Stop();
                lblDone.Text = "Finished with " + ((float)algo.Comparisons / (float)algo.CollectionSize).ToString("#0.00")
                    + "n comparisons and " + ((float)algo.Assignments / (float)algo.CollectionSize).ToString("#0.00") + "n assignments";
                lblDone.Visible = true;
            }
        }

        private void bwAlgoRunner_DoWork(object sender, DoWorkEventArgs e)
        {
            algo.Sort();
        }

        private void bwAlgoRunner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stateList = algo.States;

            foreach (CollectionState state in stateList)
            {
                if(state.ActiveItems != null)
                    state.ActiveItems.Sort();
            }

            tmrDelay.Start();
        }
    }
}
