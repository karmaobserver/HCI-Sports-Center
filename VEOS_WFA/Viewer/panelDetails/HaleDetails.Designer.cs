namespace VEOS_WFA
{
    partial class HaleDetails
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
            this.lblNameOfHale = new System.Windows.Forms.Label();
            this.lblValueOfNameHale = new System.Windows.Forms.Label();
            this.lblNumberOfTereni = new System.Windows.Forms.Label();
            this.lblValueOfBrojTerena = new System.Windows.Forms.Label();
            this.gbHaleDetails = new System.Windows.Forms.GroupBox();
            this.pbHale = new System.Windows.Forms.PictureBox();
            this.gbHaleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHale)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameOfHale
            // 
            this.lblNameOfHale.AutoSize = true;
            this.lblNameOfHale.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfHale.Location = new System.Drawing.Point(48, 19);
            this.lblNameOfHale.Name = "lblNameOfHale";
            this.lblNameOfHale.Size = new System.Drawing.Size(59, 15);
            this.lblNameOfHale.TabIndex = 0;
            this.lblNameOfHale.Text = "Ime Hale:";
            // 
            // lblValueOfNameHale
            // 
            this.lblValueOfNameHale.AutoSize = true;
            this.lblValueOfNameHale.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOfNameHale.Location = new System.Drawing.Point(127, 19);
            this.lblValueOfNameHale.Name = "lblValueOfNameHale";
            this.lblValueOfNameHale.Size = new System.Drawing.Size(12, 15);
            this.lblValueOfNameHale.TabIndex = 1;
            this.lblValueOfNameHale.Text = "/";
            // 
            // lblNumberOfTereni
            // 
            this.lblNumberOfTereni.AutoSize = true;
            this.lblNumberOfTereni.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTereni.Location = new System.Drawing.Point(48, 40);
            this.lblNumberOfTereni.Name = "lblNumberOfTereni";
            this.lblNumberOfTereni.Size = new System.Drawing.Size(73, 15);
            this.lblNumberOfTereni.TabIndex = 2;
            this.lblNumberOfTereni.Text = "Broj Terena:";
            // 
            // lblValueOfBrojTerena
            // 
            this.lblValueOfBrojTerena.AutoSize = true;
            this.lblValueOfBrojTerena.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOfBrojTerena.Location = new System.Drawing.Point(127, 40);
            this.lblValueOfBrojTerena.Name = "lblValueOfBrojTerena";
            this.lblValueOfBrojTerena.Size = new System.Drawing.Size(12, 15);
            this.lblValueOfBrojTerena.TabIndex = 3;
            this.lblValueOfBrojTerena.Text = "/";
            // 
            // gbHaleDetails
            // 
            this.gbHaleDetails.Controls.Add(this.lblNumberOfTereni);
            this.gbHaleDetails.Controls.Add(this.pbHale);
            this.gbHaleDetails.Controls.Add(this.lblNameOfHale);
            this.gbHaleDetails.Controls.Add(this.lblValueOfBrojTerena);
            this.gbHaleDetails.Controls.Add(this.lblValueOfNameHale);
            this.gbHaleDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHaleDetails.Location = new System.Drawing.Point(3, 0);
            this.gbHaleDetails.Name = "gbHaleDetails";
            this.gbHaleDetails.Size = new System.Drawing.Size(364, 61);
            this.gbHaleDetails.TabIndex = 15;
            this.gbHaleDetails.TabStop = false;
            this.gbHaleDetails.Text = "Podaci o hali:";
            // 
            // pbHale
            // 
            this.pbHale.Image = global::VEOS_WFA.Properties.Resources.hale;
            this.pbHale.Location = new System.Drawing.Point(6, 19);
            this.pbHale.Name = "pbHale";
            this.pbHale.Size = new System.Drawing.Size(36, 36);
            this.pbHale.TabIndex = 14;
            this.pbHale.TabStop = false;
            // 
            // HaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbHaleDetails);
            this.DoubleBuffered = true;
            this.Name = "HaleDetails";
            this.Size = new System.Drawing.Size(367, 64);
            this.gbHaleDetails.ResumeLayout(false);
            this.gbHaleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameOfHale;
        private System.Windows.Forms.Label lblValueOfNameHale;
        private System.Windows.Forms.Label lblNumberOfTereni;
        private System.Windows.Forms.Label lblValueOfBrojTerena;
        private System.Windows.Forms.PictureBox pbHale;
        private System.Windows.Forms.GroupBox gbHaleDetails;
    }
}
