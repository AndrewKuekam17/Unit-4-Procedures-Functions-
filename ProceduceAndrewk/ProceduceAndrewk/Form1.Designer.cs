namespace ProceduceAndrewk
{
    partial class frmAreaProcedure
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
            this.lblRectangle = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRectangle
            // 
            this.lblRectangle.AutoSize = true;
            this.lblRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangle.Location = new System.Drawing.Point(57, 156);
            this.lblRectangle.Name = "lblRectangle";
            this.lblRectangle.Size = new System.Drawing.Size(344, 20);
            this.lblRectangle.TabIndex = 0;
            this.lblRectangle.Text = "Entre the tamperature in degrees Celsius:";
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.Location = new System.Drawing.Point(121, 222);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(241, 72);
            this.btnCalculator.TabIndex = 5;
            this.btnCalculator.Text = "Convert to fahrenheit";
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(407, 158);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 6;
            // 
            // frmAreaProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.lblRectangle);
            this.Name = "frmAreaProcedure";
            this.Text = "Area Procedure By Andrew K.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRectangle;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.TextBox txtCelsius;
    }
}

