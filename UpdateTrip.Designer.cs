namespace Db_project
{
    partial class UpdateTrip
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.audience = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupsize = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.duration = new System.Windows.Forms.Label();
            this.durationbox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 11.8209F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Updating";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(427, 519);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 62);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update Trip";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(600, 398);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Audience";
            // 
            // audience
            // 
            this.audience.BackColor = System.Drawing.Color.White;
            this.audience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audience.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.audience.Location = new System.Drawing.Point(742, 398);
            this.audience.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.audience.Name = "audience";
            this.audience.Size = new System.Drawing.Size(224, 30);
            this.audience.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Group Size";
            // 
            // groupsize
            // 
            this.groupsize.BackColor = System.Drawing.Color.White;
            this.groupsize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupsize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupsize.Location = new System.Drawing.Point(242, 395);
            this.groupsize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupsize.Name = "groupsize";
            this.groupsize.Size = new System.Drawing.Size(224, 30);
            this.groupsize.TabIndex = 21;
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.end.ForeColor = System.Drawing.Color.White;
            this.end.Location = new System.Drawing.Point(600, 255);
            this.end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(92, 25);
            this.end.TabIndex = 22;
            this.end.Text = "End Date";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(105, 255);
            this.start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(102, 25);
            this.start.TabIndex = 23;
            this.start.Text = "Start Date";
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(742, 251);
            this.enddate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(249, 22);
            this.enddate.TabIndex = 24;
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(242, 251);
            this.startdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(249, 22);
            this.startdate.TabIndex = 25;
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.duration.ForeColor = System.Drawing.Color.White;
            this.duration.Location = new System.Drawing.Point(600, 122);
            this.duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(92, 25);
            this.duration.TabIndex = 26;
            this.duration.Text = "Duration";
            // 
            // durationbox
            // 
            this.durationbox.BackColor = System.Drawing.Color.White;
            this.durationbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durationbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.durationbox.Location = new System.Drawing.Point(742, 122);
            this.durationbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.durationbox.Name = "durationbox";
            this.durationbox.Size = new System.Drawing.Size(224, 30);
            this.durationbox.TabIndex = 27;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(114, 122);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(50, 25);
            this.title.TabIndex = 28;
            this.title.Text = "Title";
            // 
            // titlebox
            // 
            this.titlebox.BackColor = System.Drawing.Color.White;
            this.titlebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.titlebox.Location = new System.Drawing.Point(242, 122);
            this.titlebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(224, 30);
            this.titlebox.TabIndex = 29;
            // 
            // UpdateTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1097, 691);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.audience);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupsize);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.durationbox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.label1);
            this.Name = "UpdateTrip";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox audience;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupsize;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.TextBox durationbox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox titlebox;
    }
}