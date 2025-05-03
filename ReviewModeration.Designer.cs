using System.Windows.Forms;

namespace Db_project
{
    partial class ReviewModeration
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
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.txtReviewID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblReviewID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReviews
            // 
            this.dgvReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReviews.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvReviews.Location = new System.Drawing.Point(400, 50);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.Size = new System.Drawing.Size(850, 600);
            this.dgvReviews.TabIndex = 0;
            // 
            // txtReviewID
            // 
            this.txtReviewID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtReviewID.Location = new System.Drawing.Point(160, 100);
            this.txtReviewID.Name = "txtReviewID";
            this.txtReviewID.Size = new System.Drawing.Size(200, 29);
            this.txtReviewID.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(50, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(310, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Review";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(50, 653);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(183, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblReviewID
            // 
            this.lblReviewID.BackColor = System.Drawing.Color.Transparent;
            this.lblReviewID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReviewID.ForeColor = System.Drawing.Color.Black;
            this.lblReviewID.Location = new System.Drawing.Point(50, 100);
            this.lblReviewID.Name = "lblReviewID";
            this.lblReviewID.Size = new System.Drawing.Size(100, 30);
            this.lblReviewID.TabIndex = 0;
            this.lblReviewID.Text = "Review ID:";
            // 
            // ReviewModeration
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblReviewID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.txtReviewID);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReviewModeration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Moderation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.TextBox txtReviewID;
        private System.Windows.Forms.Button btnDelete;


        #endregion

        private Button btnBack;
        private Label lblReviewID;
    }
}