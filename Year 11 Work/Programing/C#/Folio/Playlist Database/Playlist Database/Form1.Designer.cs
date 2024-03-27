namespace Playlist_Database
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
            this.txtduration = new System.Windows.Forms.TextBox();
            this.txtsong = new System.Windows.Forms.TextBox();
            this.txtartist = new System.Windows.Forms.TextBox();
            this.cbogenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstfile = new System.Windows.Forms.ListBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playlist Database";
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(337, 166);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(100, 20);
            this.txtduration.TabIndex = 1;
            // 
            // txtsong
            // 
            this.txtsong.Location = new System.Drawing.Point(127, 87);
            this.txtsong.Name = "txtsong";
            this.txtsong.Size = new System.Drawing.Size(100, 20);
            this.txtsong.TabIndex = 2;
            // 
            // txtartist
            // 
            this.txtartist.Location = new System.Drawing.Point(127, 166);
            this.txtartist.Name = "txtartist";
            this.txtartist.Size = new System.Drawing.Size(100, 20);
            this.txtartist.TabIndex = 3;
            // 
            // cbogenre
            // 
            this.cbogenre.FormattingEnabled = true;
            this.cbogenre.Items.AddRange(new object[] {
            "Hip hop",
            "Rock",
            "Country",
            "Jazz",
            "Blues",
            "Pop",
            "Heavy metal",
            "Punk rock",
            "R&B",
            "Alternative rock",
            "Classical music",
            "Soul",
            "Reggae",
            "Indie rock",
            "Electronic dance music",
            "Techno",
            "Electronic",
            "Hard rock",
            "Folk",
            "Grunge",
            "Music of Latin America",
            "Pop rock",
            "Funk",
            "Latin music"});
            this.cbogenre.Location = new System.Drawing.Point(337, 87);
            this.cbogenre.Name = "cbogenre";
            this.cbogenre.Size = new System.Drawing.Size(100, 21);
            this.cbogenre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Song Title ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Artist";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Duration";
            // 
            // lstfile
            // 
            this.lstfile.FormattingEnabled = true;
            this.lstfile.Location = new System.Drawing.Point(111, 212);
            this.lstfile.Name = "lstfile";
            this.lstfile.Size = new System.Drawing.Size(297, 134);
            this.lstfile.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(4, 379);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(144, 30);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save To File";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(140, 379);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(191, 30);
            this.btndisplay.TabIndex = 11;
            this.btndisplay.Text = "View File Contents";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(323, 379);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(172, 30);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear Form Details";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 419);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lstfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbogenre);
            this.Controls.Add(this.txtartist);
            this.Controls.Add(this.txtsong);
            this.Controls.Add(this.txtduration);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.TextBox txtsong;
        private System.Windows.Forms.TextBox txtartist;
        private System.Windows.Forms.ComboBox cbogenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstfile;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnclear;
    }
}

