namespace AplikacjaSklepu
{
    partial class Aplikacja_Sklepu
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
            this.produkt_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produkt_button
            // 
            this.produkt_button.Location = new System.Drawing.Point(34, 27);
            this.produkt_button.Name = "produkt_button";
            this.produkt_button.Size = new System.Drawing.Size(187, 59);
            this.produkt_button.TabIndex = 0;
            this.produkt_button.Text = "Dodaj produkt";
            this.produkt_button.UseVisualStyleBackColor = true;
            this.produkt_button.Click += new System.EventHandler(this.produkt_button_Click);
            // 
            // Aplikacja_Sklepu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.produkt_button);
            this.Name = "Aplikacja_Sklepu";
            this.Text = "Aplikacja sklepu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button produkt_button;
    }
}

