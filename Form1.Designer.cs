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
            this.TxtCapasity = new System.Windows.Forms.TextBox();
            this.Txt_pr = new System.Windows.Forms.TextBox();
            this.lb_pr = new System.Windows.Forms.Label();
            this.lb_number = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.lb_volume = new System.Windows.Forms.Label();
            this.lb_clearproduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(247, 125);
            this.Calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(116, 35);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(294, 18);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(35, 13);
            this.lb_1.TabIndex = 1;
            this.lb_1.Text = "label1";
            // 
            // TxtCapasity
            // 
            this.TxtCapasity.Location = new System.Drawing.Point(25, 43);
            this.TxtCapasity.Name = "TxtCapasity";
            this.TxtCapasity.Size = new System.Drawing.Size(159, 20);
            this.TxtCapasity.TabIndex = 2;
            // 
            // Txt_pr
            // 
            this.Txt_pr.Location = new System.Drawing.Point(25, 96);
            this.Txt_pr.Name = "Txt_pr";
            this.Txt_pr.Size = new System.Drawing.Size(159, 20);
            this.Txt_pr.TabIndex = 3;
            // 
            // lb_pr
            // 
            this.lb_pr.AutoSize = true;
            this.lb_pr.Location = new System.Drawing.Point(195, 18);
            this.lb_pr.Name = "lb_pr";
            this.lb_pr.Size = new System.Drawing.Size(35, 13);
            this.lb_pr.TabIndex = 4;
            this.lb_pr.Text = "label1";
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Location = new System.Drawing.Point(80, 18);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(35, 13);
            this.lb_number.TabIndex = 5;
            this.lb_number.Text = "label1";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(25, 134);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(159, 20);
            this.Count.TabIndex = 6;
            // 
            // lb_volume
            // 
            this.lb_volume.AutoSize = true;
            this.lb_volume.Location = new System.Drawing.Point(217, 76);
            this.lb_volume.Name = "lb_volume";
            this.lb_volume.Size = new System.Drawing.Size(55, 13);
            this.lb_volume.TabIndex = 7;
            this.lb_volume.Text = "lb_volume";
            // 
            // lb_clearproduct
            // 
            this.lb_clearproduct.AutoSize = true;
            this.lb_clearproduct.Location = new System.Drawing.Point(294, 76);
            this.lb_clearproduct.Name = "lb_clearproduct";
            this.lb_clearproduct.Size = new System.Drawing.Size(80, 13);
            this.lb_clearproduct.TabIndex = 8;
            this.lb_clearproduct.Text = "lb_clearproduct";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.lb_clearproduct);
            this.Controls.Add(this.lb_volume);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.lb_number);
            this.Controls.Add(this.lb_pr);
            this.Controls.Add(this.Txt_pr);
            this.Controls.Add(this.TxtCapasity);
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
        private System.Windows.Forms.TextBox TxtCapasity;
        private System.Windows.Forms.TextBox Txt_pr;
        private System.Windows.Forms.Label lb_pr;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.NumericUpDown Count;
        private System.Windows.Forms.Label lb_volume;
        private System.Windows.Forms.Label lb_clearproduct;
    }
}

