namespace Arrays_Application
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstoutput = new System.Windows.Forms.ListBox();
            this.btnNumbers = new System.Windows.Forms.Button();
            this.btnNumbers3 = new System.Windows.Forms.Button();
            this.btnNumbers2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrays Application";
            // 
            // lstoutput
            // 
            this.lstoutput.FormattingEnabled = true;
            this.lstoutput.Location = new System.Drawing.Point(68, 51);
            this.lstoutput.Name = "lstoutput";
            this.lstoutput.Size = new System.Drawing.Size(140, 160);
            this.lstoutput.TabIndex = 1;
            this.lstoutput.SelectedIndexChanged += new System.EventHandler(this.lstoutput_SelectedIndexChanged);
            // 
            // btnNumbers
            // 
            this.btnNumbers.Location = new System.Drawing.Point(68, 217);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(140, 42);
            this.btnNumbers.TabIndex = 2;
            this.btnNumbers.Text = "Display Numbers!";
            this.btnNumbers.UseVisualStyleBackColor = true;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnNumbers3
            // 
            this.btnNumbers3.Location = new System.Drawing.Point(68, 315);
            this.btnNumbers3.Name = "btnNumbers3";
            this.btnNumbers3.Size = new System.Drawing.Size(140, 46);
            this.btnNumbers3.TabIndex = 3;
            this.btnNumbers3.Text = "Display Numbers 3!";
            this.btnNumbers3.UseVisualStyleBackColor = true;
            this.btnNumbers3.Click += new System.EventHandler(this.btnNumbers3_Click);
            // 
            // btnNumbers2
            // 
            this.btnNumbers2.Location = new System.Drawing.Point(68, 265);
            this.btnNumbers2.Name = "btnNumbers2";
            this.btnNumbers2.Size = new System.Drawing.Size(140, 44);
            this.btnNumbers2.TabIndex = 4;
            this.btnNumbers2.Text = "Display Numbers 2!";
            this.btnNumbers2.UseVisualStyleBackColor = true;
            this.btnNumbers2.Click += new System.EventHandler(this.btnNumbers2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 386);
            this.Controls.Add(this.btnNumbers2);
            this.Controls.Add(this.btnNumbers3);
            this.Controls.Add(this.btnNumbers);
            this.Controls.Add(this.lstoutput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstoutput;
        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.Button btnNumbers3;
        private System.Windows.Forms.Button btnNumbers2;
    }
}

