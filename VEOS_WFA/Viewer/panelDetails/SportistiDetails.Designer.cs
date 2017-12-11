namespace VEOS_WFA
{
    partial class SportistiDetails
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
            this.lblNameOfButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameOfButton
            // 
            this.lblNameOfButton.AutoSize = true;
            this.lblNameOfButton.Location = new System.Drawing.Point(227, 36);
            this.lblNameOfButton.Name = "lblNameOfButton";
            this.lblNameOfButton.Size = new System.Drawing.Size(87, 13);
            this.lblNameOfButton.TabIndex = 0;
            this.lblNameOfButton.Text = "Name of Button: ";
            // 
            // SportistiDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNameOfButton);
            this.DoubleBuffered = true;
            this.Name = "SportistiDetails";
            this.Size = new System.Drawing.Size(734, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameOfButton;
    }
}
