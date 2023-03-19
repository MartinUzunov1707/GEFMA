namespace GEFMA
{
    partial class CRUDForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnImageUpload = new System.Windows.Forms.Button();
            this.lblIsVegan = new System.Windows.Forms.Label();
            this.lblIsVegetarian = new System.Windows.Forms.Label();
            this.lblIsGlutenFree = new System.Windows.Forms.Label();
            this.lblIsHalal = new System.Windows.Forms.Label();
            this.chkIsVegan = new System.Windows.Forms.CheckBox();
            this.chkIsVegetarian = new System.Windows.Forms.CheckBox();
            this.chkIsGlutenFree = new System.Windows.Forms.CheckBox();
            this.chkIsHalal = new System.Windows.Forms.CheckBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblETA = new System.Windows.Forms.Label();
            this.txtETA = new System.Windows.Forms.TextBox();
            this.btnBackToDishes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(282, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(1579, 62);
            this.txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.Location = new System.Drawing.Point(282, 77);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(1579, 62);
            this.txtPrice.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Location = new System.Drawing.Point(282, 148);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1579, 62);
            this.txtDescription.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(153, 55);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(12, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(133, 55);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(12, 148);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(264, 55);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImage.Location = new System.Drawing.Point(954, 279);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(158, 55);
            this.lblImage.TabIndex = 6;
            this.lblImage.Text = "Image";
            // 
            // btnImageUpload
            // 
            this.btnImageUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImageUpload.Location = new System.Drawing.Point(935, 337);
            this.btnImageUpload.Name = "btnImageUpload";
            this.btnImageUpload.Size = new System.Drawing.Size(204, 76);
            this.btnImageUpload.TabIndex = 7;
            this.btnImageUpload.Text = "Upload Image";
            this.btnImageUpload.UseVisualStyleBackColor = true;
            this.btnImageUpload.Click += new System.EventHandler(this.btnImageUpload_Click);
            // 
            // lblIsVegan
            // 
            this.lblIsVegan.AutoSize = true;
            this.lblIsVegan.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsVegan.Location = new System.Drawing.Point(12, 289);
            this.lblIsVegan.Name = "lblIsVegan";
            this.lblIsVegan.Size = new System.Drawing.Size(164, 55);
            this.lblIsVegan.TabIndex = 8;
            this.lblIsVegan.Text = "Vegan";
            // 
            // lblIsVegetarian
            // 
            this.lblIsVegetarian.AutoSize = true;
            this.lblIsVegetarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsVegetarian.Location = new System.Drawing.Point(243, 289);
            this.lblIsVegetarian.Name = "lblIsVegetarian";
            this.lblIsVegetarian.Size = new System.Drawing.Size(257, 55);
            this.lblIsVegetarian.TabIndex = 9;
            this.lblIsVegetarian.Text = "Vegetarian";
            // 
            // lblIsGlutenFree
            // 
            this.lblIsGlutenFree.AutoSize = true;
            this.lblIsGlutenFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsGlutenFree.Location = new System.Drawing.Point(508, 289);
            this.lblIsGlutenFree.Name = "lblIsGlutenFree";
            this.lblIsGlutenFree.Size = new System.Drawing.Size(261, 55);
            this.lblIsGlutenFree.TabIndex = 10;
            this.lblIsGlutenFree.Text = "Gluten free";
            // 
            // lblIsHalal
            // 
            this.lblIsHalal.AutoSize = true;
            this.lblIsHalal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsHalal.Location = new System.Drawing.Point(775, 289);
            this.lblIsHalal.Name = "lblIsHalal";
            this.lblIsHalal.Size = new System.Drawing.Size(133, 55);
            this.lblIsHalal.TabIndex = 11;
            this.lblIsHalal.Text = "Halal";
            // 
            // chkIsVegan
            // 
            this.chkIsVegan.AutoSize = true;
            this.chkIsVegan.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkIsVegan.Location = new System.Drawing.Point(91, 347);
            this.chkIsVegan.Name = "chkIsVegan";
            this.chkIsVegan.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegan.TabIndex = 12;
            this.chkIsVegan.UseVisualStyleBackColor = true;
            // 
            // chkIsVegetarian
            // 
            this.chkIsVegetarian.AutoSize = true;
            this.chkIsVegetarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkIsVegetarian.Location = new System.Drawing.Point(366, 347);
            this.chkIsVegetarian.Name = "chkIsVegetarian";
            this.chkIsVegetarian.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegetarian.TabIndex = 13;
            this.chkIsVegetarian.UseVisualStyleBackColor = true;
            // 
            // chkIsGlutenFree
            // 
            this.chkIsGlutenFree.AutoSize = true;
            this.chkIsGlutenFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkIsGlutenFree.Location = new System.Drawing.Point(636, 347);
            this.chkIsGlutenFree.Name = "chkIsGlutenFree";
            this.chkIsGlutenFree.Size = new System.Drawing.Size(15, 14);
            this.chkIsGlutenFree.TabIndex = 14;
            this.chkIsGlutenFree.UseVisualStyleBackColor = true;
            // 
            // chkIsHalal
            // 
            this.chkIsHalal.AutoSize = true;
            this.chkIsHalal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkIsHalal.Location = new System.Drawing.Point(834, 347);
            this.chkIsHalal.Name = "chkIsHalal";
            this.chkIsHalal.Size = new System.Drawing.Size(15, 14);
            this.chkIsHalal.TabIndex = 15;
            this.chkIsHalal.UseVisualStyleBackColor = true;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(1154, 289);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(707, 381);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 16;
            this.picImage.TabStop = false;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(28, 419);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(1111, 586);
            this.dgvItems.TabIndex = 17;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.Location = new System.Drawing.Point(1172, 689);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(330, 79);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(1562, 774);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(330, 79);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(1172, 774);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(330, 79);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(1172, 774);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(330, 79);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblETA.Location = new System.Drawing.Point(18, 219);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(117, 55);
            this.lblETA.TabIndex = 22;
            this.lblETA.Text = "ETA";
            // 
            // txtETA
            // 
            this.txtETA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtETA.Location = new System.Drawing.Point(282, 216);
            this.txtETA.Name = "txtETA";
            this.txtETA.Size = new System.Drawing.Size(1579, 62);
            this.txtETA.TabIndex = 23;
            // 
            // btnBackToDishes
            // 
            this.btnBackToDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToDishes.Location = new System.Drawing.Point(1165, 883);
            this.btnBackToDishes.Name = "btnBackToDishes";
            this.btnBackToDishes.Size = new System.Drawing.Size(337, 122);
            this.btnBackToDishes.TabIndex = 24;
            this.btnBackToDishes.Text = "Back to dishes";
            this.btnBackToDishes.UseVisualStyleBackColor = true;
            this.btnBackToDishes.Click += new System.EventHandler(this.btnBackToDishes_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(1555, 883);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(337, 122);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Quit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBackToDishes);
            this.Controls.Add(this.txtETA);
            this.Controls.Add(this.lblETA);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.chkIsHalal);
            this.Controls.Add(this.chkIsGlutenFree);
            this.Controls.Add(this.chkIsVegetarian);
            this.Controls.Add(this.chkIsVegan);
            this.Controls.Add(this.lblIsHalal);
            this.Controls.Add(this.lblIsGlutenFree);
            this.Controls.Add(this.lblIsVegetarian);
            this.Controls.Add(this.lblIsVegan);
            this.Controls.Add(this.btnImageUpload);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Name = "CRUDForm";
            this.Text = "CRUDPage";
            this.Load += new System.EventHandler(this.CRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnImageUpload;
        private System.Windows.Forms.Label lblIsVegan;
        private System.Windows.Forms.Label lblIsVegetarian;
        private System.Windows.Forms.Label lblIsGlutenFree;
        private System.Windows.Forms.Label lblIsHalal;
        private System.Windows.Forms.CheckBox chkIsVegan;
        private System.Windows.Forms.CheckBox chkIsVegetarian;
        private System.Windows.Forms.CheckBox chkIsGlutenFree;
        private System.Windows.Forms.CheckBox chkIsHalal;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblETA;
        private System.Windows.Forms.TextBox txtETA;
        private System.Windows.Forms.Button btnBackToDishes;
        private System.Windows.Forms.Button btnClose;
    }
}