namespace VEOS_WFA.Viewer.dialogAzuriranjePrikaz
{
    partial class DialogTimovi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnDodavanje = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.clSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBrojSportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKomentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSifra,
            this.clBrojSportista,
            this.clSport,
            this.clKomentar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrisanje);
            this.panel1.Controls.Add(this.btnDodavanje);
            this.panel1.Controls.Add(this.btnIzmena);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 75);
            this.panel1.TabIndex = 1;
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Enabled = false;
            this.btnBrisanje.Location = new System.Drawing.Point(266, 12);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(121, 51);
            this.btnBrisanje.TabIndex = 5;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            // 
            // btnDodavanje
            // 
            this.btnDodavanje.Location = new System.Drawing.Point(12, 12);
            this.btnDodavanje.Name = "btnDodavanje";
            this.btnDodavanje.Size = new System.Drawing.Size(121, 51);
            this.btnDodavanje.TabIndex = 3;
            this.btnDodavanje.Text = "Dodavanje";
            this.btnDodavanje.UseVisualStyleBackColor = true;
            this.btnDodavanje.Click += new System.EventHandler(this.btnDodavanje_Click);
            // 
            // btnIzmena
            // 
            this.btnIzmena.Enabled = false;
            this.btnIzmena.Location = new System.Drawing.Point(139, 12);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(121, 51);
            this.btnIzmena.TabIndex = 4;
            this.btnIzmena.Text = "Izmena";
            this.btnIzmena.UseVisualStyleBackColor = true;
            // 
            // clSifra
            // 
            this.clSifra.HeaderText = "Sifra";
            this.clSifra.Name = "clSifra";
            // 
            // clBrojSportista
            // 
            this.clBrojSportista.HeaderText = "Broj Sportista";
            this.clBrojSportista.Name = "clBrojSportista";
            // 
            // clSport
            // 
            this.clSport.HeaderText = "Sport";
            this.clSport.Name = "clSport";
            // 
            // clKomentar
            // 
            this.clKomentar.HeaderText = "Komentar";
            this.clKomentar.Name = "clKomentar";
            // 
            // DialogTimovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DialogTimovi";
            this.Text = "DialogTimovi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnDodavanje;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBrojSportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKomentar;
    }
}