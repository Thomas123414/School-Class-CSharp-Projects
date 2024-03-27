namespace Luigis_Pizza
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBPizza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Radsmall = new System.Windows.Forms.RadioButton();
            this.Radmedium = new System.Windows.Forms.RadioButton();
            this.Radlarge = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxcheese = new System.Windows.Forms.CheckBox();
            this.CBoxham = new System.Windows.Forms.CheckBox();
            this.CBoxchilli = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DisOrd = new System.Windows.Forms.Button();
            this.lstorder = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNumPizza = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luigi\'s Pizza";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(213, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(213, 78);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(166, 20);
            this.txtCard.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credit Card Number:";
            // 
            // CBPizza
            // 
            this.CBPizza.FormattingEnabled = true;
            this.CBPizza.Items.AddRange(new object[] {
            "Margarita Pizza",
            "Veggie Pizza.",
            "Pepperoni Pizza.",
            "Meat Pizza.",
            "Margherita Pizza.",
            "BBQ Chicken Pizza.",
            "Hawaiian Pizza."});
            this.CBPizza.Location = new System.Drawing.Point(213, 117);
            this.CBPizza.Name = "CBPizza";
            this.CBPizza.Size = new System.Drawing.Size(166, 21);
            this.CBPizza.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pizza Type:";
            // 
            // Radsmall
            // 
            this.Radsmall.AutoSize = true;
            this.Radsmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radsmall.Location = new System.Drawing.Point(20, 229);
            this.Radsmall.Name = "Radsmall";
            this.Radsmall.Size = new System.Drawing.Size(96, 24);
            this.Radsmall.TabIndex = 7;
            this.Radsmall.TabStop = true;
            this.Radsmall.Text = "Small $8";
            this.Radsmall.UseVisualStyleBackColor = true;
            // 
            // Radmedium
            // 
            this.Radmedium.AutoSize = true;
            this.Radmedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radmedium.Location = new System.Drawing.Point(122, 230);
            this.Radmedium.Name = "Radmedium";
            this.Radmedium.Size = new System.Drawing.Size(124, 24);
            this.Radmedium.TabIndex = 8;
            this.Radmedium.TabStop = true;
            this.Radmedium.Text = "Medium $12";
            this.Radmedium.UseVisualStyleBackColor = true;
            // 
            // Radlarge
            // 
            this.Radlarge.AutoSize = true;
            this.Radlarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radlarge.Location = new System.Drawing.Point(252, 230);
            this.Radlarge.Name = "Radlarge";
            this.Radlarge.Size = new System.Drawing.Size(108, 24);
            this.Radlarge.TabIndex = 9;
            this.Radlarge.TabStop = true;
            this.Radlarge.Text = "Large $16";
            this.Radlarge.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Size:";
            // 
            // CBoxcheese
            // 
            this.CBoxcheese.AutoSize = true;
            this.CBoxcheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxcheese.Location = new System.Drawing.Point(389, 185);
            this.CBoxcheese.Name = "CBoxcheese";
            this.CBoxcheese.Size = new System.Drawing.Size(134, 24);
            this.CBoxcheese.TabIndex = 11;
            this.CBoxcheese.Text = "$1.0 Cheese ";
            this.CBoxcheese.UseVisualStyleBackColor = true;
            // 
            // CBoxham
            // 
            this.CBoxham.AutoSize = true;
            this.CBoxham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxham.Location = new System.Drawing.Point(389, 208);
            this.CBoxham.Name = "CBoxham";
            this.CBoxham.Size = new System.Drawing.Size(105, 24);
            this.CBoxham.TabIndex = 12;
            this.CBoxham.Text = "$1.5 Ham";
            this.CBoxham.UseVisualStyleBackColor = true;
            // 
            // CBoxchilli
            // 
            this.CBoxchilli.AutoSize = true;
            this.CBoxchilli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxchilli.Location = new System.Drawing.Point(389, 231);
            this.CBoxchilli.Name = "CBoxchilli";
            this.CBoxchilli.Size = new System.Drawing.Size(106, 24);
            this.CBoxchilli.TabIndex = 13;
            this.CBoxchilli.Text = "$0.8 Chilli";
            this.CBoxchilli.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Extras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // DisOrd
            // 
            this.DisOrd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisOrd.Location = new System.Drawing.Point(23, 333);
            this.DisOrd.Name = "DisOrd";
            this.DisOrd.Size = new System.Drawing.Size(163, 44);
            this.DisOrd.TabIndex = 16;
            this.DisOrd.Text = "Display Order";
            this.DisOrd.UseVisualStyleBackColor = true;
            this.DisOrd.Click += new System.EventHandler(this.DisOrd_Click);
            // 
            // lstorder
            // 
            this.lstorder.FormattingEnabled = true;
            this.lstorder.Location = new System.Drawing.Point(308, 261);
            this.lstorder.Name = "lstorder";
            this.lstorder.Size = new System.Drawing.Size(201, 186);
            this.lstorder.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Number Of Pizzas:";
            // 
            // TxtNumPizza
            // 
            this.TxtNumPizza.Location = new System.Drawing.Point(213, 158);
            this.TxtNumPizza.Name = "TxtNumPizza";
            this.TxtNumPizza.Size = new System.Drawing.Size(166, 20);
            this.TxtNumPizza.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.TxtNumPizza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstorder);
            this.Controls.Add(this.DisOrd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBoxchilli);
            this.Controls.Add(this.CBoxham);
            this.Controls.Add(this.CBoxcheese);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Radlarge);
            this.Controls.Add(this.Radmedium);
            this.Controls.Add(this.Radsmall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBPizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.txtName);
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBPizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Radsmall;
        private System.Windows.Forms.RadioButton Radmedium;
        private System.Windows.Forms.RadioButton Radlarge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CBoxcheese;
        private System.Windows.Forms.CheckBox CBoxham;
        private System.Windows.Forms.CheckBox CBoxchilli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DisOrd;
        private System.Windows.Forms.ListBox lstorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNumPizza;
    }
}

