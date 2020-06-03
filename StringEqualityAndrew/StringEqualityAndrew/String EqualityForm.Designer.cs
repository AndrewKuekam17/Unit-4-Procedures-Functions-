namespace StringEqualityAndrew
{
    partial class frmStringEquality
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
            this.lblString = new System.Windows.Forms.Label();
            this.lblCase = new System.Windows.Forms.Label();
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString.Location = new System.Drawing.Point(21, 83);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(169, 20);
            this.lblString.TabIndex = 0;
            this.lblString.Text = "(Case doent mater.)";
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase.Location = new System.Drawing.Point(11, 52);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(330, 20);
            this.lblCase.TabIndex = 1;
            this.lblCase.Text = "Enter two string to see if they are equal.";
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString1.Location = new System.Drawing.Point(21, 138);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(72, 20);
            this.lblString1.TabIndex = 2;
            this.lblString1.Text = "String1:";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.Location = new System.Drawing.Point(21, 195);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(72, 20);
            this.lblString2.TabIndex = 3;
            this.lblString2.Text = "String2:";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Red;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(137, 242);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 41);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(100, 137);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(163, 20);
            this.txtString1.TabIndex = 5;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(100, 197);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(163, 20);
            this.txtString2.TabIndex = 6;
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 303);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.lblString);
            this.Name = "frmStringEquality";
            this.Text = "String Equality By Andrew K.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
    }
}

