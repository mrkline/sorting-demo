using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Sorting
{
    public partial class CollectionRenderer : UserControl
    {
        public Color InactiveColor
        {
            get { return inactiveBrush.Color; }
            set { inactiveBrush.Color = value; }
        }
        public Color ComparisonColor
        {
            get { return comparisonBrush.Color; }
            set { comparisonBrush.Color = value; }
        }
        public Color AssignmentColor
        {
            get { return assignmentBrush.Color; }
            set { assignmentBrush.Color = value; }
        }
        private SolidBrush inactiveBrush;
        private SolidBrush comparisonBrush;
        private SolidBrush assignmentBrush;

        public CollectionState CurrentState { get; set; }

        public CollectionRenderer()
        {
            inactiveBrush = new SolidBrush(Color.Black);
            comparisonBrush = new SolidBrush(Color.Red);
            assignmentBrush = new SolidBrush(Color.Blue);
            InitializeComponent();
            // Use double buffering to avoid flicker
            this.SetStyle(
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint |
              ControlStyles.DoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            if (CurrentState != null)
            {
                int[] collection = CurrentState.State;
                List<int> activeItems = CurrentState.ActiveItems;
                CollectionState.ActionType action = CurrentState.Action;

                float fCollLen = (float)collection.Length;
                float itemWidth = (float)ClientRectangle.Width / fCollLen;
                float intervalHeight = (float)ClientRectangle.Height / fCollLen;

                RectangleF r = new RectangleF(ClientRectangle.X, ClientRectangle.Y, itemWidth, intervalHeight);

                // Items should be presorted. See frmSort
                //if (activeItems != null)
                //{
                //    activeItems.Sort();
                //}

                int activeItemNum = 0;

                for (int c = 0; c < collection.Length; ++c)
                {
                    r.Height = intervalHeight * (float)collection[c];
                    r.Y = (float)ClientRectangle.Bottom - r.Height;

                    Brush toUse;
                    if (activeItems != null
                            && activeItemNum < activeItems.Count
                            && activeItems[activeItemNum] == c)
                    {
                        if (action == CollectionState.ActionType.Comparison)
                            toUse = comparisonBrush;
                        else if (action == CollectionState.ActionType.Assignment)
                            toUse = assignmentBrush;
                        else
                            toUse = inactiveBrush;


                        ++activeItemNum;
                    }
                    else
                    {
                        toUse = inactiveBrush;
                    }

                    g.FillRectangle(toUse, r);

                    r.X += itemWidth;
                }
            }
            else
            {
                g.FillRectangle(inactiveBrush, ClientRectangle);
                g.DrawString("Collection will go here", Font, comparisonBrush, ClientRectangle);
            }
        }
    }
}
