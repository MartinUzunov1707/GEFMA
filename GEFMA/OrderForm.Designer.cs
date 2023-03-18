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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblETA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(947, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(751, 696);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1489, 907);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1697, 907);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 95);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(144, 907);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 95);
            this.button3.TabIndex = 3;
            this.button3.Text = "Order Item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(433, 907);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 95);
            this.button4.TabIndex = 4;
            this.button4.Text = "View Order";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 68.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(240, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(287, 102);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(109, 825);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(113, 42);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(86, 216);
            this.lblDescription.MaximumSize = new System.Drawing.Size(805, 281);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(205, 42);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblIsVegan
            // 
            this.lblIsVegan.AutoSize = true;
            this.lblIsVegan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsVegan.Location = new System.Drawing.Point(96, 468);
            this.lblIsVegan.Name = "lblIsVegan";
            this.lblIsVegan.Size = new System.Drawing.Size(116, 39);
            this.lblIsVegan.TabIndex = 8;
            this.lblIsVegan.Text = "Vegan";
            // 
            // lblIsVegetarian
            // 
            this.lblIsVegetarian.AutoSize = true;
            this.lblIsVegetarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsVegetarian.Location = new System.Drawing.Point(96, 547);
            this.lblIsVegetarian.Name = "lblIsVegetarian";
            this.lblIsVegetarian.Size = new System.Drawing.Size(184, 39);
            this.lblIsVegetarian.TabIndex = 9;
            this.lblIsVegetarian.Text = "Vegetarian";
            // 
            // lblIsGlutenFree
            // 
            this.lblIsGlutenFree.AutoSize = true;
            this.lblIsGlutenFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsGlutenFree.Location = new System.Drawing.Point(96, 625);
            this.lblIsGlutenFree.Name = "lblIsGlutenFree";
            this.lblIsGlutenFree.Size = new System.Drawing.Size(199, 39);
            this.lblIsGlutenFree.TabIndex = 10;
            this.lblIsGlutenFree.Text = "Gluten Free";
            // 
            // lblIsHalal
            // 
            this.lblIsHalal.AutoSize = true;
            this.lblIsHalal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsHalal.Location = new System.Drawing.Point(110, 701);
            this.lblIsHalal.Name = "lblIsHalal";
            this.lblIsHalal.Size = new System.Drawing.Size(96, 39);
            this.lblIsHalal.TabIndex = 11;
            this.lblIsHalal.Text = "Halal";
            // 
            // chkIsVegan
            // 
            this.chkIsVegan.AutoSize = true;
            this.chkIsVegan.Enabled = false;
            this.chkIsVegan.Location = new System.Drawing.Point(265, 479);
            this.chkIsVegan.Name = "chkIsVegan";
            this.chkIsVegan.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegan.TabIndex = 12;
            this.chkIsVegan.UseVisualStyleBackColor = true;
            // 
            // chkIsVegetarian
            // 
            this.chkIsVegetarian.AutoSize = true;
            this.chkIsVegetarian.Enabled = false;
            this.chkIsVegetarian.Location = new System.Drawing.Point(303, 568);
            this.chkIsVegetarian.Name = "chkIsVegetarian";
            this.chkIsVegetarian.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegetarian.TabIndex = 13;
            this.chkIsVegetarian.UseVisualStyleBackColor = true;
            // 
            // chkIsGlutenFree
            // 
            this.chkIsGlutenFree.AutoSize = true;
            this.chkIsGlutenFree.Enabled = false;
            this.chkIsGlutenFree.Location = new System.Drawing.Point(312, 637);
            this.chkIsGlutenFree.Name = "chkIsGlutenFree";
            this.chkIsGlutenFree.Size = new System.Drawing.Size(15, 14);
            this.chkIsGlutenFree.TabIndex = 14;
            this.chkIsGlutenFree.UseVisualStyleBackColor = true;
            // 
            // chkIsHalal
            // 
            this.chkIsHalal.AutoSize = true;
            this.chkIsHalal.Enabled = false;
            this.chkIsHalal.Location = new System.Drawing.Point(257, 722);
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1791, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 48);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit Database";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblETA.Location = new System.Drawing.Point(513, 825);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(0, 39);
            this.lblETA.TabIndex = 18;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblETA);
            this.Controls.Add(this.btnEdit);
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblETA;
    }
}