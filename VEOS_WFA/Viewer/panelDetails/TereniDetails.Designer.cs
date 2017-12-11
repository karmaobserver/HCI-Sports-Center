namespace VEOS_WFA
{
    partial class TereniDetails
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
            this.lblSportovi = new System.Windows.Forms.Label();
            this.lblGodOpr = new System.Windows.Forms.Label();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.lblValueOfSportovi = new System.Windows.Forms.Label();
            this.lblValueOfGodOpr = new System.Windows.Forms.Label();
            this.lblValueOfKapacitet = new System.Windows.Forms.Label();
            this.gbTereniDetails = new System.Windows.Forms.GroupBox();
            this.pbHale = new System.Windows.Forms.PictureBox();
            this.gbTereniDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHale)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSportovi
            // 
            this.lblSportovi.AutoSize = true;
            this.lblSportovi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportovi.Location = new System.Drawing.Point(48, 40);
            this.lblSportovi.Name = "lblSportovi";
            this.lblSportovi.Size = new System.Drawing.Size(57, 15);
            this.lblSportovi.TabIndex = 1;
            this.lblSportovi.Text = "Sportovi:";
            // 
            // lblGodOpr
            // 
            this.lblGodOpr.AutoSize = true;
            this.lblGodOpr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodOpr.Location = new System.Drawing.Point(171, 19);
            this.lblGodOpr.Name = "lblGodOpr";
            this.lblGodOpr.Size = new System.Drawing.Size(118, 15);
            this.lblGodOpr.TabIndex = 2;
            this.lblGodOpr.Text = "Godina opremljenja:";
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapacitet.Location = new System.Drawing.Point(48, 19);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(62, 15);
            this.lblKapacitet.TabIndex = 3;
            this.lblKapacitet.Text = "Kapacitet:";
            // 
            // lblValueOfSportovi
            // 
            this.lblValueOfSportovi.AutoSize = true;
            this.lblValueOfSportovi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOfSportovi.Location = new System.Drawing.Point(116, 40);
            this.lblValueOfSportovi.Name = "lblValueOfSportovi";
            this.lblValueOfSportovi.Size = new System.Drawing.Size(12, 15);
            this.lblValueOfSportovi.TabIndex = 7;
            this.lblValueOfSportovi.Text = "/";
            // 
            // lblValueOfGodOpr
            // 
            this.lblValueOfGodOpr.AutoSize = true;
            this.lblValueOfGodOpr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOfGodOpr.Location = new System.Drawing.Point(297, 19);
            this.lblValueOfGodOpr.Name = "lblValueOfGodOpr";
            this.lblValueOfGodOpr.Size = new System.Drawing.Size(12, 15);
            this.lblValueOfGodOpr.TabIndex = 8;
            this.lblValueOfGodOpr.Text = "/";
            // 
            // lblValueOfKapacitet
            // 
            this.lblValueOfKapacitet.AutoSize = true;
            this.lblValueOfKapacitet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOfKapacitet.Location = new System.Drawing.Point(116, 19);
            this.lblValueOfKapacitet.Name = "lblValueOfKapacitet";
            this.lblValueOfKapacitet.Size = new System.Drawing.Size(12, 15);
            this.lblValueOfKapacitet.TabIndex = 9;
            this.lblValueOfKapacitet.Text = "/";
            // 
            // gbTereniDetails
            // 
            this.gbTereniDetails.Controls.Add(this.pbHale);
            this.gbTereniDetails.Controls.Add(this.lblValueOfGodOpr);
            this.gbTereniDetails.Controls.Add(this.lblValueOfKapacitet);
            this.gbTereniDetails.Controls.Add(this.lblValueOfSportovi);
            this.gbTereniDetails.Controls.Add(this.lblKapacitet);
            this.gbTereniDetails.Controls.Add(this.lblGodOpr);
            this.gbTereniDetails.Controls.Add(this.lblSportovi);
            this.gbTereniDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTereniDetails.Location = new System.Drawing.Point(3, 0);
            this.gbTereniDetails.Name = "gbTereniDetails";
            this.gbTereniDetails.Size = new System.Drawing.Size(364, 61);
            this.gbTereniDetails.TabIndex = 10;
            this.gbTereniDetails.TabStop = false;
            this.gbTereniDetails.Text = "Podaci o terenu:";
            // 
            // pbHale
            // 
            this.pbHale.Image = global::VEOS_WFA.Properties.Resources.teren;
            this.pbHale.Location = new System.Drawing.Point(6, 19);
            this.pbHale.Name = "pbHale";
            this.pbHale.Size = new System.Drawing.Size(36, 36);
            this.pbHale.TabIndex = 15;
            this.pbHale.TabStop = false;
            // 
            // TereniDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTereniDetails);
            this.DoubleBuffered = true;
            this.Name = "TereniDetails";
            this.Size = new System.Drawing.Size(367, 64);
            this.gbTereniDetails.ResumeLayout(false);
            this.gbTereniDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSportovi;
        private System.Windows.Forms.Label lblGodOpr;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.Label lblValueOfSportovi;
        private System.Windows.Forms.Label lblValueOfGodOpr;
        private System.Windows.Forms.Label lblValueOfKapacitet;
        private System.Windows.Forms.GroupBox gbTereniDetails;
        private System.Windows.Forms.PictureBox pbHale;
    }
}
