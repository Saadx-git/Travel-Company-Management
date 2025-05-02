namespace Db_project
{
    partial class HotelAssignment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelBookingID = new System.Windows.Forms.Label();
            this.bookingid = new System.Windows.Forms.TextBox();
            this.labelHotel = new System.Windows.Forms.Label();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.assignmentdate = new System.Windows.Forms.DateTimePicker();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTitle.Location = new System.Drawing.Point(180, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(350, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "🏨 Hotel Assignment";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelBookingID);
            this.groupBox.Controls.Add(this.bookingid);
            this.groupBox.Controls.Add(this.labelHotel);
            this.groupBox.Controls.Add(this.textBoxHotelName);
            this.groupBox.Controls.Add(this.labelDate);
            this.groupBox.Controls.Add(this.assignmentdate);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.groupBox.Location = new System.Drawing.Point(100, 80);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(500, 230);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Hotel Assignment Details";
            // 
            // labelBookingID
            // 
            this.labelBookingID.AutoSize = true;
            this.labelBookingID.Location = new System.Drawing.Point(30, 40);
            this.labelBookingID.Name = "labelBookingID";
            this.labelBookingID.Size = new System.Drawing.Size(95, 23);
            this.labelBookingID.TabIndex = 0;
            this.labelBookingID.Text = "📄 Booking ID:";
            // 
            // bookingid
            // 
            this.bookingid.Location = new System.Drawing.Point(200, 40);
            this.bookingid.Name = "bookingid";
            this.bookingid.Size = new System.Drawing.Size(200, 30);
            this.bookingid.TabIndex = 1;
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(30, 95);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(109, 23);
            this.labelHotel.TabIndex = 2;
            this.labelHotel.Text = "🏨 Hotel Name:";
            // 
            // textBoxHotelName
            // 
            this.textBoxHotelName.Location = new System.Drawing.Point(200, 95);
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(200, 30);
            this.textBoxHotelName.TabIndex = 3;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(30, 150);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(147, 23);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "🗓 Assignment Date:";
            // 
            // assignmentdate
            // 
            this.assignmentdate.Location = new System.Drawing.Point(200, 150);
            this.assignmentdate.Name = "assignmentdate";
            this.assignmentdate.Size = new System.Drawing.Size(250, 30);
            this.assignmentdate.TabIndex = 5;
            // 
            // buttonAssign
            // 
            this.buttonAssign.BackColor = System.Drawing.Color.Teal;
            this.buttonAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssign.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAssign.ForeColor = System.Drawing.Color.White;
            this.buttonAssign.Location = new System.Drawing.Point(270, 330);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(150, 40);
            this.buttonAssign.TabIndex = 6;
            this.buttonAssign.Text = "Assign Hotel";
            this.buttonAssign.UseVisualStyleBackColor = false;
            // 
            // HotelAssignment
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.labelTitle);
            this.Name = "HotelAssignment";
            this.Text = "Hotel Assignment";
       //     this.Load += new System.EventHandler(this.HotelAssignment_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelBookingID;
        private System.Windows.Forms.TextBox bookingid;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.TextBox textBoxHotelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker assignmentdate;
        private System.Windows.Forms.Button buttonAssign;
    }
}
