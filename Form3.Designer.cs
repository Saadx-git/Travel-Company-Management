using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace @new
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddListing = new System.Windows.Forms.Button();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Service Listing Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colServiceName,
                this.colLocation,
                this.colEdit});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(0, 64, 0);

            // this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0))), ((int)(((byte)(64))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(50, 100);

            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 250);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAddListing
            // 
            this.btnAddListing.BackColor = System.Drawing.Color.White;
            this.btnAddListing.FlatAppearance.BorderSize = 0;
            this.btnAddListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btnAddListing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0))), ((int)(((byte)(64))), ((int)(((byte)(0)))));
            this.btnAddListing.Location = new System.Drawing.Point(50, 370);
            this.btnAddListing.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);

            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.Size = new System.Drawing.Size(120, 30);
            this.btnAddListing.TabIndex = 4;
            this.btnAddListing.Text = "+ Add Listing";
            this.btnAddListing.UseVisualStyleBackColor = false;
            // 
            // colServiceName
            // 
            this.colServiceName.HeaderText = "Hotel/Service Name";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.Width = 300;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Width = 250;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0))), ((int)(((byte)(64))), ((int)(((byte)(0)))));
            this.BackColor = System.Drawing.Color.FromArgb(0, 64, 0);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddListing);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Service Listing Management";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddListing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(0, 100, 0),       // Dark green
                Color.FromArgb(144, 238, 144),    // Light green
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}