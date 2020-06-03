namespace VolumeofaCylinderAndrew
{
    partial class frmVolumeOfACylinder
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.BackColor = System.Drawing.Color.White;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(51, 40);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(70, 20);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.White;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(51, 90);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(67, 20);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(128, 39);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(127, 92);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 3;
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.Location = new System.Drawing.Point(89, 131);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(166, 45);
            this.btnCalculator.TabIndex = 4;
            this.btnCalculator.Text = "Calculate Volume";
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(67, 193);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(24, 20);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "...";
            // 
            // frmVolumeOfACylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 222);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblRadius);
            this.Name = "frmVolumeOfACylinder";
            this.Text = "Volume of a Cylinder By Andrew K.";
            this.Load += new System.EventHandler(this.frmVolumeOfACylinder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Label lblAnswer;
    }
}

