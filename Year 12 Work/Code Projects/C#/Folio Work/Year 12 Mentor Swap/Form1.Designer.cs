namespace Year_12_Mentor_Swap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.txtYear12 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMentor = new System.Windows.Forms.ListBox();
            this.btnYear7 = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnNewMentor = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year 12 Mentor Swap";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year 7 Student Name:";
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(610, 164);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(123, 20);
            this.txtSession.TabIndex = 3;
            //this.txtSession.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mentor Sessions Attend:";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtYear7
            // 
            this.txtYear7.Location = new System.Drawing.Point(227, 162);
            this.txtYear7.Name = "txtYear7";
            this.txtYear7.Size = new System.Drawing.Size(133, 20);
            this.txtYear7.TabIndex = 3;
            //this.txtYear7.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Current Year 12 Mentor:";
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(548, 200);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(185, 20);
            this.txtAlt.TabIndex = 3;
            //this.txtAlt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtYear12
            // 
            this.txtYear12.Location = new System.Drawing.Point(251, 200);
            this.txtYear12.Name = "txtYear12";
            this.txtYear12.Size = new System.Drawing.Size(123, 20);
            this.txtYear12.TabIndex = 3;
            //this.txtYear12.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alt Mentor Name";
            //this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstMentor
            // 
            this.lstMentor.FormattingEnabled = true;
            this.lstMentor.Location = new System.Drawing.Point(209, 226);
            this.lstMentor.Name = "lstMentor";
            this.lstMentor.Size = new System.Drawing.Size(298, 134);
            this.lstMentor.TabIndex = 5;
            // 
            // btnYear7
            // 
            this.btnYear7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear7.Location = new System.Drawing.Point(57, 366);
            this.btnYear7.Name = "btnYear7";
            this.btnYear7.Size = new System.Drawing.Size(317, 25);
            this.btnYear7.TabIndex = 6;
            this.btnYear7.Text = "Display current year 7 student with mentor";
            this.btnYear7.UseVisualStyleBackColor = true;
            this.btnYear7.Click += new System.EventHandler(this.btnYear7_Click);
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.Location = new System.Drawing.Point(393, 366);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(353, 25);
            this.btnTime.TabIndex = 7;
            this.btnTime.Text = "Display the total time of student attending mentor in mins";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNewMentor
            // 
            this.btnNewMentor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMentor.Location = new System.Drawing.Point(57, 408);
            this.btnNewMentor.Name = "btnNewMentor";
            this.btnNewMentor.Size = new System.Drawing.Size(317, 23);
            this.btnNewMentor.TabIndex = 8;
            this.btnNewMentor.Text = "Display new mentor with student ";
            this.btnNewMentor.UseVisualStyleBackColor = true;
            this.btnNewMentor.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwap.Location = new System.Drawing.Point(393, 408);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(353, 23);
            this.btnSwap.TabIndex = 9;
            this.btnSwap.Text = "Swap current and alternative mentor names in text boxs";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnNewMentor);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnYear7);
            this.Controls.Add(this.lstMentor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear12);
            this.Controls.Add(this.txtYear7);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.TextBox txtYear12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstMentor;
        private System.Windows.Forms.Button btnYear7;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnNewMentor;
        private System.Windows.Forms.Button btnSwap;
    }
}

