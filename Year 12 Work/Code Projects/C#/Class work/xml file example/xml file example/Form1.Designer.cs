namespace xml_file_example
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFName = new TextBox();
            txtSName = new TextBox();
            txtAge = new TextBox();
            txtNumber = new TextBox();
            btnSave = new Button();
            btnDisplayFile = new Button();
            lsvOutput = new ListView();
            FirstName = new ColumnHeader();
            Surname = new ColumnHeader();
            Age = new ColumnHeader();
            No = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(198, 18);
            label1.Name = "label1";
            label1.Size = new Size(462, 32);
            label1.TabIndex = 0;
            label1.Text = "Armstrong Lake Soccer Player Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 101);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "FirstName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 135);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Surname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 168);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 201);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Number:";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(265, 100);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(100, 23);
            txtFName.TabIndex = 5;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(263, 133);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(100, 23);
            txtSName.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(238, 168);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 7;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(263, 193);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(182, 301);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 30);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save to file";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDisplayFile
            // 
            btnDisplayFile.Location = new Point(368, 305);
            btnDisplayFile.Name = "btnDisplayFile";
            btnDisplayFile.Size = new Size(98, 26);
            btnDisplayFile.TabIndex = 10;
            btnDisplayFile.Text = "Display File";
            btnDisplayFile.UseVisualStyleBackColor = true;
            btnDisplayFile.Click += btnDisplayFile_Click;
            // 
            // lsvOutput
            // 
            lsvOutput.Columns.AddRange(new ColumnHeader[] { FirstName, Surname, Age, No });
            lsvOutput.Location = new Point(452, 76);
            lsvOutput.Name = "lsvOutput";
            lsvOutput.Size = new Size(378, 191);
            lsvOutput.TabIndex = 11;
            lsvOutput.UseCompatibleStateImageBehavior = false;
            lsvOutput.View = View.Details;
            // 
            // FirstName
            // 
            FirstName.Text = "Firstname";
            FirstName.Width = 80;
            // 
            // Surname
            // 
            Surname.Text = "Surname";
            Surname.Width = 80;
            // 
            // Age
            // 
            Age.Text = "Age";
            // 
            // No
            // 
            No.Text = "Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
            Controls.Add(lsvOutput);
            Controls.Add(btnDisplayFile);
            Controls.Add(btnSave);
            Controls.Add(txtNumber);
            Controls.Add(txtAge);
            Controls.Add(txtSName);
            Controls.Add(txtFName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFName;
        private TextBox txtSName;
        private TextBox txtAge;
        private TextBox txtNumber;
        private Button btnSave;
        private Button btnDisplayFile;
        private ListView lsvOutput;
        private ColumnHeader FirstName;
        private ColumnHeader Surname;
        private ColumnHeader Age;
        private ColumnHeader No;
    }
}