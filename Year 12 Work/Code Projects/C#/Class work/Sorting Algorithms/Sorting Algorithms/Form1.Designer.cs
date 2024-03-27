namespace Sorting_Algorithms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectionSort = new Button();
            lstOutput = new ListBox();
            btnQuickSort = new Button();
            btnDisplay = new Button();
            SuspendLayout();
            // 
            // btnSelectionSort
            // 
            btnSelectionSort.Location = new Point(347, 317);
            btnSelectionSort.Name = "btnSelectionSort";
            btnSelectionSort.Size = new Size(100, 23);
            btnSelectionSort.TabIndex = 0;
            btnSelectionSort.Text = "Selection Sort";
            btnSelectionSort.UseVisualStyleBackColor = true;
            btnSelectionSort.Click += btnSelectionSort_Click;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(245, 94);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(120, 199);
            lstOutput.TabIndex = 1;
            // 
            // btnQuickSort
            // 
            btnQuickSort.Location = new Point(205, 317);
            btnQuickSort.Name = "btnQuickSort";
            btnQuickSort.Size = new Size(115, 23);
            btnQuickSort.TabIndex = 2;
            btnQuickSort.Text = "Quick Sort";
            btnQuickSort.UseVisualStyleBackColor = true;
            btnQuickSort.Click += btnQuickSort_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(210, 395);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 3;
            btnDisplay.Text = "Display Array";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisplay);
            Controls.Add(btnQuickSort);
            Controls.Add(lstOutput);
            Controls.Add(btnSelectionSort);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectionSort;
        private ListBox lstOutput;
        private Button btnQuickSort;
        private Button btnDisplay;
    }
}