using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sorting
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int delay = (int)nudDelay.Value;
            int[] collection = new int[(int)nudSetSize.Value];

            if (radSorted.Checked)
            {
                for (int c = 0; c < collection.Length; ++c)
                    collection[c] = c + 1;
            }
            else if (radRandomized.Checked)
            {
                for (int c = 0; c < collection.Length; ++c)
                    collection[c] = c + 1;
                collection.Shuffle();
            }
            else if (radReversed.Checked)
            {
                int len = collection.Length;
                for (int c = 0; c < len; ++c)
                    collection[c] = len - c;
            }
            else if (radFewUnique.Checked)
            {
                Random rand = new Random();
                int stepLen = collection.Length / 5;

                for (int c = 0; c < collection.Length; ++c)
                    collection[c] = rand.Next(1, 6) * stepLen;
            }
            else if (radUniform.Checked)
            {
                int u = collection.Length / 2;
                for (int c = 0; c < collection.Length; ++c)
                    collection[c] = u;
            }

            if (chkBubble.Checked)
                new frmSort(new Algorithms.Bubblesort(collection), delay).Show();

            if (chkInsertion.Checked)
                new frmSort(new Algorithms.Insertion(collection), delay).Show();

            if (chkMerge.Checked)
                new frmSort(new Algorithms.Merge(collection), delay).Show();

            if (chkQuicksort.Checked)
                new frmSort(new Algorithms.Quick(collection), delay).Show();

            if (chkHeap.Checked)
                new frmSort(new Algorithms.Heap(collection), delay).Show();
        }
    }
}
