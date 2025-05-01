using System.Windows.Forms;
using System;

namespace Db_project
{
    partial class DigitalTravelPass : Form
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
            this.lblTravelPassTitle = new System.Windows.Forms.Label();
            this.btnETickets = new System.Windows.Forms.Button();
            this.btnHotelVouchers = new System.Windows.Forms.Button();
            this.btnActivityPasses = new System.Windows.Forms.Button();
            this.dgvPasses = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTravelPassTitle
            // 
            this.lblTravelPassTitle.AutoSize = true;
            this.lblTravelPassTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTravelPassTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTravelPassTitle.Location = new System.Drawing.Point(430, 30);
            this.lblTravelPassTitle.Name = "lblTravelPassTitle";
            this.lblTravelPassTitle.Size = new System.Drawing.Size(369, 45);
            this.lblTravelPassTitle.TabIndex = 0;
            this.lblTravelPassTitle.Text = "Your Digital Travel Pass";
            // 
            // btnETickets
            // 
            this.btnETickets.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnETickets.FlatAppearance.BorderSize = 0;
            this.btnETickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnETickets.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnETickets.ForeColor = System.Drawing.Color.White;
            this.btnETickets.Location = new System.Drawing.Point(50, 100);
            this.btnETickets.Margin = new System.Windows.Forms.Padding(5);
            this.btnETickets.Name = "btnETickets";
            this.btnETickets.Size = new System.Drawing.Size(150, 40);
            this.btnETickets.TabIndex = 6;
            this.btnETickets.Text = "E-Tickets";
            this.btnETickets.UseVisualStyleBackColor = false;
            this.btnETickets.Click += new System.EventHandler(this.btnETickets_Click);
            // 
            // btnHotelVouchers
            // 
            this.btnHotelVouchers.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnHotelVouchers.FlatAppearance.BorderSize = 0;
            this.btnHotelVouchers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelVouchers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHotelVouchers.ForeColor = System.Drawing.Color.White;
            this.btnHotelVouchers.Location = new System.Drawing.Point(210, 100);
            this.btnHotelVouchers.Margin = new System.Windows.Forms.Padding(5);
            this.btnHotelVouchers.Name = "btnHotelVouchers";
            this.btnHotelVouchers.Size = new System.Drawing.Size(150, 40);
            this.btnHotelVouchers.TabIndex = 7;
            this.btnHotelVouchers.Text = "Hotel Vouchers";
            this.btnHotelVouchers.UseVisualStyleBackColor = false;
            this.btnHotelVouchers.Click += new System.EventHandler(this.btnHotelVouchers_Click);
            // 
            // btnActivityPasses
            // 
            this.btnActivityPasses.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnActivityPasses.FlatAppearance.BorderSize = 0;
            this.btnActivityPasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivityPasses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnActivityPasses.ForeColor = System.Drawing.Color.White;
            this.btnActivityPasses.Location = new System.Drawing.Point(370, 100);
            this.btnActivityPasses.Margin = new System.Windows.Forms.Padding(5);
            this.btnActivityPasses.Name = "btnActivityPasses";
            this.btnActivityPasses.Size = new System.Drawing.Size(150, 40);
            this.btnActivityPasses.TabIndex = 8;
            this.btnActivityPasses.Text = "Activity Passes";
            this.btnActivityPasses.UseVisualStyleBackColor = false;
            this.btnActivityPasses.Click += new System.EventHandler(this.btnActivityPasses_Click);
            // 
            // dgvPasses
            // 
            this.dgvPasses.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPasses.Location = new System.Drawing.Point(50, 160);
            this.dgvPasses.Name = "dgvPasses";
            this.dgvPasses.Size = new System.Drawing.Size(1031, 450);
            this.dgvPasses.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(50, 655);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DigitalTravelPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dgvPasses);
            this.Controls.Add(this.lblTravelPassTitle);
            this.Controls.Add(this.btnETickets);
            this.Controls.Add(this.btnHotelVouchers);
            this.Controls.Add(this.btnActivityPasses);
            this.Controls.Add(this.btnBack);
            this.Name = "DigitalTravelPass";
            this.Text = "Digital Travel Pass";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTravelPassTitle;
        private System.Windows.Forms.Button btnETickets;
        private System.Windows.Forms.Button btnHotelVouchers;
        private System.Windows.Forms.Button btnActivityPasses;
        private System.Windows.Forms.DataGridView dgvPasses;
        private System.Windows.Forms.Button btnBack;

    }
}
