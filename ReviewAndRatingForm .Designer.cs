using System;
using System.Windows.Forms;

namespace Db_project
{
    partial class ReviewAndRatingForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private ComboBox cmbTrips;
        private TextBox txtComments;
        private NumericUpDown numRating;
        private Button btnSubmitReview;
        private Label lblTrip;
        private Label lblComments;
        private Label lblRating;
        private Label lblTitle;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.cmbTrips = new System.Windows.Forms.ComboBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(417, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Your Review and Rating";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrip
            // 
            this.lblTrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTrip.Location = new System.Drawing.Point(419, 170);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(120, 30);
            this.lblTrip.TabIndex = 1;
            this.lblTrip.Text = "Select Trip:";
            // 
            // cmbTrips
            // 
            this.cmbTrips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrips.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbTrips.Items.AddRange(new object[] {
            "Trip 1",
            "Trip 2",
            "Trip 3"});
            this.cmbTrips.Location = new System.Drawing.Point(549, 170);
            this.cmbTrips.Name = "cmbTrips";
            this.cmbTrips.Size = new System.Drawing.Size(200, 24);
            this.cmbTrips.TabIndex = 2;
            // 
            // lblComments
            // 
            this.lblComments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblComments.Location = new System.Drawing.Point(419, 230);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(120, 30);
            this.lblComments.TabIndex = 3;
            this.lblComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Arial", 10F);
            this.txtComments.Location = new System.Drawing.Point(549, 230);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(400, 120);
            this.txtComments.TabIndex = 4;
            // 
            // lblRating
            // 
            this.lblRating.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRating.Location = new System.Drawing.Point(419, 370);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(120, 30);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = "Rating (1-5):";
            // 
            // numRating
            // 
            this.numRating.Font = new System.Drawing.Font("Arial", 10F);
            this.numRating.Location = new System.Drawing.Point(549, 370);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(100, 23);
            this.numRating.TabIndex = 6;
            this.numRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.BackColor = System.Drawing.Color.Teal;
            this.btnSubmitReview.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.Location = new System.Drawing.Point(549, 430);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(150, 40);
            this.btnSubmitReview.TabIndex = 7;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.UseVisualStyleBackColor = false;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(37, 648);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReviewAndRatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.cmbTrips);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.btnSubmitReview);
            this.Name = "ReviewAndRatingForm";
            this.Text = "Review and Rating Form";
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Button click event to submit a review
        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            string selectedTrip = cmbTrips.SelectedItem.ToString();
            string comments = txtComments.Text;
            int rating = (int)numRating.Value;

            if (string.IsNullOrEmpty(comments))
            {
                MessageBox.Show("Please enter your comments.");
                return;
            }

            // Normally, insert data into the database here.
            // For this demo, just show a success message and clear fields.

            MessageBox.Show("Review submitted successfully!");
            txtComments.Clear();  // Clear the comment box after submission
            numRating.Value = 5;  // Reset rating to 5
        }

        private Button btnBack;
    }
}
