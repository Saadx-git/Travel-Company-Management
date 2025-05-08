using System.Drawing;
using System.Windows.Forms;

namespace @new
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPerformance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridViewPerformance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provider Performance Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(40, 643);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 40);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridViewPerformance
            // 
            this.dataGridViewPerformance.AllowUserToAddRows = false;
            this.dataGridViewPerformance.AllowUserToDeleteRows = false;
            this.dataGridViewPerformance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPerformance.Location = new System.Drawing.Point(40, 129);
            this.dataGridViewPerformance.Name = "dataGridViewPerformance";
            this.dataGridViewPerformance.ReadOnly = true;
            this.dataGridViewPerformance.Size = new System.Drawing.Size(1200, 200);
            this.dataGridViewPerformance.TabIndex = 25;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPerformance);
            this.Name = "Form6";
            this.Text = "Provider Performance Report";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformance)).EndInit();
            this.ResumeLayout(false);

        }

        private Label label1;
        private Button btnBack;
    }
}
