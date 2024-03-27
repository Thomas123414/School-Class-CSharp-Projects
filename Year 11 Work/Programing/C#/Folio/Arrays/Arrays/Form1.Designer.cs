namespace Arrays
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
            this.lstcars = new System.Windows.Forms.ListBox();
            this.btncars = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstcars
            // 
            this.lstcars.FormattingEnabled = true;
            this.lstcars.Location = new System.Drawing.Point(82, 75);
            this.lstcars.Name = "lstcars";
            this.lstcars.Size = new System.Drawing.Size(143, 134);
            this.lstcars.TabIndex = 0;
            this.lstcars.SelectedIndexChanged += new System.EventHandler(this.lstcars_SelectedIndexChanged);
            // 
            // btncars
            // 
            this.btncars.Location = new System.Drawing.Point(82, 238);
            this.btncars.Name = "btncars";
            this.btncars.Size = new System.Drawing.Size(143, 49);
            this.btncars.TabIndex = 1;
            this.btncars.Text = "Display List Of Cars";
            this.btncars.UseVisualStyleBackColor = true;
            this.btncars.Click += new System.EventHandler(this.btncars_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of cars in my garage ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncars);
            this.Controls.Add(this.lstcars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstcars;
        private System.Windows.Forms.Button btncars;
        private System.Windows.Forms.Label label1;
    }
}

