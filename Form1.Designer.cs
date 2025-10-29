namespace lab3
{
    partial class Form1
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
            this.Calculate = new System.Windows.Forms.Button();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_pr = new System.Windows.Forms.Label();
            this.lb_number = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.lb_volume = new System.Windows.Forms.Label();
            this.lb_clearproduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBox_capasity = new System.Windows.Forms.ComboBox();
            this.cBox_pr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calculate.Font = new System.Drawing.Font("Sylfaen", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(278, 23);
            this.Calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(108, 39);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_1.Location = new System.Drawing.Point(26, 23);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(53, 34);
            this.lb_1.TabIndex = 1;
            this.lb_1.Text = "Vessel(s)\r\nCapasity";
            // 
            // lb_pr
            // 
            this.lb_pr.AutoSize = true;
            this.lb_pr.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_pr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_pr.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_pr.Location = new System.Drawing.Point(8, 80);
            this.lb_pr.Name = "lb_pr";
            this.lb_pr.Size = new System.Drawing.Size(71, 34);
            this.lb_pr.TabIndex = 4;
            this.lb_pr.Text = " Percentage \r\nof substance";
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_number.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_number.Location = new System.Drawing.Point(15, 138);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(62, 34);
            this.lb_number.TabIndex = 5;
            this.lb_number.Text = "Number of\r\n  Vessels";
            // 
            // Count
            // 
            this.Count.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Count.Location = new System.Drawing.Point(96, 147);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(159, 20);
            this.Count.TabIndex = 6;
            // 
            // lb_volume
            // 
            this.lb_volume.AutoSize = true;
            this.lb_volume.BackColor = System.Drawing.SystemColors.Info;
            this.lb_volume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_volume.Location = new System.Drawing.Point(322, 107);
            this.lb_volume.Name = "lb_volume";
            this.lb_volume.Size = new System.Drawing.Size(15, 15);
            this.lb_volume.TabIndex = 7;
            this.lb_volume.Text = "0";
            this.lb_volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_clearproduct
            // 
            this.lb_clearproduct.AllowDrop = true;
            this.lb_clearproduct.AutoSize = true;
            this.lb_clearproduct.BackColor = System.Drawing.SystemColors.Info;
            this.lb_clearproduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_clearproduct.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lb_clearproduct.Location = new System.Drawing.Point(322, 187);
            this.lb_clearproduct.Name = "lb_clearproduct";
            this.lb_clearproduct.Size = new System.Drawing.Size(15, 15);
            this.lb_clearproduct.TabIndex = 8;
            this.lb_clearproduct.Text = "0";
            this.lb_clearproduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_clearproduct.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(292, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total volume:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(286, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = " Percentage of\r\nclear substance:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseWaitCursor = true;
            // 
            // cBox_capasity
            // 
            this.cBox_capasity.FormattingEnabled = true;
            this.cBox_capasity.Location = new System.Drawing.Point(96, 35);
            this.cBox_capasity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBox_capasity.Name = "cBox_capasity";
            this.cBox_capasity.Size = new System.Drawing.Size(161, 21);
            this.cBox_capasity.TabIndex = 12;
            // 
            // cBox_pr
            // 
            this.cBox_pr.FormattingEnabled = true;
            this.cBox_pr.Location = new System.Drawing.Point(96, 90);
            this.cBox_pr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBox_pr.Name = "cBox_pr";
            this.cBox_pr.Size = new System.Drawing.Size(161, 21);
            this.cBox_pr.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.cBox_pr);
            this.Controls.Add(this.cBox_capasity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_clearproduct);
            this.Controls.Add(this.lb_volume);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.lb_number);
            this.Controls.Add(this.lb_pr);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.Calculate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_pr;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.NumericUpDown Count;
        private System.Windows.Forms.Label lb_volume;
        private System.Windows.Forms.Label lb_clearproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBox_capasity;
        private System.Windows.Forms.ComboBox cBox_pr;
    }
}

