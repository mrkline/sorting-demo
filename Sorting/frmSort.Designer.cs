namespace Sorting
{
    partial class frmSort
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
            this.components = new System.ComponentModel.Container();
            this.lblDone = new System.Windows.Forms.Label();
            this.tmrDelay = new System.Windows.Forms.Timer(this.components);
            this.bwAlgoRunner = new System.ComponentModel.BackgroundWorker();
            this.crCollection = new Sorting.CollectionRenderer();
            this.SuspendLayout();
            // 
            // lblDone
            // 
            this.lblDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDone.Location = new System.Drawing.Point(12, 239);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(132, 20);
            this.lblDone.TabIndex = 1;
            this.lblDone.Text = "Set At Runtime";
            this.lblDone.Visible = false;
            // 
            // tmrDelay
            // 
            this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
            // 
            // bwAlgoRunner
            // 
            this.bwAlgoRunner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAlgoRunner_DoWork);
            this.bwAlgoRunner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAlgoRunner_RunWorkerCompleted);
            // 
            // crCollection
            // 
            this.crCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crCollection.AssignmentColor = System.Drawing.Color.Blue;
            this.crCollection.ComparisonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crCollection.CurrentState = null;
            this.crCollection.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crCollection.Location = new System.Drawing.Point(12, 12);
            this.crCollection.Name = "crCollection";
            this.crCollection.Size = new System.Drawing.Size(470, 192);
            this.crCollection.TabIndex = 0;
            // 
            // frmSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 272);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.crCollection);
            this.MaximizeBox = false;
            this.Name = "frmSort";
            this.ShowIcon = false;
            this.Text = "Set At Runtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CollectionRenderer crCollection;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Timer tmrDelay;
        private System.ComponentModel.BackgroundWorker bwAlgoRunner;
    }
}