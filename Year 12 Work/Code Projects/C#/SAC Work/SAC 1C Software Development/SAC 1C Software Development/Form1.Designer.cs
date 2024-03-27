namespace SAC_1C_Software_Development
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LsvOutput = new System.Windows.Forms.ListView();
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Givenname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.House = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year_Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.btnInputDetails = new System.Windows.Forms.Button();
            this.btnViewEvent = new System.Windows.Forms.Button();
            this.btnEditCompetitor = new System.Windows.Forms.Button();
            this.btnViewFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Belair High School Swimming Sports Home";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(637, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // LsvOutput
            // 
            this.LsvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Event,
            this.Givenname,
            this.Surname,
            this.Gender,
            this.House,
            this.Age,
            this.Year_Level});
            this.LsvOutput.HideSelection = false;
            this.LsvOutput.Location = new System.Drawing.Point(12, 53);
            this.LsvOutput.Name = "LsvOutput";
            this.LsvOutput.Size = new System.Drawing.Size(619, 282);
            this.LsvOutput.TabIndex = 3;
            this.LsvOutput.UseCompatibleStateImageBehavior = false;
            this.LsvOutput.View = System.Windows.Forms.View.Details;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            this.Event.Width = 100;
            // 
            // Givenname
            // 
            this.Givenname.Text = "GivenName";
            this.Givenname.Width = 120;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 100;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // House
            // 
            this.House.Text = "House";
            this.House.Width = 90;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            // 
            // Year_Level
            // 
            this.Year_Level.Text = "Year_Level";
            this.Year_Level.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Event:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(641, 314);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAge.Location = new System.Drawing.Point(638, 261);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(179, 15);
            this.lblAverageAge.TabIndex = 6;
            this.lblAverageAge.Text = "Average age of Competitors:";
            // 
            // btnInputDetails
            // 
            this.btnInputDetails.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputDetails.Location = new System.Drawing.Point(23, 352);
            this.btnInputDetails.Name = "btnInputDetails";
            this.btnInputDetails.Size = new System.Drawing.Size(165, 29);
            this.btnInputDetails.TabIndex = 7;
            this.btnInputDetails.Text = "Input Competitor Details";
            this.btnInputDetails.UseVisualStyleBackColor = true;
            this.btnInputDetails.Click += new System.EventHandler(this.btnInputDetails_Click);
            // 
            // btnViewEvent
            // 
            this.btnViewEvent.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEvent.Location = new System.Drawing.Point(563, 352);
            this.btnViewEvent.Name = "btnViewEvent";
            this.btnViewEvent.Size = new System.Drawing.Size(183, 29);
            this.btnViewEvent.TabIndex = 8;
            this.btnViewEvent.Text = "View Competitors By Event";
            this.btnViewEvent.UseVisualStyleBackColor = true;
            this.btnViewEvent.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditCompetitor
            // 
            this.btnEditCompetitor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCompetitor.Location = new System.Drawing.Point(343, 352);
            this.btnEditCompetitor.Name = "btnEditCompetitor";
            this.btnEditCompetitor.Size = new System.Drawing.Size(214, 29);
            this.btnEditCompetitor.TabIndex = 9;
            this.btnEditCompetitor.Text = "Edit Selected Competitor Details";
            this.btnEditCompetitor.UseVisualStyleBackColor = true;
            this.btnEditCompetitor.Click += new System.EventHandler(this.btnEditCompetitor_Click);
            // 
            // btnViewFile
            // 
            this.btnViewFile.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFile.Location = new System.Drawing.Point(194, 352);
            this.btnViewFile.Name = "btnViewFile";
            this.btnViewFile.Size = new System.Drawing.Size(143, 29);
            this.btnViewFile.TabIndex = 10;
            this.btnViewFile.Text = "View Competitor File";
            this.btnViewFile.UseVisualStyleBackColor = true;
            this.btnViewFile.Click += new System.EventHandler(this.btnViewFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(854, 393);
            this.Controls.Add(this.btnViewFile);
            this.Controls.Add(this.btnEditCompetitor);
            this.Controls.Add(this.btnViewEvent);
            this.Controls.Add(this.btnInputDetails);
            this.Controls.Add(this.lblAverageAge);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LsvOutput);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView LsvOutput;
        private System.Windows.Forms.ColumnHeader Givenname;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader House;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Year_Level;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Button btnInputDetails;
        private System.Windows.Forms.Button btnViewEvent;
        private System.Windows.Forms.Button btnEditCompetitor;
        private System.Windows.Forms.Button btnViewFile;
        internal System.Windows.Forms.ColumnHeader Event;
    }
}

