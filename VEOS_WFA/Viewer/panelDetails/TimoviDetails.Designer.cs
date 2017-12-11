namespace VEOS_WFA
{
    partial class TimoviDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbTimovi = new System.Windows.Forms.PictureBox();
            this.lblBrSportista = new System.Windows.Forms.Label();
            this.lblSport = new System.Windows.Forms.Label();
            this.lblValueOfBrSportista = new System.Windows.Forms.Label();
            this.lblValueOfSport = new System.Windows.Forms.Label();
            this.tbKomentar = new System.Windows.Forms.TextBox();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.gbTimoviDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimovi)).BeginInit();
            this.gbTimoviDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTimovi
            // 
            this.pbTimovi.Image = global::VEOS_WFA.Properties.Resources.tim;
            this.pbTimovi.Location = new System.Drawing.Point(6, 19);
            this.pbTimovi.Name = "pbTimovi";
            this.pbTimovi.Size = new System.Drawing.Size(36, 36);
            this.pbTimovi.TabIndex = 32;
            this.pbTimovi.TabStop = false;
            // 
            // lblBrSportista
            // 
            this.lblBrSportista.AutoSize = true;
            this.lblBrSportista.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrSportista.Location = new System.Drawing.Point(48, 40);
            this.lblBrSportista.Name = "lblBrSportista";
            this.lblBrSportista.Size = new System.Drawing.Size(85, 15);
            this.lblBrSportista.TabIndex = 27;
            this.lblBrSportista.Text = "Broj Sportista:";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSport.Location = new System.Drawing.Point(48, 19);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(41, 15);
            this.lblSport.TabIndex = 28;
            this.lblSport.Text = "Sport:";
            // 
            // lblValueOfBrSportista
            // 
            this.lblValueOfBrSportista.AutoSize = true;
            this.lblValueOfBrSportista.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOfBrSportista.Location = new System.Drawing.Point(139, 40);
            this.lblValueOfBrSportista.Name = "lblValueOfBrSportista";
            this.lblValueOfBrSportista.Size = new System.Drawing.Size(12, 15);
            this.lblValueOfBrSportista.TabIndex = 30;
            this.lblValueOfBrSportista.Text = "/";
            // 
            // lblValueOfSport
            // 
            this.lblValueOfSport.AutoSize = true;
            this.lblValueOfSport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOfSport.Location = new System.Drawing.Point(139, 19);
            this.lblValueOfSport.Name = "lblValueOfSport";
            this.lblValueOfSport.Size = new System.Drawing.Size(12, 15);
            this.lblValueOfSport.TabIndex = 31;
            this.lblValueOfSport.Text = "/";
            // 
            // tbKomentar
            // 
            this.tbKomentar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKomentar.Enabled = false;
            this.tbKomentar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKomentar.Location = new System.Drawing.Point(251, 22);
            this.tbKomentar.Multiline = true;
            this.tbKomentar.Name = "tbKomentar";
            this.tbKomentar.Size = new System.Drawing.Size(107, 33);
            this.tbKomentar.TabIndex = 33;
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomentar.Location = new System.Drawing.Point(182, 40);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(66, 15);
            this.lblKomentar.TabIndex = 34;
            this.lblKomentar.Text = "Komentar:";
            // 
            // gbTimoviDetails
            // 
            this.gbTimoviDetails.Controls.Add(this.tbKomentar);
            this.gbTimoviDetails.Controls.Add(this.pbTimovi);
            this.gbTimoviDetails.Controls.Add(this.lblKomentar);
            this.gbTimoviDetails.Controls.Add(this.lblBrSportista);
            this.gbTimoviDetails.Controls.Add(this.lblValueOfSport);
            this.gbTimoviDetails.Controls.Add(this.lblSport);
            this.gbTimoviDetails.Controls.Add(this.lblValueOfBrSportista);
            this.gbTimoviDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimoviDetails.Location = new System.Drawing.Point(0, 0);
            this.gbTimoviDetails.Name = "gbTimoviDetails";
            this.gbTimoviDetails.Size = new System.Drawing.Size(364, 61);
            this.gbTimoviDetails.TabIndex = 35;
            this.gbTimoviDetails.TabStop = false;
            this.gbTimoviDetails.Text = "Podaci o timu:";
            // 
            // TimoviDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTimoviDetails);
            this.DoubleBuffered = true;
            this.Name = "TimoviDetails";
            this.Size = new System.Drawing.Size(367, 64);
            ((System.ComponentModel.ISupportInitialize)(this.pbTimovi)).EndInit();
            this.gbTimoviDetails.ResumeLayout(false);
            this.gbTimoviDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTimovi;
        private System.Windows.Forms.Label lblBrSportista;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.Label lblValueOfBrSportista;
        private System.Windows.Forms.Label lblValueOfSport;
        private System.Windows.Forms.TextBox tbKomentar;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.GroupBox gbTimoviDetails;


    }
}
