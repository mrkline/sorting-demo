namespace Sorting
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSorts = new System.Windows.Forms.GroupBox();
            this.chkHeap = new System.Windows.Forms.CheckBox();
            this.chkQuicksort = new System.Windows.Forms.CheckBox();
            this.chkMerge = new System.Windows.Forms.CheckBox();
            this.chkInsertion = new System.Windows.Forms.CheckBox();
            this.chkBubble = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalLength = new System.Windows.Forms.Label();
            this.nudSetSize = new System.Windows.Forms.NumericUpDown();
            this.lblSetSize = new System.Windows.Forms.Label();
            this.grpCollType = new System.Windows.Forms.GroupBox();
            this.radSorted = new System.Windows.Forms.RadioButton();
            this.radFewUnique = new System.Windows.Forms.RadioButton();
            this.radReversed = new System.Windows.Forms.RadioButton();
            this.radRandomized = new System.Windows.Forms.RadioButton();
            this.radUniform = new System.Windows.Forms.RadioButton();
            this.grpSorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetSize)).BeginInit();
            this.grpCollType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSorts
            // 
            this.grpSorts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSorts.Controls.Add(this.chkHeap);
            this.grpSorts.Controls.Add(this.chkQuicksort);
            this.grpSorts.Controls.Add(this.chkMerge);
            this.grpSorts.Controls.Add(this.chkInsertion);
            this.grpSorts.Controls.Add(this.chkBubble);
            this.grpSorts.Location = new System.Drawing.Point(12, 13);
            this.grpSorts.Name = "grpSorts";
            this.grpSorts.Size = new System.Drawing.Size(201, 144);
            this.grpSorts.TabIndex = 0;
            this.grpSorts.TabStop = false;
            this.grpSorts.Text = "Pick your sorts";
            // 
            // chkHeap
            // 
            this.chkHeap.AutoSize = true;
            this.chkHeap.Location = new System.Drawing.Point(6, 112);
            this.chkHeap.Name = "chkHeap";
            this.chkHeap.Size = new System.Drawing.Size(69, 17);
            this.chkHeap.TabIndex = 5;
            this.chkHeap.Text = "Heapsort";
            this.chkHeap.UseVisualStyleBackColor = true;
            // 
            // chkQuicksort
            // 
            this.chkQuicksort.AutoSize = true;
            this.chkQuicksort.Location = new System.Drawing.Point(6, 89);
            this.chkQuicksort.Name = "chkQuicksort";
            this.chkQuicksort.Size = new System.Drawing.Size(71, 17);
            this.chkQuicksort.TabIndex = 4;
            this.chkQuicksort.Text = "Quicksort";
            this.chkQuicksort.UseVisualStyleBackColor = true;
            // 
            // chkMerge
            // 
            this.chkMerge.AutoSize = true;
            this.chkMerge.Location = new System.Drawing.Point(6, 66);
            this.chkMerge.Name = "chkMerge";
            this.chkMerge.Size = new System.Drawing.Size(78, 17);
            this.chkMerge.TabIndex = 3;
            this.chkMerge.Text = "Merge Sort";
            this.chkMerge.UseVisualStyleBackColor = true;
            // 
            // chkInsertion
            // 
            this.chkInsertion.AutoSize = true;
            this.chkInsertion.Location = new System.Drawing.Point(6, 43);
            this.chkInsertion.Name = "chkInsertion";
            this.chkInsertion.Size = new System.Drawing.Size(88, 17);
            this.chkInsertion.TabIndex = 2;
            this.chkInsertion.Text = "Insertion Sort";
            this.chkInsertion.UseVisualStyleBackColor = true;
            // 
            // chkBubble
            // 
            this.chkBubble.AutoSize = true;
            this.chkBubble.Location = new System.Drawing.Point(6, 19);
            this.chkBubble.Name = "chkBubble";
            this.chkBubble.Size = new System.Drawing.Size(76, 17);
            this.chkBubble.TabIndex = 1;
            this.chkBubble.Text = "Bubblesort";
            this.chkBubble.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(12, 362);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(201, 58);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go Go Gadget Sort";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // nudDelay
            // 
            this.nudDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudDelay.Location = new System.Drawing.Point(129, 301);
            this.nudDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(84, 20);
            this.nudDelay.TabIndex = 2;
            this.nudDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblIntervalLength
            // 
            this.lblIntervalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIntervalLength.AutoSize = true;
            this.lblIntervalLength.Location = new System.Drawing.Point(12, 303);
            this.lblIntervalLength.Name = "lblIntervalLength";
            this.lblIntervalLength.Size = new System.Drawing.Size(111, 13);
            this.lblIntervalLength.TabIndex = 3;
            this.lblIntervalLength.Text = "Iteration Inverval (ms):";
            // 
            // nudSetSize
            // 
            this.nudSetSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudSetSize.Location = new System.Drawing.Point(129, 328);
            this.nudSetSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSetSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSetSize.Name = "nudSetSize";
            this.nudSetSize.Size = new System.Drawing.Size(84, 20);
            this.nudSetSize.TabIndex = 4;
            this.nudSetSize.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            // 
            // lblSetSize
            // 
            this.lblSetSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSetSize.AutoSize = true;
            this.lblSetSize.Location = new System.Drawing.Point(12, 330);
            this.lblSetSize.Name = "lblSetSize";
            this.lblSetSize.Size = new System.Drawing.Size(49, 13);
            this.lblSetSize.TabIndex = 5;
            this.lblSetSize.Text = "Set Size:";
            // 
            // grpCollType
            // 
            this.grpCollType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCollType.Controls.Add(this.radUniform);
            this.grpCollType.Controls.Add(this.radSorted);
            this.grpCollType.Controls.Add(this.radFewUnique);
            this.grpCollType.Controls.Add(this.radReversed);
            this.grpCollType.Controls.Add(this.radRandomized);
            this.grpCollType.Location = new System.Drawing.Point(13, 163);
            this.grpCollType.Name = "grpCollType";
            this.grpCollType.Size = new System.Drawing.Size(200, 132);
            this.grpCollType.TabIndex = 6;
            this.grpCollType.TabStop = false;
            this.grpCollType.Text = "Collection Type";
            // 
            // radSorted
            // 
            this.radSorted.AutoSize = true;
            this.radSorted.Location = new System.Drawing.Point(6, 88);
            this.radSorted.Name = "radSorted";
            this.radSorted.Size = new System.Drawing.Size(56, 17);
            this.radSorted.TabIndex = 3;
            this.radSorted.TabStop = true;
            this.radSorted.Text = "Sorted";
            this.radSorted.UseVisualStyleBackColor = true;
            // 
            // radFewUnique
            // 
            this.radFewUnique.AutoSize = true;
            this.radFewUnique.Location = new System.Drawing.Point(6, 65);
            this.radFewUnique.Name = "radFewUnique";
            this.radFewUnique.Size = new System.Drawing.Size(126, 17);
            this.radFewUnique.TabIndex = 2;
            this.radFewUnique.TabStop = true;
            this.radFewUnique.Text = "Stepped (few unique)";
            this.radFewUnique.UseVisualStyleBackColor = true;
            // 
            // radReversed
            // 
            this.radReversed.AutoSize = true;
            this.radReversed.Location = new System.Drawing.Point(6, 42);
            this.radReversed.Name = "radReversed";
            this.radReversed.Size = new System.Drawing.Size(71, 17);
            this.radReversed.TabIndex = 1;
            this.radReversed.TabStop = true;
            this.radReversed.Text = "Reversed";
            this.radReversed.UseVisualStyleBackColor = true;
            // 
            // radRandomized
            // 
            this.radRandomized.AutoSize = true;
            this.radRandomized.Checked = true;
            this.radRandomized.Location = new System.Drawing.Point(6, 19);
            this.radRandomized.Name = "radRandomized";
            this.radRandomized.Size = new System.Drawing.Size(84, 17);
            this.radRandomized.TabIndex = 0;
            this.radRandomized.TabStop = true;
            this.radRandomized.Text = "Randomized";
            this.radRandomized.UseVisualStyleBackColor = true;
            // 
            // radUniform
            // 
            this.radUniform.AutoSize = true;
            this.radUniform.Location = new System.Drawing.Point(6, 111);
            this.radUniform.Name = "radUniform";
            this.radUniform.Size = new System.Drawing.Size(61, 17);
            this.radUniform.TabIndex = 4;
            this.radUniform.TabStop = true;
            this.radUniform.Text = "Uniform";
            this.radUniform.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 431);
            this.Controls.Add(this.grpCollType);
            this.Controls.Add(this.lblSetSize);
            this.Controls.Add(this.nudSetSize);
            this.Controls.Add(this.lblIntervalLength);
            this.Controls.Add(this.nudDelay);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.grpSorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Race";
            this.grpSorts.ResumeLayout(false);
            this.grpSorts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetSize)).EndInit();
            this.grpCollType.ResumeLayout(false);
            this.grpCollType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSorts;
        private System.Windows.Forms.CheckBox chkInsertion;
        private System.Windows.Forms.CheckBox chkBubble;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.Label lblIntervalLength;
        private System.Windows.Forms.NumericUpDown nudSetSize;
        private System.Windows.Forms.Label lblSetSize;
        private System.Windows.Forms.CheckBox chkMerge;
        private System.Windows.Forms.CheckBox chkQuicksort;
        private System.Windows.Forms.GroupBox grpCollType;
        private System.Windows.Forms.RadioButton radReversed;
        private System.Windows.Forms.RadioButton radRandomized;
        private System.Windows.Forms.RadioButton radFewUnique;
        private System.Windows.Forms.RadioButton radSorted;
        private System.Windows.Forms.CheckBox chkHeap;
        private System.Windows.Forms.RadioButton radUniform;
    }
}

