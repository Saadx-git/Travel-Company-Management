using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace @new
{
    public partial class Service_Listing : Form
    {
        private System.ComponentModel.IContainer components = null;

        private Label label2;
        private DataGridView dataGridView1;
        private Button btnAddListing;
        private DataGridViewTextBoxColumn colServiceName;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewButtonColumn colEdit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddListing = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(400, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Service Listing Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceName,
            this.colLocation,
            this.colEdit});
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridView1.Location = new System.Drawing.Point(100, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1080, 400);
            this.dataGridView1.TabIndex = 1;
            // 
            // colServiceName
            // 
            this.colServiceName.HeaderText = "Hotel / Service Name";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.Width = 450;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Width = 350;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 150;
            // 
            // btnAddListing
            // 
            this.btnAddListing.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddListing.FlatAppearance.BorderSize = 0;
            this.btnAddListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddListing.ForeColor = System.Drawing.Color.White;
            this.btnAddListing.Location = new System.Drawing.Point(100, 530);
            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.Size = new System.Drawing.Size(160, 40);
            this.btnAddListing.TabIndex = 2;
            this.btnAddListing.Text = "+ Add Listing";
            this.btnAddListing.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(36, 650);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 40);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddListing);
            this.Name = "Form3";
            this.Text = "Service Listing Management";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(0, 100, 0),
                Color.FromArgb(144, 238, 144),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private Button btnBack;
    }
}
