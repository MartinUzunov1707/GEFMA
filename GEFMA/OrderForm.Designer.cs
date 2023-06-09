﻿namespace GEFMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(841, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(1066, 572);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrevious.Location = new System.Drawing.Point(1262, 934);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(185, 81);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(1262, 851);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 79);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrder.Location = new System.Drawing.Point(711, 851);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(529, 166);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order Item";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewOrder.Location = new System.Drawing.Point(402, 851);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(288, 166);
            this.btnViewOrder.TabIndex = 4;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 68.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(40, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(287, 102);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(407, 772);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(146, 55);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(31, 210);
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
            this.lblIsVegan.Location = new System.Drawing.Point(410, 685);
            this.lblIsVegan.Name = "lblIsVegan";
            this.lblIsVegan.Size = new System.Drawing.Size(116, 39);
            this.lblIsVegan.TabIndex = 8;
            this.lblIsVegan.Text = "Vegan";
            // 
            // lblIsVegetarian
            // 
            this.lblIsVegetarian.AutoSize = true;
            this.lblIsVegetarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsVegetarian.Location = new System.Drawing.Point(1032, 689);
            this.lblIsVegetarian.Name = "lblIsVegetarian";
            this.lblIsVegetarian.Size = new System.Drawing.Size(184, 39);
            this.lblIsVegetarian.TabIndex = 9;
            this.lblIsVegetarian.Text = "Vegetarian";
            // 
            // lblIsGlutenFree
            // 
            this.lblIsGlutenFree.AutoSize = true;
            this.lblIsGlutenFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsGlutenFree.Location = new System.Drawing.Point(648, 689);
            this.lblIsGlutenFree.Name = "lblIsGlutenFree";
            this.lblIsGlutenFree.Size = new System.Drawing.Size(199, 39);
            this.lblIsGlutenFree.TabIndex = 10;
            this.lblIsGlutenFree.Text = "Gluten Free";
            // 
            // lblIsHalal
            // 
            this.lblIsHalal.AutoSize = true;
            this.lblIsHalal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsHalal.Location = new System.Drawing.Point(1335, 689);
            this.lblIsHalal.Name = "lblIsHalal";
            this.lblIsHalal.Size = new System.Drawing.Size(96, 39);
            this.lblIsHalal.TabIndex = 11;
            this.lblIsHalal.Text = "Halal";
            // 
            // chkIsVegan
            // 
            this.chkIsVegan.AutoSize = true;
            this.chkIsVegan.Enabled = false;
            this.chkIsVegan.Location = new System.Drawing.Point(456, 727);
            this.chkIsVegan.Name = "chkIsVegan";
            this.chkIsVegan.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegan.TabIndex = 12;
            this.chkIsVegan.UseVisualStyleBackColor = true;
            // 
            // chkIsVegetarian
            // 
            this.chkIsVegetarian.AutoSize = true;
            this.chkIsVegetarian.Enabled = false;
            this.chkIsVegetarian.Location = new System.Drawing.Point(1121, 727);
            this.chkIsVegetarian.Name = "chkIsVegetarian";
            this.chkIsVegetarian.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegetarian.TabIndex = 13;
            this.chkIsVegetarian.UseVisualStyleBackColor = true;
            // 
            // chkIsGlutenFree
            // 
            this.chkIsGlutenFree.AutoSize = true;
            this.chkIsGlutenFree.Enabled = false;
            this.chkIsGlutenFree.Location = new System.Drawing.Point(734, 727);
            this.chkIsGlutenFree.Name = "chkIsGlutenFree";
            this.chkIsGlutenFree.Size = new System.Drawing.Size(15, 14);
            this.chkIsGlutenFree.TabIndex = 14;
            this.chkIsGlutenFree.UseVisualStyleBackColor = true;
            // 
            // chkIsHalal
            // 
            this.chkIsHalal.AutoSize = true;
            this.chkIsHalal.Enabled = false;
            this.chkIsHalal.Location = new System.Drawing.Point(1378, 731);
            this.chkIsHalal.Name = "chkIsHalal";
            this.chkIsHalal.Size = new System.Drawing.Size(15, 14);
            this.chkIsHalal.TabIndex = 15;
            this.chkIsHalal.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuit.Location = new System.Drawing.Point(1719, 924);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(173, 105);
            this.btnQuit.TabIndex = 16;
            this.btnQuit.Text = "Close";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(1719, 813);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(173, 105);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit Database";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblETA.Location = new System.Drawing.Point(767, 772);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(537, 55);
            this.lblETA.TabIndex = 18;
            this.lblETA.Text = "Estimated time to make:";
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
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.picImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.Text = "GEFMA";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnViewOrder;
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