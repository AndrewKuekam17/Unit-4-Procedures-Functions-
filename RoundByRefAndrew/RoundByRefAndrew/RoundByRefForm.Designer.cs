namespace RoundByRefAndrew
{
    partial class frmRoundByRef
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
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblRoundTo = new System.Windows.Forms.Label();
            this.btnRound = new System.Windows.Forms.Button();
            this.nudnumDecimal = new System.Windows.Forms.NumericUpDown();
            this.txtNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudnumDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(23, 54);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(204, 20);
            this.lblDecimal.TabIndex = 0;
            this.lblDecimal.Text = "Enter a decimal number:";
            // 
            // lblRoundTo
            // 
            this.lblRoundTo.AutoSize = true;
            this.lblRoundTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundTo.Location = new System.Drawing.Point(23, 98);
            this.lblRoundTo.Name = "lblRoundTo";
            this.lblRoundTo.Size = new System.Drawing.Size(398, 20);
            this.lblRoundTo.TabIndex = 1;
            this.lblRoundTo.Text = "How many decimal places do you want to roud to";
            // 
            // btnRound
            // 
            this.btnRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(152, 135);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(118, 35);
            this.btnRound.TabIndex = 2;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = false;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // nudnumDecimal
            // 
            this.nudnumDecimal.Location = new System.Drawing.Point(427, 101);
            this.nudnumDecimal.Name = "nudnumDecimal";
            this.nudnumDecimal.Size = new System.Drawing.Size(120, 20);
            this.nudnumDecimal.TabIndex = 3;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(234, 53);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 4;
            // 
            // frmRoundByRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 182);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.nudnumDecimal);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.lblRoundTo);
            this.Controls.Add(this.lblDecimal);
            this.Name = "frmRoundByRef";
            this.Text = "Round By Reference  By Andrew K.";
            ((System.ComponentModel.ISupportInitialize)(this.nudnumDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblRoundTo;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.NumericUpDown nudnumDecimal;
        private System.Windows.Forms.TextBox txtNumber;
    }
}

