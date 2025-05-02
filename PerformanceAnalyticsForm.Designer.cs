namespace DB_Project_1
{ 
    partial class PerformanceAnalyticsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPerformance;
        private System.Windows.Forms.Label lblHeading;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvPerformance = new System.Windows.Forms.DataGridView();
            this.lblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerformance
            // 
            this.dgvPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformance.Location = new System.Drawing.Point(30, 70);
            this.dgvPerformance.Name = "dgvPerformance";
            this.dgvPerformance.RowHeadersWidth = 57;
            this.dgvPerformance.Size = new System.Drawing.Size(640, 300);
            this.dgvPerformance.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(30, 25);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(306, 37);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Performance Analytics";
            // 
            // PerformanceAnalyticsForm
            // 
            this.ClientSize = new System.Drawing.Size(1260, 668);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.dgvPerformance);
            this.Name = "PerformanceAnalyticsForm";
            this.Text = "Performance Analytics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
