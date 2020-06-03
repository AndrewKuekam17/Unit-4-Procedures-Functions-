namespace PassReferenceAndrew
{
    partial class frmPassbyReferenceandClickEvents
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
            this.lblClick = new System.Windows.Forms.Label();
            this.picCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.BackColor = System.Drawing.Color.White;
            this.lblClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.Location = new System.Drawing.Point(32, 43);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(248, 20);
            this.lblClick.TabIndex = 0;
            this.lblClick.Text = "Click on the card to change it.";
            // 
            // picCard
            // 
            this.picCard.Image = global::PassReferenceAndrew.Properties.Resources.Front;
            this.picCard.Location = new System.Drawing.Point(48, 89);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(221, 248);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard.TabIndex = 1;
            this.picCard.TabStop = false;
            this.picCard.Click += new System.EventHandler(this.picCard_Click);
            // 
            // frmPassbyReferenceandClickEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 384);
            this.Controls.Add(this.picCard);
            this.Controls.Add(this.lblClick);
            this.Name = "frmPassbyReferenceandClickEvents";
            this.Text = "Pass by Reference & Click Events By Andrew K.";
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.PictureBox picCard;
    }
}

