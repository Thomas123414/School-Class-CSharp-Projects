namespace Arrays_Example
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInputToArray = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDisplayNos = new System.Windows.Forms.Button();
            this.btnAddnumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrays Example";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 58);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(175, 199);
            this.lstOutput.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(12, 391);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(237, 48);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display Name Array Contents";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 463);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(237, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search Array for a value";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInputToArray
            // 
            this.btnInputToArray.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInputToArray.Location = new System.Drawing.Point(225, 222);
            this.btnInputToArray.Name = "btnInputToArray";
            this.btnInputToArray.Size = new System.Drawing.Size(287, 35);
            this.btnInputToArray.TabIndex = 4;
            this.btnInputToArray.Text = "Store + Display Input Values in Array";
            this.btnInputToArray.UseVisualStyleBackColor = true;
            this.btnInputToArray.Click += new System.EventHandler(this.btnInputToArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(283, 58);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 20);
            this.txtName1.TabIndex = 6;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(283, 91);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(100, 20);
            this.txtName2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(283, 124);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(100, 20);
            this.txtName3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // txtName4
            // 
            this.txtName4.Location = new System.Drawing.Point(283, 157);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(100, 20);
            this.txtName4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(282, 475);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDisplayNos
            // 
            this.btnDisplayNos.Location = new System.Drawing.Point(12, 309);
            this.btnDisplayNos.Name = "btnDisplayNos";
            this.btnDisplayNos.Size = new System.Drawing.Size(237, 50);
            this.btnDisplayNos.TabIndex = 15;
            this.btnDisplayNos.Text = "Display numbers array";
            this.btnDisplayNos.UseVisualStyleBackColor = true;
            this.btnDisplayNos.Click += new System.EventHandler(this.btnDisplayNos_Click);
            // 
            // btnAddnumbers
            // 
            this.btnAddnumbers.Location = new System.Drawing.Point(282, 309);
            this.btnAddnumbers.Name = "btnAddnumbers";
            this.btnAddnumbers.Size = new System.Drawing.Size(230, 50);
            this.btnAddnumbers.TabIndex = 16;
            this.btnAddnumbers.Text = "Add Numbers";
            this.btnAddnumbers.UseVisualStyleBackColor = true;
            this.btnAddnumbers.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 533);
            this.Controls.Add(this.btnAddnumbers);
            this.Controls.Add(this.btnDisplayNos);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtName4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInputToArray);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Output";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInputToArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDisplayNos;
        private System.Windows.Forms.Button btnAddnumbers;
    }
}

