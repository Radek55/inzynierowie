using AplikacjaInzynierka.Constans;
namespace AplikacjaInzynierka.Wprowadzenie
{
    partial class FormStartowy
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
            this.WprowadzenieTekst = new System.Windows.Forms.Label();
            this.WprowadzeniePrzycisk = new System.Windows.Forms.Button();
            this.kod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WprowadzenieTekst
            // 
            this.WprowadzenieTekst.AutoSize = true;
            this.WprowadzenieTekst.Location = new System.Drawing.Point(100, 100);
            this.WprowadzenieTekst.Name = "WprowadzenieTekst";
            this.WprowadzenieTekst.Size = new System.Drawing.Size(356, 128);
            this.WprowadzenieTekst.TabIndex = 1;
            this.WprowadzenieTekst.Text = "Siema, tutaj tekst wprowadzenia\r\nw\r\nw\r\nw";
            this.WprowadzenieTekst.Click += new System.EventHandler(this.label1_Click);
            // 
            // WprowadzeniePrzycisk
            // 
            this.WprowadzeniePrzycisk.Location = new System.Drawing.Point(1000, 575);
            this.WprowadzeniePrzycisk.Name = "WprowadzeniePrzycisk";
            this.WprowadzeniePrzycisk.Size = new System.Drawing.Size(150, 50);
            this.WprowadzeniePrzycisk.TabIndex = 2;
            this.WprowadzeniePrzycisk.Text = "Start";
            this.WprowadzeniePrzycisk.UseVisualStyleBackColor = true;
            this.WprowadzeniePrzycisk.Click += new System.EventHandler(this.WprowadzeniePrzycisk_Click);
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(100, 231);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(200, 39);
            this.kod.TabIndex = 3;
            // 
            // FormStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.WprowadzeniePrzycisk);
            this.Controls.Add(this.WprowadzenieTekst);
            this.Name = "FormStartowy";
            this.Text = "Badanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WprowadzenieTekst;
        private Button WprowadzeniePrzycisk;
        private TextBox kod;
    }
}