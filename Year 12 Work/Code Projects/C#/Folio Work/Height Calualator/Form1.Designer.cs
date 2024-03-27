namespace Height_Calualator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtheight1 = new System.Windows.Forms.TextBox();
            this.txtheight2 = new System.Windows.Forms.TextBox();
            this.txtheight3 = new System.Windows.Forms.TextBox();
            this.txtheight4 = new System.Windows.Forms.TextBox();
            this.txtheight5 = new System.Windows.Forms.TextBox();
            this.lstdetails = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height 1 (cm)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height 2 (cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height 3 (cm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height 4 (cm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Height 5 (cm)";
            // 
            // txtheight1
            // 
            this.txtheight1.Location = new System.Drawing.Point(142, 69);
            this.txtheight1.Name = "txtheight1";
            this.txtheight1.Size = new System.Drawing.Size(185, 20);
            this.txtheight1.TabIndex = 6;
            // 
            // txtheight2
            // 
            this.txtheight2.Location = new System.Drawing.Point(142, 104);
            this.txtheight2.Name = "txtheight2";
            this.txtheight2.Size = new System.Drawing.Size(185, 20);
            this.txtheight2.TabIndex = 7;
            // 
            // txtheight3
            // 
            this.txtheight3.Location = new System.Drawing.Point(142, 142);
            this.txtheight3.Name = "txtheight3";
            this.txtheight3.Size = new System.Drawing.Size(185, 20);
            this.txtheight3.TabIndex = 8;
            // 
            // txtheight4
            // 
            this.txtheight4.Location = new System.Drawing.Point(142, 180);
            this.txtheight4.Name = "txtheight4";
            this.txtheight4.Size = new System.Drawing.Size(185, 20);
            this.txtheight4.TabIndex = 9;
            // 
            // txtheight5
            // 
            this.txtheight5.Location = new System.Drawing.Point(142, 220);
            this.txtheight5.Name = "txtheight5";
            this.txtheight5.Size = new System.Drawing.Size(185, 20);
            this.txtheight5.TabIndex = 10;
            // 
            // lstdetails
            // 
            this.lstdetails.FormattingEnabled = true;
            this.lstdetails.Location = new System.Drawing.Point(355, 64);
            this.lstdetails.Name = "lstdetails";
            this.lstdetails.Size = new System.Drawing.Size(226, 173);
            this.lstdetails.TabIndex = 11;
            this.lstdetails.SelectedIndexChanged += new System.EventHandler(this.lstdetails_SelectedIndexChanged);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(203, 246);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(182, 62);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 309);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lstdetails);
            this.Controls.Add(this.txtheight5);
            this.Controls.Add(this.txtheight4);
            this.Controls.Add(this.txtheight3);
            this.Controls.Add(this.txtheight2);
            this.Controls.Add(this.txtheight1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtheight1;
        private System.Windows.Forms.TextBox txtheight2;
        private System.Windows.Forms.TextBox txtheight3;
        private System.Windows.Forms.TextBox txtheight4;
        private System.Windows.Forms.TextBox txtheight5;
        private System.Windows.Forms.ListBox lstdetails;
        private System.Windows.Forms.Button btncalculate;
    }
}

