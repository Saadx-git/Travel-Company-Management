namespace Db_project
{
    partial class AdminInterface
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblUSrID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.prfile_mng = new System.Windows.Forms.Button();
            this.showtravellers = new System.Windows.Forms.Button();
            this.showoperators = new System.Windows.Forms.Button();
            this.showproviders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(375, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(552, 63);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "User/Operator Management";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 95);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(551, 557);
            this.dgvUsers.TabIndex = 6;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Green;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(857, 198);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(150, 40);
            this.btnApprove.TabIndex = 7;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(1056, 198);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(150, 40);
            this.btnReject.TabIndex = 8;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // lblUSrID
            // 
            this.lblUSrID.AutoSize = true;
            this.lblUSrID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUSrID.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblUSrID.Location = new System.Drawing.Point(853, 117);
            this.lblUSrID.Name = "lblUSrID";
            this.lblUSrID.Size = new System.Drawing.Size(69, 21);
            this.lblUSrID.TabIndex = 17;
            this.lblUSrID.Text = "User ID:";
            this.lblUSrID.Click += new System.EventHandler(this.lblTripID_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserID.Location = new System.Drawing.Point(998, 113);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(208, 25);
            this.txtUserID.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(855, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "Categories Management";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(855, 537);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 47);
            this.button2.TabIndex = 20;
            this.button2.Text = "Analytics";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(855, 605);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 47);
            this.button3.TabIndex = 21;
            this.button3.Text = "Review Moderation";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // prfile_mng
            // 
            this.prfile_mng.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.prfile_mng.FlatAppearance.BorderSize = 0;
            this.prfile_mng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prfile_mng.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.prfile_mng.ForeColor = System.Drawing.Color.White;
            this.prfile_mng.Location = new System.Drawing.Point(855, 400);
            this.prfile_mng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prfile_mng.Name = "prfile_mng";
            this.prfile_mng.Size = new System.Drawing.Size(262, 47);
            this.prfile_mng.TabIndex = 22;
            this.prfile_mng.Text = "Profile Management";
            this.prfile_mng.UseVisualStyleBackColor = false;
            this.prfile_mng.Click += new System.EventHandler(this.prfile_mng_Click);
            // 
            // showtravellers
            // 
            this.showtravellers.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.showtravellers.FlatAppearance.BorderSize = 0;
            this.showtravellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showtravellers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.showtravellers.ForeColor = System.Drawing.Color.White;
            this.showtravellers.Location = new System.Drawing.Point(597, 472);
            this.showtravellers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showtravellers.Name = "showtravellers";
            this.showtravellers.Size = new System.Drawing.Size(155, 47);
            this.showtravellers.TabIndex = 23;
            this.showtravellers.Text = "Travellers";
            this.showtravellers.UseVisualStyleBackColor = false;
            this.showtravellers.Click += new System.EventHandler(this.showtravellers_Click);
            // 
            // showoperators
            // 
            this.showoperators.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.showoperators.FlatAppearance.BorderSize = 0;
            this.showoperators.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showoperators.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.showoperators.ForeColor = System.Drawing.Color.White;
            this.showoperators.Location = new System.Drawing.Point(597, 537);
            this.showoperators.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showoperators.Name = "showoperators";
            this.showoperators.Size = new System.Drawing.Size(155, 47);
            this.showoperators.TabIndex = 24;
            this.showoperators.Text = "Operators";
            this.showoperators.UseVisualStyleBackColor = false;
            this.showoperators.Click += new System.EventHandler(this.showoperators_Click);
            // 
            // showproviders
            // 
            this.showproviders.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.showproviders.FlatAppearance.BorderSize = 0;
            this.showproviders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showproviders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.showproviders.ForeColor = System.Drawing.Color.White;
            this.showproviders.Location = new System.Drawing.Point(597, 603);
            this.showproviders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showproviders.Name = "showproviders";
            this.showproviders.Size = new System.Drawing.Size(155, 47);
            this.showproviders.TabIndex = 25;
            this.showproviders.Text = "Service Provider";
            this.showproviders.UseVisualStyleBackColor = false;
            this.showproviders.Click += new System.EventHandler(this.showproviders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(596, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Show Registrations";
            // 
            // AdminInterface
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showproviders);
            this.Controls.Add(this.showoperators);
            this.Controls.Add(this.showtravellers);
            this.Controls.Add(this.prfile_mng);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUSrID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Interface - TravelEase";
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblUSrID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button prfile_mng;
        private System.Windows.Forms.Button showtravellers;
        private System.Windows.Forms.Button showoperators;
        private System.Windows.Forms.Button showproviders;
        private System.Windows.Forms.Label label1;
    }
}
