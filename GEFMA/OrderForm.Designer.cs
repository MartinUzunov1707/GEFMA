namespace GEFMA
{
    partial class OrderForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblIsVegan = new System.Windows.Forms.Label();
            this.lblIsVegetarian = new System.Windows.Forms.Label();
            this.lblIsGlutenFree = new System.Windows.Forms.Label();
            this.lblIsHalal = new System.Windows.Forms.Label();
            this.chkIsVegan = new System.Windows.Forms.CheckBox();
            this.chkIsVegetarian = new System.Windows.Forms.CheckBox();
            this.chkIsGlutenFree = new System.Windows.Forms.CheckBox();
            this.chkIsHalal = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(947, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(751, 696);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1525, 932);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1718, 932);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 932);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "Order Item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 932);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 70);
            this.button4.TabIndex = 4;
            this.button4.Text = "View Order";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(145, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 42);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(109, 825);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(90, 33);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(96, 203);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(151, 31);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblIsVegan
            // 
            this.lblIsVegan.AutoSize = true;
            this.lblIsVegan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsVegan.Location = new System.Drawing.Point(96, 468);
            this.lblIsVegan.Name = "lblIsVegan";
            this.lblIsVegan.Size = new System.Drawing.Size(82, 29);
            this.lblIsVegan.TabIndex = 8;
            this.lblIsVegan.Text = "Vegan";
            // 
            // lblIsVegetarian
            // 
            this.lblIsVegetarian.AutoSize = true;
            this.lblIsVegetarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsVegetarian.Location = new System.Drawing.Point(96, 547);
            this.lblIsVegetarian.Name = "lblIsVegetarian";
            this.lblIsVegetarian.Size = new System.Drawing.Size(129, 29);
            this.lblIsVegetarian.TabIndex = 9;
            this.lblIsVegetarian.Text = "Vegetarian";
            // 
            // lblIsGlutenFree
            // 
            this.lblIsGlutenFree.AutoSize = true;
            this.lblIsGlutenFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsGlutenFree.Location = new System.Drawing.Point(96, 625);
            this.lblIsGlutenFree.Name = "lblIsGlutenFree";
            this.lblIsGlutenFree.Size = new System.Drawing.Size(140, 29);
            this.lblIsGlutenFree.TabIndex = 10;
            this.lblIsGlutenFree.Text = "Gluten Free";
            // 
            // lblIsHalal
            // 
            this.lblIsHalal.AutoSize = true;
            this.lblIsHalal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsHalal.Location = new System.Drawing.Point(110, 701);
            this.lblIsHalal.Name = "lblIsHalal";
            this.lblIsHalal.Size = new System.Drawing.Size(68, 29);
            this.lblIsHalal.TabIndex = 11;
            this.lblIsHalal.Text = "Halal";
            // 
            // chkIsVegan
            // 
            this.chkIsVegan.AutoSize = true;
            this.chkIsVegan.Enabled = false;
            this.chkIsVegan.Location = new System.Drawing.Point(222, 480);
            this.chkIsVegan.Name = "chkIsVegan";
            this.chkIsVegan.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegan.TabIndex = 12;
            this.chkIsVegan.UseVisualStyleBackColor = true;
            // 
            // chkIsVegetarian
            // 
            this.chkIsVegetarian.AutoSize = true;
            this.chkIsVegetarian.Enabled = false;
            this.chkIsVegetarian.Location = new System.Drawing.Point(247, 559);
            this.chkIsVegetarian.Name = "chkIsVegetarian";
            this.chkIsVegetarian.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegetarian.TabIndex = 13;
            this.chkIsVegetarian.UseVisualStyleBackColor = true;
            // 
            // chkIsGlutenFree
            // 
            this.chkIsGlutenFree.AutoSize = true;
            this.chkIsGlutenFree.Enabled = false;
            this.chkIsGlutenFree.Location = new System.Drawing.Point(258, 637);
            this.chkIsGlutenFree.Name = "chkIsGlutenFree";
            this.chkIsGlutenFree.Size = new System.Drawing.Size(15, 14);
            this.chkIsGlutenFree.TabIndex = 14;
            this.chkIsGlutenFree.UseVisualStyleBackColor = true;
            // 
            // chkIsHalal
            // 
            this.chkIsHalal.AutoSize = true;
            this.chkIsHalal.Enabled = false;
            this.chkIsHalal.Location = new System.Drawing.Point(235, 713);
            this.chkIsHalal.Name = "chkIsHalal";
            this.chkIsHalal.Size = new System.Drawing.Size(15, 14);
            this.chkIsHalal.TabIndex = 15;
            this.chkIsHalal.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1791, 42);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(101, 47);
            this.btnQuit.TabIndex = 16;
            this.btnQuit.Text = "Close";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.chkIsHalal);
            this.Controls.Add(this.chkIsGlutenFree);
            this.Controls.Add(this.chkIsVegetarian);
            this.Controls.Add(this.chkIsVegan);
            this.Controls.Add(this.lblIsHalal);
            this.Controls.Add(this.lblIsGlutenFree);
            this.Controls.Add(this.lblIsVegetarian);
            this.Controls.Add(this.lblIsVegan);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblIsVegan;
        private System.Windows.Forms.Label lblIsVegetarian;
        private System.Windows.Forms.Label lblIsGlutenFree;
        private System.Windows.Forms.Label lblIsHalal;
        private System.Windows.Forms.CheckBox chkIsVegan;
        private System.Windows.Forms.CheckBox chkIsVegetarian;
        private System.Windows.Forms.CheckBox chkIsGlutenFree;
        private System.Windows.Forms.CheckBox chkIsHalal;
        private System.Windows.Forms.Button btnQuit;
    }
}