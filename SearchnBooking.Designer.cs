namespace Db_project
{
    partial class SearchnBooking
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
            this.lblSearchBookingTitle = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblPriceRange = new System.Windows.Forms.Label();
            this.txtPriceRange = new System.Windows.Forms.TextBox();
            this.lblActivityType = new System.Windows.Forms.Label();
            this.cmbActivityType = new System.Windows.Forms.ComboBox();
            this.lblGroupSize = new System.Windows.Forms.Label();
            this.txtGroupSize = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearchBookingTitle
            // 
            this.lblSearchBookingTitle.AutoSize = true;
            this.lblSearchBookingTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSearchBookingTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSearchBookingTitle.Location = new System.Drawing.Point(450, 30);
            this.lblSearchBookingTitle.Name = "lblSearchBookingTitle";
            this.lblSearchBookingTitle.Size = new System.Drawing.Size(388, 45);
            this.lblSearchBookingTitle.TabIndex = 0;
            this.lblSearchBookingTitle.Text = "Search & Book Your Trip";
            this.lblSearchBookingTitle.UseMnemonic = false;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDestination.Location = new System.Drawing.Point(384, 116);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(103, 21);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination:";
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDestination.Location = new System.Drawing.Point(534, 116);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(300, 25);
            this.txtDestination.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(384, 176);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 21);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Location = new System.Drawing.Point(534, 176);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(300, 25);
            this.dtpDate.TabIndex = 4;
            // 
            // lblPriceRange
            // 
            this.lblPriceRange.AutoSize = true;
            this.lblPriceRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPriceRange.Location = new System.Drawing.Point(384, 236);
            this.lblPriceRange.Name = "lblPriceRange";
            this.lblPriceRange.Size = new System.Drawing.Size(106, 21);
            this.lblPriceRange.TabIndex = 5;
            this.lblPriceRange.Text = "Max Budget:";
            // 
            // txtPriceRange
            // 
            this.txtPriceRange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPriceRange.Location = new System.Drawing.Point(534, 236);
            this.txtPriceRange.Name = "txtPriceRange";
            this.txtPriceRange.Size = new System.Drawing.Size(300, 25);
            this.txtPriceRange.TabIndex = 6;
            // 
            // lblActivityType
            // 
            this.lblActivityType.AutoSize = true;
            this.lblActivityType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivityType.Location = new System.Drawing.Point(384, 296);
            this.lblActivityType.Name = "lblActivityType";
            this.lblActivityType.Size = new System.Drawing.Size(113, 21);
            this.lblActivityType.TabIndex = 7;
            this.lblActivityType.Text = "Activity Type:";
            // 
            // cmbActivityType
            // 
            this.cmbActivityType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbActivityType.Items.AddRange(new object[] {
            "Hiking",
            "Cultural Tours",
            "Beach",
            "Adventure",
            "Sightseeing"});
            this.cmbActivityType.Location = new System.Drawing.Point(534, 296);
            this.cmbActivityType.Name = "cmbActivityType";
            this.cmbActivityType.Size = new System.Drawing.Size(300, 25);
            this.cmbActivityType.TabIndex = 8;
            // 
            // lblGroupSize
            // 
            this.lblGroupSize.AutoSize = true;
            this.lblGroupSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGroupSize.Location = new System.Drawing.Point(384, 356);
            this.lblGroupSize.Name = "lblGroupSize";
            this.lblGroupSize.Size = new System.Drawing.Size(96, 21);
            this.lblGroupSize.TabIndex = 9;
            this.lblGroupSize.Text = "Group Size:";
            // 
            // txtGroupSize
            // 
            this.txtGroupSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGroupSize.Location = new System.Drawing.Point(534, 356);
            this.txtGroupSize.Name = "txtGroupSize";
            this.txtGroupSize.Size = new System.Drawing.Size(300, 25);
            this.txtGroupSize.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(388, 439);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search Trips";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(688, 439);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(150, 40);
            this.btnBook.TabIndex = 12;
            this.btnBook.Text = "Book Now";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // SearchnBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblSearchBookingTitle);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblPriceRange);
            this.Controls.Add(this.txtPriceRange);
            this.Controls.Add(this.lblActivityType);
            this.Controls.Add(this.cmbActivityType);
            this.Controls.Add(this.lblGroupSize);
            this.Controls.Add(this.txtGroupSize);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBook);
            this.Name = "SearchnBooking";
            this.Text = "Search & Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchBookingTitle;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.TextBox txtPriceRange;
        private System.Windows.Forms.Label lblActivityType;
        private System.Windows.Forms.ComboBox cmbActivityType;
        private System.Windows.Forms.Label lblGroupSize;
        private System.Windows.Forms.TextBox txtGroupSize;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBook;
    }
}
