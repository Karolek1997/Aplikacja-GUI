namespace KotWButach
{
    partial class Dodawanieproduktu
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
            this.producent_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.model_textbox = new System.Windows.Forms.TextBox();
            this.rozmiar_textbox = new System.Windows.Forms.TextBox();
            this.kolor_textbox = new System.Windows.Forms.TextBox();
            this.dostepnailosc_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Wybor_Kategorii = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // producent_textbox
            // 
            this.producent_textbox.Location = new System.Drawing.Point(383, 129);
            this.producent_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.producent_textbox.Name = "producent_textbox";
            this.producent_textbox.Size = new System.Drawing.Size(254, 22);
            this.producent_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(106, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producent";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(157, 485);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Zapisz";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(943, 485);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 6;
            this.close_button.Text = "Zamknij";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(106, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(106, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kolor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(106, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rozmiar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(106, 403);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dostepna Ilość";
            // 
            // model_textbox
            // 
            this.model_textbox.Location = new System.Drawing.Point(383, 205);
            this.model_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.model_textbox.Name = "model_textbox";
            this.model_textbox.Size = new System.Drawing.Size(254, 22);
            this.model_textbox.TabIndex = 11;
            // 
            // rozmiar_textbox
            // 
            this.rozmiar_textbox.Location = new System.Drawing.Point(383, 272);
            this.rozmiar_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.rozmiar_textbox.Name = "rozmiar_textbox";
            this.rozmiar_textbox.Size = new System.Drawing.Size(254, 22);
            this.rozmiar_textbox.TabIndex = 12;
            // 
            // kolor_textbox
            // 
            this.kolor_textbox.Location = new System.Drawing.Point(383, 335);
            this.kolor_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.kolor_textbox.Name = "kolor_textbox";
            this.kolor_textbox.Size = new System.Drawing.Size(254, 22);
            this.kolor_textbox.TabIndex = 13;
            // 
            // dostepnailosc_textbox
            // 
            this.dostepnailosc_textbox.Location = new System.Drawing.Point(383, 403);
            this.dostepnailosc_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.dostepnailosc_textbox.Name = "dostepnailosc_textbox";
            this.dostepnailosc_textbox.Size = new System.Drawing.Size(254, 22);
            this.dostepnailosc_textbox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(106, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kategoria Produktu";
            // 
            // Wybor_Kategorii
            // 
            this.Wybor_Kategorii.FormattingEnabled = true;
            this.Wybor_Kategorii.Location = new System.Drawing.Point(383, 60);
            this.Wybor_Kategorii.Name = "Wybor_Kategorii";
            this.Wybor_Kategorii.Size = new System.Drawing.Size(254, 24);
            this.Wybor_Kategorii.TabIndex = 16;
            // 
            // Dodawanieproduktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 582);
            this.Controls.Add(this.Wybor_Kategorii);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dostepnailosc_textbox);
            this.Controls.Add(this.kolor_textbox);
            this.Controls.Add(this.rozmiar_textbox);
            this.Controls.Add(this.model_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.producent_textbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dodawanieproduktu";
            this.Text = "Dodaj produkt";
            this.Load += new System.EventHandler(this.Dodawanieproduktu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox producent_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox model_textbox;
        private System.Windows.Forms.TextBox rozmiar_textbox;
        private System.Windows.Forms.TextBox kolor_textbox;
        private System.Windows.Forms.TextBox dostepnailosc_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Wybor_Kategorii;
    }
}