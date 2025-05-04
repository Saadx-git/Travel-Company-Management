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
            this.buttonAssign = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelBookingID = new System.Windows.Forms.Label();
            this.bookingid = new System.Windows.Forms.TextBox();
            this.labelHotel = new System.Windows.Forms.Label();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.assignmentdate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(450, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(350, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "🏨 Hotel Assignment";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAssign
            // 
            this.buttonAssign.BackColor = System.Drawing.Color.Indigo;
            this.buttonAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssign.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAssign.ForeColor = System.Drawing.Color.White;
            this.buttonAssign.Location = new System.Drawing.Point(802, 313);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(166, 45);
            this.buttonAssign.TabIndex = 6;
            this.buttonAssign.Text = "Assign Hotel";
            this.buttonAssign.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(31, 611);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 40);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelBookingID
            // 
            this.labelBookingID.AutoSize = true;
            this.labelBookingID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingID.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelBookingID.Location = new System.Drawing.Point(672, 138);
            this.labelBookingID.Name = "labelBookingID";
            this.labelBookingID.Size = new System.Drawing.Size(123, 21);
            this.labelBookingID.TabIndex = 26;
            this.labelBookingID.Text = "📄 Booking ID:";
            // 
            // bookingid
            // 
            this.bookingid.Location = new System.Drawing.Point(864, 138);
            this.bookingid.Name = "bookingid";
            this.bookingid.Size = new System.Drawing.Size(200, 20);
            this.bookingid.TabIndex = 27;
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelHotel.Location = new System.Drawing.Point(672, 193);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(133, 21);
            this.labelHotel.TabIndex = 28;
            this.labelHotel.Text = "🏨 Hotel Name:";
            // 
            // textBoxHotelName
            // 
            this.textBoxHotelName.Location = new System.Drawing.Point(864, 193);
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(200, 20);
            this.textBoxHotelName.TabIndex = 29;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelDate.Location = new System.Drawing.Point(672, 248);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(169, 21);
            this.labelDate.TabIndex = 30;
            this.labelDate.Text = "🗓 Assignment Date:";
            // 
            // assignmentdate
            // 
            this.assignmentdate.Location = new System.Drawing.Point(864, 248);
            this.assignmentdate.Name = "assignmentdate";
            this.assignmentdate.Size = new System.Drawing.Size(250, 20);
            this.assignmentdate.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 437);
            this.dataGridView1.TabIndex = 32;
            // 
            // HotelAssignment
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelBookingID);
            this.Controls.Add(this.bookingid);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.textBoxHotelName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.assignmentdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.labelTitle);
            this.Name = "HotelAssignment";
            this.Text = "Hotel Assignment";
            this.Load += new System.EventHandler(this.HotelAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelBookingID;
        private System.Windows.Forms.TextBox bookingid;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.TextBox textBoxHotelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker assignmentdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
