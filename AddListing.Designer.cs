namespace Db_project
{

    partial class AddListing
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblHeading.Location = new System.Drawing.Point(475, 34);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(300, 40);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Add New Listing";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTitle.Location = new System.Drawing.Point(450, 149);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(363, 29);
            this.txtTitle.TabIndex = 1;

            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrice.Location = new System.Drawing.Point(450, 207);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(363, 29);
            this.txtPrice.TabIndex = 3;

            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDescription.Location = new System.Drawing.Point(450, 260);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(363, 156);
            this.txtDescription.TabIndex = 4;

            this.btnSubmit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(450, 497);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(363, 65);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit Listing";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(24, 668);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(202, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblName.Location = new System.Drawing.Point(338, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 21);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name:";

            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblGender.Location = new System.Drawing.Point(338, 210);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 21);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Price:";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEmail.Location = new System.Drawing.Point(338, 263);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(102, 21);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Description:";

            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
    }
}
