namespace pripremaZaProvjeruZnanja
{
    partial class Form1
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
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.labelVrsta = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelGodiste = new System.Windows.Forms.Label();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelSnaga = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dtpGodiste = new System.Windows.Forms.DateTimePicker();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.trckSnaga = new System.Windows.Forms.TrackBar();
            this.rtxtIspis = new System.Windows.Forms.RichTextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Automobil",
            "JetSki",
            "Zrakoplov"});
            this.cmbVrsta.Location = new System.Drawing.Point(66, 31);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(241, 21);
            this.cmbVrsta.TabIndex = 0;
            // 
            // labelVrsta
            // 
            this.labelVrsta.AutoSize = true;
            this.labelVrsta.Location = new System.Drawing.Point(12, 31);
            this.labelVrsta.Name = "labelVrsta";
            this.labelVrsta.Size = new System.Drawing.Size(31, 13);
            this.labelVrsta.TabIndex = 1;
            this.labelVrsta.Text = "Vrsta";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(12, 69);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 2;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelGodiste
            // 
            this.labelGodiste.AutoSize = true;
            this.labelGodiste.Location = new System.Drawing.Point(12, 103);
            this.labelGodiste.Name = "labelGodiste";
            this.labelGodiste.Size = new System.Drawing.Size(43, 13);
            this.labelGodiste.TabIndex = 3;
            this.labelGodiste.Text = "Godište";
            this.labelGodiste.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Location = new System.Drawing.Point(12, 135);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(37, 13);
            this.labelMarka.TabIndex = 4;
            this.labelMarka.Text = "Marka";
            // 
            // labelSnaga
            // 
            this.labelSnaga.AutoSize = true;
            this.labelSnaga.Location = new System.Drawing.Point(12, 164);
            this.labelSnaga.Name = "labelSnaga";
            this.labelSnaga.Size = new System.Drawing.Size(41, 13);
            this.labelSnaga.TabIndex = 5;
            this.labelSnaga.Text = "Snaga ";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(66, 69);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(241, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // dtpGodiste
            // 
            this.dtpGodiste.Location = new System.Drawing.Point(66, 103);
            this.dtpGodiste.Name = "dtpGodiste";
            this.dtpGodiste.Size = new System.Drawing.Size(241, 20);
            this.dtpGodiste.TabIndex = 7;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(66, 135);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(241, 20);
            this.txtMarka.TabIndex = 8;
            // 
            // trckSnaga
            // 
            this.trckSnaga.LargeChange = 20;
            this.trckSnaga.Location = new System.Drawing.Point(66, 164);
            this.trckSnaga.Maximum = 350;
            this.trckSnaga.Minimum = 45;
            this.trckSnaga.Name = "trckSnaga";
            this.trckSnaga.Size = new System.Drawing.Size(241, 45);
            this.trckSnaga.SmallChange = 5;
            this.trckSnaga.TabIndex = 9;
            this.trckSnaga.Value = 45;
            this.trckSnaga.Scroll += new System.EventHandler(this.trckSnaga_Scroll);
            // 
            // rtxtIspis
            // 
            this.rtxtIspis.Location = new System.Drawing.Point(19, 302);
            this.rtxtIspis.Name = "rtxtIspis";
            this.rtxtIspis.Size = new System.Drawing.Size(288, 148);
            this.rtxtIspis.TabIndex = 10;
            this.rtxtIspis.Text = "";
            this.rtxtIspis.TextChanged += new System.EventHandler(this.rtxtIspis_TextChanged);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(19, 226);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(133, 57);
            this.btnUnesi.TabIndex = 11;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(170, 226);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(137, 57);
            this.btnIspisi.TabIndex = 12;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 480);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.rtxtIspis);
            this.Controls.Add(this.trckSnaga);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.dtpGodiste);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.labelSnaga);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.labelGodiste);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.labelVrsta);
            this.Controls.Add(this.cmbVrsta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label labelVrsta;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelGodiste;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelSnaga;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DateTimePicker dtpGodiste;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TrackBar trckSnaga;
        private System.Windows.Forms.RichTextBox rtxtIspis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIspisi;
    }
}

