using System.Drawing;
using System.Windows.Forms;
using System;

namespace Db_project
{
    partial class PlatformAnalytics
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.metricsPanel = new System.Windows.Forms.Panel();
            this.lblUserTraffic = new System.Windows.Forms.Label();
            this.txtUserTraffic = new System.Windows.Forms.TextBox();
            this.lblBookingTrends = new System.Windows.Forms.Label();
            this.txtBookingTrends = new System.Windows.Forms.TextBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.btnRefreshAnalytics = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblHeader.Location = new System.Drawing.Point(400, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(469, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Platform Analytics Dashboard";
            // 
            // metricsPanel
            // 
            this.metricsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.metricsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metricsPanel.Location = new System.Drawing.Point(59, 334);
            this.metricsPanel.Name = "metricsPanel";
            this.metricsPanel.Size = new System.Drawing.Size(1161, 202);
            this.metricsPanel.TabIndex = 1;
            // 
            // lblUserTraffic
            // 
            this.lblUserTraffic.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUserTraffic.Location = new System.Drawing.Point(54, 100);
            this.lblUserTraffic.Name = "lblUserTraffic";
            this.lblUserTraffic.Size = new System.Drawing.Size(250, 30);
            this.lblUserTraffic.TabIndex = 0;
            this.lblUserTraffic.Text = "🧑‍🤝‍🧑  Total User Traffic:";
            // 
            // txtUserTraffic
            // 
            this.txtUserTraffic.BackColor = System.Drawing.Color.White;
            this.txtUserTraffic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserTraffic.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtUserTraffic.Location = new System.Drawing.Point(324, 100);
            this.txtUserTraffic.Name = "txtUserTraffic";
            this.txtUserTraffic.ReadOnly = true;
            this.txtUserTraffic.Size = new System.Drawing.Size(600, 32);
            this.txtUserTraffic.TabIndex = 1;
            // 
            // lblBookingTrends
            // 
            this.lblBookingTrends.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBookingTrends.Location = new System.Drawing.Point(54, 180);
            this.lblBookingTrends.Name = "lblBookingTrends";
            this.lblBookingTrends.Size = new System.Drawing.Size(250, 30);
            this.lblBookingTrends.TabIndex = 2;
            this.lblBookingTrends.Text = "📈  Booking Trends:";
            // 
            // txtBookingTrends
            // 
            this.txtBookingTrends.BackColor = System.Drawing.Color.White;
            this.txtBookingTrends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookingTrends.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBookingTrends.Location = new System.Drawing.Point(324, 180);
            this.txtBookingTrends.Name = "txtBookingTrends";
            this.txtBookingTrends.ReadOnly = true;
            this.txtBookingTrends.Size = new System.Drawing.Size(600, 32);
            this.txtBookingTrends.TabIndex = 3;
            // 
            // lblRevenue
            // 
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.Location = new System.Drawing.Point(54, 260);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(250, 30);
            this.lblRevenue.TabIndex = 4;
            this.lblRevenue.Text = "💰  Revenue Generated:";
            // 
            // txtRevenue
            // 
            this.txtRevenue.BackColor = System.Drawing.Color.White;
            this.txtRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRevenue.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtRevenue.Location = new System.Drawing.Point(324, 260);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(600, 32);
            this.txtRevenue.TabIndex = 5;
            // 
            // btnRefreshAnalytics
            // 
            this.btnRefreshAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.btnRefreshAnalytics.FlatAppearance.BorderSize = 0;
            this.btnRefreshAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAnalytics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefreshAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnRefreshAnalytics.Location = new System.Drawing.Point(529, 601);
            this.btnRefreshAnalytics.Name = "btnRefreshAnalytics";
            this.btnRefreshAnalytics.Size = new System.Drawing.Size(220, 50);
            this.btnRefreshAnalytics.TabIndex = 2;
            this.btnRefreshAnalytics.Text = "↻ Refresh Analytics";
            this.btnRefreshAnalytics.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(59, 651);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(186, 46);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PlatformAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.metricsPanel);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblUserTraffic);
            this.Controls.Add(this.txtUserTraffic);
            this.Controls.Add(this.lblBookingTrends);
            this.Controls.Add(this.txtBookingTrends);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.btnRefreshAnalytics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlatformAnalytics";
            this.Text = "PlatformAnalytics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblUserTraffic;
        private System.Windows.Forms.Label lblBookingTrends;
        private System.Windows.Forms.Label lblRevenue;

        private System.Windows.Forms.TextBox txtUserTraffic;
        private System.Windows.Forms.TextBox txtBookingTrends;
        private System.Windows.Forms.TextBox txtRevenue;

        private System.Windows.Forms.Button btnRefreshAnalytics;

        #endregion

        private Panel metricsPanel;
        private Button btnBack;
    }
}