namespace GEFMA
{
    partial class CRUDFormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDFormOrders));
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnMarkAsInProgress = new System.Windows.Forms.Button();
            this.btnMarkAsCompleted = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBackToDishes = new System.Windows.Forms.Button();
            this.btnGoToDishes = new System.Windows.Forms.Button();
            this.btnDeleteCompleted = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(316, 227);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(1378, 750);
            this.dgvItems.TabIndex = 18;
            // 
            // btnMarkAsInProgress
            // 
            this.btnMarkAsInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMarkAsInProgress.Location = new System.Drawing.Point(26, 227);
            this.btnMarkAsInProgress.Name = "btnMarkAsInProgress";
            this.btnMarkAsInProgress.Size = new System.Drawing.Size(269, 134);
            this.btnMarkAsInProgress.TabIndex = 21;
            this.btnMarkAsInProgress.Text = "Mark as in progress";
            this.btnMarkAsInProgress.UseVisualStyleBackColor = true;
            this.btnMarkAsInProgress.Click += new System.EventHandler(this.btnMarkAsInProgress_Click);
            // 
            // btnMarkAsCompleted
            // 
            this.btnMarkAsCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMarkAsCompleted.Location = new System.Drawing.Point(26, 376);
            this.btnMarkAsCompleted.Name = "btnMarkAsCompleted";
            this.btnMarkAsCompleted.Size = new System.Drawing.Size(269, 134);
            this.btnMarkAsCompleted.TabIndex = 22;
            this.btnMarkAsCompleted.Text = "Mark as completed";
            this.btnMarkAsCompleted.UseVisualStyleBackColor = true;
            this.btnMarkAsCompleted.Click += new System.EventHandler(this.btnMarkAsCompleted_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(26, 656);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(269, 134);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(464, 77);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(383, 116);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Quit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBackToDishes
            // 
            this.btnBackToDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToDishes.Location = new System.Drawing.Point(891, 72);
            this.btnBackToDishes.Name = "btnBackToDishes";
            this.btnBackToDishes.Size = new System.Drawing.Size(383, 121);
            this.btnBackToDishes.TabIndex = 27;
            this.btnBackToDishes.Text = "Back to dishes";
            this.btnBackToDishes.UseVisualStyleBackColor = true;
            this.btnBackToDishes.Click += new System.EventHandler(this.btnBackToDishes_Click);
            // 
            // btnGoToDishes
            // 
            this.btnGoToDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToDishes.Location = new System.Drawing.Point(1311, 72);
            this.btnGoToDishes.Name = "btnGoToDishes";
            this.btnGoToDishes.Size = new System.Drawing.Size(383, 121);
            this.btnGoToDishes.TabIndex = 28;
            this.btnGoToDishes.Text = "Edit database";
            this.btnGoToDishes.UseVisualStyleBackColor = true;
            this.btnGoToDishes.Click += new System.EventHandler(this.btnGoToDishes_Click);
            // 
            // btnDeleteCompleted
            // 
            this.btnDeleteCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCompleted.Location = new System.Drawing.Point(26, 516);
            this.btnDeleteCompleted.Name = "btnDeleteCompleted";
            this.btnDeleteCompleted.Size = new System.Drawing.Size(269, 134);
            this.btnDeleteCompleted.TabIndex = 29;
            this.btnDeleteCompleted.Text = "Delete completed";
            this.btnDeleteCompleted.UseVisualStyleBackColor = true;
            this.btnDeleteCompleted.Click += new System.EventHandler(this.btnDeleteCompleted_Click);
            // 
            // CRUDFormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnDeleteCompleted);
            this.Controls.Add(this.btnGoToDishes);
            this.Controls.Add(this.btnBackToDishes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMarkAsCompleted);
            this.Controls.Add(this.btnMarkAsInProgress);
            this.Controls.Add(this.dgvItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUDFormOrders";
            this.Text = "GEFMA";
            this.Load += new System.EventHandler(this.CRUDFormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnMarkAsInProgress;
        private System.Windows.Forms.Button btnMarkAsCompleted;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBackToDishes;
        private System.Windows.Forms.Button btnGoToDishes;
        private System.Windows.Forms.Button btnDeleteCompleted;
    }
}