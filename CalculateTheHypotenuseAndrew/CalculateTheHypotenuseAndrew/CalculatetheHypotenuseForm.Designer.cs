namespace CalculateTheHypotenuseAndrew
{
    partial class frmCalculatetheHypotenuse
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
            this.lblALeg = new System.Windows.Forms.Label();
            this.lblBLeg = new System.Windows.Forms.Label();
            this.txtALeg = new System.Windows.Forms.TextBox();
            this.txtBLeg = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblALeg
            // 
            this.lblALeg.AutoSize = true;
            this.lblALeg.BackColor = System.Drawing.Color.White;
            this.lblALeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALeg.Location = new System.Drawing.Point(69, 121);
            this.lblALeg.Name = "lblALeg";
            this.lblALeg.Size = new System.Drawing.Size(64, 20);
            this.lblALeg.TabIndex = 1;
            this.lblALeg.Text = " a Leg:";
            // 
            // lblBLeg
            // 
            this.lblBLeg.AutoSize = true;
            this.lblBLeg.BackColor = System.Drawing.Color.White;
            this.lblBLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBLeg.Location = new System.Drawing.Point(74, 165);
            this.lblBLeg.Name = "lblBLeg";
            this.lblBLeg.Size = new System.Drawing.Size(59, 20);
            this.lblBLeg.TabIndex = 2;
            this.lblBLeg.Text = "b Leg:";
            // 
            // txtALeg
            // 
            this.txtALeg.Location = new System.Drawing.Point(140, 120);
            this.txtALeg.Name = "txtALeg";
            this.txtALeg.Size = new System.Drawing.Size(100, 20);
            this.txtALeg.TabIndex = 3;
            // 
            // txtBLeg
            // 
            this.txtBLeg.Location = new System.Drawing.Point(140, 167);
            this.txtBLeg.Name = "txtBLeg";
            this.txtBLeg.Size = new System.Drawing.Size(100, 20);
            this.txtBLeg.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculateTheHypotenuseAndrew.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(283, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.BackColor = System.Drawing.Color.White;
            this.lblIntroduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduction.Location = new System.Drawing.Point(50, 54);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(442, 20);
            this.lblIntroduction.TabIndex = 5;
            this.lblIntroduction.Text = "The Pythagorean Theorem with an actual right triangle";
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.Beige;
            this.btnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.Location = new System.Drawing.Point(69, 226);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(171, 53);
            this.btnCalculator.TabIndex = 6;
            this.btnCalculator.Text = "Calculate the Hypotenuse";
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(125, 337);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(24, 20);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "...";
            // 
            // frmCalculatetheHypotenuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 390);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.txtBLeg);
            this.Controls.Add(this.txtALeg);
            this.Controls.Add(this.lblBLeg);
            this.Controls.Add(this.lblALeg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCalculatetheHypotenuse";
            this.Text = "Calculate the Hypotenuse By Andrew K.";
            this.Load += new System.EventHandler(this.frmCalculatetheHypotenuse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblALeg;
        private System.Windows.Forms.Label lblBLeg;
        private System.Windows.Forms.TextBox txtALeg;
        private System.Windows.Forms.TextBox txtBLeg;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Label lblAnswer;
    }
}

