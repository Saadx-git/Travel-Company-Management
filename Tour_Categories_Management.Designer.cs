namespace Db_project
{
    partial class Tour_Categories_Management
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

            private void InitializeComponent()
            {
            this.labelTourCategories = new System.Windows.Forms.Label();
            this.dgvTourCategories = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTourCategories
            // 
            this.labelTourCategories.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTourCategories.ForeColor = System.Drawing.Color.Teal;
            this.labelTourCategories.Location = new System.Drawing.Point(245, 24);
            this.labelTourCategories.Name = "labelTourCategories";
            this.labelTourCategories.Size = new System.Drawing.Size(350, 30);
            this.labelTourCategories.TabIndex = 5;
            this.labelTourCategories.Text = "🌍 Tour Categories Management ✈️";
            this.labelTourCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTourCategories
            // 
            this.dgvTourCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourCategories.Location = new System.Drawing.Point(65, 64);
            this.dgvTourCategories.Name = "dgvTourCategories";
            this.dgvTourCategories.RowHeadersWidth = 57;
            this.dgvTourCategories.Size = new System.Drawing.Size(720, 150);
            this.dgvTourCategories.TabIndex = 6;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(65, 224);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(150, 40);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "➕ Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.Orange;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditCategory.Location = new System.Drawing.Point(245, 224);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(150, 40);
            this.btnEditCategory.TabIndex = 8;
            this.btnEditCategory.Text = "✏️ Edit Category";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(425, 224);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteCategory.TabIndex = 9;
            this.btnDeleteCategory.Text = "🗑️ Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // Tour_Categories_Management
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(845, 453);
            this.Controls.Add(this.labelTourCategories);
            this.Controls.Add(this.dgvTourCategories);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Tour_Categories_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Interface - TravelEase";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourCategories)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Label labelTourCategories;
        private System.Windows.Forms.DataGridView dgvTourCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
    }
    }
