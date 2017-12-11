namespace VEOS_WFA.Viewer.messageBoxes
{
    partial class DeleteWarning
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteWarning));
            this.btnDa = new System.Windows.Forms.Button();
            this.btnNe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDa
            // 
            this.btnDa.BackColor = System.Drawing.Color.Transparent;
            this.btnDa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDa.BackgroundImage")));
            this.btnDa.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnDa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDa.Image = global::VEOS_WFA.Properties.Resources.potvrda2;
            this.btnDa.Location = new System.Drawing.Point(115, 57);
            this.btnDa.Name = "btnDa";
            this.btnDa.Size = new System.Drawing.Size(138, 40);
            this.btnDa.TabIndex = 1;
            this.btnDa.Text = "Da";
            this.btnDa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnDa, "Biće obrisano");
            this.btnDa.UseVisualStyleBackColor = false;
            this.btnDa.MouseEnter += new System.EventHandler(this.btnDa_MouseEnter);
            this.btnDa.MouseLeave += new System.EventHandler(this.btnDa_MouseLeave);
            // 
            // btnNe
            // 
            this.btnNe.BackColor = System.Drawing.Color.Transparent;
            this.btnNe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNe.BackgroundImage")));
            this.btnNe.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNe.Image = global::VEOS_WFA.Properties.Resources.odustanak21;
            this.btnNe.Location = new System.Drawing.Point(259, 57);
            this.btnNe.Name = "btnNe";
            this.btnNe.Size = new System.Drawing.Size(138, 40);
            this.btnNe.TabIndex = 2;
            this.btnNe.Text = "Ne";
            this.btnNe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNe, "Neće biti obrisano");
            this.btnNe.UseVisualStyleBackColor = false;
            this.btnNe.MouseEnter += new System.EventHandler(this.btnNe_MouseEnter);
            this.btnNe.MouseLeave += new System.EventHandler(this.btnNe_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::VEOS_WFA.Properties.Resources.questionMessageBox;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNe);
            this.panel1.Controls.Add(this.btnDa);
            this.panel1.Controls.Add(this.lblMessage);
            this.helpProvider1.SetHelpKeyword(this.panel1, "Brisanje");
            this.helpProvider1.SetHelpNavigator(this.panel1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.helpProvider1.SetShowHelp(this.panel1, true);
            this.panel1.Size = new System.Drawing.Size(410, 110);
            this.panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(34, 27);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(42, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "..\\\\..\\\\help\\\\help.chm";
            // 
            // DeleteWarning
            // 
            this.AcceptButton = this.btnDa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNe;
            this.ClientSize = new System.Drawing.Size(410, 110);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteWarning";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeleteWarning";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnNe;
        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}