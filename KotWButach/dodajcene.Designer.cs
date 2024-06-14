namespace KotWButach
{
    partial class dodajcene
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cenanetto_textbox = new System.Windows.Forms.TextBox();
            this.save_button1 = new System.Windows.Forms.Button();
            this.close_button1 = new System.Windows.Forms.Button();
            this.Wybor_Kategorii1 = new System.Windows.Forms.ComboBox();
            this.Wybor_Modelu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategoria produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena netto";
            // 
            // cenanetto_textbox
            // 
            this.cenanetto_textbox.Location = new System.Drawing.Point(293, 138);
            this.cenanetto_textbox.Name = "cenanetto_textbox";
            this.cenanetto_textbox.Size = new System.Drawing.Size(254, 20);
            this.cenanetto_textbox.TabIndex = 5;
            // 
            // save_button1
            // 
            this.save_button1.Location = new System.Drawing.Point(111, 330);
            this.save_button1.Name = "save_button1";
            this.save_button1.Size = new System.Drawing.Size(75, 23);
            this.save_button1.TabIndex = 6;
            this.save_button1.Text = "Zapisz";
            this.save_button1.UseVisualStyleBackColor = true;
            this.save_button1.Click += new System.EventHandler(this.save_button1_Click);
            // 
            // close_button1
            // 
            this.close_button1.Location = new System.Drawing.Point(642, 330);
            this.close_button1.Name = "close_button1";
            this.close_button1.Size = new System.Drawing.Size(75, 23);
            this.close_button1.TabIndex = 7;
            this.close_button1.Text = "Zamknij";
            this.close_button1.UseVisualStyleBackColor = true;
            this.close_button1.Click += new System.EventHandler(this.close_button1_Click);
            // 
            // Wybor_Kategorii1
            // 
            this.Wybor_Kategorii1.FormattingEnabled = true;
            this.Wybor_Kategorii1.Location = new System.Drawing.Point(293, 46);
            this.Wybor_Kategorii1.Name = "Wybor_Kategorii1";
            this.Wybor_Kategorii1.Size = new System.Drawing.Size(254, 21);
            this.Wybor_Kategorii1.TabIndex = 17;
            // 
            // Wybor_Modelu
            // 
            this.Wybor_Modelu.FormattingEnabled = true;
            this.Wybor_Modelu.Location = new System.Drawing.Point(293, 91);
            this.Wybor_Modelu.Name = "Wybor_Modelu";
            this.Wybor_Modelu.Size = new System.Drawing.Size(254, 21);
            this.Wybor_Modelu.TabIndex = 18;
            // 
            // dodajcene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wybor_Modelu);
            this.Controls.Add(this.Wybor_Kategorii1);
            this.Controls.Add(this.close_button1);
            this.Controls.Add(this.save_button1);
            this.Controls.Add(this.cenanetto_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dodajcene";
            this.Text = "Dodaj cenę";
            this.Load += new System.EventHandler(this.dodajcene_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cenanetto_textbox;
        private System.Windows.Forms.Button save_button1;
        private System.Windows.Forms.Button close_button1;
        private System.Windows.Forms.ComboBox Wybor_Kategorii1;
        private System.Windows.Forms.ComboBox Wybor_Modelu;
    }
}