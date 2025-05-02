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
            this.panelTourCategories = new System.Windows.Forms.Panel();
            this.labelTourCategories = new System.Windows.Forms.Label();
            this.dgvTourCategories = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.panelTourCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTourCategories
            // 
            this.panelTourCategories.BackColor = System.Drawing.Color.White;
            this.panelTourCategories.Controls.Add(this.labelTourCategories);
            this.panelTourCategories.Controls.Add(this.dgvTourCategories);
            this.panelTourCategories.Controls.Add(this.btnAddCategory);
            this.panelTourCategories.Controls.Add(this.btnEditCategory);
            this.panelTourCategories.Controls.Add(this.btnDeleteCategory);
            this.panelTourCategories.Location = new System.Drawing.Point(12, 12);
            this.panelTourCategories.Name = "panelTourCategories";
            this.panelTourCategories.Size = new System.Drawing.Size(760, 350);
            this.panelTourCategories.TabIndex = 5;
            // 
            // labelTourCategories
            // 
            this.labelTourCategories.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTourCategories.ForeColor = System.Drawing.Color.Teal;
            this.labelTourCategories.Location = new System.Drawing.Point(200, 10);
            this.labelTourCategories.Name = "labelTourCategories";
            this.labelTourCategories.Size = new System.Drawing.Size(350, 30);
            this.labelTourCategories.TabIndex = 0;
            this.labelTourCategories.Text = "🌍 Tour Categories Management ✈️";
            this.labelTourCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTourCategories
            // 
            this.dgvTourCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourCategories.Location = new System.Drawing.Point(20, 50);
            this.dgvTourCategories.Name = "dgvTourCategories";
            this.dgvTourCategories.RowHeadersWidth = 57;
            this.dgvTourCategories.Size = new System.Drawing.Size(720, 150);
            this.dgvTourCategories.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(20, 210);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(150, 40);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "➕ Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.Orange;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditCategory.Location = new System.Drawing.Point(200, 210);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(150, 40);
            this.btnEditCategory.TabIndex = 3;
            this.btnEditCategory.Text = "✏️ Edit Category";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(380, 210);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "🗑️ Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // Tour_Categories_Management
            // 
            this.ClientSize = new System.Drawing.Size(845, 453);
            this.Controls.Add(this.panelTourCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Tour_Categories_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Interface - TravelEase";
            this.panelTourCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourCategories)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Panel panelTourCategories;
            private System.Windows.Forms.Label labelTourCategories;
            private System.Windows.Forms.DataGridView dgvTourCategories;
            private System.Windows.Forms.Button btnAddCategory;
            private System.Windows.Forms.Button btnEditCategory;
            private System.Windows.Forms.Button btnDeleteCategory;
        }
    }
