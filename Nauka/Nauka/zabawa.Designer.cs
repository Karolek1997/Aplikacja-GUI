namespace Nauka
{
    partial class form
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.przycisk1 = new System.Windows.Forms.Button();
            this.przycisk2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(235, 68);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 1;
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(235, 113);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(100, 20);
            this.surname_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // przycisk1
            // 
            this.przycisk1.Location = new System.Drawing.Point(64, 369);
            this.przycisk1.Name = "przycisk1";
            this.przycisk1.Size = new System.Drawing.Size(75, 23);
            this.przycisk1.TabIndex = 4;
            this.przycisk1.Text = "save";
            this.przycisk1.UseVisualStyleBackColor = true;
            this.przycisk1.Click += new System.EventHandler(this.przycisk1_Click);
            // 
            // przycisk2
            // 
            this.przycisk2.Location = new System.Drawing.Point(442, 369);
            this.przycisk2.Name = "przycisk2";
            this.przycisk2.Size = new System.Drawing.Size(75, 23);
            this.przycisk2.TabIndex = 5;
            this.przycisk2.Text = "close";
            this.przycisk2.UseVisualStyleBackColor = true;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.przycisk2);
            this.Controls.Add(this.przycisk1);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label1);
            this.Name = "form";
            this.Text = "zabawa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button przycisk1;
        private System.Windows.Forms.Button przycisk2;
    }
}