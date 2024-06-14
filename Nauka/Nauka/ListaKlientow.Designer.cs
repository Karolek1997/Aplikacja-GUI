namespace Nauka
{
    partial class mainform
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.reg_std_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reg_std_btn
            // 
            this.reg_std_btn.Location = new System.Drawing.Point(39, 50);
            this.reg_std_btn.Name = "reg_std_btn";
            this.reg_std_btn.Size = new System.Drawing.Size(264, 63);
            this.reg_std_btn.TabIndex = 0;
            this.reg_std_btn.Text = "Klienci sklepu";
            this.reg_std_btn.UseVisualStyleBackColor = true;
            this.reg_std_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 575);
            this.Controls.Add(this.reg_std_btn);
            this.Name = "mainform";
            this.Text = "MainFormm";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reg_std_btn;
    }
}

