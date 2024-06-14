namespace KotWButach
{
    partial class oknoglowne
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
            this.dodajprodukt_button = new System.Windows.Forms.Button();
            this.pokazprodukty_button = new System.Windows.Forms.Button();
            this.pokazklientow_button = new System.Windows.Forms.Button();
            this.dodajcene_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodajprodukt_button
            // 
            this.dodajprodukt_button.Location = new System.Drawing.Point(25, 35);
            this.dodajprodukt_button.Name = "dodajprodukt_button";
            this.dodajprodukt_button.Size = new System.Drawing.Size(275, 58);
            this.dodajprodukt_button.TabIndex = 0;
            this.dodajprodukt_button.Text = "Dodaj Produkt";
            this.dodajprodukt_button.UseVisualStyleBackColor = true;
            this.dodajprodukt_button.Click += new System.EventHandler(this.dodajprodukt_button_Click);
            // 
            // pokazprodukty_button
            // 
            this.pokazprodukty_button.Location = new System.Drawing.Point(25, 246);
            this.pokazprodukty_button.Name = "pokazprodukty_button";
            this.pokazprodukty_button.Size = new System.Drawing.Size(275, 58);
            this.pokazprodukty_button.TabIndex = 1;
            this.pokazprodukty_button.Text = "Pokaz produkty";
            this.pokazprodukty_button.UseVisualStyleBackColor = true;
            this.pokazprodukty_button.Click += new System.EventHandler(this.pokazprodukty_button_Click);
            // 
            // pokazklientow_button
            // 
            this.pokazklientow_button.Location = new System.Drawing.Point(501, 35);
            this.pokazklientow_button.Name = "pokazklientow_button";
            this.pokazklientow_button.Size = new System.Drawing.Size(275, 58);
            this.pokazklientow_button.TabIndex = 2;
            this.pokazklientow_button.Text = "Pokaz klientów";
            this.pokazklientow_button.UseVisualStyleBackColor = true;
            this.pokazklientow_button.Click += new System.EventHandler(this.pokazklientow_button_Click);
            // 
            // dodajcene_button
            // 
            this.dodajcene_button.Location = new System.Drawing.Point(25, 143);
            this.dodajcene_button.Name = "dodajcene_button";
            this.dodajcene_button.Size = new System.Drawing.Size(275, 58);
            this.dodajcene_button.TabIndex = 3;
            this.dodajcene_button.Text = "Dodaj cenę";
            this.dodajcene_button.UseVisualStyleBackColor = true;
            this.dodajcene_button.Click += new System.EventHandler(this.dodajcene_button_Click);
            // 
            // oknoglowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodajcene_button);
            this.Controls.Add(this.pokazklientow_button);
            this.Controls.Add(this.pokazprodukty_button);
            this.Controls.Add(this.dodajprodukt_button);
            this.Name = "oknoglowne";
            this.Text = "AplikacjaSklepu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodajprodukt_button;
        private System.Windows.Forms.Button pokazprodukty_button;
        private System.Windows.Forms.Button pokazklientow_button;
        private System.Windows.Forms.Button dodajcene_button;
    }
}

