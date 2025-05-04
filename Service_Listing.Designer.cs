using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace @new
{
    public partial class Service_Listing : Form
    {
        private System.ComponentModel.IContainer components = null;

        private Label label2;
        private DataGridView dataGridView1;
        private Button btnAddListing;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddListing = new System.Windows.Forms.Button();
            this.btn_BookingManagement = new System.Windows.Forms.Button();
            this.btnServiceConfirmation = new System.Windows.Forms.Button();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.btnProfileManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(400, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Service Listing Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.Location = new System.Drawing.Point(100, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1080, 288);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAddListing
            // 
            this.btnAddListing.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddListing.FlatAppearance.BorderSize = 0;
            this.btnAddListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddListing.ForeColor = System.Drawing.Color.White;
            this.btnAddListing.Location = new System.Drawing.Point(100, 418);
            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.Size = new System.Drawing.Size(160, 40);
            this.btnAddListing.TabIndex = 2;
            this.btnAddListing.Text = "+ Add Listing";
            this.btnAddListing.UseVisualStyleBackColor = false;
            this.btnAddListing.Click += new System.EventHandler(this.btnAddListing_Click);
            // 
            // btn_BookingManagement
            // 
            this.btn_BookingManagement.BackColor = System.Drawing.Color.Lime;
            this.btn_BookingManagement.FlatAppearance.BorderSize = 0;
            this.btn_BookingManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BookingManagement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_BookingManagement.ForeColor = System.Drawing.Color.White;
            this.btn_BookingManagement.Location = new System.Drawing.Point(839, 512);
            this.btn_BookingManagement.Name = "btn_BookingManagement";
            this.btn_BookingManagement.Size = new System.Drawing.Size(220, 50);
            this.btn_BookingManagement.TabIndex = 26;
            this.btn_BookingManagement.Text = "Booking Management";
            this.btn_BookingManagement.UseVisualStyleBackColor = false;
            this.btn_BookingManagement.Click += new System.EventHandler(this.btn_BookingManagement_Click);
            // 
            // btnServiceConfirmation
            // 
            this.btnServiceConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnServiceConfirmation.FlatAppearance.BorderSize = 0;
            this.btnServiceConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceConfirmation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnServiceConfirmation.ForeColor = System.Drawing.Color.White;
            this.btnServiceConfirmation.Location = new System.Drawing.Point(186, 512);
            this.btnServiceConfirmation.Name = "btnServiceConfirmation";
            this.btnServiceConfirmation.Size = new System.Drawing.Size(220, 50);
            this.btnServiceConfirmation.TabIndex = 23;
            this.btnServiceConfirmation.Text = "Service Confirmation";
            this.btnServiceConfirmation.UseVisualStyleBackColor = false;
            this.btnServiceConfirmation.Click += new System.EventHandler(this.btnServiceConfirmation_Click);
            // 
            // btnPerformance
            // 
            this.btnPerformance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPerformance.FlatAppearance.BorderSize = 0;
            this.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPerformance.ForeColor = System.Drawing.Color.White;
            this.btnPerformance.Location = new System.Drawing.Point(501, 512);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(220, 50);
            this.btnPerformance.TabIndex = 24;
            this.btnPerformance.Text = "Performance";
            this.btnPerformance.UseVisualStyleBackColor = false;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // btnProfileManagement
            // 
            this.btnProfileManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnProfileManagement.FlatAppearance.BorderSize = 0;
            this.btnProfileManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileManagement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnProfileManagement.ForeColor = System.Drawing.Color.White;
            this.btnProfileManagement.Location = new System.Drawing.Point(501, 614);
            this.btnProfileManagement.Name = "btnProfileManagement";
            this.btnProfileManagement.Size = new System.Drawing.Size(220, 50);
            this.btnProfileManagement.TabIndex = 27;
            this.btnProfileManagement.Text = "Profile Management";
            this.btnProfileManagement.UseVisualStyleBackColor = false;
            this.btnProfileManagement.Click += new System.EventHandler(this.btnProfileManagement_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(304, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "- Delete Listing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Service_Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProfileManagement);
            this.Controls.Add(this.btn_BookingManagement);
            this.Controls.Add(this.btnServiceConfirmation);
            this.Controls.Add(this.btnPerformance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddListing);
            this.Name = "Service_Listing";
            this.Text = "Service Listing Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button btn_BookingManagement;
        private Button btnServiceConfirmation;
        private Button btnPerformance;
        private Button btnProfileManagement;
        private Button button1;
    }
}
