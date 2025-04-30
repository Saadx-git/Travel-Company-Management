using System;
using System.Drawing;
using System.Windows.Forms;

namespace Db_project
{
    public partial class Profile_Management : Form
    {
        private Label lblTitle;
        private Label lblUserID, lblName, lblGender, lblEmail, lblPassword, lblPhone, lblAddress, lblRegDate, lblUserType;
        private TextBox txtUserID, txtName, txtEmail, txtPassword, txtPhone, txtAddress, txtRegDate, txtUserType;
        private ComboBox cmbGender;
        private Button btnSaveChanges, btnReset;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.txtRegDate = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(390, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Your Profile";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUserID.Location = new System.Drawing.Point(250, 120);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(150, 30);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "User ID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserID.Location = new System.Drawing.Point(450, 120);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(300, 29);
            this.txtUserID.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblName.Location = new System.Drawing.Point(30, 168);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 30);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(230, 168);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 29);
            this.txtName.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGender.Location = new System.Drawing.Point(30, 228);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(150, 30);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(230, 228);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(300, 29);
            this.cmbGender.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmail.Location = new System.Drawing.Point(30, 288);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 30);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(230, 288);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 29);
            this.txtEmail.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPassword.Location = new System.Drawing.Point(600, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(150, 30);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(800, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 29);
            this.txtPassword.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPhone.Location = new System.Drawing.Point(600, 227);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(150, 30);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.Location = new System.Drawing.Point(800, 227);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 29);
            this.txtPhone.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAddress.Location = new System.Drawing.Point(600, 287);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(150, 30);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.Location = new System.Drawing.Point(800, 287);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 29);
            this.txtAddress.TabIndex = 14;
            // 
            // lblRegDate
            // 
            this.lblRegDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRegDate.Location = new System.Drawing.Point(600, 347);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(150, 30);
            this.lblRegDate.TabIndex = 15;
            this.lblRegDate.Text = "Registered Date:";
            // 
            // txtRegDate
            // 
            this.txtRegDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRegDate.Location = new System.Drawing.Point(800, 347);
            this.txtRegDate.Name = "txtRegDate";
            this.txtRegDate.ReadOnly = true;
            this.txtRegDate.Size = new System.Drawing.Size(300, 29);
            this.txtRegDate.TabIndex = 16;
            // 
            // lblUserType
            // 
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUserType.Location = new System.Drawing.Point(30, 346);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(150, 30);
            this.lblUserType.TabIndex = 17;
            this.lblUserType.Text = "User Type:";
            // 
            // txtUserType
            // 
            this.txtUserType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserType.Location = new System.Drawing.Point(230, 346);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.ReadOnly = true;
            this.txtUserType.Size = new System.Drawing.Size(300, 29);
            this.txtUserType.TabIndex = 18;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(541, 438);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(160, 40);
            this.btnSaveChanges.TabIndex = 19;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(541, 513);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 40);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(38, 643);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 40);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Profile_Management
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblRegDate);
            this.Controls.Add(this.txtRegDate);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnReset);
            this.Name = "Profile_Management";
            this.Text = "Manage Profile";
            this.Load += new System.EventHandler(this.Profile_Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Save changes to database here
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            cmbGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private Button btnBack;
    }
}
