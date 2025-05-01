using System.Windows.Forms;
using System;

namespace Db_project
{
    partial class TripDashboard
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTripDashboardTitle = new System.Windows.Forms.Label();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.btnDigitalPass = new System.Windows.Forms.Button();
            this.btnReviewsRatings = new System.Windows.Forms.Button();
            this.btnProfileManagement = new System.Windows.Forms.Button();
            this.btn_Book_Trip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTripDashboardTitle
            // 
            this.lblTripDashboardTitle.AutoSize = true;
            this.lblTripDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTripDashboardTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTripDashboardTitle.Location = new System.Drawing.Point(530, 30);
            this.lblTripDashboardTitle.Name = "lblTripDashboardTitle";
            this.lblTripDashboardTitle.Size = new System.Drawing.Size(257, 45);
            this.lblTripDashboardTitle.TabIndex = 0;
            this.lblTripDashboardTitle.Text = "Upcoming Trips";
            // 
            // dgvTrips
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.dgvTrips.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTrips.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrips.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTrips.Location = new System.Drawing.Point(162, 95);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RowHeadersWidth = 51;
            this.dgvTrips.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTrips.Size = new System.Drawing.Size(952, 294);
            this.dgvTrips.TabIndex = 1;
            this.dgvTrips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrips_CellContentClick);
            // 
            // btnDigitalPass
            // 
            this.btnDigitalPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDigitalPass.FlatAppearance.BorderSize = 0;
            this.btnDigitalPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDigitalPass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDigitalPass.ForeColor = System.Drawing.Color.White;
            this.btnDigitalPass.Location = new System.Drawing.Point(223, 490);
            this.btnDigitalPass.Name = "btnDigitalPass";
            this.btnDigitalPass.Size = new System.Drawing.Size(220, 50);
            this.btnDigitalPass.TabIndex = 2;
            this.btnDigitalPass.Text = "Digital Travel Pass";
            this.btnDigitalPass.UseVisualStyleBackColor = false;
            this.btnDigitalPass.Click += new System.EventHandler(this.btnDigitalPass_Click);
            // 
            // btnReviewsRatings
            // 
            this.btnReviewsRatings.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReviewsRatings.FlatAppearance.BorderSize = 0;
            this.btnReviewsRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewsRatings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReviewsRatings.ForeColor = System.Drawing.Color.White;
            this.btnReviewsRatings.Location = new System.Drawing.Point(538, 490);
            this.btnReviewsRatings.Name = "btnReviewsRatings";
            this.btnReviewsRatings.Size = new System.Drawing.Size(220, 50);
            this.btnReviewsRatings.TabIndex = 3;
            this.btnReviewsRatings.Text = "Reviews and Ratings";
            this.btnReviewsRatings.UseVisualStyleBackColor = false;
            this.btnReviewsRatings.Click += new System.EventHandler(this.btnReviewsRatings_Click);
            // 
            // btnProfileManagement
            // 
            this.btnProfileManagement.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnProfileManagement.FlatAppearance.BorderSize = 0;
            this.btnProfileManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileManagement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnProfileManagement.ForeColor = System.Drawing.Color.White;
            this.btnProfileManagement.Location = new System.Drawing.Point(881, 490);
            this.btnProfileManagement.Name = "btnProfileManagement";
            this.btnProfileManagement.Size = new System.Drawing.Size(220, 50);
            this.btnProfileManagement.TabIndex = 4;
            this.btnProfileManagement.Text = "Profile Management";
            this.btnProfileManagement.UseVisualStyleBackColor = false;
            this.btnProfileManagement.Click += new System.EventHandler(this.btnProfileManagement_Click);
            // 
            // btn_Book_Trip
            // 
            this.btn_Book_Trip.BackColor = System.Drawing.Color.Lime;
            this.btn_Book_Trip.FlatAppearance.BorderSize = 0;
            this.btn_Book_Trip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Book_Trip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Book_Trip.ForeColor = System.Drawing.Color.White;
            this.btn_Book_Trip.Location = new System.Drawing.Point(538, 618);
            this.btn_Book_Trip.Name = "btn_Book_Trip";
            this.btn_Book_Trip.Size = new System.Drawing.Size(220, 50);
            this.btn_Book_Trip.TabIndex = 5;
            this.btn_Book_Trip.Text = "Book Trip";
            this.btn_Book_Trip.UseVisualStyleBackColor = false;
            this.btn_Book_Trip.Click += new System.EventHandler(this.button1_Click);
            // 
            // TripDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_Book_Trip);
            this.Controls.Add(this.btnDigitalPass);
            this.Controls.Add(this.btnReviewsRatings);
            this.Controls.Add(this.btnProfileManagement);
            this.Controls.Add(this.lblTripDashboardTitle);
            this.Controls.Add(this.dgvTrips);
            this.Name = "TripDashboard";
            this.Text = "Trip Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //string searchTerm = txtSearch.Text.ToLower();
            //foreach (DataGridViewRow row in dgvTrips.Rows)
            //{
            //    bool isVisible = row.Cells["Title"].Value.ToString().ToLower().Contains(searchTerm);
            //    row.Visible = isVisible;
            //}
        }

        #endregion

        private System.Windows.Forms.Label lblTripDashboardTitle;
        private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.Button btnDigitalPass;
        private System.Windows.Forms.Button btnReviewsRatings;
        private System.Windows.Forms.Button btnProfileManagement;
        private Button btn_Book_Trip;
    }
}
